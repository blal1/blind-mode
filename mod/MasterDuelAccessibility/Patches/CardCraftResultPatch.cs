namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Deck.CardCraftResultDialog.GetResultMessage :
    ///   public static string GetResultMessage(int cardID, Dictionary&lt;int, int&gt; resultPrem)
    ///
    /// Annonce le message de résultat déjà composé par le jeu.
    /// Injecté via __result (valeur de retour du postfix).
    ///
    /// Utilise interrupt:true car c'est un événement critique : l'utilisateur
    /// vient de confirmer une action irréversible (création / démantèlement).
    /// </summary>
    internal static class CardCraftResultPatch
    {
        // Postfix pour CardCraftResultDialog.GetResultMessage(int, Dictionary<int,int>)
        public static void GetResultMessage_Postfix(int __0, string __result)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || string.IsNullOrWhiteSpace(__result)) return;

            try
            {
                // Le message est déjà formaté par le jeu (ex: "Dark Magician created!")
                // On le lit tel quel. S'il est vide, on construit un fallback.
                string msg = __result;

                // Fallback : si le message est vide, annoncer le nom de la carte
                if (string.IsNullOrWhiteSpace(msg))
                {
                    string? cardName = AccessToolsHelper.GetCardName(__0);
                    if (!string.IsNullOrWhiteSpace(cardName))
                        msg = Loc.Get("craft_result_generic", cardName);
                }

                if (!string.IsNullOrWhiteSpace(msg))
                    tts.Speak(msg, interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }
    }
}
