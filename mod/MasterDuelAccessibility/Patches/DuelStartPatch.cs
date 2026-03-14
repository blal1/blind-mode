using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches for the duel-start animation screens (section 3.2).
    ///
    /// ## Screens covered
    ///
    /// A) DuelStartViewController (global namespace, extends BaseMenuViewController)
    ///    → "Duel commençant."
    ///    The animation shows player portraits, ranks, and a coin/dice toss.
    ///    Player names are loaded asynchronously via PlayerSet.myid lookups
    ///    and are not reliably readable at NotificationStackEntry time.
    ///    The coin/dice result is separately announced by DuelMiscPatch.OnCoinResult /
    ///    OnDiceResult, so we only announce the screen entry here.
    ///
    /// B) DuelStartViewController_Team (global namespace, extends DuelStartViewController)
    ///    → "Duel commençant." (same announcement — team duels use the same intro flow)
    ///    Patched separately because IL2CPP patches apply to the declaring type's
    ///    method body, not inherited overrides.
    ///
    /// C) DuelStartOverlayViewController_Team (global namespace, extends BaseMenuViewController)
    ///    → "Duel d'équipe commençant."
    ///    Team-specific overlay showing team members.
    ///    Fields: playerEom / rivalEom (ElementObjectManager), MAX_MEMBERS (int).
    ///    Member names are not directly readable — announced generically.
    ///
    /// ## Application
    /// Applied via LatePatches.ApplyDuelScenePatches().
    /// </summary>
    internal static class DuelStartPatch
    {
        private static bool _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchDuelStart(harmony, "DuelStartViewController",
                nameof(DuelStart_Postfix), "DuelStartViewController");

            PatchDuelStart(harmony, "DuelStartViewController_Team",
                nameof(DuelStart_Postfix), "DuelStartViewController_Team");

            PatchDuelStart(harmony, "DuelStartOverlayViewController_Team",
                nameof(DuelStartTeam_Postfix), "DuelStartOverlayViewController_Team");

            _applied = true;
        }

        internal static void Reset()
        {
            _applied = false;
        }

        // ── Shared patcher ────────────────────────────────────────────────────

        private static void PatchDuelStart(
            HarmonyLib.Harmony harmony,
            string typeName,
            string postfixName,
            string logLabel)
        {
            try
            {
                var t = AccessToolsHelper.FindType(typeName);
                if (t == null)
                {
                    Plugin.Instance?.LogWarn($"[DuelStartPatch] {logLabel} introuvable.");
                    return;
                }

                var m = t.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn($"[DuelStartPatch] {logLabel}.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(DuelStartPatch).GetMethod(
                    postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(m, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg($"[DuelStartPatch] ✓ {logLabel}.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelStartPatch] {logLabel}: {ex.Message}");
            }
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        /// <summary>
        /// DuelStartViewController / DuelStartViewController_Team.
        /// Announces the duel start animation screen.
        /// Coin/dice result is separately announced by DuelMiscPatch.
        /// </summary>
        private static void DuelStart_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("duel_start"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// DuelStartOverlayViewController_Team — team duel overlay.
        /// </summary>
        private static void DuelStartTeam_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("duel_start_team"), interrupt: false); }
            catch { }
        }
    }
}
