using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans saison / ranked non couverts par SeasonPointPatch :
    ///
    ///   Section 14 — Saison / Ranked :
    ///     SeasonPointTopMenuViewController.NotificationStackEntry()  → "Menu saison."
    ///     SeasonPointHistoryViewController.NotificationStackEntry()  → "Historique de saison."
    ///     SeasonPointRankingViewController.NotificationStackEntry()  → "Classement saison."
    ///     SeasonPointTeamCreateViewController.NotificationStackEntry()       → "Créer une équipe."
    ///     SeasonPointTeamCreateDialogViewController.NotificationStackEntry() → "Créer une équipe."
    ///     SeasonPointTeamParticipateViewController.NotificationStackEntry()  → "Rejoindre une équipe."
    ///     SeasonPointTeamTopViewController.NotificationStackEntry()          → "Classement équipe."
    ///     SeasonResultViewController.NotificationStackEntry()               → "Résultat de saison."
    ///
    /// Tous dans YgomGame.SeasonPoint sauf SeasonResultViewController (namespace global).
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class SeasonMiscPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointTopMenuViewController",        nameof(TopMenu_Postfix),         "SeasonPointTopMenuViewController");
            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointHistoryViewController",        nameof(History_Postfix),         "SeasonPointHistoryViewController");
            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointRankingViewController",        nameof(Ranking_Postfix),         "SeasonPointRankingViewController");
            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointTeamCreateViewController",     nameof(TeamCreate_Postfix),      "SeasonPointTeamCreateViewController");
            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointTeamCreateDialogViewController", nameof(TeamCreate_Postfix),   "SeasonPointTeamCreateDialogViewController");
            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointTeamParticipateViewController",  nameof(TeamParticipate_Postfix), "SeasonPointTeamParticipateViewController");
            PatchNSE(harmony, "YgomGame.SeasonPoint.SeasonPointTeamTopViewController",        nameof(TeamTop_Postfix),         "SeasonPointTeamTopViewController");
            PatchNSE(harmony, "SeasonResultViewController",                                   nameof(SeasonResult_Postfix),    "SeasonResultViewController");

            _applied = true;
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[SeasonMiscPatch] {logLabel} introuvable.");
                return;
            }
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[SeasonMiscPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(SeasonMiscPatch), postfixName));
            Plugin.Instance?.LogMsg($"[SeasonMiscPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void TopMenu_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_topmenu"), interrupt: false);

        public static void History_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_history"), interrupt: false);

        public static void Ranking_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_ranking"), interrupt: false);

        public static void TeamCreate_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_team_create"), interrupt: false);

        public static void TeamParticipate_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_team_participate"), interrupt: false);

        public static void TeamTop_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_team_top"), interrupt: false);

        public static void SeasonResult_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("season_result"), interrupt: false);
    }
}
