using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch for LoginBonusViewController — daily login bonus screen.
    ///
    /// ## What is announced:
    ///
    /// A) OnCreatedView() — screen opens
    ///    → "Login bonus. Day N of M. Reward: [description] ×Q [status]"
    ///
    /// ## Data chain (dump-confirmed):
    ///
    ///   LoginBonusViewController
    ///     └─ m_MapWidget (LoginBonusMapWidet 0xE8)
    ///          ├─ progress (int property) — 0-based index of the current day
    ///          └─ slotWidgets (LoginBonusSlotWidget[]) — one per day
    ///               ├─ day (int property)         — 1-based day label
    ///               ├─ labelText (TMP_Text)        — "Day 1", "Jour 1" etc.
    ///               ├─ rewardNum (TMP_Text)        — quantity shown on screen
    ///               ├─ rewardCount (int property)  — number of rewards in this slot
    ///               └─ recievedCover (GameObject)  — active when already claimed
    ///
    /// Applied in LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class LoginBonusPatch
    {
        private static bool _applied = false;

        // Cached field/property references resolved once per scene
        private static FieldInfo?    _fMapWidget;
        private static PropertyInfo? _pProgress;
        private static PropertyInfo? _pSlotWidgets;
        private static PropertyInfo? _pLabelText;
        private static PropertyInfo? _pRewardNum;
        private static PropertyInfo? _pRewardCount;
        private static PropertyInfo? _pRecievedCover;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.LoginBonusViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[LoginBonusPatch] LoginBonusViewController introuvable.");
                return;
            }

            var m = vcType.GetMethod("OnCreatedView",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[LoginBonusPatch] OnCreatedView introuvable.");
                return;
            }

            harmony.Patch(m, postfix: new HarmonyMethod(
                typeof(LoginBonusPatch), nameof(OnCreatedView_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[LoginBonusPatch] ✓ LoginBonusViewController.OnCreatedView");
        }

        internal static void Reset()
        {
            _applied        = false;
            _fMapWidget     = null;
            _pProgress      = null;
            _pSlotWidgets   = null;
            _pLabelText     = null;
            _pRewardNum     = null;
            _pRewardCount   = null;
            _pRecievedCover = null;
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void OnCreatedView_Postfix(object __instance)
        {
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
                Plugin.Instance?.LogWarn($"[LoginBonusPatch] {ex.Message}");
            }
        }

        // ── Announcement builder ──────────────────────────────────────────────

        private static string BuildAnnouncement(object vc)
        {
            // 1. Get m_MapWidget
            object? mapWidget = GetMapWidget(vc);
            if (mapWidget == null) return Loc.Get("screen_login_bonus");

            // 2. Get progress (0-based current day index) and slot array
            int progress = GetIntProp(mapWidget, ref _pProgress, "progress");
            Array? slots = GetSlotWidgets(mapWidget);
            int total = slots?.Length ?? 0;

            // 3. Build header "Login bonus. Day N of M."
            string header = total > 0
                ? Loc.Get("login_bonus_day_n_of_m", progress + 1, total)
                : Loc.Get("screen_login_bonus");

            // 4. Read today's slot data
            if (slots == null || progress < 0 || progress >= total)
                return header;

            object? slot = slots.GetValue(progress);
            if (slot == null) return header;

            string reward = BuildSlotDescription(slot, progress, total);
            return string.IsNullOrWhiteSpace(reward)
                ? header
                : $"{header}. {reward}";
        }

        private static string BuildSlotDescription(object slot, int progress, int total)
        {
            var parts = new System.Collections.Generic.List<string>();

            // labelText — e.g. "Jour 1" / "Day 1"
            string? label = GetTmpText(slot, ref _pLabelText, "labelText");
            if (!string.IsNullOrWhiteSpace(label)) parts.Add(label!);

            // rewardNum — quantity string e.g. "×3"
            string? qty = GetTmpText(slot, ref _pRewardNum, "rewardNum");
            if (!string.IsNullOrWhiteSpace(qty)) parts.Add(qty!);

            // rewardCount — integer count
            int count = GetIntProp(slot, ref _pRewardCount, "rewardCount");
            if (count > 0 && string.IsNullOrWhiteSpace(qty))
                parts.Add($"×{count}");

            // recievedCover — already claimed today?
            bool claimed = GetGameObjectActive(slot, ref _pRecievedCover, "recievedCover");
            if (claimed)
                parts.Add(Loc.Get("login_bonus_claimed"));
            else
                parts.Add(Loc.Get("login_bonus_available"));

            return string.Join(", ", parts);
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        private static object? GetMapWidget(object vc)
        {
            if (_fMapWidget == null)
            {
                _fMapWidget = vc.GetType().GetField("m_MapWidget",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            }
            return _fMapWidget?.GetValue(vc);
        }

        private static Array? GetSlotWidgets(object mapWidget)
        {
            if (_pSlotWidgets == null)
            {
                _pSlotWidgets = mapWidget.GetType().GetProperty("slotWidgets",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            }
            return _pSlotWidgets?.GetValue(mapWidget) as Array;
        }

        private static int GetIntProp(object obj, ref PropertyInfo? cache, string name)
        {
            try
            {
                if (cache == null)
                    cache = obj.GetType().GetProperty(name,
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var val = cache?.GetValue(obj);
                return val == null ? 0 : Convert.ToInt32(val);
            }
            catch { return 0; }
        }

        private static string? GetTmpText(object obj, ref PropertyInfo? cache, string propName)
        {
            try
            {
                if (cache == null)
                    cache = obj.GetType().GetProperty(propName,
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var tmp = cache?.GetValue(obj);
                if (tmp == null) return null;
                var textProp = tmp.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                return textProp?.GetValue(tmp)?.ToString();
            }
            catch { return null; }
        }

        private static bool GetGameObjectActive(object obj, ref PropertyInfo? cache, string propName)
        {
            try
            {
                if (cache == null)
                    cache = obj.GetType().GetProperty(propName,
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var go = cache?.GetValue(obj) as UnityEngine.GameObject;
                return go != null && go.activeInHierarchy;
            }
            catch { return false; }
        }
    }
}
