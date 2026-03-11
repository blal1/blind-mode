using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour FriendViewController — liste d'amis (suivis / abonnés / bloqués).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — écran amis ouvert
    ///    → "Amis — N suivis." si le compteur est lisible
    ///    → "Amis." sinon
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   FriendViewController (namespace YgomGame.Friend)
    ///     m_FollowNumText (TMP_Text 0x1E8) — texte du nombre de suivis affiché
    ///     m_FollowContexts (FollowContextCollection 0x230) — collection de suivis
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class FriendViewControllerPatch
    {
        private static bool _applied = false;
        private static FieldInfo? _fFollowNumText;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Friend.FriendViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[FriendViewControllerPatch] FriendViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[FriendViewControllerPatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(FriendViewControllerPatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[FriendViewControllerPatch] ✓ FriendViewController.NotificationStackEntry");
        }

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
    }
}
