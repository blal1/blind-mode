using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using MasterDuelAccessibility.Patches;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Yu-Gi-Oh! Master Duel — Accessibility Mod (BepInEx IL2CPP)
    ///
    /// Fonctionnalités :
    ///   - Synthèse vocale via Tolk (NVDA, JAWS, SAPI fallback)
    ///   - Annonce les changements de PV, phases, tours, noms de cartes, effets
    ///   - Raccourcis clavier (voir KeyboardShortcuts.cs)
    ///   - Activable/désactivable via BepInEx ConfigFile
    ///
    /// Déploiement :
    ///   BepInEx/plugins/MasterDuelAccessibility.dll
    ///   BepInEx/plugins/MasterDuelAccessibility/lib/screen-reader-libs/windows/
    ///     Tolk.dll, nvdaControllerClient64.dll, SAAPI64.dll
    ///   BepInEx/plugins/TolkDotNet.dll
    ///
    /// NOTE : BepInEx.Unity.IL2CPP.BasePlugin n'est PAS un MonoBehaviour.
    ///        Le per-frame Update() et le hook de scène sont gérés par le composant
    ///        interne PluginBehaviour (voir classe ci-dessous).
    /// </summary>
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        public static Plugin? Instance { get; private set; }

        internal TtsService? Tts { get; private set; }

        /// <summary>
        /// Registre central des raccourcis clavier.
        /// Accessible dès KeyboardShortcuts.Awake().
        /// </summary>
        internal ShortcutRegistry ShortcutRegistry { get; } = new ShortcutRegistry();

        private HarmonyLib.Harmony? _harmony;

        // BepInEx config entries
        internal BepInEx.Configuration.ConfigEntry<bool>? CfgEnabled    { get; private set; }
        internal BepInEx.Configuration.ConfigEntry<bool>? CfgVerbose    { get; private set; }
        internal BepInEx.Configuration.ConfigEntry<bool>? CfgShowHints  { get; private set; }

        // ── Logger helpers ───────────────────────────────────────────────────
        internal void LogMsg(string msg)  => Log.LogInfo(msg);
        internal void LogWarn(string msg) => Log.LogWarning(msg);
        internal void LogErr(string msg)  => Log.LogError(msg);

        // ── Point d'entrée BepInEx IL2CPP ───────────────────────────────────
        public override void Load()
        {
            Instance = this;

            // ── Config ──────────────────────────────────────────────────────
            CfgEnabled = Config.Bind(
                "General",
                "TtsEnabled",
                true,
                "Activer les annonces vocales d'accessibilité.");

            CfgVerbose = Config.Bind(
                "General",
                "verbose_announcements",
                true,
                "Inclure les descriptions complètes dans les annonces (mode verbeux).");

            CfgShowHints = Config.Bind(
                "General",
                "show_keyboard_hints",
                true,
                "Afficher les indications de raccourcis clavier dans les annonces (ex. 'F1 pour l'aide').");

            // ── Localisation ─────────────────────────────────────────────────
            Loc.Initialize();

            // ── Tolk ────────────────────────────────────────────────────────
            Tts = new TtsService { Enabled = CfgEnabled.Value };
            CfgEnabled.SettingChanged += (_, _) =>
            {
                if (Tts != null) Tts.Enabled = CfgEnabled.Value;
                LogMsg($"TTS {(CfgEnabled.Value ? "activé" : "désactivé")}");
            };

            // ── MonoBehaviour pour Update() + scène ─────────────────────────
            // BasePlugin n'étant pas un MonoBehaviour, on enregistre un composant
            // IL2CPP dédié (PluginBehaviour) pour les hooks per-frame et de scène.
            RegisterBehaviour();

            // ── MonoBehaviour pour les raccourcis clavier ────────────────────
            RegisterKeyboardShortcuts();

            // ── Patches Harmony ──────────────────────────────────────────────
            _harmony = new HarmonyLib.Harmony(MyPluginInfo.PLUGIN_GUID);
            ApplyPatches();

            LogMsg($"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} chargé (BepInEx).");
            Tts.Speak(Loc.WithHint(Loc.Get("mod_loaded"), "hint_help"));
        }

        internal void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            InputBlockPatch.ResetFrameState();

            // Appliquer les patches spécifiques à cette scène (runtime patching)
            if (_harmony != null)
                LatePatches.Initialize(scene.name, _harmony);

            LogMsg($"[Scene] Scène chargée : '{scene.name}' (index {scene.buildIndex})");
        }

        public override bool Unload()
        {
            _harmony?.UnpatchSelf();
            Tts?.Dispose();
            Instance = null;
            return base.Unload();
        }

        private void RegisterBehaviour()
        {
            try
            {
                ClassInjector.RegisterTypeInIl2Cpp<PluginBehaviour>();
                var go = new GameObject("MDA_Plugin");
                UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)go);
                go.AddComponent(Il2CppInterop.Runtime.Il2CppType.Of<PluginBehaviour>());
                ((UnityEngine.Object)(object)go).hideFlags = (HideFlags)61;
                LogMsg("[Plugin] PluginBehaviour enregistré.");
            }
            catch (Exception ex)
            {
                LogErr($"[Plugin] Échec PluginBehaviour : {ex.Message}");
            }
        }

        private void RegisterKeyboardShortcuts()
        {
            try
            {
                ClassInjector.RegisterTypeInIl2Cpp<KeyboardShortcuts>();
                var go = new GameObject("MDA_KeyboardShortcuts");
                UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)go);
                go.AddComponent(Il2CppInterop.Runtime.Il2CppType.Of<KeyboardShortcuts>());
                ((UnityEngine.Object)(object)go).hideFlags = (HideFlags)61;
                LogMsg("[Shortcuts] MonoBehaviour enregistré.");
            }
            catch (Exception ex)
            {
                LogErr($"[Shortcuts] Échec d'enregistrement : {ex.Message}");
            }
        }

        private void ApplyPatches()
        {
            TryPatch("YgomGame.Duel.DuelLP", "ChangeLP",
                new HarmonyMethod(typeof(DuelHudPatch), nameof(DuelHudPatch.ChangeLP_Postfix)));
            TryPatch("YgomGame.Duel.DuelLP", "SetLP",
                new HarmonyMethod(typeof(DuelHudPatch), nameof(DuelHudPatch.SetLP_Postfix)));

            // PhaseChange (ViewType=5) et TurnChange (ViewType=6) sont gérés
            // dans DuelEventPatch.RunEffect_Postfix via délégation à PhasePatch.

            TryPatch("YgomSystem.UI.SelectionButton", "OnSelected",
                new HarmonyMethod(typeof(SelectionButtonPatch), nameof(SelectionButtonPatch.OnSelected_Postfix)));
            TryPatch("YgomSystem.UI.SelectionButton", "OnPointerClick",
                new HarmonyMethod(typeof(SelectionButtonPatch), nameof(SelectionButtonPatch.OnPointerClick_Postfix)));
            TryPatch("YgomSystem.UI.SelectionButton", "OnDeselected",
                new HarmonyMethod(typeof(SelectionButtonPatch), nameof(SelectionButtonPatch.OnDeselected_Postfix)));

            TryPatch("YgomSystem.UI.ColorContainerGraphic", "SetColor",
                new HarmonyMethod(typeof(ColorContainerPatch), nameof(ColorContainerPatch.SetColor_Postfix)));
            TryPatch("YgomSystem.UI.ColorContainerImage", "SetColor",
                new HarmonyMethod(typeof(ColorContainerPatch), nameof(ColorContainerPatch.SetColor_Postfix)));

            TryPatch("YgomSystem.UI.ViewController", "OnFocusChanged",
                new HarmonyMethod(typeof(ViewControllerPatch), nameof(ViewControllerPatch.OnFocusChanged_Postfix)));
            TryPatch("YgomSystem.UI.ViewController", "OnBack",
                new HarmonyMethod(typeof(ViewControllerPatch), nameof(ViewControllerPatch.OnBack_Postfix)));
            TryPatch("YgomSystem.UI.ViewController", "ShowUI",
                new HarmonyMethod(typeof(ViewControllerPatch), nameof(ViewControllerPatch.Show_Postfix)));

            TryPatch("YgomGame.Duel.CardInfo", "SetDescriptionArea",
                new HarmonyMethod(typeof(CardInfoPatch), nameof(CardInfoPatch.Show_Postfix)));

            TryPatch("YgomGame.Duel.DuelClient", "RunEffect",
                new HarmonyMethod(typeof(DuelEventPatch), nameof(DuelEventPatch.RunEffect_Postfix)));
            TryPatch("YgomGame.Duel.DuelClient", "Awake",
                new HarmonyMethod(typeof(DuelEventPatch), nameof(DuelEventPatch.DuelStart_Postfix)));
            TryPatch("YgomGame.Duel.DuelClient", "OnDestroy",
                new HarmonyMethod(typeof(DuelEventPatch), nameof(DuelEventPatch.DuelEnd_Postfix)));

            TryPatchByParamCount("YgomGame.Duel.DuelConfirmDialog", "Open", 6,
                new HarmonyMethod(typeof(DuelDialogPatch), nameof(DuelDialogPatch.ConfirmDialog_Open_Postfix)));
            TryPatchByParamCount("YgomGame.Duel.DuelConfirmDialog", "Open", 4,
                new HarmonyMethod(typeof(DuelDialogPatch), nameof(DuelDialogPatch.ConfirmDialog_OpenSimple_Postfix)));
            // DuelSelectDialog.Open est patché dynamiquement par DialogStatePatch.Initialize()
            // lors du chargement de la scène duel — ne pas le patcher ici pour éviter l'ambiguïté.

            TryPatch("YgomGame.CardBrowser.CardBrowserViewController", "Start",
                new HarmonyMethod(typeof(CardBrowserPatch), nameof(CardBrowserPatch.Start_Postfix)));
            TryPatch("YgomGame.CardBrowser.CardBrowserViewController", "OnPageChanged",
                new HarmonyMethod(typeof(CardBrowserPatch), nameof(CardBrowserPatch.OnPageChanged_Postfix)));

            TryPatch("YgomGame.DeckEditViewController2", "StartCardAddEffect",
                new HarmonyMethod(typeof(DeckEditPatch), nameof(DeckEditPatch.StartCardAddEffect_Postfix)));
            TryPatchByParamCount("YgomGame.DeckEditViewController2", "RemoveFromDeck", 2,
                new HarmonyMethod(typeof(DeckEditPatch), nameof(DeckEditPatch.RemoveFromDeck_Postfix)));
            TryPatch("YgomGame.DeckEditViewController2", "OnSubmitDeckName",
                new HarmonyMethod(typeof(DeckEditPatch), nameof(DeckEditPatch.OnSubmitDeckName_Postfix)));
            TryPatch("YgomGame.DeckEditViewController2", "OnClickSaveButton",
                new HarmonyMethod(typeof(DeckEditPatch), nameof(DeckEditPatch.OnClickSaveButton_Postfix)));
            TryPatch("YgomGame.DeckEditViewController2", "OnFocusChanged",
                new HarmonyMethod(typeof(DeckEditPatch), nameof(DeckEditPatch.OnFocusChanged_Postfix)));

            TryPatch("PvpMenuMatchingViewController", "SetActiveView",
                new HarmonyMethod(typeof(MatchingPatch), nameof(MatchingPatch.SetActiveView_Postfix)));

            TryPatchByParamCount("YgomGame.Duel.CardCommand", "Open", 6,
                new HarmonyMethod(typeof(CardCommandPatch), nameof(CardCommandPatch.Open_Postfix)));

            TryPatch("YgomGame.Duel.DuelClient", "InvokeDecideAttackTarget",
                new HarmonyMethod(typeof(DuelAttackPatch), nameof(DuelAttackPatch.InvokeDecideAttackTarget_Postfix)));

            TryPatch("YgomGame.DeckSelectViewController2", "OnFocusChanged",
                new HarmonyMethod(typeof(DeckSelectPatch), nameof(DeckSelectPatch.OnFocusChanged_Postfix)));

            TryPatchByParamCount("YgomGame.Deck.CardCraftDialog", "Open", 5,
                new HarmonyMethod(typeof(CardCraftPatch), nameof(CardCraftPatch.Open_Postfix)));

            TryPatch("YgomGame.Deck.CardCraftResultDialog", "GetResultMessage",
                new HarmonyMethod(typeof(CardCraftResultPatch), nameof(CardCraftResultPatch.GetResultMessage_Postfix)));

            // ── InputBlockPatch
            TryPatchPostfix(
                typeof(Input), nameof(Input.GetKeyDown), new[] { typeof(KeyCode) },
                new HarmonyMethod(typeof(InputBlockPatch), nameof(InputBlockPatch.GetKeyDown_Postfix)));

            // ── EventSystemPatch
            TryPatchPrefix(
                typeof(StandaloneInputModule), "SendMoveEventToSelectedObject", Array.Empty<Type>(),
                new HarmonyMethod(typeof(EventSystemPatch), nameof(EventSystemPatch.SendMoveEventToSelectedObject_Prefix)));
            TryPatchPrefix(
                typeof(StandaloneInputModule), "SendSubmitEventToSelectedObject", Array.Empty<Type>(),
                new HarmonyMethod(typeof(EventSystemPatch), nameof(EventSystemPatch.SendSubmitEventToSelectedObject_Prefix)));

            // ── InputFieldPatch
            TryPatchPostfix(
                typeof(TMPro.TMP_InputField), "OnSelect", new[] { typeof(UnityEngine.EventSystems.BaseEventData) },
                new HarmonyMethod(typeof(InputFieldPatch), nameof(InputFieldPatch.OnSelect_Postfix)));
            TryPatchPostfix(
                typeof(TMPro.TMP_InputField), "OnDeselect", new[] { typeof(UnityEngine.EventSystems.BaseEventData) },
                new HarmonyMethod(typeof(InputFieldPatch), nameof(InputFieldPatch.OnDeselect_Postfix)));

            // ── TogglePatch
            TryPatchPostfix(
                typeof(UnityEngine.UI.Toggle), "Set", new[] { typeof(bool), typeof(bool) },
                new HarmonyMethod(typeof(TogglePatch), nameof(TogglePatch.Set_Postfix)));

            // ── CardReportTelopPatch — bandeau stats post-effet (ex: "+500 ATK")
            CardReportTelopPatch.Apply(_harmony!);

            // ── SliderPatch — valeur des curseurs dans les menus (ex: volume, musique)
            TryPatchPostfix(
                typeof(UnityEngine.UI.Slider), "Set", new[] { typeof(float), typeof(bool) },
                new HarmonyMethod(typeof(SliderPatch), nameof(SliderPatch.Set_Postfix)));

            // ── DropdownPatch — listes déroulantes TMP (ex: langue, options graphiques)
            // Show() : annonce l'ouverture avec l'option courante
            TryPatchPostfix(
                typeof(TMPro.TMP_Dropdown), "Show", Array.Empty<Type>(),
                new HarmonyMethod(typeof(DropdownPatch), nameof(DropdownPatch.Show_Postfix)));
            // set_value : annonce la sélection d'une nouvelle option
            TryPatchPostfix(
                typeof(TMPro.TMP_Dropdown), "set_value", new[] { typeof(int) },
                new HarmonyMethod(typeof(DropdownPatch), nameof(DropdownPatch.SetValue_Postfix)));
            // Hide() : réinitialise l'état interne lors de la fermeture
            TryPatchPostfix(
                typeof(TMPro.TMP_Dropdown), "Hide", Array.Empty<Type>(),
                new HarmonyMethod(typeof(DropdownPatch), nameof(DropdownPatch.Hide_Postfix)));

            // ── InputDigitViewPatch — sélecteur de nombre (ex: "Payer X PV")
            TryPatch("YgomGame.Menu.Common.InputDigitViewController", "OnCreatedView",
                new HarmonyMethod(typeof(InputDigitViewPatch), nameof(InputDigitViewPatch.OnCreatedView_Postfix)));
            TryPatch("YgomGame.Menu.Common.InputDigitViewController", "OnValueAdded",
                new HarmonyMethod(typeof(InputDigitViewPatch), nameof(InputDigitViewPatch.OnValueAdded_Postfix)));

            // ── FilterSelectViewPatch — dialog de filtres multi-sélection
            // Annonce le titre et l'état de chaque option (actif / inactif)
            TryPatch("FilterSelectViewController", "OpenFilterSelect",
                new HarmonyMethod(typeof(FilterSelectViewPatch), nameof(FilterSelectViewPatch.OpenFilterSelect_Postfix)));

            // ── CommonDialogPatch — dialogs génériques (confirmation, alerte, erreur, etc.)
            // Toutes les variantes Open*Dialog partagent (string title, string message, ...)
            var commonDialogPostfix = new HarmonyMethod(
                typeof(CommonDialogPatch), nameof(CommonDialogPatch.Dialog_Postfix));
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenAlertDialog",          commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenAlertDialogScroll",    commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenConfirmationDialog",   commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenConfirmationDialogScroll", commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenConfirmationPartDialog", commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenErrorDialog",          commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenYesNoConfirmationDialog", commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenYesNoConfirmationDialogScroll", commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenNoticeYesNoDialog",    commonDialogPostfix);
            TryPatch("YgomGame.Menu.CommonDialogViewController", "OpenCheckBoxDialog",       commonDialogPostfix);
            TryPatchByParamCount("YgomGame.Menu.CommonDialogViewController", "OpenItemConfirmDialog", 7, commonDialogPostfix);
            TryPatchByParamCount("YgomGame.Menu.CommonDialogViewController", "OpenItemConfirmDialog", 9, commonDialogPostfix);
        }

        // ── TryPatch helpers ─────────────────────────────────────────────────

        private void TryPatch(string typeName, string methodName, HarmonyMethod postfix)
        {
            try
            {
                var type = AccessTools.TypeByName(typeName);
                if (type == null) { LogWarn($"[Patch] Type '{typeName}' introuvable."); return; }

                var method = (MethodInfo?)AccessTools.Method(type, methodName)
                    ?? type.GetMethods().FirstOrDefault(m => m.Name == methodName);
                if (method == null) { LogWarn($"[Patch] Méthode '{typeName}.{methodName}' introuvable."); return; }

                _harmony!.Patch(method, postfix: postfix);
                LogMsg($"[Patch] ✓ {typeName}.{methodName}");
            }
            catch (Exception ex) { LogErr($"[Patch] Échec {typeName}.{methodName}: {ex.Message}"); }
        }

        private void TryPatchPostfix(Type type, string methodName, Type[] paramTypes, HarmonyMethod postfix)
        {
            try
            {
                var method = paramTypes.Length > 0
                    ? type.GetMethod(methodName,
                          BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance,
                          null, paramTypes, null)
                    : (MethodInfo?)AccessTools.Method(type, methodName)
                      ?? type.GetMethods().FirstOrDefault(m => m.Name == methodName);

                if (method == null) { LogWarn($"[Patch] '{type.Name}.{methodName}' introuvable."); return; }
                _harmony!.Patch(method, postfix: postfix);
                LogMsg($"[Patch] ✓ {type.Name}.{methodName}");
            }
            catch (Exception ex) { LogErr($"[Patch] Échec {type.Name}.{methodName}: {ex.Message}"); }
        }

        private void TryPatchPrefix(Type type, string methodName, Type[] paramTypes, HarmonyMethod prefix)
        {
            try
            {
                var method = paramTypes.Length > 0
                    ? type.GetMethod(methodName,
                          BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance,
                          null, paramTypes, null)
                    : (MethodInfo?)AccessTools.Method(type, methodName)
                      ?? type.GetMethods().FirstOrDefault(m => m.Name == methodName);

                if (method == null) { LogWarn($"[Patch] prefix '{type.Name}.{methodName}' introuvable."); return; }
                _harmony!.Patch(method, prefix: prefix);
                LogMsg($"[Patch] ✓ prefix {type.Name}.{methodName}");
            }
            catch (Exception ex) { LogErr($"[Patch] Échec prefix {type.Name}.{methodName}: {ex.Message}"); }
        }

        private void TryPatchByParamCount(string typeName, string methodName, int paramCount, HarmonyMethod postfix)
        {
            try
            {
                var type = AccessTools.TypeByName(typeName);
                if (type == null) { LogWarn($"[Patch] Type '{typeName}' introuvable."); return; }

                var method = type.GetMethods()
                    .FirstOrDefault(m => m.Name == methodName && m.GetParameters().Length == paramCount);
                if (method == null) { LogWarn($"[Patch] '{typeName}.{methodName}' ({paramCount} params) introuvable."); return; }

                _harmony!.Patch(method, postfix: postfix);
                LogMsg($"[Patch] ✓ {typeName}.{methodName} ({paramCount} params)");
            }
            catch (Exception ex) { LogErr($"[Patch] Échec {typeName}.{methodName}/{paramCount}: {ex.Message}"); }
        }
    }

    /// <summary>
    /// Composant MonoBehaviour IL2CPP pour gérer les hooks Unity per-frame et par scène.
    /// <summary>
    /// Composant MonoBehaviour IL2CPP pour gérer les hooks Unity per-frame et par scène.
    ///
    /// BasePlugin (BepInEx IL2CPP) n'hérite PAS de MonoBehaviour, contrairement à
    /// BaseUnityPlugin (BepInEx Mono). Ce composant est enregistré via ClassInjector
    /// et attaché à un GameObject DontDestroyOnLoad pour agir comme un MonoBehaviour.
    /// </summary>
    public class PluginBehaviour : MonoBehaviour
    {
        public PluginBehaviour(IntPtr ptr) : base(ptr) { }

        // Garde une référence gérée pour éviter que le GC ne collecte le delegate.
        private System.Action<Scene, LoadSceneMode>? _managedSceneHandler;

        private void Awake()
        {
            // Il2CppInterop ne supporte pas la conversion directe d'un method group
            // en UnityAction<Scene,LoadSceneMode> via new UnityAction<>(...).
            // On utilise donc SceneManager.add_sceneLoaded avec un delegate IL2CPP
            // wrappé via Il2CppInterop.Runtime.DelegateSupport.
            _managedSceneHandler = (scene, mode) => Plugin.Instance?.OnSceneLoaded(scene, mode);
            SceneManager.sceneLoaded += Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<
                UnityEngine.Events.UnityAction<Scene, LoadSceneMode>>(_managedSceneHandler);
        }

        private void Update()
        {
            InputBlockPatch.ResetFrameState();
        }

        private void OnDestroy()
        {
            // On ne peut pas facilement désabonner ici sans stocker le délégué converti.
            // Le scene handler orphelin est inoffensif car le plugin se dispose via Unload().
            Plugin.Instance?.Unload();
        }
    }
}
