using HarmonyLib;

using System;
using System.Collections;
using System.Reflection;
using System.Text;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans de tutoriel (section 1.5).
    ///
    /// ## Écrans couverts
    ///
    /// A) InitialSettingsViewController (YgomGame.Tutorial)
    ///    Écran de saisie du nom de duel au premier lancement.
    ///    → "Configuration initiale. Saisissez votre nom de duel."
    ///    Hook : NotificationStackEntry() — même RVA que BaseMenuViewController
    ///    mais Harmony patch par MethodInfo, donc distinct.
    ///
    /// B) CardFlyingViewController (YgomGame.Tutorial)
    ///    Animation d'intro : les cartes du deck de départ volent à l'écran.
    ///    → Annonce les messages du tutoriel (IList&lt;string&gt; passé à Start()).
    ///    Hook : static Start(IList&lt;string&gt; msgList, UnityAction onFinish)
    ///    — contient les textes réels affichés à l'écran.
    ///    __0 = msgList (IList&lt;string&gt; — itéré via IEnumerable)
    ///
    /// C) ScenarioViewController (YgomGame.Scenario)
    ///    → Déjà couvert par ScenarioPatch (LatePatches.ApplyMenuScenePatches).
    ///    → Annonce m_ScenarioName.
    ///
    /// ## Application
    /// Appliqué via Plugin.ApplyPatches() (avant la scène Menu).
    /// </summary>
    internal static class TutorialPatch
    {
        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            PatchInitialSettings(harmony);
            PatchCardFlying(harmony);
        }

        // ── A) InitialSettingsViewController ─────────────────────────────────

        private static void PatchInitialSettings(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("YgomGame.Tutorial.InitialSettingsViewController");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[TutorialPatch] InitialSettingsViewController introuvable.");
                    return;
                }

                var method = type.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[TutorialPatch] InitialSettingsViewController.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(TutorialPatch).GetMethod(
                    nameof(InitialSettings_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[TutorialPatch] ✓ InitialSettingsViewController.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TutorialPatch] Erreur InitialSettings: {ex.Message}");
            }
        }

        // ── B) CardFlyingViewController.Start() ──────────────────────────────

        private static void PatchCardFlying(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("YgomGame.Tutorial.CardFlyingViewController");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[TutorialPatch] CardFlyingViewController introuvable.");
                    return;
                }

                // static Start(IList<string> msgList, UnityAction onFinish) — 2 params
                System.Reflection.MethodInfo? method = null;
                foreach (var m in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                {
                    if (m.Name == "Start" && m.GetParameters().Length == 2)
                    {
                        method = m;
                        break;
                    }
                }

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[TutorialPatch] CardFlyingViewController.Start introuvable.");
                    return;
                }

                var postfix = typeof(TutorialPatch).GetMethod(
                    nameof(CardFlying_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[TutorialPatch] ✓ CardFlyingViewController.Start");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[TutorialPatch] Erreur CardFlying: {ex.Message}");
            }
        }

        // ── Postfix handlers ─────────────────────────────────────────────────

        /// <summary>
        /// InitialSettingsViewController.NotificationStackEntry() —
        /// écran de saisie du nom de duel (premier lancement).
        /// </summary>
        private static void InitialSettings_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("tuto_initial_settings"), interrupt: true); }
            catch { }
        }

        /// <summary>
        /// CardFlyingViewController.Start(IList&lt;string&gt; msgList, UnityAction onFinish) —
        /// intro du tutoriel avec animation de cartes volantes.
        ///
        /// __0 = msgList — itéré via IEnumerable pour lire les messages textuels.
        /// Si la liste est vide ou illisible, annonce le message générique.
        /// </summary>
        private static void CardFlying_Postfix(object __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? messages = ReadStringList(__0);
                if (!string.IsNullOrWhiteSpace(messages))
                    tts.Speak(Loc.Get("tuto_card_flying_messages", messages!), interrupt: true);
                else
                    tts.Speak(Loc.Get("tuto_card_flying"), interrupt: true);
            }
            catch { }
        }

        // ── Helper ────────────────────────────────────────────────────────────

        /// <summary>
        /// Itère un IList&lt;string&gt; (passé comme object depuis IL2CPP) via IEnumerable
        /// et concatène les entrées non vides avec ". ".
        /// </summary>
        private static string? ReadStringList(object list)
        {
            if (list == null) return null;
            try
            {
                var enumerable = list as IEnumerable;
                if (enumerable == null) return null;

                var sb = new StringBuilder();
                foreach (object? item in enumerable)
                {
                    if (item == null) continue;
                    string? s = item.ToString();
                    if (string.IsNullOrWhiteSpace(s)) continue;
                    if (sb.Length > 0) sb.Append(". ");
                    sb.Append(s.Trim());
                }
                return sb.Length > 0 ? sb.ToString() : null;
            }
            catch { return null; }
        }
    }
}
