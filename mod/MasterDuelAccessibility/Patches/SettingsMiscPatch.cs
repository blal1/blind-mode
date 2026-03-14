using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans de paramètres (section 15) :
    ///
    ///   SettingMenuViewController.NotificationStackEntry()
    ///     → annonce la page courante selon SettingMenuViewController.Page :
    ///       General=0, Duel=1, Audience=2, CrossPlay=3, Privacy=4
    ///     → "Paramètres — [page]."
    ///
    ///   LanguageSelectViewController.NotificationStackEntry()
    ///     → lit m_currentLangText (TMP_Text 0x130) → "Sélection de langue. [langue actuelle]."
    ///       ou "Sélection de langue." si le texte est vide.
    ///
    ///   PrivacySettingsViewController.NotificationStackEntry()
    ///     → "Paramètres de confidentialité."
    ///
    /// Namespace : SettingMenuViewController + LanguageSelectViewController → (global / vide)
    ///             PrivacySettingsViewController → (global / vide)
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class SettingsMiscPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNSE(harmony, "SettingMenuViewController",     nameof(SettingMenu_Postfix),   "SettingMenuViewController");
            PatchNSE(harmony, "LanguageSelectViewController",  nameof(LanguageSelect_Postfix), "LanguageSelectViewController");
            PatchNSE(harmony, "PrivacySettingsViewController", nameof(PrivacySettings_Postfix),"PrivacySettingsViewController");

            _applied = true;
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[SettingsMiscPatch] {logLabel} introuvable.");
                return;
            }
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[SettingsMiscPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(SettingsMiscPatch), postfixName));
            Plugin.Instance?.LogMsg($"[SettingsMiscPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // ── SettingMenuViewController ─────────────────────────────────────────
        // Page enum : General=0, Duel=1, Audience=2, CrossPlay=3, Privacy=4

        public static void SettingMenu_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = __instance.GetType().GetField("currentPage",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                int page = f != null ? Convert.ToInt32(f.GetValue(__instance)) : 0;
                string pageKey = page switch
                {
                    0 => "settings_page_general",
                    1 => "settings_page_duel",
                    2 => "settings_page_audience",
                    3 => "settings_page_crossplay",
                    4 => "settings_page_privacy",
                    _ => "settings_page_general"
                };
                tts.Speak(Loc.Get("settings_open", Loc.Get(pageKey)), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("settings_open_generic"), interrupt: false); }
        }

        // ── LanguageSelectViewController ─────────────────────────────────────
        // m_currentLangText : TMP_Text at 0x130

        public static void LanguageSelect_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = __instance.GetType().GetField("m_currentLangText",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var tmp = f?.GetValue(__instance);
                string? lang = tmp?.GetType()
                    .GetProperty("text", BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(tmp) as string;

                string msg = string.IsNullOrWhiteSpace(lang)
                    ? Loc.Get("language_select")
                    : Loc.Get("language_select_current", lang);
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("language_select"), interrupt: false); }
        }

        // ── PrivacySettingsViewController ─────────────────────────────────────

        public static void PrivacySettings_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("privacy_settings"), interrupt: false);
    }
}
