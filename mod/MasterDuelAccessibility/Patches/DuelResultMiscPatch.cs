using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches for miscellaneous duel result screens (section 5.2).
    ///
    /// ## Screens covered
    ///
    /// A) DuelResultViewController_Solo (global namespace, extends DuelResultViewController)
    ///    → "Résultat solo." on NotificationStackEntry
    ///    Fields (dump-confirmed): SaveButton, BackButton (SelectionButton), m_GameMode.
    ///    Detailed score reading is handled by the base DuelResultPatch.OnCreatedView.
    ///
    /// B) DuelistCupResultViewController (YgomGame.Menu)
    ///    → "Duelist Cup. [Résultat]. DP avant : X, après : Y (delta)."
    ///    Fields (dump-confirmed):
    ///      resultType (Engine.ResultType 0x188) — Win=1/Lose=2/Draw=3/Time=4
    ///      bDP (int 0x190) — DP before the duel
    ///      aDP (int 0x194) — DP after the duel
    ///      gameMode (Util.GameMode 0x198)
    ///    These fields are set before NotificationStackEntry fires.
    ///
    /// C) ColosseumDuelResultViewController_Rate (YgomGame.Menu)
    ///    → "Résultat Colosseum. [Résultat]."
    ///    Fields (dump-confirmed): resultType (Engine.ResultType 0x148).
    ///    Rate values are embedded in the ElementObjectManager — not directly readable.
    ///
    /// ## Application
    /// Applied via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class DuelResultMiscPatch
    {
        private static bool _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNotificationStackEntry(harmony,
                "DuelResultViewController_Solo",
                nameof(DuelResultSolo_Postfix),
                "DuelResultViewController_Solo");

            PatchNotificationStackEntry(harmony,
                "YgomGame.Menu.DuelistCupResultViewController",
                nameof(DuelistCupResult_Postfix),
                "DuelistCupResultViewController");

            PatchNotificationStackEntry(harmony,
                "YgomGame.Menu.ColosseumDuelResultViewController_Rate",
                nameof(ColosseumResult_Postfix),
                "ColosseumDuelResultViewController_Rate");

            _applied = true;
        }

        internal static void Reset() => _applied = false;

        // ── Shared patcher ────────────────────────────────────────────────────

        private static void PatchNotificationStackEntry(
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
                    Plugin.Instance?.LogWarn($"[DuelResultMiscPatch] {logLabel} introuvable.");
                    return;
                }

                var m = t.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn($"[DuelResultMiscPatch] {logLabel}.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(DuelResultMiscPatch).GetMethod(
                    postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(m, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg($"[DuelResultMiscPatch] ✓ {logLabel}.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelResultMiscPatch] {logLabel}: {ex.Message}");
            }
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        /// <summary>
        /// DuelResultViewController_Solo — solo mode result.
        /// Announces the screen label; detailed score is handled by base DuelResultPatch.
        /// </summary>
        private static void DuelResultSolo_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("result_solo"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// DuelistCupResultViewController — reads DP before/after + result type.
        /// Fields: resultType (Engine.ResultType), bDP (before), aDP (after).
        /// </summary>
        private static void DuelistCupResult_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int resultType = ReadIntField(__instance, "resultType");
                int bDP        = ReadIntField(__instance, "bDP");
                int aDP        = ReadIntField(__instance, "aDP");

                string resultLabel = ResultTypeToKey(resultType);
                int delta = aDP - bDP;
                string deltaStr = delta >= 0 ? $"+{delta}" : delta.ToString();

                tts.Speak(Loc.Get("result_duelist_cup", resultLabel, bDP, aDP, deltaStr),
                    interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// ColosseumDuelResultViewController_Rate — reads result type only.
        /// Rate values are in the EOM and not directly readable.
        /// </summary>
        private static void ColosseumResult_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int resultType = ReadIntField(__instance, "resultType");
                string resultLabel = ResultTypeToKey(resultType);
                tts.Speak(Loc.Get("result_colosseum", resultLabel), interrupt: false);
            }
            catch { }
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        private static int ReadIntField(object instance, string fieldName)
        {
            try
            {
                var t = instance.GetType();
                while (t != null && t != typeof(object))
                {
                    var f = t.GetField(fieldName,
                        BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.DeclaredOnly);
                    if (f != null) return Convert.ToInt32(f.GetValue(instance));
                    t = t.BaseType;
                }
                return 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Maps Engine.ResultType int to a Loc key string.
        /// Win=1, Lose=2, Draw=3, Time=4
        /// </summary>
        private static string ResultTypeToKey(int resultType) => resultType switch
        {
            1 => Loc.Get("duel_win"),
            2 => Loc.Get("duel_lose"),
            3 => Loc.Get("duel_draw"),
            _ => Loc.Get("duel_result_unknown"),
        };
    }
}
