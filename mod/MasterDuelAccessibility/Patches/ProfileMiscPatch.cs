using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans de profil et social non couverts par ProfilePatch :
    ///
    ///   Section 11.1 — Profil joueur :
    ///     ProfileDataViewController.NotificationStackEntry()
    ///       → "Données du profil." (historique de rang, stats de victoires)
    ///       Namespace : YgomGame.Menu
    ///     ProfileEditViewController.NotificationStackEntry()
    ///       → "Édition du profil."
    ///       Namespace : (global / vide)
    ///     ProfileCardCheckViewController.NotificationStackEntry()
    ///       → "Vérification des cartes du profil."
    ///       Namespace : (global / vide)
    ///
    ///   Section 11.2 — Amis :
    ///     FriendSearchViewController.NotificationStackEntry()
    ///       → "Recherche d'ami."
    ///       Namespace : (global / vide)
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ProfileMiscPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNSE(harmony, "YgomGame.Menu.ProfileDataViewController",    nameof(ProfileData_Postfix),    "ProfileDataViewController");
            PatchNSE(harmony, "ProfileEditViewController",                  nameof(ProfileEdit_Postfix),    "ProfileEditViewController");
            PatchNSE(harmony, "ProfileCardCheckViewController",             nameof(ProfileCardCheck_Postfix), "ProfileCardCheckViewController");
            PatchNSE(harmony, "FriendSearchViewController",                 nameof(FriendSearch_Postfix),   "FriendSearchViewController");

            _applied = true;
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[ProfileMiscPatch] {logLabel} introuvable.");
                return;
            }
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[ProfileMiscPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(ProfileMiscPatch), postfixName));
            Plugin.Instance?.LogMsg($"[ProfileMiscPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void ProfileData_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("profile_data"), interrupt: false);

        public static void ProfileEdit_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("profile_edit"), interrupt: false);

        public static void ProfileCardCheck_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("profile_card_check"), interrupt: false);

        public static void FriendSearch_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("friend_search"), interrupt: false);
    }
}
