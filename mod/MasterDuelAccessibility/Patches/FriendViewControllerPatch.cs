using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour l'écran amis (FriendViewController).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) FriendViewController.NotificationStackEntry() — écran ouvert
    ///    → "Amis — N suivis." si le compteur est lisible
    ///    → "Amis." sinon
    ///
    /// B) FriendListWidget.OnSelectedEntityWidget(FriendWidget selectedWidget) — ISV navigation
    ///    → "[Nom]. En ligne." / "[Nom]. Hors ligne."
    ///    → 300 ms cooldown + déduplication par pcode
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   FriendViewController (namespace YgomGame.Friend)
    ///     m_FollowNumText (TMP_Text 0x1E8) — nombre de suivis
    ///
    ///   FriendListWidget (namespace YgomGame.Friend)
    ///     m_DisplayFriendContexts (List&lt;IPlayerContext&gt; 0x78) — contextes visibles
    ///     GetSelectedPcode() → long — pcode du joueur sélectionné
    ///
    ///   PlayerContextBase (interface IPlayerContext)
    ///     playerName (string public property) — nom du joueur
    ///     isOnline   (bool   public property) — statut en ligne
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class FriendViewControllerPatch
    {
        private static bool _applied = false;
        private static FieldInfo? _fFollowNumText;

        // ISV navigation caches
        private static PropertyInfo? _pGetSelectedPcode;
        private static FieldInfo?    _fDisplayContexts;
        private static PropertyInfo? _pPlayerName;
        private static PropertyInfo? _pIsOnline;
        private static long          _lastAnnouncedPcode = 0L;
        private static DateTime      _lastFocusAt = DateTime.MinValue;
        private static readonly TimeSpan _focusCooldown = TimeSpan.FromMilliseconds(300);

        internal static void Reset()
        {
            _applied           = false;
            _lastAnnouncedPcode = 0L;
        }

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Friend.FriendViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[FriendViewControllerPatch] FriendViewController introuvable.");
                return;
            }

            // NotificationStackEntry — ouverture de l'écran amis
            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack != null)
            {
                harmony.Patch(mStack, postfix: new HarmonyMethod(
                    typeof(FriendViewControllerPatch), nameof(StackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[FriendViewControllerPatch] ✓ FriendViewController.NotificationStackEntry");
            }
            else
            {
                Plugin.Instance?.LogWarn("[FriendViewControllerPatch] NotificationStackEntry introuvable.");
            }

            // FriendListWidget.OnSelectedEntityWidget — ISV focus
            var listWidgetType = AccessToolsHelper.FindType("YgomGame.Friend.FriendListWidget");
            if (listWidgetType != null)
            {
                var mSel = listWidgetType.GetMethod("OnSelectedEntityWidget",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mSel != null)
                {
                    harmony.Patch(mSel, postfix: new HarmonyMethod(
                        typeof(FriendViewControllerPatch), nameof(OnSelectedEntityWidget_Postfix)));
                    Plugin.Instance?.LogMsg("[FriendViewControllerPatch] ✓ FriendListWidget.OnSelectedEntityWidget");
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
                string? countText = TryReadFollowCount(__instance);
                string msg = !string.IsNullOrWhiteSpace(countText)
                    ? Loc.Get("friend_open_count", countText!)
                    : Loc.Get("friend_open");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[FriendViewControllerPatch] {ex.Message}");
            }
        }

        /// <summary>
        /// Postfix pour FriendListWidget.OnSelectedEntityWidget(FriendWidget selectedWidget).
        /// Fires when the user navigates to a friend in the ISV list.
        /// Announces player name + online status.
        /// </summary>
        public static void OnSelectedEntityWidget_Postfix(object __instance, object selectedWidget)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            // Cooldown
            var now = DateTime.Now;
            if ((now - _lastFocusAt) < _focusCooldown) return;

            try
            {
                var listType = __instance.GetType();

                // GetSelectedPcode() → long
                if (_pGetSelectedPcode == null)
                    _pGetSelectedPcode = null; // We'll use the method instead

                var mGetPcode = listType.GetMethod("GetSelectedPcode",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mGetPcode == null) return;

                long pcode = Convert.ToInt64(mGetPcode.Invoke(__instance, null));
                if (pcode == 0L) return;

                // Dedup: same player
                if (pcode == _lastAnnouncedPcode) return;
                _lastAnnouncedPcode = pcode;
                _lastFocusAt = now;

                // m_DisplayFriendContexts (List<IPlayerContext>)
                if (_fDisplayContexts == null)
                    _fDisplayContexts = FindField(listType, "m_DisplayFriendContexts");
                var contextList = _fDisplayContexts?.GetValue(__instance) as IList;
                if (contextList == null) return;

                // Find matching pcode
                object? ctx = null;
                foreach (var item in contextList)
                {
                    if (item == null) continue;
                    // Get pcode from context
                    var pcodeVal = item.GetType().GetProperty("pcode",
                        BindingFlags.Public | BindingFlags.Instance)?.GetValue(item);
                    if (pcodeVal != null && Convert.ToInt64(pcodeVal) == pcode)
                    {
                        ctx = item;
                        break;
                    }
                }
                if (ctx == null) return;

                // playerName + isOnline
                if (_pPlayerName == null)
                    _pPlayerName = ctx.GetType().GetProperty("playerName",
                        BindingFlags.Public | BindingFlags.Instance);
                if (_pIsOnline == null)
                    _pIsOnline = ctx.GetType().GetProperty("isOnline",
                        BindingFlags.Public | BindingFlags.Instance);

                string? name = _pPlayerName?.GetValue(ctx) as string;
                bool isOnline = (bool?)_pIsOnline?.GetValue(ctx) ?? false;

                if (string.IsNullOrWhiteSpace(name)) return;

                string status = isOnline ? Loc.Get("friend_online") : Loc.Get("friend_offline");
                tts.Speak(Loc.Get("friend_isv_player", name!, status), interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[FriendViewControllerPatch] OnSelectedEntityWidget: {ex.Message}");
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string? TryReadFollowCount(object instance)
        {
            try
            {
                if (_fFollowNumText == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField("m_FollowNumText",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fFollowNumText = f; break; }
                        t = t.BaseType;
                    }
                }
                if (_fFollowNumText == null) return null;

                object? tmp = _fFollowNumText.GetValue(instance);
                if (tmp == null) return null;

                var textProp = tmp.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                return textProp?.GetValue(tmp)?.ToString();
            }
            catch { return null; }
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
