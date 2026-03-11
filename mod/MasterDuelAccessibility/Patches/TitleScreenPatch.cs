using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour l'écran de chargement initial et l'écran titre du jeu.
    ///
    /// ## Scénario de chargement
    ///
    /// Au premier lancement du jeu, la séquence est :
    ///   1. BootSequence.Start()            — chargement des assets fondamentaux
    ///   2. PreTitleSequneceViewController  — logos (Konami, Unity, etc.)
    ///   3. SystemProgress.DispProgress()   — spinner de chargement entre scènes
    ///   4. TitleViewController             — écran titre "Appuyez pour commencer"
    ///   5. TitleViewController.OnClickStart() → SystemProgress → scène Home
    ///
    /// ## Ce patch couvre :
    ///
    /// A) BootSequence.Start()
    ///    → Annonce "Chargement du jeu en cours..." au tout premier démarrage
    ///
    /// B) SystemProgress.DispProgress(ProgressType type, ...)
    ///    → Annonce "Chargement en cours..." quand l'écran de chargement apparaît
    ///    → Annonce "Chargement terminé." quand il se cache (ProgressType.None)
    ///
    /// C) TitleViewController.NotificationStackEntry()
    ///    → Annonce "Écran titre. Appuyez sur Entrée pour commencer."
    ///    → C'est le signal que l'écran titre est visible et interactif
    ///
    /// D) TitleViewController.OnClickStart() [private]
    ///    → Annonce "Connexion en cours..." quand le joueur démarre
    ///
    /// ## Application
    /// Ces patches sont appliqués dès le démarrage (Plugin.ApplyPatches),
    /// pas de dépendance de scène.
    /// </summary>
    internal static class TitleScreenPatch
    {
        // ── Déduplication SystemProgress ──────────────────────────────────────
        // Évite d'annoncer plusieurs fois consécutives le même message de chargement
        private static int _lastProgressType = -1;

        // ── Appliqué au démarrage via Plugin ─────────────────────────────────

        // ── Cooldown LoadingViewController ───────────────────────────────────
        private static DateTime _lastLoadingAnnounce = DateTime.MinValue;
        private const double LoadingCooldownMs = 3000; // 3s entre deux annonces

        // ── Caches réflexion TitleDataLinkDialog + TitleDemoVC ────────────────
        private static FieldInfo? _fMainText;
        private static FieldInfo? _fScenarioNameDemo;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            PatchBootSequence(harmony);
            PatchSystemProgress(harmony);
            PatchTitleViewController(harmony);
            PatchLogoViewControllers(harmony);
            PatchTitleExtras(harmony);
            PatchLoadingViewController(harmony);
        }

        // ── A) BootSequence.Start() ───────────────────────────────────────────

        private static void PatchBootSequence(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("BootSequence");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] BootSequence introuvable.");
                    return;
                }

                var method = type.GetMethod("Start",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                if (method == null)
                {
                    // Start() peut être IEnumerator — chercher par nom peu importe le retour
                    method = type.GetMethod("Start",
                        BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.Static);
                }
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] BootSequence.Start introuvable.");
                    return;
                }

                var postfix = typeof(TitleScreenPatch).GetMethod(
                    nameof(BootStart_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[TitleScreenPatch] ✓ BootSequence.Start");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TitleScreenPatch] Erreur PatchBootSequence: {ex.Message}");
            }
        }

        // ── B) SystemProgress.DispProgress() ─────────────────────────────────

        private static void PatchSystemProgress(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("YgomGame.Menu.SystemProgress");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] SystemProgress introuvable.");
                    return;
                }

                // DispProgress(ProgressType type, Color fadeColor, float delay, bool immediate, ...)
                var method = type.GetMethod("DispProgress",
                    BindingFlags.Public | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] SystemProgress.DispProgress introuvable.");
                    return;
                }

                var postfix = typeof(TitleScreenPatch).GetMethod(
                    nameof(DispProgress_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[TitleScreenPatch] ✓ SystemProgress.DispProgress");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TitleScreenPatch] Erreur PatchSystemProgress: {ex.Message}");
            }
        }

        // ── C) TitleViewController.NotificationStackEntry() ──────────────────

        private static void PatchTitleViewController(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("YgomGame.Menu.TitleViewController");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] TitleViewController introuvable.");
                    return;
                }

                // C) NotificationStackEntry — écran titre prêt
                var stackEntry = type.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.Instance);
                if (stackEntry != null)
                {
                    var postfix = typeof(TitleScreenPatch).GetMethod(
                        nameof(TitleStackEntry_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                    harmony.Patch(stackEntry, postfix: new HarmonyMethod(postfix));
                    Plugin.Instance?.LogMsg("[TitleScreenPatch] ✓ TitleViewController.NotificationStackEntry");
                }

                // D) OnClickStart — bouton "Commencer" cliqué
                var clickStart = type.GetMethod("OnClickStart",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                if (clickStart != null)
                {
                    var postfix = typeof(TitleScreenPatch).GetMethod(
                        nameof(TitleClickStart_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                    harmony.Patch(clickStart, postfix: new HarmonyMethod(postfix));
                    Plugin.Instance?.LogMsg("[TitleScreenPatch] ✓ TitleViewController.OnClickStart");
                }
                else
                {
                    // Essayer via StartGame() (méthode publique alternative)
                    var startGame = type.GetMethod("StartGame",
                        BindingFlags.Public | BindingFlags.Instance);
                    if (startGame != null)
                    {
                        var postfix = typeof(TitleScreenPatch).GetMethod(
                            nameof(TitleClickStart_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                        harmony.Patch(startGame, postfix: new HarmonyMethod(postfix));
                        Plugin.Instance?.LogMsg("[TitleScreenPatch] ✓ TitleViewController.StartGame");
                    }
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TitleScreenPatch] Erreur PatchTitleViewController: {ex.Message}");
            }
        }

        // ── E) Logo ViewControllers (Konami, Unity, OnDemand, PreTitle) ──────

        /// <summary>
        /// Patche chaque ViewController de logo/intro via NotificationStackEntry.
        /// Tous sont dans YgomGame.Menu sauf PreTitleSequneceViewController.
        /// </summary>
        private static void PatchLogoViewControllers(HarmonyLib.Harmony harmony)
        {
            // (typeName, postfixMethodName, logLabel)
            var targets = new (string TypeName, string PostfixName, string LogLabel)[]
            {
                ("YgomGame.Menu.KonamiLogoViewController",    nameof(KonamiLogo_Postfix),    "KonamiLogoViewController"),
                ("YgomGame.Menu.UnityLogoViewController",     nameof(UnityLogo_Postfix),     "UnityLogoViewController"),
                ("YgomGame.Menu.OnDemandLogoViewController",  nameof(OnDemandLogo_Postfix),  "OnDemandLogoViewController"),
                ("YgomGame.Menu.PreTitleSequneceViewController", nameof(PreTitle_Postfix),   "PreTitleSequneceViewController"),
            };

            foreach (var (typeName, postfixName, logLabel) in targets)
            {
                try
                {
                    var type = AccessToolsHelper.FindType(typeName);
                    if (type == null)
                    {
                        Plugin.Instance?.LogWarn($"[TitleScreenPatch] {logLabel} introuvable.");
                        continue;
                    }

                    var method = type.GetMethod("NotificationStackEntry",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    if (method == null)
                    {
                        Plugin.Instance?.LogWarn($"[TitleScreenPatch] {logLabel}.NotificationStackEntry introuvable.");
                        continue;
                    }

                    var postfix = typeof(TitleScreenPatch).GetMethod(
                        postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                    harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                    Plugin.Instance?.LogMsg($"[TitleScreenPatch] ✓ {logLabel}.NotificationStackEntry");
                }
                catch (Exception ex)
                {
                    Plugin.Instance?.LogErr($"[TitleScreenPatch] Erreur patch {logLabel}: {ex.Message}");
                }
            }
        }

        // ── F) TitleDemoVC, TitleSettingMenuVC, TitleDataLinkDialogVC ─────────

        private static void PatchTitleExtras(HarmonyLib.Harmony harmony)
        {
            // TitleDemoViewController — cinématique d'intro du titre
            PatchSimpleStackEntry(harmony,
                "YgomGame.Menu.TitleDemoViewController",
                nameof(TitleDemo_Postfix),
                "TitleDemoViewController");

            // TitleSettingMenuViewController — sous-menu de paramètres sur l'écran titre
            PatchSimpleStackEntry(harmony,
                "YgomGame.SubMenu.TitleSettingMenuViewController",
                nameof(TitleSettingMenu_Postfix),
                "TitleSettingMenuViewController");

            // TitleDataLinkDialogViewController — dialog de liaison de compte
            PatchSimpleStackEntry(harmony,
                "YgomGame.Menu.TitleDataLinkDialogViewController",
                nameof(TitleDataLink_Postfix),
                "TitleDataLinkDialogViewController");
        }

        /// <summary>
        /// Patche NotificationStackEntry d'un type quelconque avec un postfix donné.
        /// Factorisé pour éviter la répétition.
        /// </summary>
        private static void PatchSimpleStackEntry(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            try
            {
                var type = AccessToolsHelper.FindType(typeName);
                if (type == null)
                {
                    Plugin.Instance?.LogWarn($"[TitleScreenPatch] {logLabel} introuvable.");
                    return;
                }

                var method = type.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn($"[TitleScreenPatch] {logLabel}.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(TitleScreenPatch).GetMethod(
                    postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg($"[TitleScreenPatch] ✓ {logLabel}.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TitleScreenPatch] Erreur patch {logLabel}: {ex.Message}");
            }
        }

        // ── G) LoadingViewController ──────────────────────────────────────────

        private static void PatchLoadingViewController(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("YgomGame.Menu.LoadingViewController");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] LoadingViewController introuvable.");
                    return;
                }

                var method = type.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[TitleScreenPatch] LoadingViewController.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(TitleScreenPatch).GetMethod(
                    nameof(Loading_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[TitleScreenPatch] ✓ LoadingViewController.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TitleScreenPatch] Erreur PatchLoadingViewController: {ex.Message}");
            }
        }

        // ── Postfix handlers ─────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour BootSequence.Start() — annonce le démarrage du jeu.
        /// NOTE: Start() est un IEnumerator, le postfix s'exécute quand le coroutine
        /// démarre (pas quand il se termine). C'est suffisant pour l'annonce.
        /// </summary>
        private static void BootStart_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                Plugin.Instance?.LogMsg("[TitleScreenPatch] BootSequence.Start → annonce chargement");
                tts.Speak(Loc.Get("game_loading"), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// Postfix pour SystemProgress.DispProgress(ProgressType type, Color fadeColor, ...).
        ///
        /// __0 = ProgressType (int) :
        ///   0 = None (chargement terminé / spinner caché)
        ///   1 = Normal (spinner rotatif)
        ///   2 = Tips (chargement avec conseils)
        ///   3 = Blank (fondu noir sans spinner)
        /// </summary>
        private static void DispProgress_Postfix(int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Éviter de répéter le même type d'annonce
                if (__0 == _lastProgressType) return;
                _lastProgressType = __0;

                switch (__0)
                {
                    case 0: // None — chargement terminé
                        // N'annoncer "terminé" que si on était en train de charger
                        // (évite le faux positif au 1er lancement avant tout chargement)
                        break;

                    case 1: // Normal
                    case 2: // Tips
                        tts.Speak(Loc.Get("loading_in_progress"), interrupt: false, addToHistory: false);
                        break;

                    case 3: // Blank — transition silencieuse
                        break;
                }
            }
            catch { }
        }

        /// <summary>
        /// Postfix pour TitleViewController.NotificationStackEntry() —
        /// l'écran titre est maintenant visible et interactif.
        /// </summary>
        private static void TitleStackEntry_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                Plugin.Instance?.LogMsg("[TitleScreenPatch] Écran titre affiché");
                tts.Speak(Loc.Get("title_screen_ready"), interrupt: true);
            }
            catch { }
        }

        /// <summary>
        /// Postfix pour TitleViewController.OnClickStart() / StartGame() —
        /// le joueur vient de cliquer sur "Commencer".
        /// </summary>
        private static void TitleClickStart_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("title_starting"), interrupt: true, addToHistory: false);
            }
            catch { }
        }

        // ── E) Logo postfixes ─────────────────────────────────────────────────

        private static void KonamiLogo_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("logo_konami"), interrupt: true); }
            catch { }
        }

        private static void UnityLogo_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("logo_unity"), interrupt: true); }
            catch { }
        }

        private static void OnDemandLogo_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("logo_on_demand"), interrupt: true); }
            catch { }
        }

        private static void PreTitle_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("logo_pre_title"), interrupt: true); }
            catch { }
        }

        // ── F) TitleExtras postfixes ──────────────────────────────────────────

        /// <summary>
        /// TitleDemoViewController — cinématique de démo du titre.
        /// Lit m_scenarioName (string 0xD0) si disponible.
        /// </summary>
        private static void TitleDemo_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? scenarioName = TryReadStringField(__instance, ref _fScenarioNameDemo, "m_scenarioName");
                if (!string.IsNullOrWhiteSpace(scenarioName))
                    tts.Speak(Loc.Get("title_demo_named", scenarioName!), interrupt: true);
                else
                    tts.Speak(Loc.Get("title_demo"), interrupt: true);
            }
            catch { }
        }

        private static void TitleSettingMenu_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("title_settings"), interrupt: true); }
            catch { }
        }

        /// <summary>
        /// TitleDataLinkDialogViewController — dialog de liaison de compte.
        /// Lit MainText (ExtendedTextMeshProUGUI 0x110) → .text si disponible.
        /// </summary>
        private static void TitleDataLink_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? mainText = TryReadTmpFieldByName(__instance, ref _fMainText, "MainText");
                if (!string.IsNullOrWhiteSpace(mainText))
                    tts.Speak(Loc.Get("title_data_link_text", mainText!), interrupt: true);
                else
                    tts.Speak(Loc.Get("title_data_link"), interrupt: true);
            }
            catch { }
        }

        // ── G) LoadingViewController postfix ─────────────────────────────────

        /// <summary>
        /// LoadingViewController.NotificationStackEntry — écran de chargement inter-scènes.
        /// Cooldown 3s pour éviter les spams lors des chargements fréquents.
        /// </summary>
        private static void Loading_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var now = DateTime.UtcNow;
                if ((now - _lastLoadingAnnounce).TotalMilliseconds < LoadingCooldownMs) return;
                _lastLoadingAnnounce = now;
                tts.Speak(Loc.Get("loading_screen"), interrupt: false, addToHistory: false);
            }
            catch { }
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        /// <summary>
        /// Lit un champ string par nom en remontant la hiérarchie de type.
        /// </summary>
        private static string? TryReadStringField(object instance, ref FieldInfo? cache, string fieldName)
        {
            try
            {
                if (cache == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField(fieldName,
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { cache = f; break; }
                        t = t.BaseType;
                    }
                }
                return cache?.GetValue(instance)?.ToString();
            }
            catch { return null; }
        }

        /// <summary>
        /// Lit un composant TMP (ExtendedTextMeshProUGUI ou TMP_Text) par nom de champ
        /// et retourne sa propriété .text.
        /// </summary>
        private static string? TryReadTmpFieldByName(object instance, ref FieldInfo? cache, string fieldName)
        {
            try
            {
                if (cache == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField(fieldName,
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { cache = f; break; }
                        t = t.BaseType;
                    }
                }
                if (cache == null) return null;

                object? comp = cache.GetValue(instance);
                if (comp == null) return null;

                var textProp = comp.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                return textProp?.GetValue(comp)?.ToString();
            }
            catch { return null; }
        }
    }
}
