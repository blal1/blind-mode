using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch for LotteryPortalViewController — pack selection portal.
    /// Also patches LotteryCardSelectViewController — guaranteed card selection.
    ///
    /// ## What is announced:
    ///
    /// A) LotteryPortalViewController.NotificationStackEntry() — portal screen opens
    ///    → "Pack portal. [pack name if available]"
    ///
    /// B) LotteryCardSelectViewController.NotificationStackEntry() — guaranteed card select
    ///    → "Sélection de carte garantie — [pack name]." or "Sélection de carte garantie."
    ///    Reads m_lotteryID (int) and resolves via LotteryData.GetName.
    ///    Namespace: YgomGame.Lottery, TypeDefIndex 5901.
    ///
    /// ## Data chain (dump-confirmed):
    ///
    ///   LotteryPortalViewController (YgomGame.Lottery)
    ///     ├─ m_Id (int 0xE8)         — the lottery pack ID for the current screen
    ///     └─ NotificationStackEntry()
    ///
    ///   LotteryCardSelectViewController (YgomGame.Lottery)
    ///     ├─ m_lotteryID (int 0xD0)  — lottery pack ID
    ///     └─ NotificationStackEntry() — override
    ///
    /// Pack name resolution via LotteryData.GetName(int lotteryId) — see ResolveLotteryName().
    ///
    /// Applied in LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class LotteryPortalPatch
    {
        private static bool _applied = false;

        private static FieldInfo?  _fId;
        private static Type?       _lotteryDataType;
        private static MethodInfo? _mGetName;
        private static bool        _nameResolutionTried;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Lottery.LotteryPortalViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[LotteryPortalPatch] LotteryPortalViewController introuvable.");
                return;
            }

            // Patch NotificationStackEntry — fires when screen becomes active
            var nse = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (nse != null)
            {
                harmony.Patch(nse, postfix: new HarmonyMethod(
                    typeof(LotteryPortalPatch), nameof(NotificationStackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[LotteryPortalPatch] ✓ LotteryPortalViewController.NotificationStackEntry");
            }

            // LotteryCardSelectViewController.NotificationStackEntry — guaranteed card selection
            var cardSelectType = AccessToolsHelper.FindType("YgomGame.Lottery.LotteryCardSelectViewController");
            if (cardSelectType != null)
            {
                var nseCardSelect = cardSelectType.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (nseCardSelect != null)
                {
                    harmony.Patch(nseCardSelect, postfix: new HarmonyMethod(
                        typeof(LotteryPortalPatch), nameof(CardSelectNSE_Postfix)));
                    Plugin.Instance?.LogMsg("[LotteryPortalPatch] ✓ LotteryCardSelectViewController.NotificationStackEntry");
                }
            }
            else
            {
                Plugin.Instance?.LogWarn("[LotteryPortalPatch] LotteryCardSelectViewController introuvable.");
            }

            _applied = true;
            Plugin.Instance?.LogMsg("[LotteryPortalPatch] Patches appliqués.");
        }

        internal static void Reset()
        {
            _applied            = false;
            _fId                = null;
            _lotteryDataType    = null;
            _mGetName           = null;
            _nameResolutionTried = false;
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void NotificationStackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string announcement = BuildAnnouncement(__instance);
                tts.Speak(announcement, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[LotteryPortalPatch] {ex.Message}");
            }
        }

        // ── Announcement builder ──────────────────────────────────────────────

        private static string BuildAnnouncement(object vc)
        {
            int lotteryId = GetId(vc);

            // Try to resolve pack name from LotteryData API
            string? packName = lotteryId > 0 ? ResolveLotteryName(lotteryId) : null;

            return string.IsNullOrWhiteSpace(packName)
                ? Loc.Get("screen_lottery_portal")
                : Loc.Get("lottery_portal_pack", packName!);
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        private static int GetId(object vc)
        {
            try
            {
                if (_fId == null)
                    _fId = vc.GetType().GetField("m_Id",
                        BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var val = _fId?.GetValue(vc);
                return val == null ? 0 : Convert.ToInt32(val);
            }
            catch { return 0; }
        }

        // ── LotteryCardSelectViewController.NotificationStackEntry ────────────
        // m_lotteryID (int 0xD0) — pack ID for the guaranteed card selection

        public static void CardSelectNSE_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var fId = __instance.GetType().GetField("m_lotteryID",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                int lotteryId = fId != null ? Convert.ToInt32(fId.GetValue(__instance)) : 0;
                string? packName = lotteryId > 0 ? ResolveLotteryName(lotteryId) : null;
                string msg = string.IsNullOrWhiteSpace(packName)
                    ? Loc.Get("lottery_card_select")
                    : Loc.Get("lottery_card_select_pack", packName!);
                tts.Speak(msg, interrupt: false);
            }
            catch
            {
                Plugin.Instance?.Tts?.Speak(Loc.Get("lottery_card_select"), interrupt: false);
            }
        }

        /// <summary>
        /// Attempts to resolve a lottery pack name using the game's LotteryData API.
        /// Master Duel has YgomGame.Lottery.LotteryData with static name lookup methods.
        /// Falls back to null if unavailable — caller uses generic screen title.
        /// </summary>
        private static string? ResolveLotteryName(int lotteryId)
        {
            try
            {
                if (!_nameResolutionTried)
                {
                    _nameResolutionTried = true;

                    // Try YgomGame.Lottery.LotteryData — static class with pack metadata
                    _lotteryDataType = AccessToolsHelper.FindType("YgomGame.Lottery.LotteryData");

                    if (_lotteryDataType != null)
                    {
                        // Look for GetName / GetPackName / GetTitle with (int) signature
                        foreach (var candidate in new[] { "GetName", "GetTitle", "GetPackName" })
                        {
                            _mGetName = _lotteryDataType.GetMethod(candidate,
                                BindingFlags.Public | BindingFlags.Static,
                                null, new[] { typeof(int) }, null);
                            if (_mGetName != null) break;
                        }
                    }

                    if (_mGetName != null)
                        Plugin.Instance?.LogMsg("[LotteryPortalPatch] LotteryData.GetName résolu.");
                    else
                        Plugin.Instance?.LogMsg("[LotteryPortalPatch] LotteryData.GetName indisponible — fallback titre.");
                }

                if (_mGetName == null) return null;

                var result = _mGetName.Invoke(null, new object[] { lotteryId });
                var name = result?.ToString();
                return string.IsNullOrWhiteSpace(name) ? null : name;
            }
            catch { return null; }
        }
    }
}
