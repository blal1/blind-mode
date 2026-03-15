using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour l'écran principal du Duel Pass.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — écran ouvert
    ///    → "Duel Pass. Palier actuel : X. Prochain palier : Y."
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   DuelPassViewController (namespace YgomGame.Duelpass)
    ///     └─ progressBar (DuelpassProgressBarWidget, privé 0xD0)
    ///          ├─ currentGradeText (TMP_Text, privé 0x10)
    ///          └─ nextGradeText    (TMP_Text, privé 0x18)
    ///
    /// Appliqué via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class DuelPassViewControllerPatch
    {
        private static bool _applied = false;

        // Instance active — utilisée par KeyboardShortcuts.ReadDuelPassProgression()
        internal static object? ActiveInstance;

        // Caches de réflexion
        private static FieldInfo? _fProgressBar;
        private static FieldInfo? _fCurrentGradeText;
        private static FieldInfo? _fNextGradeText;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Duelpass.DuelPassViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[DuelPassViewControllerPatch] DuelPassViewController introuvable.");
                return;
            }

            var m = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[DuelPassViewControllerPatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(m, postfix: new HarmonyMethod(
                typeof(DuelPassViewControllerPatch), nameof(NotificationStackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[DuelPassViewControllerPatch] ✓ DuelPassViewController.NotificationStackEntry");
        }

        internal static void Reset()
        {
            _applied           = false;
            ActiveInstance     = null;
            _fProgressBar      = null;
            _fCurrentGradeText = null;
            _fNextGradeText    = null;
        }

        /// <summary>
        /// Retourne l'annonce de progression actuelle (utilisé par raccourci P hors duel).
        /// </summary>
        internal static string GetCurrentAnnouncement() =>
            ActiveInstance != null ? BuildAnnouncement(ActiveInstance) : Loc.Get("screen_duel_pass");

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void NotificationStackEntry_Postfix(object __instance)
        {
            ActiveInstance = __instance;
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string msg = BuildAnnouncement(__instance);
                if (!string.IsNullOrWhiteSpace(msg))
                    tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[DuelPassViewControllerPatch] {ex.Message}");
            }
        }

        // ── Announcement builder ──────────────────────────────────────────────

        private static string BuildAnnouncement(object vc)
        {
            // 1. Lire le widget progressBar (DuelpassProgressBarWidget)
            if (_fProgressBar == null)
                _fProgressBar = vc.GetType().GetField("progressBar",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            object? progressBarWidget = _fProgressBar?.GetValue(vc);
            if (progressBarWidget == null)
                return Loc.Get("screen_duel_pass");

            // 2. Lire currentGradeText et nextGradeText depuis le widget
            if (_fCurrentGradeText == null)
                _fCurrentGradeText = progressBarWidget.GetType().GetField("currentGradeText",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            if (_fNextGradeText == null)
                _fNextGradeText = progressBarWidget.GetType().GetField("nextGradeText",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            string? currentGrade = ReadTmpText(_fCurrentGradeText, progressBarWidget);
            string? nextGrade    = ReadTmpText(_fNextGradeText,    progressBarWidget);

            // 3. Construire le message
            if (!string.IsNullOrWhiteSpace(currentGrade) && !string.IsNullOrWhiteSpace(nextGrade))
                return Loc.Get("duelpass_grade_info", currentGrade!, nextGrade!);

            if (!string.IsNullOrWhiteSpace(currentGrade))
                return Loc.Get("duelpass_grade_current", currentGrade!);

            return Loc.Get("screen_duel_pass");
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string? ReadTmpText(FieldInfo? fi, object obj)
        {
            try
            {
                var tmp = fi?.GetValue(obj);
                if (tmp == null) return null;
                var textProp = tmp.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                return textProp?.GetValue(tmp)?.ToString();
            }
            catch { return null; }
        }
    }
}
