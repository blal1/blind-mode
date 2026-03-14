using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans de salons privés (Room) :
    ///
    ///   Section 10.2 — Salons privés :
    ///     RoomCreateViewController.NotificationStackEntry()
    ///       → "Créer un salon."
    ///     RoomEntryViewController.NotificationStackEntry()
    ///       → "Rejoindre un salon." / "Rejoindre en tant que spectateur."
    ///         (lit le champ mode : RoomEntryViewController.Mode NORMAL=0, SPECTER=1)
    ///     RoomInfoViewController.NotificationStackEntry()
    ///       → "Salon : [nom]. N sur M joueur(s)."
    ///         (lit roomName, roomMemberCurrent, roomMemberMax)
    ///     RoomInviteViewController.NotificationStackEntry()
    ///       → "Inviter un ami."
    ///     RoomMemberViewController.NotificationStackEntry()
    ///       → "Membres du salon."
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// Namespace : (global / vide)
    /// </summary>
    internal static class RoomPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNSE(harmony, "RoomCreateViewController",  nameof(RoomCreate_Postfix),  "RoomCreateViewController");
            PatchNSE(harmony, "RoomEntryViewController",   nameof(RoomEntry_Postfix),   "RoomEntryViewController");
            PatchNSE(harmony, "RoomInfoViewController",    nameof(RoomInfo_Postfix),    "RoomInfoViewController");
            PatchNSE(harmony, "RoomInviteViewController",  nameof(RoomInvite_Postfix),  "RoomInviteViewController");
            PatchNSE(harmony, "RoomMemberViewController",  nameof(RoomMember_Postfix),  "RoomMemberViewController");

            _applied = true;
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[RoomPatch] {logLabel} introuvable.");
                return;
            }
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[RoomPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(RoomPatch), postfixName));
            Plugin.Instance?.LogMsg($"[RoomPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void RoomCreate_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("room_create"), interrupt: false);

        public static void RoomInvite_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("room_invite"), interrupt: false);

        public static void RoomMember_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("room_member"), interrupt: false);

        /// <summary>
        /// RoomEntryViewController : lit le champ mode (RoomEntryViewController.Mode).
        /// NORMAL=0 → rejoindre en tant que joueur.
        /// SPECTER=1 → rejoindre en tant que spectateur.
        /// </summary>
        public static void RoomEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = FindField(__instance.GetType(), "mode");
                int mode = f != null ? Convert.ToInt32(f.GetValue(__instance)) : 0;
                string key = mode == 1 ? "room_entry_specter" : "room_entry";
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("room_entry"), interrupt: false); }
        }

        /// <summary>
        /// RoomInfoViewController : lit roomName, roomMemberCurrent, roomMemberMax.
        /// Annonce : "Salon : [nom]. N sur M joueur(s)." ou fallback générique.
        /// </summary>
        public static void RoomInfo_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                var nameField    = FindField(t, "roomName");
                var currentField = FindField(t, "roomMemberCurrent");
                var maxField     = FindField(t, "roomMemberMax");

                string? roomName = nameField?.GetValue(__instance) as string;
                int current      = currentField != null ? Convert.ToInt32(currentField.GetValue(__instance)) : 0;
                int max          = maxField     != null ? Convert.ToInt32(maxField.GetValue(__instance))     : 0;

                string msg;
                if (!string.IsNullOrWhiteSpace(roomName) && max > 0)
                    msg = Loc.Get("room_info", roomName, current, max);
                else if (!string.IsNullOrWhiteSpace(roomName))
                    msg = Loc.Get("room_info_name", roomName);
                else
                    msg = Loc.Get("room_info_generic");

                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("room_info_generic"), interrupt: false); }
        }

        // ── Helper ────────────────────────────────────────────────────────────

        private static FieldInfo? FindField(Type t, string name)
        {
            var cur = t;
            while (cur != null && cur != typeof(object))
            {
                var f = cur.GetField(name,
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (f != null) return f;
                cur = cur.BaseType;
            }
            return null;
        }
    }
}
