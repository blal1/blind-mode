using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour ProfileViewController — écran de profil joueur.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — profil ouvert
    ///    → "Profil de [nom]. Niveau [niveau]."
    ///    ou → "Profil de [nom]." si niveau absent
    ///    ou → "Profil." si aucune donnée disponible
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   ProfileViewController (namespace YgomGame.Menu)
    ///     profileCard (ProfileCard 0x198)
    ///       m_ProfileDic (Dictionary<string,object> 0x70)
    ///         "name"  → nom du joueur
    ///         "level" → niveau
    ///         "rank"  → rang (int)
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ProfilePatch
    {
        private static bool _applied = false;

        // Caches réflexion ProfileViewController
        private static FieldInfo? _fProfileCard;

        // Caches réflexion ProfileCard
        private static FieldInfo? _fProfileDic;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.ProfileViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[ProfilePatch] ProfileViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[ProfilePatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(ProfilePatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[ProfilePatch] ✓ ProfileViewController.NotificationStackEntry");
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? name  = null;
                string? level = null;

                var dic = GetProfileDic(__instance);
                if (dic != null)
                {
                    name  = GetDicValue(dic, "name");
                    level = GetDicValue(dic, "level");
                }

                string msg;
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(level))
                    msg = Loc.Get("profile_open_name_level", name!, level!);
                else if (!string.IsNullOrWhiteSpace(name))
                    msg = Loc.Get("profile_open_name", name!);
                else
                    msg = Loc.Get("profile_open");

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ProfilePatch] {ex.Message}");
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static object? GetProfileDic(object vcInstance)
        {
            try
            {
                // Lire profileCard depuis ProfileViewController
                if (_fProfileCard == null)
                {
                    var t = vcInstance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField("profileCard",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fProfileCard = f; break; }
                        t = t.BaseType;
                    }
                }
                if (_fProfileCard == null) return null;

                object? card = _fProfileCard.GetValue(vcInstance);
                if (card == null) return null;

                // Lire m_ProfileDic depuis ProfileCard
                if (_fProfileDic == null)
                {
                    var ct = card.GetType();
                    while (ct != null && ct != typeof(object))
                    {
                        var f = ct.GetField("m_ProfileDic",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fProfileDic = f; break; }
                        ct = ct.BaseType;
                    }
                }
                if (_fProfileDic == null) return null;

                return _fProfileDic.GetValue(card);
            }
            catch { return null; }
        }

        private static string? GetDicValue(object dic, string key)
        {
            try
            {
                // Dictionary<string,object> via IDictionary
                if (dic is System.Collections.IDictionary idict)
                {
                    var val = idict[key];
                    return val?.ToString();
                }
                // Fallback : méthode get_Item via réflexion (IL2CPP dict)
                var getItem = dic.GetType().GetMethod("get_Item",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (getItem != null)
                    return getItem.Invoke(dic, new object[] { key })?.ToString();
                return null;
            }
            catch { return null; }
        }
    }
}
