using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans boutique secondaires (gemmes, tickets, échanges, historique) :
    ///
    ///   GemShopViewController.NotificationStackEntry()       → "Boutique de gemmes"
    ///   GemShopPermissionViewController.NotificationStackEntry() → "Consentement requis"
    ///   GemShopApprovalViewController.NotificationStackEntry()   → "Approbation requise"
    ///   GemGetHistoryViewController.NotificationStackEntry()     → "Historique des achats"
    ///   TicketInventoryViewController.NotificationStackEntry()   → "Inventaire de tickets"
    ///   ItemExchangeViewController.NotificationStackEntry()      → "Échange d'objets"
    ///   ItemGetHistoryViewController.NotificationStackEntry()    → "Historique des objets"
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches() — types chargés dynamiquement.
    /// </summary>
    internal static class ShopMiscPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchStackEntry(harmony, "YgomGame.GemShop.GemShopViewController",      "gem_shop",             "GemShopViewController");
            PatchStackEntry(harmony, "YgomGame.GemShop.GemShopPermissionViewController", "gem_shop_permission", "GemShopPermissionViewController");
            PatchStackEntry(harmony, "YgomGame.Menu.GemShopApprovalViewController",  "gem_shop_approval",    "GemShopApprovalViewController");
            PatchStackEntry(harmony, "YgomGame.GemGetHistory.GemGetHistoryViewController", "gem_get_history", "GemGetHistoryViewController");
            PatchStackEntry(harmony, "YgomGame.Shop.TicketInventoryViewController",  "ticket_inventory",     "TicketInventoryViewController");
            PatchStackEntry(harmony, "YgomGame.ItemExchangeViewController",          "item_exchange",        "ItemExchangeViewController");
            PatchStackEntry(harmony, "YgomGame.ItemGetHistory.ItemGetHistoryViewController", "item_get_history", "ItemGetHistoryViewController");

            _applied = true;
        }

        private static void PatchStackEntry(
            HarmonyLib.Harmony harmony,
            string typeName,
            string locKey,
            string logLabel)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[ShopMiscPatch] {logLabel} introuvable.");
                return;
            }

            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[ShopMiscPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }

            // Capture locKey in closure via lambda is not supported with HarmonyMethod;
            // use a shared dispatcher with the type name as key.
            _locKeys[typeName] = locKey;

            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(
                typeof(ShopMiscPatch), nameof(Generic_Entry_Postfix)));
            Plugin.Instance?.LogMsg($"[ShopMiscPatch] ✓ {logLabel}.NotificationStackEntry");
        }

        // Shared postfix — looks up the Loc key by concrete type name
        private static readonly System.Collections.Generic.Dictionary<string, string> _locKeys =
            new System.Collections.Generic.Dictionary<string, string>();

        public static void Generic_Entry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Resolve full type name (with namespace) to find the Loc key
                string fullName = __instance.GetType().FullName ?? "";
                if (!_locKeys.TryGetValue(fullName, out var key)) return;
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { /* silent */ }
        }
    }
}
