using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.DeckSelectViewController2 :
    ///   - OnFocusChanged(bool setfocus) : annonce le nom du deck mis en focus
    ///     lorsque l'écran de sélection de deck s'ouvre (avant un duel, mode solo, etc.)
    ///
    /// DeckSelectViewController2 hérite de BaseMenuViewController.
    /// Les decks sont stockés dans le champ protégé m_Decks (List<DeckReference>).
    /// La DeckReference sélectionnée est déterminée via le scroll view actif
    /// ou via l'index courant.
    ///
    /// Stratégie : lire m_Decks[selectedIndex].name via réflexion.
    /// L'index sélectionné est lu depuis lastSet (int privé) qui correspond
    /// à l'index du deck affiché au centre du scroll.
    /// </summary>
    internal static class DeckSelectPatch
    {
        private static readonly BindingFlags AnyInst =
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
        private static readonly BindingFlags PubInst =
            BindingFlags.Public | BindingFlags.Instance;

        // Postfix pour DeckSelectViewController2.OnFocusChanged(bool setfocus)
        public static void OnFocusChanged_Postfix(object __instance, bool setfocus)
        {
            if (!setfocus) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                string? deckName = GetSelectedDeckName(__instance);
                if (!string.IsNullOrWhiteSpace(deckName))
                    tts.Speak(Loc.Get("deck_select_focus", deckName), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        /// <summary>
        /// Tente de lire le nom du deck sélectionné depuis l'instance.
        /// Stratégie 1 : m_Decks[lastSet].name (index courant du scroll).
        /// Stratégie 2 : m_Decks[0].name (premier deck si lastSet introuvable).
        /// </summary>
        private static string? GetSelectedDeckName(object instance)
        {
            // Lire la liste m_Decks (protected field)
            var type = instance.GetType();
            FieldInfo? decksField = null;
            while (type != null && decksField == null)
            {
                decksField = type.GetField("m_Decks", AnyInst);
                type = type.BaseType;
            }
            if (decksField == null) return null;

            var deckList = decksField.GetValue(instance);
            if (deckList == null) return null;

            // Compter les éléments
            var countProp = deckList.GetType().GetProperty("Count", PubInst);
            int count = countProp?.GetValue(deckList) is int c ? c : 0;
            if (count == 0) return null;

            // Lire lastSet pour l'index courant
            int selectedIndex = 0;
            type = instance.GetType();
            FieldInfo? lastSetField = null;
            while (type != null && lastSetField == null)
            {
                lastSetField = type.GetField("lastSet", AnyInst);
                type = type.BaseType;
            }
            if (lastSetField?.GetValue(instance) is int ls && ls >= 0 && ls < count)
                selectedIndex = ls;

            // Lire deckList[selectedIndex]
            var getItemMethod = deckList.GetType().GetMethod(
                "get_Item", PubInst, null, new[] { typeof(int) }, null);
            var deckRef = getItemMethod?.Invoke(deckList, new object[] { selectedIndex });
            if (deckRef == null) return null;

            // Lire DeckReference.name
            var nameProp = deckRef.GetType().GetProperty("name", PubInst);
            if (nameProp?.GetValue(deckRef) is string n)
                return n;

            var nameField = deckRef.GetType().GetField("name", PubInst);
            return nameField?.GetValue(deckRef) as string;
        }
    }
}
