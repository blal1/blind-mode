using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour RoomViewController — salon privé (duel room).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) RoomViewController.NotificationStackEntry() — salon ouvert
    ///    → "Salon : [nom]. N joueur(s) sur M." si info disponible
    ///    → "Salon." sinon
    ///
    /// B) RoomMemberViewController.UpdateEntity(GameObject gob, int index) — membre focalisé
    ///    → "[Nom]. V[win] D[lose] N[draw]."
    ///    → 300 ms cooldown + déduplication par index
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
    ///   RoomMemberViewController (namespace YgomGame.Room)
    ///     dataList (List&lt;Data&gt; 0x110)
    ///       Data.name (string) — nom du joueur
    ///       Data.win / lose / draw (int) — statistiques
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class RoomViewControllerPatch
    {
        private static bool _applied = false;

        // Room info reflection cache
        private static FieldInfo? _fRoomBehaviour;
        private static FieldInfo? _fRoomInfo;
        private static FieldInfo? _fRoomName;
        private static FieldInfo? _fMemberNum;
        private static FieldInfo? _fMemberMax;

        // RoomMemberViewController ISV caches
        private static FieldInfo?    _fDataList;
        private static FieldInfo?    _fMemberName;
        private static FieldInfo?    _fWin;
        private static FieldInfo?    _fLose;
        private static FieldInfo?    _fDraw;
        private static int           _lastAnnouncedIndex = -1;
        private static DateTime      _lastMemberFocusAt = DateTime.MinValue;
        private static readonly TimeSpan _memberCooldown = TimeSpan.FromMilliseconds(300);

        internal static void Reset()
        {
            _applied              = false;
            _lastAnnouncedIndex   = -1;
        }

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            // RoomViewController.NotificationStackEntry
            var vcType = AccessToolsHelper.FindType("YgomGame.Room.RoomViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[RoomViewControllerPatch] RoomViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack != null)
            {
                harmony.Patch(mStack, postfix: new HarmonyMethod(
                    typeof(RoomViewControllerPatch), nameof(StackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[RoomViewControllerPatch] ✓ RoomViewController.NotificationStackEntry");
            }
            else
            {
                Plugin.Instance?.LogWarn("[RoomViewControllerPatch] NotificationStackEntry introuvable.");
            }

            // RoomMemberViewController.UpdateEntity — ISV member focus
            var memberType = AccessToolsHelper.FindType("YgomGame.Room.RoomMemberViewController");
            if (memberType != null)
            {
                var mUpdate = memberType.GetMethod("UpdateEntity",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mUpdate != null)
                {
                    harmony.Patch(mUpdate, postfix: new HarmonyMethod(
                        typeof(RoomViewControllerPatch), nameof(UpdateEntity_Postfix)));
                    Plugin.Instance?.LogMsg("[RoomViewControllerPatch] ✓ RoomMemberViewController.UpdateEntity");
                }
            }

            _applied = true;
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                TryReadRoomInfo(__instance, out string? roomName, out int memberNum, out int memberMax);

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

        /// <summary>
        /// Postfix pour RoomMemberViewController.UpdateEntity(GameObject gob, int index).
        /// Fires when an ISV cell is bound to data. Announces member name + W/L/D.
        /// Uses 300ms cooldown + index dedup to avoid announcing all items during bulk render.
        /// </summary>
        public static void UpdateEntity_Postfix(object __instance, object gob, int index)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            // Dedup: same index recently announced
            var now = DateTime.Now;
            if (index == _lastAnnouncedIndex && (now - _lastMemberFocusAt) < _memberCooldown) return;

            _lastAnnouncedIndex = index;
            _lastMemberFocusAt  = now;

            try
            {
                var vcType = __instance.GetType();

                // dataList (List<RoomMemberViewController.Data>)
                if (_fDataList == null)
                    _fDataList = FindField(vcType, "dataList");
                var list = _fDataList?.GetValue(__instance) as IList;
                if (list == null || index < 0 || index >= list.Count) return;

                object? data = list[index];
                if (data == null) return;

                var dataType = data.GetType();

                if (_fMemberName == null) _fMemberName = FindField(dataType, "name");
                if (_fWin  == null) _fWin  = FindField(dataType, "win");
                if (_fLose == null) _fLose = FindField(dataType, "lose");
                if (_fDraw == null) _fDraw = FindField(dataType, "draw");

                string? name = _fMemberName?.GetValue(data)?.ToString();
                int win  = (_fWin  != null) ? Convert.ToInt32(_fWin.GetValue(data))  : 0;
                int lose = (_fLose != null) ? Convert.ToInt32(_fLose.GetValue(data)) : 0;
                int draw = (_fDraw != null) ? Convert.ToInt32(_fDraw.GetValue(data)) : 0;

                if (string.IsNullOrWhiteSpace(name)) return;

                tts.Speak(Loc.Get("room_member_item", name!, win, lose, draw), interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[RoomViewControllerPatch] UpdateEntity: {ex.Message}");
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static void TryReadRoomInfo(object vcInstance,
            out string? roomName, out int memberNum, out int memberMax)
        {
            roomName  = null;
            memberNum = 0;
            memberMax = 0;
            try
            {
                if (_fRoomBehaviour == null)
                    _fRoomBehaviour = FindField(vcInstance.GetType(), "roomBehaviour");
                object? behaviour = _fRoomBehaviour?.GetValue(vcInstance);
                if (behaviour == null) return;

                if (_fRoomInfo == null)
                    _fRoomInfo = FindField(behaviour.GetType(), "roomInfo");
                object? info = _fRoomInfo?.GetValue(behaviour);
                if (info == null) return;

                var infoType = info.GetType();

                if (_fRoomName  == null) _fRoomName  = FindField(infoType, "roomName");
                if (_fMemberNum == null) _fMemberNum = FindField(infoType, "memberNum");
                if (_fMemberMax == null) _fMemberMax = FindField(infoType, "memberMax");

                roomName  = _fRoomName?.GetValue(info)?.ToString();
                memberNum = (_fMemberNum != null) ? Convert.ToInt32(_fMemberNum.GetValue(info)) : 0;
                memberMax = (_fMemberMax != null) ? Convert.ToInt32(_fMemberMax.GetValue(info)) : 0;
            }
            catch { }
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
