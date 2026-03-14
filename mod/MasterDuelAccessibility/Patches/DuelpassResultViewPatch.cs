using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour DuelpassResultViewController — résultat Duel Pass post-duel.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) OnGradeUp(int grade) — montée de palier
    ///    → "Palier supérieur ! Palier {grade}."
    ///
    /// B) OnEndProgressBarAnimation() — animation terminée
    ///    → "Duel Pass. Palier actuel : {X}. Prochain palier : {Y}."
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   DuelpassResultViewController (namespace YgomGame.Duelpass)
    ///     └─ resultProgressBar (DuelpassResultProgressBarWidget 0xD0)
    ///          ├─ currentGradeText (TMP_Text privé 0x10)
    ///          └─ nextGradeText    (TMP_Text privé 0x18)
    ///
    /// Appliqué via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class DuelpassResultViewPatch
    {
        private static bool _applied = false;

        // Caches de réflexion
        private static FieldInfo? _fResultProgressBar;
        private static FieldInfo? _fCurrentGradeText;
        private static FieldInfo? _fNextGradeText;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Duelpass.DuelpassResultViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[DuelpassResultViewPatch] DuelpassResultViewController introuvable.");
                return;
            }

            // Patch OnGradeUp(int grade) — montée de palier
            var mGradeUp = vcType.GetMethod("OnGradeUp",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mGradeUp != null)
            {
                harmony.Patch(mGradeUp, postfix: new HarmonyMethod(
                    typeof(DuelpassResultViewPatch), nameof(OnGradeUp_Postfix)));
                Plugin.Instance?.LogMsg("[DuelpassResultViewPatch] ✓ DuelpassResultViewController.OnGradeUp");
            }

            // Patch OnEndProgressBarAnimation() — état final après animation
            var mEnd = vcType.GetMethod("OnEndProgressBarAnimation",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mEnd != null)
            {
                harmony.Patch(mEnd, postfix: new HarmonyMethod(
                    typeof(DuelpassResultViewPatch), nameof(OnEndAnimation_Postfix)));
                Plugin.Instance?.LogMsg("[DuelpassResultViewPatch] ✓ DuelpassResultViewController.OnEndProgressBarAnimation");
            }

            if (mGradeUp == null && mEnd == null)
            {
                Plugin.Instance?.LogWarn("[DuelpassResultViewPatch] Aucune méthode à patcher.");
                return;
            }

            _applied = true;
        }

        internal static void Reset()
        {
            _applied           = false;
            _fResultProgressBar = null;
            _fCurrentGradeText = null;
            _fNextGradeText    = null;
        }

        // ── Postfix : OnGradeUp ──────────────────────────────────────────────

        /// <summary>__0 = grade (int) — nouveau palier atteint.</summary>
        public static void OnGradeUp_Postfix(int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("duelpass_grade_up", __0), interrupt: false);
            }
            catch { }
        }

        // ── Postfix : OnEndProgressBarAnimation ─────────────────────────────

        public static void OnEndAnimation_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? msg = BuildGradeAnnouncement(__instance);
                if (!string.IsNullOrWhiteSpace(msg))
                    tts.Speak(msg!, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[DuelpassResultViewPatch] OnEndAnimation: {ex.Message}");
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string? BuildGradeAnnouncement(object vc)
        {
            if (_fResultProgressBar == null)
                _fResultProgressBar = vc.GetType().GetField("resultProgressBar",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            object? widget = _fResultProgressBar?.GetValue(vc);
            if (widget == null) return null;

            if (_fCurrentGradeText == null)
                _fCurrentGradeText = widget.GetType().GetField("currentGradeText",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            if (_fNextGradeText == null)
                _fNextGradeText = widget.GetType().GetField("nextGradeText",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            string? current = ReadTmpText(_fCurrentGradeText, widget);
            string? next    = ReadTmpText(_fNextGradeText,    widget);

            if (!string.IsNullOrWhiteSpace(current) && !string.IsNullOrWhiteSpace(next))
                return Loc.Get("duelpass_grade_info", current!, next!);

            if (!string.IsNullOrWhiteSpace(current))
                return Loc.Get("duelpass_grade_current", current!);

            return null;
        }

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
