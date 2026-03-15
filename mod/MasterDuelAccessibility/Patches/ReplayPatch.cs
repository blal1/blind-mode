using HarmonyLib;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches for replay list screens (section 5.3).
    ///
    /// ## Screens covered
    ///
    /// A) ProfileReplayViewController (YgomGame.Menu)
    ///    → NSE: "Replays. N replay(s)."
    ///    → ISV: OnItemSetData(GameObject, int) — annonce résultat, mode, date quand un item est affiché.
    ///    Fields (dump-confirmed): replayInfos (List&lt;ReplayInfo&gt; 0x1C0), isv (ISV).
    ///
    /// B) RoomReplayViewController (YgomGame.Room)
    ///    → NSE: "Replays du salon. N replay(s)."
    ///    → ISV: UpdateEntity(GameObject, int) — annonce textes de l'item (résultat, pseudo).
    ///    Fields (dump-confirmed): dataList (List&lt;ReplayData&gt; 0x118), isReplay (bool).
    ///
    /// C) DuelLiveReplayDialogViewController (YgomGame.DuelLive)
    ///    → "Replay en direct. Choisissez un deck."
    ///
    /// ## Application
    /// Applied via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ReplayPatch
    {
        private static bool _applied = false;

        // ── Dédup ISV ─────────────────────────────────────────────────────────
        private static int    _profileLastIdx  = -1;
        private static string? _profileLastTxt;
        private static int    _roomLastIdx     = -1;
        private static string? _roomLastTxt;

        // ── Cache réflexion TMP_Text ─────────────────────────────────────────
        private static Type?       _tmpTextType;
        private static PropertyInfo? _tmpTextProp;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            // ── NSE patches ──────────────────────────────────────────────────
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

            // ── ISV patches ──────────────────────────────────────────────────

            // ProfileReplayViewController.OnItemSetData(GameObject, int) — public
            var profileType = AccessToolsHelper.FindType("YgomGame.Menu.ProfileReplayViewController")
                           ?? AccessToolsHelper.FindType("ProfileReplayViewController");
            if (profileType != null)
            {
                var mIsd = profileType.GetMethod("OnItemSetData",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mIsd != null)
                {
                    harmony.Patch(mIsd, postfix: new HarmonyMethod(
                        typeof(ReplayPatch), nameof(ProfileReplayISV_Postfix)));
                    Plugin.Instance?.LogMsg("[ReplayPatch] ✓ ProfileReplayViewController.OnItemSetData");
                }
                else
                    Plugin.Instance?.LogWarn("[ReplayPatch] ProfileReplayViewController.OnItemSetData introuvable.");
            }

            // RoomReplayViewController.UpdateEntity(GameObject, int) — private
            var roomType = AccessToolsHelper.FindType("YgomGame.Room.RoomReplayViewController")
                        ?? AccessToolsHelper.FindType("RoomReplayViewController");
            if (roomType != null)
            {
                var mUe = roomType.GetMethod("UpdateEntity",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mUe != null)
                {
                    harmony.Patch(mUe, postfix: new HarmonyMethod(
                        typeof(ReplayPatch), nameof(RoomReplayISV_Postfix)));
                    Plugin.Instance?.LogMsg("[ReplayPatch] ✓ RoomReplayViewController.UpdateEntity");
                }
                else
                    Plugin.Instance?.LogWarn("[ReplayPatch] RoomReplayViewController.UpdateEntity introuvable.");
            }

            _applied = true;
        }

        internal static void Reset()
        {
            _applied        = false;
            _profileLastIdx = -1;
            _profileLastTxt = null;
            _roomLastIdx    = -1;
            _roomLastTxt    = null;
        }

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

        // ── ISV postfixes ─────────────────────────────────────────────────────

        /// <summary>
        /// ProfileReplayViewController.OnItemSetData — item devenu visible dans l'ISV.
        /// Annonce les textes visibles (résultat W/L/D, mode, date…).
        /// </summary>
        public static void ProfileReplayISV_Postfix(object __instance,
            UnityEngine.GameObject __0, int __1)
            => AnnounceIsvItem(__0, __1, ref _profileLastIdx, ref _profileLastTxt);

        /// <summary>
        /// RoomReplayViewController.UpdateEntity — item mis à jour dans l'ISV du salon.
        /// </summary>
        public static void RoomReplayISV_Postfix(object __instance,
            UnityEngine.GameObject __0, int __1)
            => AnnounceIsvItem(__0, __1, ref _roomLastIdx, ref _roomLastTxt);

        /// <summary>
        /// Collecte tous les TMP_Text non vides sous gob, les joint avec ", " et annonce.
        /// Dédup par (dataindex, texte) pour éviter la répétition lors des scrolls.
        /// </summary>
        private static void AnnounceIsvItem(UnityEngine.GameObject gob, int dataindex,
            ref int lastIdx, ref string? lastTxt)
        {
            if (gob == null) return;
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string msg = CollectGobTexts(gob);
                if (string.IsNullOrWhiteSpace(msg)) return;

                // Dédup : ne pas annoncer si même index et même texte
                if (dataindex == lastIdx && msg == lastTxt) return;
                lastIdx = dataindex;
                lastTxt = msg;

                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// Collecte les textes TMP_Text non vides sous un GO (jusqu'à 4 valeurs).
        /// </summary>
        private static string CollectGobTexts(UnityEngine.GameObject go)
        {
            if (_tmpTextType == null)
            {
                _tmpTextType = AccessToolsHelper.FindType("TMPro.TMP_Text")
                            ?? AccessToolsHelper.FindType("TMPro.TextMeshProUGUI");
            }
            if (_tmpTextType == null) return string.Empty;

            if (_tmpTextProp == null)
                _tmpTextProp = _tmpTextType.GetProperty("text",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            var comps = go.GetComponentsInChildren(
                Il2CppInterop.Runtime.Il2CppType.From(_tmpTextType), true);
            if (comps == null) return string.Empty;

            var parts = new List<string>();
            foreach (var c in comps)
            {
                if (c == null) continue;
                string? txt = _tmpTextProp?.GetValue(c)?.ToString();
                if (!string.IsNullOrWhiteSpace(txt) && txt != "-" && txt.Length > 1)
                    parts.Add(txt!);
                if (parts.Count >= 4) break;
            }
            return string.Join(". ", parts);
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
