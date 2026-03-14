using System;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches matchmaking et duel test :
    ///
    ///   PvpMenuMatchingViewController.SetActiveView
    ///     SEARCHING=0, MATCHING=1, TIMEOUT=2 (standard ranked / cup / etc.)
    ///
    ///   PvpMenuMatchingViewControllerBase.NotificationStackEntry
    ///     Annonce le type d'écran à l'ouverture, en fonction du type concret.
    ///     Couvre les 4 sous-classes : standard, Room, Team, WcsFinal.
    ///
    ///   PvpMenuMatchingViewController_Room.SetActiveView
    ///   PvpMenuMatchingViewController_WcsFinal.SetActiveView
    ///     INIT=0 (silencieux), SEARCHING=1, MATCHING=2, TIMEOUT=3
    ///
    ///   TestDuelMatchingViewController.NotificationStackEntry
    ///   TestDuelMatchingViewController.SetActiveView
    ///     SEARCHING=0, MATCHING=1, TIMEOUT=2
    ///
    /// Namespace : (global / vide)
    /// </summary>
    internal static class MatchingPatch
    {
        // ── Postfix PvpMenuMatchingViewController.SetActiveView ───────────────
        // Enum PvpMenuMatchingViewController.View : SEARCHING=0, MATCHING=1, TIMEOUT=2

        public static void SetActiveView_Postfix(object __instance, object state)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int viewState = Convert.ToInt32(state);
                string key = viewState switch
                {
                    0 => "match_searching",
                    1 => "match_found",
                    2 => "match_timeout",
                    _ => ""
                };
                if (!string.IsNullOrEmpty(key))
                    tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }

        // ── Postfix PvpMenuMatchingViewControllerBase.NotificationStackEntry ──
        // Dispatches on concrete type name to announce which kind of matching screen opened.

        public static void MatchingBase_NSE_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string typeName = __instance?.GetType().Name ?? "";
                string key = typeName switch
                {
                    "PvpMenuMatchingViewController_Room"     => "matchmaking_room",
                    "PvpMenuMatchingViewController_Team"     => "matchmaking_team",
                    "PvpMenuMatchingViewController_WcsFinal" => "matchmaking_wcs",
                    _                                        => "matchmaking_ranked"
                };
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }

        // ── Postfix PvpMenuMatchingViewController_Room/WcsFinal.SetActiveView ─
        // Enum View : INIT=0 (silencieux), SEARCHING=1, MATCHING=2, TIMEOUT=3

        public static void SetActiveView_Room_Postfix(object __instance, object state)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int viewState = Convert.ToInt32(state);
                string key = viewState switch
                {
                    1 => "match_searching",
                    2 => "match_found",
                    3 => "match_timeout",
                    _ => ""  // INIT=0 → silencieux
                };
                if (!string.IsNullOrEmpty(key))
                    tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }

        // ── TestDuelMatchingViewController.NotificationStackEntry ─────────────

        public static void TestDuelMatching_NSE_Postfix(object __instance)
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("matchmaking_test_duel"), interrupt: false);
        }

        // ── TestDuelMatchingViewController.SetActiveView ──────────────────────
        // Enum View : SEARCHING=0, MATCHING=1, TIMEOUT=2 (identique au standard)

        public static void SetActiveView_TestDuel_Postfix(object __instance, object state)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int viewState = Convert.ToInt32(state);
                string key = viewState switch
                {
                    0 => "match_searching",
                    1 => "match_found",
                    2 => "match_timeout",
                    _ => ""
                };
                if (!string.IsNullOrEmpty(key))
                    tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }
    }
}
