using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.DeckSelectViewController2 :
    ///   - OnFocusChanged(bool setfocus) : annonce le nom du deck mis en focus
    ///     lorsque l'écran de sélection de deck s'ouvre (avant un duel, mode solo, etc.)
    ///   - OnItemSetData(GameObject gob, int dataindex) : ISV callback — annonce le
    ///     nom du deck quand un item de la liste ISV est chargé (avec cooldown 300ms).
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

        // ISV cooldown — évite les annonces en rafale pendant le scroll
        private static long _lastISVTick = 0L;
        private const long ISVCooldownTicks = 3_000_000L; // 300 ms

        // Postfix pour DeckSelectViewController2.OnFocusChanged(bool setfocus)
        public static void OnFocusChanged_Postfix(object __instance, bool setfocus)
        {
            if (!setfocus) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                string modeLabel = GetModeLabel(__instance);
                string? deckName = GetSelectedDeckName(__instance);

                if (!string.IsNullOrWhiteSpace(deckName))
                    tts.Speak(Loc.Get("deck_select_focus_mode", modeLabel, deckName), interrupt: false);
                else if (!string.IsNullOrWhiteSpace(modeLabel))
                    tts.Speak(Loc.Get("deck_select_mode", modeLabel), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        /// <summary>
        /// Lit m_SelectMode (protected field) depuis l'instance via réflexion
        /// et retourne le libellé localisé correspondant.
        /// </summary>
        private static string GetModeLabel(object instance)
        {
            try
            {
                var type = instance.GetType();
                FieldInfo? field = null;
                while (type != null && field == null)
                {
                    field = type.GetField("m_SelectMode", AnyInst);
                    type = type.BaseType;
                }
                if (field == null) return string.Empty;

                int mode = System.Convert.ToInt32(field.GetValue(instance));
                return mode switch
                {
                    0  => Loc.Get("deck_mode_default"),
                    1  => Loc.Get("deck_mode_ranked"),
                    2  => Loc.Get("deck_mode_pve"),
                    3  => Loc.Get("deck_mode_tournament"),
                    4  => Loc.Get("deck_mode_solo"),
                    5  => Loc.Get("deck_mode_room"),
                    6  => Loc.Get("deck_mode_exhibition"),
                    8  => Loc.Get("deck_mode_free"),
                    9  => Loc.Get("deck_mode_cup"),
                    10 => Loc.Get("deck_mode_wcs"),
                    12 => Loc.Get("deck_mode_rank_event"),
                    13 => Loc.Get("deck_mode_team"),
                    15 => Loc.Get("deck_mode_duel_trial"),
                    17 => Loc.Get("deck_mode_versus"),
                    20 => Loc.Get("deck_mode_rate"),
                    22 => Loc.Get("deck_mode_rdc"),
                    24 => Loc.Get("deck_mode_dice_rally"),
                    _  => string.Empty,
                };
            }
            catch { return string.Empty; }
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

        // ── ISV Navigation — OnItemSetData ────────────────────────────────────

        /// <summary>
        /// Postfix pour DeckSelectViewController2.OnItemSetData(GameObject gob, int dataindex).
        /// Fires when an ISV item is populated with deck data.
        /// Announces deck name + position with 300 ms cooldown to suppress scroll flooding.
        /// </summary>
        public static void OnItemSetData_Postfix(object __instance, object gob, int dataindex)
        {
            // 300 ms cooldown
            long now = DateTime.Now.Ticks;
            if (now - _lastISVTick < ISVCooldownTicks) return;
            _lastISVTick = now;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                var type = __instance.GetType();
                FieldInfo? decksField = null;
                while (type != null && decksField == null)
                {
                    decksField = type.GetField("m_Decks", AnyInst);
                    type = type.BaseType;
                }
                if (decksField == null) return;

                var deckList = decksField.GetValue(__instance);
                if (deckList == null) return;

                var countProp = deckList.GetType().GetProperty("Count", PubInst);
                int count = countProp?.GetValue(deckList) is int c ? c : 0;
                if (dataindex < 0 || dataindex >= count) return;

                var getItem = deckList.GetType().GetMethod(
                    "get_Item", PubInst, null, new[] { typeof(int) }, null);
                var deckRef = getItem?.Invoke(deckList, new object[] { dataindex });
                if (deckRef == null) return;

                var nameField = deckRef.GetType().GetField("name", AnyInst);
                string? name = nameField?.GetValue(deckRef) as string;
                if (string.IsNullOrWhiteSpace(name)) return;

                tts.Speak(Loc.Get("deck_isv_item", name, dataindex + 1, count), interrupt: true);
            }
            catch { }
        }
    }
}
