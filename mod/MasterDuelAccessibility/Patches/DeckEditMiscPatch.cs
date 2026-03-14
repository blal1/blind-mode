using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les dialogs de l'éditeur de deck non couverts par DeckEditPatch :
    ///
    ///   Section 6.1 — Éditeur de deck :
    ///     DeckEditSubMenuViewController.NotificationStackEntry()
    ///       → "Sous-menu deck." (copier, supprimer, renommer)
    ///       Namespace : (global / vide), hérite SubMenuViewController
    ///     DeckNameEditDialog.NotificationStackEntry()
    ///       → "Renommer le deck."
    ///       Namespace : (global / vide), hérite SelectDialogViewControllerBase<string>
    ///     AutoBuildDialog.NotificationStackEntry()
    ///       → "Construction automatique."
    ///       Namespace : (global / vide)
    ///     FilterDialog.NotificationStackEntry()
    ///       → "Filtres avancés."
    ///       Namespace : (global / vide)
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class DeckEditMiscPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchNSE(harmony, "DeckEditSubMenuViewController", nameof(DeckSubMenu_Postfix), "DeckEditSubMenuViewController");
            PatchNSE(harmony, "DeckNameEditDialog",            nameof(DeckNameEdit_Postfix),"DeckNameEditDialog");
            PatchNSE(harmony, "AutoBuildDialog",               nameof(AutoBuild_Postfix),   "AutoBuildDialog");
            PatchNSE(harmony, "FilterDialog",                  nameof(FilterDialog_Postfix),"FilterDialog");

            _applied = true;
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[DeckEditMiscPatch] {logLabel} introuvable.");
                return;
            }
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[DeckEditMiscPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(DeckEditMiscPatch), postfixName));
            Plugin.Instance?.LogMsg($"[DeckEditMiscPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void DeckSubMenu_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("deck_submenu"), interrupt: false);

        public static void DeckNameEdit_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("deck_name_edit"), interrupt: false);

        public static void AutoBuild_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("deck_auto_build"), interrupt: false);

        public static void FilterDialog_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("deck_filter_dialog"), interrupt: false);
    }
}
