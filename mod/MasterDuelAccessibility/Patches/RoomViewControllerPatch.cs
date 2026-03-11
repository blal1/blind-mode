using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour RoomViewController — salon privé (duel room).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — salon ouvert
    ///    → "Salon : [nom]. N joueur(s)." si info disponible
    ///    → "Salon." sinon
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   RoomViewController (namespace YgomGame.Room)
    ///     roomBehaviour (RoomBehaviour 0xF0)
    ///       roomInfo (RoomBehaviour.RoomInfo 0xF8)
    ///         roomName  (string 0x18) — nom du salon
    ///         memberNum (int    0x28) — nombre de membres actuels
    ///         memberMax (int    0x34) — capacité maximale
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class RoomViewControllerPatch
    {
        private static bool _applied = false;

        private static FieldInfo? _fRoomBehaviour;
        private static FieldInfo? _fRoomInfo;
        private static FieldInfo? _fRoomName;
        private static FieldInfo? _fMemberNum;
        private static FieldInfo? _fMemberMax;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Room.RoomViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[RoomViewControllerPatch] RoomViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[RoomViewControllerPatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(RoomViewControllerPatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[RoomViewControllerPatch] ✓ RoomViewController.NotificationStackEntry");
        }

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? roomName  = null;
                int     memberNum = 0;
                int     memberMax = 0;

                TryReadRoomInfo(__instance, out roomName, out memberNum, out memberMax);

                string msg;
                if (!string.IsNullOrWhiteSpace(roomName) && memberMax > 0)
                    msg = Loc.Get("room_open_name_members", roomName!, memberNum, memberMax);
                else if (!string.IsNullOrWhiteSpace(roomName))
                    msg = Loc.Get("room_open_name", roomName!);
                else
                    msg = Loc.Get("room_open");

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[RoomViewControllerPatch] {ex.Message}");
            }
        }

        private static void TryReadRoomInfo(object vcInstance,
            out string? roomName, out int memberNum, out int memberMax)
        {
            roomName  = null;
            memberNum = 0;
            memberMax = 0;
            try
            {
                // roomBehaviour
                if (_fRoomBehaviour == null)
                    _fRoomBehaviour = FindField(vcInstance.GetType(), "roomBehaviour");
                object? behaviour = _fRoomBehaviour?.GetValue(vcInstance);
                if (behaviour == null) return;

                // roomInfo
                if (_fRoomInfo == null)
                    _fRoomInfo = FindField(behaviour.GetType(), "roomInfo");
                object? info = _fRoomInfo?.GetValue(behaviour);
                if (info == null) return;

                var infoType = info.GetType();

                if (_fRoomName == null)
                    _fRoomName = FindField(infoType, "roomName");
                if (_fMemberNum == null)
                    _fMemberNum = FindField(infoType, "memberNum");
                if (_fMemberMax == null)
                    _fMemberMax = FindField(infoType, "memberMax");

                roomName  = _fRoomName?.GetValue(info)?.ToString();
                memberNum = (_fMemberNum != null) ? Convert.ToInt32(_fMemberNum.GetValue(info)) : 0;
                memberMax = (_fMemberMax != null) ? Convert.ToInt32(_fMemberMax.GetValue(info)) : 0;
            }
            catch { /* ignore reflection failures */ }
        }

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
