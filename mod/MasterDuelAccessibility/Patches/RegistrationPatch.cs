using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans de première connexion / inscription (section 1.4).
    ///
    /// ## Écrans couverts
    ///
    /// 1. GameEntrySequenceViewController / V2 (YgomGame.Menu)
    ///    → "Création de compte." — orchestrateur général, pas de données utiles
    ///
    /// 2. GameEntryApprovalViewController (YgomGame.Menu)
    ///    → "Approbation requise. Lisez et acceptez pour continuer."
    ///
    /// 3. AgeGateViewController (YgomGame.Menu.AgeGate)
    ///    → "Vérification d'âge. Saisissez votre date de naissance."
    ///    (m_year / m_month / m_day = objets complexes, non lus directement)
    ///
    /// 4. AgeSelectViewController (YgomGame.Menu)
    ///    → "Sélection d'âge. Âge actuel : N. (de X à Y)"
    ///    m_ageCurrent (int 0x12C), m_ageMin (int 0x120), m_ageMax (int 0x124)
    ///
    /// 5. BirthdateSelectViewController (YgomGame.Menu)
    ///    → "Date de naissance. Saisissez votre date de naissance."
    ///
    /// 6. CountrySelectViewController (YgomGame.Menu.CountrySelect)
    ///    → "Pays : [nom sélectionné]." via m_currentNameText (TMP_Text 0x138)
    ///
    /// 7. USAStateSelectViewController (YgomGame.Menu.USAStateSelect)
    ///    → "État (États-Unis) : [nom sélectionné]." via m_currentNameText (TMP_Text 0x138)
    ///
    /// 8. FirstLanguageSelectViewController (YgomGame.Menu)
    ///    → "Sélection de langue."
    ///
    /// 9. TermOfServiceViewController (YgomGame.Menu.TermOfService)
    ///    → "Conditions d'utilisation. Lisez et acceptez pour continuer."
    ///
    /// 10. PrivacyPolicyViewController (YgomGame.Menu)
    ///    → "Politique de confidentialité. Lisez et acceptez pour continuer."
    ///
    /// 11. GemRestoreOnLoginViewController (global namespace — cas rare)
    ///    → "Restauration de gemmes en cours."
    ///    Pas de champs TMP_Text accessibles (seul _pdAnalyzer / coroutines réseau).
    ///    Annonce générique suffisante — l'écran disparaît rapidement.
    ///
    /// ## Application
    /// Appliqué via Plugin.ApplyPatches() (avant la scène Menu).
    /// </summary>
    internal static class RegistrationPatch
    {
        // ── Caches réflexion ─────────────────────────────────────────────────
        private static FieldInfo? _fAgeCurrent;
        private static FieldInfo? _fAgeMin;
        private static FieldInfo? _fAgeMax;
        private static FieldInfo? _fCountryNameText;
        private static FieldInfo? _fStateNameText;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            PatchSequenceVCs(harmony);
            PatchApproval(harmony);
            PatchAgeGate(harmony);
            PatchAgeSelect(harmony);
            PatchBirthdateSelect(harmony);
            PatchCountrySelect(harmony);
            PatchUSAStateSelect(harmony);
            PatchFirstLanguageSelect(harmony);
            PatchTermOfService(harmony);
            PatchPrivacyPolicy(harmony);
            PatchGemRestoreOnLogin(harmony);
        }

        // ── 1) GameEntrySequenceViewController + V2 ───────────────────────────

        private static void PatchSequenceVCs(HarmonyLib.Harmony harmony)
        {
            PatchStackEntry(harmony,
                "YgomGame.Menu.GameEntrySequenceViewController",
                nameof(GameEntrySequence_Postfix),
                "GameEntrySequenceViewController");

            PatchStackEntry(harmony,
                "YgomGame.Menu.GameEntrySequenceV2ViewController",
                nameof(GameEntrySequence_Postfix),
                "GameEntrySequenceV2ViewController");
        }

        // ── 2) GameEntryApprovalViewController ───────────────────────────────

        private static void PatchApproval(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.GameEntryApprovalViewController",
                nameof(Approval_Postfix),
                "GameEntryApprovalViewController");

        // ── 3) AgeGateViewController ──────────────────────────────────────────

        private static void PatchAgeGate(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.AgeGate.AgeGateViewController",
                nameof(AgeGate_Postfix),
                "AgeGateViewController");

        // ── 4) AgeSelectViewController ────────────────────────────────────────

        private static void PatchAgeSelect(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.AgeSelectViewController",
                nameof(AgeSelect_Postfix),
                "AgeSelectViewController");

        // ── 5) BirthdateSelectViewController ─────────────────────────────────

        private static void PatchBirthdateSelect(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.BirthdateSelectViewController",
                nameof(BirthdateSelect_Postfix),
                "BirthdateSelectViewController");

        // ── 6) CountrySelectViewController ───────────────────────────────────

        private static void PatchCountrySelect(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.CountrySelect.CountrySelectViewController",
                nameof(CountrySelect_Postfix),
                "CountrySelectViewController");

        // ── 7) USAStateSelectViewController ──────────────────────────────────

        private static void PatchUSAStateSelect(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.USAStateSelect.USAStateSelectViewController",
                nameof(USAStateSelect_Postfix),
                "USAStateSelectViewController");

        // ── 8) FirstLanguageSelectViewController ──────────────────────────────

        private static void PatchFirstLanguageSelect(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.FirstLanguageSelectViewController",
                nameof(FirstLanguageSelect_Postfix),
                "FirstLanguageSelectViewController");

        // ── 9) TermOfServiceViewController ────────────────────────────────────

        private static void PatchTermOfService(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.TermOfService.TermOfServiceViewController",
                nameof(TermOfService_Postfix),
                "TermOfServiceViewController");

        // ── 10) PrivacyPolicyViewController ──────────────────────────────────

        private static void PatchPrivacyPolicy(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "YgomGame.Menu.PrivacyPolicyViewController",
                nameof(PrivacyPolicy_Postfix),
                "PrivacyPolicyViewController");

        // ── Shared patcher ───────────────────────────────────────────────────

        private static void PatchStackEntry(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            try
            {
                var type = AccessToolsHelper.FindType(typeName);
                if (type == null)
                {
                    Plugin.Instance?.LogWarn($"[RegistrationPatch] {logLabel} introuvable.");
                    return;
                }

                var method = type.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn($"[RegistrationPatch] {logLabel}.NotificationStackEntry introuvable.");
                    return;
                }

                var postfix = typeof(RegistrationPatch).GetMethod(
                    postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg($"[RegistrationPatch] ✓ {logLabel}.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[RegistrationPatch] Erreur {logLabel}: {ex.Message}");
            }
        }

        // ── Postfix handlers ─────────────────────────────────────────────────

        /// <summary>
        /// GameEntrySequenceViewController / V2 — orchestrateur d'inscription.
        /// Annonce l'ouverture du flux de création de compte.
        /// </summary>
        private static void GameEntrySequence_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_account_create"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// GameEntryApprovalViewController — consentement requis.
        /// </summary>
        private static void Approval_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_approval"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// AgeGateViewController — vérification d'âge par date de naissance.
        /// Les sélecteurs d'année/mois/jour sont des composants complexes ;
        /// on annonce l'instruction générale ; SelectionButtonPatch couvre la navigation.
        /// </summary>
        private static void AgeGate_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_age_gate"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// AgeSelectViewController — curseur de sélection d'âge.
        /// Lit m_ageCurrent (0x12C), m_ageMin (0x120), m_ageMax (0x124) via réflexion.
        /// </summary>
        private static void AgeSelect_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int current = TryReadIntField(__instance, ref _fAgeCurrent, "m_ageCurrent");
                int min     = TryReadIntField(__instance, ref _fAgeMin,     "m_ageMin");
                int max     = TryReadIntField(__instance, ref _fAgeMax,     "m_ageMax");

                if (min != 0 || max != 0)
                    tts.Speak(Loc.Get("reg_age_select_range", current, min, max), interrupt: false);
                else
                    tts.Speak(Loc.Get("reg_age_select", current), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// BirthdateSelectViewController — saisie de date de naissance complète
        /// (jour/mois/année). Composants complexes — annonce l'instruction générale.
        /// </summary>
        private static void BirthdateSelect_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_birthdate"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// CountrySelectViewController — lit m_currentNameText (TMP_Text 0x138).
        /// </summary>
        private static void CountrySelect_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? name = TryReadTmpText(__instance, ref _fCountryNameText, "m_currentNameText");
                if (!string.IsNullOrWhiteSpace(name))
                    tts.Speak(Loc.Get("reg_country_selected", name!), interrupt: false);
                else
                    tts.Speak(Loc.Get("reg_country"), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// USAStateSelectViewController — lit m_currentNameText (TMP_Text 0x138).
        /// </summary>
        private static void USAStateSelect_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? name = TryReadTmpText(__instance, ref _fStateNameText, "m_currentNameText");
                if (!string.IsNullOrWhiteSpace(name))
                    tts.Speak(Loc.Get("reg_state_selected", name!), interrupt: false);
                else
                    tts.Speak(Loc.Get("reg_state"), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// FirstLanguageSelectViewController — sélection de langue initiale.
        /// </summary>
        private static void FirstLanguageSelect_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_language_select"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// TermOfServiceViewController — conditions d'utilisation.
        /// </summary>
        private static void TermOfService_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_tos"), interrupt: false); }
            catch { }
        }

        /// <summary>
        /// PrivacyPolicyViewController — politique de confidentialité.
        /// </summary>
        private static void PrivacyPolicy_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("reg_privacy"), interrupt: false); }
            catch { }
        }

        // ── 11) GemRestoreOnLoginViewController ──────────────────────────────

        private static void PatchGemRestoreOnLogin(HarmonyLib.Harmony harmony)
            => PatchStackEntry(harmony,
                "GemRestoreOnLoginViewController",   // global namespace (no namespace prefix)
                nameof(GemRestore_Postfix),
                "GemRestoreOnLoginViewController");

        private static void GemRestore_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("gem_restore_login"), interrupt: false); }
            catch { }
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        private static int TryReadIntField(object instance, ref FieldInfo? cache, string fieldName)
        {
            try
            {
                if (cache == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField(fieldName,
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { cache = f; break; }
                        t = t.BaseType;
                    }
                }
                return cache == null ? 0 : Convert.ToInt32(cache.GetValue(instance));
            }
            catch { return 0; }
        }

        private static string? TryReadTmpText(object instance, ref FieldInfo? cache, string fieldName)
        {
            try
            {
                if (cache == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField(fieldName,
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { cache = f; break; }
                        t = t.BaseType;
                    }
                }
                if (cache == null) return null;
                object? comp = cache.GetValue(instance);
                if (comp == null) return null;
                var textProp = comp.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                return textProp?.GetValue(comp)?.ToString();
            }
            catch { return null; }
        }
    }
}
