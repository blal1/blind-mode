using HarmonyLib;
using MasterDuelAccessibility.Services.PanelDetection;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch runtime pour détecter l'ouverture / fermeture des panneaux de menus
    /// via les méthodes lifecycle du ViewController.
    ///
    /// Rôle dans l'architecture (inspiré AccessibleArena HarmonyPanelDetector) :
    ///   Ce patch est le DÉTECTEUR — il observe les méthodes du moteur et SIGNALE
    ///   les changements à PanelStateManager.Instance.
    ///   Il ne parle JAMAIS directement au TTS.
    ///
    /// Méthodes patchées :
    ///   ViewController.NotificationStackEntry() → ReportPanelOpened()
    ///   ViewController.NotificationStackRemove() → ReportPanelClosed()
    ///   + handlers spécialisés pour Settings, LoginBonus, PresentBox, etc.
    ///     qui fournissent le PanelType correct sans attendre la classification générique.
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class MenuPanelStatePatch
    {
        private static bool _applied = false;

        // ── Application des patches ───────────────────────────────────────────

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[MenuPanelStatePatch] Initialisation...");

            // ── Base : ViewController.NotificationStackEntry / Remove ─────────
            PatchMethod(harmony,
                "YgomSystem.UI.ViewController", "NotificationStackEntry",
                nameof(VC_StackEntry_Postfix));

            PatchMethod(harmony,
                "YgomSystem.UI.ViewController", "NotificationStackRemove",
                nameof(VC_StackRemove_Postfix));

            // ── Panneaux spécifiques (PanelType fourni explicitement) ─────────
            PatchMethod(harmony,
                "YgomGame.Settings.SettingsViewController", "NotificationStackEntry",
                nameof(Settings_StackEntry_Postfix));

            PatchMethod(harmony,
                "YgomGame.Menu.LoginBonusViewController", "NotificationStackEntry",
                nameof(LoginBonus_StackEntry_Postfix));

            PatchMethod(harmony,
                "YgomGame.Menu.PresentBoxViewController", "NotificationStackEntry",
                nameof(PresentBox_StackEntry_Postfix));

            PatchMethod(harmony,
                "YgomGame.Menu.FriendSearchViewController", "NotificationStackEntry",
                nameof(FriendSearch_StackEntry_Postfix));

            PatchMethod(harmony,
                "YgomGame.PromoCodes.PromoCodesViewController", "NotificationStackEntry",
                nameof(PromoCodes_StackEntry_Postfix));

            PatchMethod(harmony,
                "SeasonResultViewController", "NotificationStackEntry",
                nameof(SeasonResult_StackEntry_Postfix));

            PatchMethod(harmony,
                "YgomGame.ActionSheet.ActionSheetViewController", "NotificationStackEntry",
                nameof(ActionSheet_StackEntry_Postfix));

            // SortDialogs
            PatchMethod(harmony,
                "YgomGame.Menu.SortDialogViewController_Card",     nameof(SortDialog_StackEntry_Postfix));
            PatchMethod(harmony,
                "YgomGame.Menu.SortDialogViewController_CardFile", nameof(SortDialog_StackEntry_Postfix));
            PatchMethod(harmony,
                "YgomGame.Menu.SortDialogViewController_Solo",     nameof(SortDialog_StackEntry_Postfix));

            _applied = true;
            Plugin.Instance?.LogMsg("[MenuPanelStatePatch] Patches appliqués.");
        }

        internal static void Reset() { _applied = false; }

        // ── Helpers d'application ─────────────────────────────────────────────

        /// <summary>Version 3 args : type + méthode + postfix explicitement nommé.</summary>
        private static void PatchMethod(
            HarmonyLib.Harmony harmony,
            string typeName,
            string methodName,
            string postfixName)
        {
            try
            {
                var type = AccessToolsHelper.FindType(typeName);
                if (type == null)
                {
                    Plugin.Instance?.LogWarn($"[MenuPanelStatePatch] Type '{typeName}' introuvable.");
                    return;
                }
                var method = type.GetMethod(methodName,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn($"[MenuPanelStatePatch] '{typeName}.{methodName}' introuvable.");
                    return;
                }
                var patchMeth = typeof(MenuPanelStatePatch).GetMethod(
                    postfixName, BindingFlags.Static | BindingFlags.NonPublic);
                if (patchMeth == null)
                {
                    Plugin.Instance?.LogWarn($"[MenuPanelStatePatch] Postfix '{postfixName}' introuvable.");
                    return;
                }
                harmony.Patch(method, postfix: new HarmonyMethod(patchMeth));
                Plugin.Instance?.LogMsg($"[MenuPanelStatePatch] ✓ {typeName}.{methodName}");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[MenuPanelStatePatch] Échec {typeName}.{methodName}: {ex.Message}");
            }
        }

        /// <summary>Version 2 args : type + postfix = NotificationStackEntry implicite.</summary>
        private static void PatchMethod(
            HarmonyLib.Harmony harmony,
            string typeName,
            string postfixName)
            => PatchMethod(harmony, typeName, "NotificationStackEntry", postfixName);

        // ── Helpers partagés ──────────────────────────────────────────────────

        /// <summary>
        /// Extrait le nom canonique d'un ViewController (sans suffixe).
        /// "LoginBonusViewController" → "LoginBonus"
        /// </summary>
        private static string? SafeGetTypeName(object? instance)
        {
            if (instance == null) return null;
            try
            {
                string name = instance.GetType().Name;
                if (string.IsNullOrEmpty(name)) return null;

                string[] suffixes = { "ViewController2", "ViewController", "Dialog", "Widget" };
                foreach (var s in suffixes)
                {
                    if (name.EndsWith(s, StringComparison.Ordinal))
                    {
                        name = name.Substring(0, name.Length - s.Length);
                        break;
                    }
                }
                return string.IsNullOrEmpty(name) ? null : name;
            }
            catch { return null; }
        }

        // ── Postfix générique — ViewController base ───────────────────────────

        /// <summary>
        /// ViewController.NotificationStackEntry() — panneau entré dans la stack.
        /// Délègue au PanelStateManager pour classification et annonce TTS.
        /// </summary>
        private static void VC_StackEntry_Postfix(object __instance)
        {
            string? name = SafeGetTypeName(__instance);
            if (name == null) return;

            // Les handlers spécialisés ci-dessous gèrent leurs propres appels ;
            // pour éviter les doublons, on laisse le manager filtrer les doublons.
            PanelStateManager.Instance?.ReportPanelOpened(name);
        }

        /// <summary>
        /// ViewController.NotificationStackRemove() — panneau retiré de la stack.
        /// </summary>
        private static void VC_StackRemove_Postfix(object __instance)
        {
            string? name = SafeGetTypeName(__instance);
            if (name == null) return;
            PanelStateManager.Instance?.ReportPanelClosed(name);
        }

        // ── Postfix handlers spécialisés ──────────────────────────────────────
        // Fournissent le PanelType correct et le displayName localisé
        // pour que PanelStateManager n'ait pas besoin de deviner.

        private static void Settings_StackEntry_Postfix(object __instance)
            => PanelStateManager.Instance?.ReportPanelOpened(
                "Settings", PanelType.Settings, Loc.Get("screen_settings"));

        private static void LoginBonus_StackEntry_Postfix(object __instance)
            => PanelStateManager.Instance?.ReportPanelOpened(
                "LoginBonus", PanelType.Reward, Loc.Get("screen_login_bonus"));

        private static void PresentBox_StackEntry_Postfix(object __instance)
            => PanelStateManager.Instance?.ReportPanelOpened(
                "PresentBox", PanelType.Reward, Loc.Get("screen_present_box"));

        private static void FriendSearch_StackEntry_Postfix(object __instance)
            => PanelStateManager.Instance?.ReportPanelOpened(
                "FriendSearch", PanelType.Social, Loc.Get("screen_friends_search"));

        private static void PromoCodes_StackEntry_Postfix(object __instance)
            => PanelStateManager.Instance?.ReportPanelOpened(
                "PromoCodes", PanelType.Input, Loc.Get("screen_password"));

        private static void SeasonResult_StackEntry_Postfix(object __instance)
            => PanelStateManager.Instance?.ReportPanelOpened(
                "SeasonResult", PanelType.Reward, Loc.Get("screen_season_result"));

        private static void ActionSheet_StackEntry_Postfix(object __instance)
        {
            // Tenter de lire le titre via réflexion
            string? title = TryReadFieldText(__instance, "_title")
                ?? TryReadFieldText(__instance, "m_titleText")
                ?? TryReadFieldText(__instance, "titleText");

            string displayName = string.IsNullOrWhiteSpace(title)
                ? Loc.Get("action_sheet_opened")
                : Loc.Get("action_sheet_title", title!);

            PanelStateManager.Instance?.ReportPanelOpened(
                "ActionSheet", PanelType.ActionSheet, displayName);
        }

        private static void SortDialog_StackEntry_Postfix(object __instance)
        {
            string typeName = SafeGetTypeName(__instance) ?? "Sort";
            string label = typeName switch
            {
                "SortDialogViewController_Card"     => Loc.Get("screen_sort_card"),
                "SortDialogViewController_CardFile" => Loc.Get("screen_sort_cardfile"),
                "SortDialogViewController_Solo"     => Loc.Get("screen_sort_solo"),
                _                                   => Loc.Get("screen_sort_card"),
            };
            PanelStateManager.Instance?.ReportPanelOpened(
                "SortDialog", PanelType.SortDialog, label);
        }

        // ── Réflexion helpers ─────────────────────────────────────────────────

        private static string? TryReadFieldText(object instance, string fieldName)
        {
            try
            {
                var field = instance.GetType().GetField(fieldName,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (field == null) return null;
                var value = field.GetValue(instance);
                if (value == null) return null;
                if (value is string s) return string.IsNullOrWhiteSpace(s) ? null : s;
                var textProp = value.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                var text = textProp?.GetValue(value)?.ToString();
                return string.IsNullOrWhiteSpace(text) ? null : text;
            }
            catch { return null; }
        }
    }
}
