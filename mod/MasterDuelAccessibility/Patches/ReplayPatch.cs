using HarmonyLib;

using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches for replay list screens (section 5.3).
    ///
    /// ## Screens covered
    ///
    /// A) ProfileReplayViewController (YgomGame.Menu)
    ///    → "Replays. N replay(s)." — player's personal replay history.
    ///    Fields (dump-confirmed): replayInfos (List&lt;ReplayInfo&gt; 0x1C0), isv (ISV).
    ///    Reads replayInfos count via IEnumerable.
    ///    Navigation items are announced by SelectionButtonPatch.
    ///
    /// B) RoomReplayViewController (YgomGame.Room)
    ///    → "Replays du salon. N replay(s)." — replays from a private room.
    ///    Fields (dump-confirmed): dataList (List&lt;ReplayData&gt; 0x118), isReplay (bool).
    ///    Reads dataList count via IEnumerable.
    ///
    /// C) DuelLiveReplayDialogViewController (YgomGame.DuelLive)
    ///    → "Replay en direct. Choisissez un deck." — replay from spectator mode.
    ///    Fields: productWidget (0xD0), pickCardCount (int 0xD8).
    ///    No readable player-name strings (only constants DUELIST_A / DUELIST_B).
    ///
    /// ## Application
    /// Applied via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ReplayPatch
    {
        private static bool _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNotificationStackEntry(harmony,
                "YgomGame.Menu.ProfileReplayViewController",
                nameof(ProfileReplay_Postfix),
                "ProfileReplayViewController");

            PatchNotificationStackEntry(harmony,
                "YgomGame.Room.RoomReplayViewController",
                nameof(RoomReplay_Postfix),
                "RoomReplayViewController");

            PatchNotificationStackEntry(harmony,
                "YgomGame.DuelLive.DuelLiveReplayDialogViewController",
                nameof(LiveReplay_Postfix),
                "DuelLiveReplayDialogViewController");

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
                    Plugin.Instance?.LogWarn($"[ReplayPatch] {logLabel} introuvable.");
                    return;
                }

                var m = t.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn($"[ReplayPatch] {logLabel}.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(ReplayPatch).GetMethod(
                    postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(m, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg($"[ReplayPatch] ✓ {logLabel}.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[ReplayPatch] {logLabel}: {ex.Message}");
            }
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        /// <summary>
        /// ProfileReplayViewController — personal replay history.
        /// Reads replayInfos (List&lt;ReplayInfo&gt;) count.
        /// </summary>
        private static void ProfileReplay_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int count = CountListField(__instance, "replayInfos");
                string msg = count >= 0
                    ? Loc.Get("replay_profile", count)
                    : Loc.Get("replay_profile_empty");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// RoomReplayViewController — room replay list.
        /// Reads dataList (List&lt;ReplayData&gt;) count.
        /// </summary>
        private static void RoomReplay_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int count = CountListField(__instance, "dataList");
                string msg = count >= 0
                    ? Loc.Get("replay_room", count)
                    : Loc.Get("replay_room_empty");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// DuelLiveReplayDialogViewController — spectator-mode live replay.
        /// No player-name strings are directly readable; announce generic prompt.
        /// </summary>
        private static void LiveReplay_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("replay_live"), interrupt: false); }
            catch { }
        }

        // ── Reflection helper ─────────────────────────────────────────────────

        /// <summary>
        /// Counts items in a List/IEnumerable field by walking the type hierarchy.
        /// Returns -1 if the field is not found or null.
        /// </summary>
        private static int CountListField(object instance, string fieldName)
        {
            try
            {
                var t = instance.GetType();
                FieldInfo? field = null;
                while (t != null && t != typeof(object))
                {
                    field = t.GetField(fieldName,
                        BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.DeclaredOnly);
                    if (field != null) break;
                    t = t.BaseType;
                }

                if (field == null) return -1;

                var list = field.GetValue(instance) as IEnumerable;
                if (list == null) return -1;

                int count = 0;
                foreach (var _ in list) count++;
                return count;
            }
            catch { return -1; }
        }
    }
}
