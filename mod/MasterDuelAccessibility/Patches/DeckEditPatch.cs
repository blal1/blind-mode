using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour DeckEditViewController2 :
    ///   - StartCardAddEffect : annonce le nom de la carte ajoutée au deck
    ///   - RemoveFromDeck     : annonce le nom de la carte retirée du deck
    ///   - OnSubmitDeckName   : annonce le nouveau nom après renommage
    ///   - OnClickSaveButton  : annonce la sauvegarde du deck
    ///
    /// Signatures cibles :
    ///   protected void StartCardAddEffect(CardBase targetCard, TransitionCard.Size size)
    ///   public void RemoveFromDeck(DeckCard card, bool isDrag, Nullable&lt;Vector3&gt; pos, bool isFlick)
    ///   public void OnSubmitDeckName(string deckName)
    ///   public void OnClickSaveButton()
    ///
    /// CardBase / DeckCard exposent m_BaseData (CardBaseData) → CardID,
    /// résolu via Content.Instance.GetName().
    /// </summary>
    internal static class DeckEditPatch
    {
        private static readonly BindingFlags Pub =
            BindingFlags.Public | BindingFlags.Instance;

        // ── Shared helper ─────────────────────────────────────────────────────

        /// <summary>
        /// Reads CardID from a CardBase-derived instance (via m_BaseData.CardID),
        /// then resolves the display name. Returns null on any failure.
        /// </summary>
        private static string? GetCardNameFromInstance(object cardBase)
        {
            var baseDataProp = cardBase.GetType().GetProperty("m_BaseData", Pub);
            var baseData = baseDataProp?.GetValue(cardBase);
            if (baseData == null) return null;

            var cardIdProp = baseData.GetType().GetProperty("CardID", Pub);
            if (cardIdProp?.GetValue(baseData) is not int cardId || cardId <= 0) return null;

            return AccessToolsHelper.GetCardName(cardId);
        }

        // ── Postfix DeckEditViewController2.StartCardAddEffect ───────────────

        public static void StartCardAddEffect_Postfix(object __instance, object targetCard)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || targetCard == null) return;

            try
            {
                string? name = GetCardNameFromInstance(targetCard);
                if (!string.IsNullOrWhiteSpace(name))
                    tts.Speak(Loc.Get("deck_card_added", name), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── Postfix DeckEditViewController2.RemoveFromDeck (2-param) ─────────
        // Signature: public DeckCard RemoveFromDeck(CardBaseData baseData, bool isUndo)
        // Note: 4-param overload (DeckCard, bool, Nullable<Vector3>, bool) not used
        //       because Nullable<Vector3> triggers an Il2CppInterop crash on Unity 6.
        // CardBaseData is a non-generic struct with a public CardID property.

        public static void RemoveFromDeck_Postfix(object __instance, object baseData)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || baseData == null) return;

            try
            {
                var cardIdProp = baseData.GetType()
                    .GetProperty("CardID", BindingFlags.Public | BindingFlags.Instance);
                if (cardIdProp?.GetValue(baseData) is not int cardId || cardId <= 0) return;

                string? name = AccessToolsHelper.GetCardName(cardId);
                if (!string.IsNullOrWhiteSpace(name))
                    tts.Speak(Loc.Get("deck_card_removed", name), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── Postfix DeckEditViewController2.OnSubmitDeckName ─────────────────
        // Signature: public void OnSubmitDeckName(string deckName)
        // Fires when the user confirms a new deck name in the rename dialog.

        public static void OnSubmitDeckName_Postfix(object __instance, string deckName)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || string.IsNullOrWhiteSpace(deckName)) return;

            tts.Speak(Loc.Get("deck_renamed", deckName));
        }

        // ── Postfix DeckEditViewController2.OnClickSaveButton ────────────────
        // Signature: public void OnClickSaveButton()
        // Fires immediately when the user clicks the Save button.
        // Reads the current deck name from m_DeckName property via reflection.

        public static void OnClickSaveButton_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                var nameProp = __instance.GetType().GetProperty("m_DeckName", Pub);
                var deckName = nameProp?.GetValue(__instance) as string;
                tts.Speak(string.IsNullOrWhiteSpace(deckName)
                    ? Loc.Get("deck_saved")
                    : Loc.Get("deck_saved_named", deckName));
            }
            catch
            {
                tts.Speak(Loc.Get("deck_saved"));
            }
        }

        // ── Postfix DeckEditViewController2.OnFocusChanged ───────────────────
        // Fires when the deck editor gains or loses focus.
        // When gaining focus (setfocus=true), announces the deck name being edited.

        public static void OnFocusChanged_Postfix(object __instance, bool setfocus)
        {
            if (!setfocus) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                var nameProp = __instance.GetType().GetProperty("m_DeckName", Pub);
                var deckName = nameProp?.GetValue(__instance) as string;
                if (!string.IsNullOrWhiteSpace(deckName))
                    tts.Speak(Loc.Get("deck_editing", deckName), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }
    }
}
