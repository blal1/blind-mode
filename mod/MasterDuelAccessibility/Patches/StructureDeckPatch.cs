using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les decks de structure :
    ///
    ///   StructureDeckSelectViewController.NotificationStackEntry()
    ///     → "Sélection du deck de structure"
    ///
    ///   StructureDeckSelectBackableViewController.NotificationStackEntry()
    ///     → idem (sous-classe)
    ///
    ///   StructureDeckObtainViewController.NotificationStackEntry()
    ///     → "Deck de structure obtenu"
    ///
    /// Namespace : YgomGame.Menu
    /// Appliqué dans LatePatches.ApplyMenuScenePatches() — types chargés dynamiquement.
    /// </summary>
    internal static class StructureDeckPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            // StructureDeckSelectViewController
            PatchStackEntry(harmony,
                "YgomGame.Menu.StructureDeckSelectViewController",
                nameof(Select_Entry_Postfix),
                "StructureDeckSelectViewController");

            // StructureDeckSelectBackableViewController (sous-classe, Override propre)
            PatchStackEntry(harmony,
                "YgomGame.Menu.StructureDeckSelectBackableViewController",
                nameof(Select_Entry_Postfix),
                "StructureDeckSelectBackableViewController");

            // StructureDeckObtainViewController
            PatchStackEntry(harmony,
                "YgomGame.Menu.StructureDeckObtainViewController",
                nameof(Obtain_Entry_Postfix),
                "StructureDeckObtainViewController");

            _applied = true;
        }

        private static void PatchStackEntry(
            HarmonyLib.Harmony harmony,
            string typeName,
            string postfixName,
            string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[StructureDeckPatch] {logLabel} introuvable.");
                return;
            }

            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[StructureDeckPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(
                typeof(StructureDeckPatch), postfixName));
            Plugin.Instance?.LogMsg($"[StructureDeckPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void Select_Entry_Postfix(object __instance)
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("structure_deck_select"), interrupt: false);
        }

        public static void Obtain_Entry_Postfix(object __instance)
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("structure_deck_obtained"), interrupt: false);
        }
    }
}
