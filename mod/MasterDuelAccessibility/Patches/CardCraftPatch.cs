namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Deck.CardCraftDialog :
    ///   - Open(ViewController, CraftMode, int cardID, Premium, Action) → 5 paramètres
    ///
    /// Annonce l'intention de création ou de démantèlement :
    ///   "Créer : [nom de la carte]"
    ///   "Démanteler : [nom de la carte]"
    ///   "Création boostée : [nom de la carte]"
    ///
    /// Injection positionnelle Harmony :
    ///   __0 = ViewController manager (ignoré)
    ///   __1 = CraftMode (int) : 0=Create, 1=BoostCreate, 2=Dismantle
    ///   __2 = int cardID
    ///   __3 = CardCollectionInfo.Premium (ignoré)
    ///   __4 = Action callback (ignoré)
    ///
    /// Méthode statique → les paramètres Harmony sont injectés depuis __0.
    /// </summary>
    internal static class CardCraftPatch
    {
        // Postfix pour CardCraftDialog.Open(ViewController, CraftMode, int, Premium, Action)
        // Paramètre 5 = index 0..4
        public static void Open_Postfix(int __1, int __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                string? cardName = AccessToolsHelper.GetCardName(__2);
                if (string.IsNullOrWhiteSpace(cardName)) return;

                // CraftMode : 0=Create, 1=BoostCreate, 2=Dismantle
                string key = __1 switch
                {
                    0 => "craft_create",
                    1 => "craft_boost_create",
                    _ => "craft_dismantle"   // 2=Dismantle
                };

                tts.Speak(Loc.Get(key, cardName), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }
    }
}
