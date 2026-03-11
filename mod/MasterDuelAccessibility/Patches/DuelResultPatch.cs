using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch for DuelResultViewController — post-duel result screen.
    ///
    /// ## What is announced:
    ///
    /// A) OnCreatedView() — result screen opens
    ///    → Reads ResultInfoScores to announce total score and rewards
    ///    → Reads rank change info if available
    ///
    /// B) OnFocusChanged(bool setfocus) — focus returns to result screen
    ///    → Re-announces summary on regain focus (after viewing replay, etc.)
    ///
    /// ## Data sources (via reflection):
    /// - m_GameMode : Util.GameMode — which mode was played
    /// - m_GetScoreReward : GetScoreReward widget — score + rewards
    /// - RetryButton, SaveButton, BackButton : SelectionButton — actions
    ///
    /// Applied in LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class DuelResultPatch
    {
        private static bool _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.DuelResultViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[DuelResultPatch] DuelResultViewController introuvable.");
                return;
            }

            PatchOnCreatedView(harmony, vcType);
            PatchOnFocusChanged(harmony, vcType);

            _applied = true;
            Plugin.Instance?.LogMsg("[DuelResultPatch] Patches appliqués.");
        }

        internal static void Reset() => _applied = false;

        private static void PatchOnCreatedView(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OnCreatedView",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[DuelResultPatch] OnCreatedView introuvable.");
                return;
            }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(DuelResultPatch), nameof(OnCreatedView_Postfix)));
            Plugin.Instance?.LogMsg("[DuelResultPatch] ✓ DuelResultViewController.OnCreatedView");
        }

        private static void PatchOnFocusChanged(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OnFocusChanged",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null) return; // Not critical

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(DuelResultPatch), nameof(OnFocusChanged_Postfix)));
            Plugin.Instance?.LogMsg("[DuelResultPatch] ✓ DuelResultViewController.OnFocusChanged");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        public static void OnCreatedView_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string summary = BuildResultSummary(__instance);
                if (!string.IsNullOrWhiteSpace(summary))
                    tts.Speak(summary, interrupt: false);
            }
            catch { }
        }

        public static void OnFocusChanged_Postfix(object __instance, bool __0)
        {
            if (!__0) return;
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("screen_duel_result"), interrupt: false);
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>
        /// Builds a summary string from the duel result screen.
        /// Reads m_GetScoreReward widget for score data, buttons for available actions.
        /// </summary>
        private static string BuildResultSummary(object instance)
        {
            var parts = new List<string>();

            parts.Add(Loc.Get("screen_duel_result"));

            // Try to read the game mode
            string? gameMode = ReadGameMode(instance);
            if (!string.IsNullOrWhiteSpace(gameMode))
                parts.Add(gameMode!);

            // Try to read the score reward widget content
            string? scoreInfo = ReadScoreReward(instance);
            if (!string.IsNullOrWhiteSpace(scoreInfo))
                parts.Add(scoreInfo!);

            // Announce available buttons
            string? buttons = ReadAvailableButtons(instance);
            if (!string.IsNullOrWhiteSpace(buttons))
                parts.Add(buttons!);

            return string.Join(". ", parts);
        }

        /// <summary>
        /// Reads m_GameMode field value and maps to a readable label.
        /// </summary>
        private static string? ReadGameMode(object instance)
        {
            try
            {
                var field = instance.GetType().GetField("m_GameMode",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                if (field == null) return null;

                int mode = Convert.ToInt32(field.GetValue(instance));
                return mode switch
                {
                    0 => Loc.Get("result_mode_ranked"),
                    1 => Loc.Get("result_mode_casual"),
                    2 => Loc.Get("result_mode_solo"),
                    3 => Loc.Get("result_mode_room"),
                    4 => Loc.Get("result_mode_event"),
                    _ => null,
                };
            }
            catch { return null; }
        }

        /// <summary>
        /// Reads the GetScoreReward widget for total score points.
        /// </summary>
        private static string? ReadScoreReward(object instance)
        {
            try
            {
                var field = instance.GetType().GetField("m_GetScoreReward",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var widget = field?.GetValue(instance);
                if (widget == null) return null;

                // Try to read the total point from the widget
                // ResultInfoScores has SetTotalPoint(int) — the value is stored internally
                // We try to find a text element showing the total
                var textFields = new[] { "m_TotalPointText", "m_totalPoint", "totalPointText" };
                foreach (var tf in textFields)
                {
                    var txtField = widget.GetType().GetField(tf,
                        BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    if (txtField == null) continue;

                    var txtObj = txtField.GetValue(widget);
                    if (txtObj == null) continue;

                    var textProp = txtObj.GetType().GetProperty("text",
                        BindingFlags.Public | BindingFlags.Instance);
                    var text = textProp?.GetValue(txtObj)?.ToString();
                    if (!string.IsNullOrWhiteSpace(text))
                        return Loc.Get("result_score", text!);
                }

                return null;
            }
            catch { return null; }
        }

        /// <summary>
        /// Checks which action buttons are active (Retry, Save, Back).
        /// </summary>
        private static string? ReadAvailableButtons(object instance)
        {
            try
            {
                var actions = new List<string>();
                var btnNames = new[] {
                    ("RetryButton", "result_btn_retry"),
                    ("SaveButton",  "result_btn_save"),
                    ("BackButton",  "result_btn_back"),
                };

                foreach (var (fieldName, locKey) in btnNames)
                {
                    var field = instance.GetType().GetField(fieldName,
                        BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    var btn = field?.GetValue(instance);
                    if (btn == null) continue;

                    // Check if active
                    var goProp = btn.GetType().GetProperty("gameObject",
                        BindingFlags.Public | BindingFlags.Instance);
                    var go = goProp?.GetValue(btn) as UnityEngine.GameObject;
                    if (go != null && go.activeInHierarchy)
                        actions.Add(Loc.Get(locKey));
                }

                return actions.Count > 0
                    ? Loc.Get("result_actions", string.Join(", ", actions))
                    : null;
            }
            catch { return null; }
        }
    }
}
