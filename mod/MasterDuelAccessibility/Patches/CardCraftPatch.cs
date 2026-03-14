using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour la création et le démantèlement de cartes :
    ///
    ///   CardCraftDialog.Open(ViewController, CraftMode, int, Premium, Action)
    ///     → annonce le mode (créer/démanteler) et le nom de la carte
    ///
    ///   BatchDismantleDialog.NotificationStackEntry()
    ///     → annonce le nombre de cartes à démanteler en lot
    ///
    ///   CardRelativeBrowserViewController.NotificationStackEntry()
    ///     → annonce le nom de la carte dont on voit les cartes liées
    /// </summary>
    internal static class CardCraftPatch
    {
        // ── CardCraftDialog.Open ─────────────────────────────────────────────

        // Postfix pour CardCraftDialog.Open(ViewController, CraftMode, int, Premium, Action)
        // __1 = CraftMode (int): 0=Create, 1=BoostCreate, 2=Dismantle
        // __2 = cardID (int)
        public static void Open_Postfix(int __1, int __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                string? cardName = AccessToolsHelper.GetCardName(__2);
                if (string.IsNullOrWhiteSpace(cardName)) return;

                string key = __1 switch
                {
                    0 => "craft_create",
                    1 => "craft_boost_create",
                    _ => "craft_dismantle"
                };

                tts.Speak(Loc.Get(key, cardName), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── BatchDismantleDialog.NotificationStackEntry ──────────────────────

        /// <summary>
        /// Announces the number of cards selected for batch dismantling.
        /// Reads m_DismantleCards (List&lt;CardBaseData&gt; at 0x1A0) via reflection.
        /// </summary>
        public static void BatchDismantle_Entry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                var cardsField = FindField(t, "m_DismantleCards");
                var cards = cardsField?.GetValue(__instance);
                int count = 0;
                if (cards != null)
                {
                    var countProp = cards.GetType().GetProperty("Count",
                        BindingFlags.Public | BindingFlags.Instance);
                    count = Convert.ToInt32(countProp?.GetValue(cards) ?? 0);
                }

                string msg = count > 0
                    ? Loc.Get("batch_dismantle_open", count.ToString())
                    : Loc.Get("batch_dismantle_dialog");
                tts.Speak(msg, interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── CardRelativeBrowserViewController.NotificationStackEntry ─────────

        /// <summary>
        /// Announces the source card when opening the related-cards browser.
        /// Reads m_Mrk (int at 0xE0) — the marker/card ID of the source card.
        /// </summary>
        public static void RelativeBrowser_Entry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                var mrkField = FindField(t, "m_Mrk");
                int mrk = Convert.ToInt32(mrkField?.GetValue(__instance) ?? 0);

                string? cardName = mrk > 0 ? AccessToolsHelper.GetCardName(mrk) : null;
                string msg = string.IsNullOrWhiteSpace(cardName)
                    ? Loc.Get("relative_browser")
                    : Loc.Get("relative_browser_card", cardName);
                tts.Speak(msg, interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── helpers ──────────────────────────────────────────────────────────

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
