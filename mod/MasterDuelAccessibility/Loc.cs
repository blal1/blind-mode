using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Central localization for the MasterDuelAccessibility mod.
    /// Supports French (primary) and English (fallback).
    ///
    /// Language is auto-detected from YgomSystem.Utility.Locale.GetLanguage()
    /// at initialization. French players get French strings; all others get English.
    ///
    /// Usage:
    ///   Loc.Get("key")           - Get a string
    ///   Loc.Get("key", a, b)     - Get a string with placeholders {0}, {1}
    ///   Loc.RefreshLanguage()    - Re-detect game language (e.g. after settings change)
    /// </summary>
    public static class Loc
    {
        #region Fields

        private static bool _initialized = false;
        private static string _currentLang = "en"; // default until detected

        private static readonly Dictionary<string, string> _french  = new();
        private static readonly Dictionary<string, string> _english = new();

        #endregion

        #region Public API

        /// <summary>Initializes localization. Call once at mod startup.</summary>
        public static void Initialize()
        {
            InitializeStrings();
            _initialized = true;
            RefreshLanguage(); // detect game language after strings are loaded
        }

        /// <summary>
        /// Re-detects the game language from Locale.GetLanguage().
        /// Maps "fr-FR" → "fr", everything else → "en".
        /// Safe to call at any time.
        /// </summary>
        public static void RefreshLanguage()
        {
            try
            {
                var localeType = AccessToolsHelper.FindType("YgomSystem.Utility.Locale");
                if (localeType == null) return;
                var getLanguageMethod = localeType.GetMethod(
                    "GetLanguage",
                    BindingFlags.Public | BindingFlags.Static);
                var result = getLanguageMethod?.Invoke(null, null) as string;
                if (!string.IsNullOrEmpty(result))
                    _currentLang = result!.StartsWith("fr") ? "fr" : "en";
            }
            catch { /* keep current lang on error */ }
        }

        /// <summary>Gets a localized string by key.</summary>
        public static string Get(string key)
        {
            if (!_initialized) Initialize();

            if (GetCurrentDict().TryGetValue(key, out string? val)) return val!;
            if (_english.TryGetValue(key, out string? eng))         return eng!;
            return key; // fallback: key itself (visible in logs)
        }

        /// <summary>Gets a localized string with placeholders {0}, {1}, …</summary>
        public static string Get(string key, params object[] args)
        {
            string template = Get(key);
            try   { return string.Format(template, args); }
            catch { return template; }
        }

        #endregion

        #region Private

        private static Dictionary<string, string> GetCurrentDict() =>
            _currentLang == "fr" ? _french : _english;

        /// <summary>
        /// Adds a string in both languages.
        /// Convention for keys: [category]_[action]
        /// </summary>
        private static void Add(string key, string fr, string en)
        {
            _french[key]  = fr;
            _english[key] = en;
        }

        private static void InitializeStrings()
        {
            // ===== GENERAL =====
            Add("mod_loaded",
                "Mod d'accessibilité chargé. Synthèse vocale active.",
                "Accessibility mod loaded. Text-to-speech active.");

            // ===== MENUS =====
            Add("menu_duel",
                "Duel",
                "Duel");
            Add("menu_deck",
                "Deck",
                "Deck");
            Add("menu_solo",
                "Solo",
                "Solo");
            Add("menu_shop",
                "Boutique",
                "Shop");
            Add("menu_missions",
                "Missions",
                "Missions");
            Add("menu_notifications",
                "Notifications",
                "Notifications");
            Add("menu_settings",
                "Paramètres",
                "Settings");
            Add("menu_duelpass",
                "Duel Pass",
                "Duel Pass");

            // ===== DUEL — LP =====
            Add("duel_lp_damage_you",
                "Vous : {0} PV. -{1} dégâts.",
                "You: {0} LP. -{1} damage.");
            Add("duel_lp_damage_opp",
                "Adversaire : {0} PV. -{1} dégâts.",
                "Opponent: {0} LP. -{1} damage.");
            Add("duel_lp_gain_you",
                "Vous : {0} PV. +{1} récupérés.",
                "You: {0} LP. +{1} recovered.");
            Add("duel_lp_gain_opp",
                "Adversaire : {0} PV. +{1} récupérés.",
                "Opponent: {0} LP. +{1} recovered.");
            Add("duel_lp_set_you",
                "Vos PV initialisés : {0}.",
                "Your LP set to: {0}.");
            Add("duel_lp_set_opp",
                "PV adversaire initialisés : {0}.",
                "Opponent LP set to: {0}.");
            Add("duel_lp_status",
                "Vos points de vie : {0}. Points de vie adversaire : {1}.",
                "Your life points: {0}. Opponent life points: {1}.");

            // ===== DUEL — TURNS / PHASES =====
            Add("duel_turn_yours",
                "Votre tour.",
                "Your turn.");
            Add("duel_turn_opp",
                "Tour de l'adversaire.",
                "Opponent's turn.");
            Add("duel_turn_yours_n",
                "Votre tour, tour {0}.",
                "Your turn, turn {0}.");
            Add("duel_turn_opp_n",
                "Tour de l'adversaire, tour {0}.",
                "Opponent's turn, turn {0}.");
            Add("duel_phase_draw",
                "Phase de Pioche",
                "Draw Phase");
            Add("duel_phase_standby",
                "Phase de Stand-by",
                "Standby Phase");
            Add("duel_phase_main1",
                "Phase Principale 1",
                "Main Phase 1");
            Add("duel_phase_battle",
                "Phase de Bataille",
                "Battle Phase");
            Add("duel_phase_main2",
                "Phase Principale 2",
                "Main Phase 2");
            Add("duel_phase_end",
                "Phase de Fin",
                "End Phase");
            Add("duel_phase_unknown",
                "Phase {0}",
                "Phase {0}");

            // ===== DUEL — EVENTS =====
            Add("duel_started",
                "Duel commencé !",
                "Duel started!");
            Add("duel_attack",
                "Attaque !",
                "Attack!");
            Add("duel_attack_vs",
                "{0} attaque {1} !",
                "{0} attacks {1}!");
            Add("duel_attack_direct",
                "{0} : attaque directe !",
                "{0}: direct attack!");
            Add("duel_attack_vs_stats",
                "{0} (ATK {1}) attaque {2} (ATK {3}) !",
                "{0} (ATK {1}) attacks {2} (ATK {3})!");
            Add("duel_attack_direct_stats",
                "{0} (ATK {1}) : attaque directe !",
                "{0} (ATK {1}): direct attack!");
            Add("duel_hand_show",
                "L'adversaire montre sa main.",
                "Opponent shows their hand.");
            Add("duel_tribute_summon",
                "Invocation par Tribut !",
                "Tribute Summon!");
            Add("duel_synchro_summon",
                "Invocation Synchro !",
                "Synchro Summon!");
            Add("duel_normal_summon",
                "Monstre invoqué.",
                "Monster summoned.");
            Add("duel_special_summon",
                "Invocation Spéciale !",
                "Special Summon!");
            Add("duel_ritual_summon",
                "Invocation Rituel !",
                "Ritual Summon!");
            Add("duel_pendulum_summon",
                "Invocation Pendule !",
                "Pendulum Summon!");
            Add("duel_maximum_summon",
                "Invocation Maximum !",
                "Maximum Summon!");
            Add("duel_fusion_summon",
                "Invocation par Fusion !",
                "Fusion Summon!");
            Add("duel_summon",
                "Invocation !",
                "Summon!");
            Add("duel_fusion",
                "Fusion !",
                "Fusion!");
            Add("duel_xyz_summon",
                "Invocation Xyz !",
                "Xyz Summon!");
            Add("duel_link_summon",
                "Invocation Lien !",
                "Link Summon!");
            Add("duel_flip_summon",
                "Invocation par Retournement !",
                "Flip Summon!");
            Add("duel_materials_used",
                "Matériaux combinés.",
                "Materials combined.");
            Add("duel_effect_resolved",
                "Effet résolu.",
                "Effect resolved.");
            Add("duel_chain_start",
                "Chaîne démarrée.",
                "Chain started.");
            Add("duel_chain_resolve",
                "Résolution de la chaîne.",
                "Chain resolving.");
            Add("duel_chain_response",
                "Réponse à la chaîne.",
                "Chain response.");
            Add("duel_chain_step",
                "Étape de chaîne.",
                "Chain step.");
            Add("duel_chain_end",
                "Chaîne résolue.",
                "Chain resolved.");
            Add("duel_draw",
                "Pioche.",
                "Draw.");
            Add("duel_activate",
                "Effet activé !",
                "Effect activated!");
            Add("duel_set",
                "Sort/Piège posé.",
                "Spell/Trap set.");
            Add("duel_flip",
                "Retournement !",
                "Flip!");
            Add("duel_turn_end_event",
                "Fin de tour.",
                "End of turn.");
            Add("duel_damage",
                "Dégâts de combat.",
                "Battle damage.");
            Add("duel_destroy",
                "Destruction !",
                "Destroyed!");
            Add("duel_surrender",
                "Abandon.",
                "Surrender.");
            Add("duel_special_win",
                "Victoire par effet spécial !",
                "Special condition win!");
            Add("duel_coin",
                "Lancer de pièce.",
                "Coin toss.");
            Add("duel_dice",
                "Lancer de dé.",
                "Dice roll.");
            Add("duel_janken",
                "Jeu de Pierre-Feuille-Ciseaux.",
                "Rock-Paper-Scissors.");
            Add("duel_cpu_thinking",
                "L'adversaire réfléchit.",
                "Opponent is thinking.");

            // ===== DUEL — END RESULT =====
            Add("duel_end_win",
                "Vous avez gagné !",
                "You win!");
            Add("duel_end_lose",
                "Vous avez perdu.",
                "You lose.");
            Add("duel_end_draw",
                "Match nul.",
                "Draw.");
            Add("duel_end_time",
                "Duel terminé (temps écoulé).",
                "Duel over (time limit).");
            Add("duel_end_generic",
                "Duel terminé.",
                "Duel over.");

            // ===== CARD INFO =====
            Add("card_level",
                "Niveau {0}",
                "Level {0}");
            Add("card_rank",
                "Rang {0}",
                "Rank {0}");
            Add("card_link",
                "Lien {0}",
                "Link {0}");
            Add("card_pendulum_scale",
                "Échelle Pendule {0}",
                "Pendulum Scale {0}");
            Add("card_atk",
                "ATK {0}",
                "ATK {0}");
            Add("card_def",
                "DEF {0}",
                "DEF {0}");
            Add("attr_light",  "Lumière",  "LIGHT");
            Add("attr_dark",   "Ténèbres", "DARK");
            Add("attr_water",  "Eau",      "WATER");
            Add("attr_fire",   "Feu",      "FIRE");
            Add("attr_earth",  "Terre",    "EARTH");
            Add("attr_wind",   "Vent",     "WIND");
            Add("attr_divine", "Divin",    "DIVINE");
            Add("card_not_available",
                "Carte non disponible.",
                "Card not available.");

            // ===== NOMS DE TOUCHES (ShortcutDefinition.GetKeyString) =====
            Add("key_space", "Espace",  "Space");
            Add("key_shift", "Maj",     "Shift");
            Add("key_ctrl",  "Ctrl",    "Ctrl");
            Add("key_alt",   "Alt",     "Alt");
            Add("no_shortcuts_active",
                "Aucun raccourci actif.",
                "No shortcuts active.");

            // ===== DESCRIPTIONS DES RACCOURCIS (ShortcutRegistry.BuildHelpText) =====
            // Clés utilisées par ShortcutDefinition.DescriptionLocKey.
            // Le texte d'aide (F1) est désormais auto-généré par ShortcutRegistry.BuildHelpText().
            Add("shortcut_alt",
                "Lire les infos de la carte focalisée",
                "Read focused card info");
            Add("shortcut_f1",
                "Aide — raccourcis actifs",
                "Help — active shortcuts");
            Add("shortcut_f2",
                "Répéter la dernière annonce",
                "Repeat last announcement");
            Add("shortcut_space",
                "Points de vie",
                "Life points");
            Add("shortcut_shift_space",
                "État du duel (tour, phase, PV)",
                "Duel status (turn, phase, LP)");
            Add("shortcut_shift_f3",
                "Carte suivante en main",
                "Next hand card");
            Add("shortcut_f3",
                "Toutes les cartes en main",
                "All hand cards");
            Add("shortcut_ctrl_f4",
                "Carte suivante sur le terrain",
                "Next field card");
            Add("shortcut_ctrl_shift_f4",
                "Carte suivante sur le terrain adverse",
                "Next opp field card");
            Add("shortcut_ctrl_f7",
                "Cartes bannies adversaires",
                "Opponent banished cards");
            Add("shortcut_ctrl_f8",
                "Taille Extra Deck adverse",
                "Opponent Extra Deck size");
            Add("shortcut_f4",
                "Terrain (votre côté)",
                "Your field cards");
            Add("shortcut_shift_f4",
                "Terrain adverse",
                "Opponent field");
            Add("shortcut_f5",
                "Silence",
                "Silence");
            Add("shortcut_f6",
                "Cimetière",
                "Graveyard");
            Add("shortcut_f7",
                "Cartes bannies",
                "Banished cards");
            Add("shortcut_f8",
                "Extra Deck",
                "Extra Deck");
            Add("shortcut_f9",
                "Cimetière adverse",
                "Opponent graveyard");
            Add("shortcut_f10",
                "Taille des decks",
                "Deck sizes");
            Add("shortcut_f11",
                "Main adverse (nombre)",
                "Opponent hand count");
            Add("shortcut_f12",
                "Historique des annonces",
                "Announcement history");

            // ===== KEYBOARD SHORTCUTS =====
            Add("help_text",
                "Raccourcis clavier : " +
                "Espace : points de vie. " +
                "Maj+Espace : état du duel. " +
                "Alt : informations sur la carte. " +
                "F1 : aide. " +
                "F2 : répéter. " +
                "F3 : cartes en main. " +
                "F4 : cartes sur le terrain. " +
                "Maj+F4 : terrain adverse. " +
                "F5 : silence. " +
                "F6 : cimetière. " +
                "F7 : cartes bannies. " +
                "F8 : extra deck. " +
                "F9 : cimetière adversaire. " +
                "F10 : taille des decks. " +
                "F11 : cartes en main adverse. " +
                "F12 : historique des annonces.",
                "Keyboard shortcuts: " +
                "Space: life points. " +
                "Shift+Space: duel status. " +
                "Alt: card info. " +
                "F1: help. " +
                "F2: repeat. " +
                "F3: hand cards. " +
                "F4: field cards. " +
                "Shift+F4: opponent field. " +
                "F5: silence. " +
                "F6: graveyard. " +
                "F7: banished cards. " +
                "F8: extra deck. " +
                "F9: opponent graveyard. " +
                "F10: deck sizes. " +
                "F11: opponent hand count. " +
                "F12: announcement history.");
            Add("hand_cards",
                "Main ({0} carte{1}) : {2}",
                "Hand ({0} card{1}): {2}");
            Add("hand_empty",
                "Aucune carte en main.",
                "No cards in hand.");
            Add("hand_error",
                "Impossible de lire la main.",
                "Cannot read hand.");
            Add("field_cards",
                "Terrain : {0}",
                "Field: {0}");
            Add("field_empty",
                "Aucune carte sur le terrain.",
                "No cards on the field.");
            Add("field_error",
                "Impossible de lire le terrain.",
                "Cannot read field.");
            Add("grave_cards",
                "Cimetière ({0} carte{1}) : {2}",
                "Graveyard ({0} card{1}): {2}");
            Add("grave_empty",
                "Cimetière vide.",
                "Graveyard empty.");
            Add("grave_error",
                "Impossible de lire le cimetière.",
                "Cannot read graveyard.");
            Add("banished_cards",
                "Cartes bannies ({0} carte{1}) : {2}",
                "Banished cards ({0} card{1}): {2}");
            Add("banished_empty",
                "Aucune carte bannie.",
                "No banished cards.");
            Add("banished_error",
                "Impossible de lire les cartes bannies.",
                "Cannot read banished cards.");
            Add("extra_deck_cards",
                "Extra Deck ({0} carte{1}) : {2}",
                "Extra Deck ({0} card{1}): {2}");
            Add("extra_deck_empty",
                "Extra Deck vide.",
                "Extra Deck is empty.");
            Add("extra_deck_error",
                "Impossible de lire l'Extra Deck.",
                "Cannot read Extra Deck.");
            Add("opp_field_cards",
                "Terrain adverse : {0}",
                "Opponent field: {0}");
            Add("opp_field_empty",
                "Terrain adverse vide.",
                "Opponent field empty.");
            Add("opp_field_error",
                "Impossible de lire le terrain adverse.",
                "Cannot read opponent field.");
            Add("opp_grave_cards",
                "Cimetière adversaire ({0} carte{1}) : {2}",
                "Opponent graveyard ({0} card{1}): {2}");
            Add("opp_grave_empty",
                "Cimetière adversaire vide.",
                "Opponent graveyard empty.");
            Add("opp_grave_error",
                "Impossible de lire le cimetière adversaire.",
                "Cannot read opponent graveyard.");
            Add("opp_banished_cards",
                "Bannies adversaires ({0} carte{1}) : {2}",
                "Opp banished ({0} card{1}): {2}");
            Add("opp_banished_empty",
                "Aucune carte bannie côté adversaire.",
                "Opponent has no banished cards.");
            Add("opp_banished_error",
                "Impossible de lire les bannies adversaires.",
                "Cannot read opponent banished.");
            Add("opp_extra_deck_count",
                "Extra Deck adverse : {0} carte{1}.",
                "Opponent Extra Deck: {0} card{1}.");
            Add("opp_extra_deck_error",
                "Impossible de lire l'Extra Deck adverse.",
                "Cannot read opponent Extra Deck.");
            Add("deck_count",
                "Mon deck : {0} carte{1}. Deck adversaire : {2} carte{3}.",
                "My deck: {0} card{1}. Opponent deck: {2} card{3}.");
            Add("deck_error",
                "Impossible de lire la taille des decks.",
                "Cannot read deck sizes.");
            Add("opp_hand_count",
                "Main adverse : {0} carte{1}.",
                "Opponent hand: {0} card{1}.");
            Add("opp_hand_error",
                "Impossible de lire la main adverse.",
                "Cannot read opponent hand.");
            // ── Navigation carte par carte (Shift+F3, Ctrl+F4, Ctrl+Shift+F4) ──────
            // Format : nom de la carte + position dans la liste (ex. "Dark Magician, 2/5")
            Add("hand_card_nav",
                "{0}, {1} sur {2}",
                "{0}, {1} of {2}");
            Add("field_card_nav",
                "{0}, {1} sur {2}",
                "{0}, {1} of {2}");
            Add("opp_field_card_nav",
                "Adverse : {0}, {1} sur {2}",
                "Opp: {0}, {1} of {2}");
            Add("history_entry",
                "{2} ({0}/{1})",
                "{2} ({0}/{1})");
            Add("history_empty",
                "Historique vide.",
                "History empty.");
            Add("card_face_down",
                " (face cachée)",
                " (face-down)");
            Add("card_face_down_unknown",
                "carte face cachée",
                "face-down card");
            Add("duel_status_yours",
                "Tour {0}, votre tour. Vous : {1} PV, Adversaire : {2} PV.",
                "Turn {0}, your turn. You: {1} LP, Opponent: {2} LP.");
            Add("duel_status_opp",
                "Tour {0}, tour de l'adversaire. Vous : {1} PV, Adversaire : {2} PV.",
                "Turn {0}, opponent's turn. You: {1} LP, Opponent: {2} LP.");
            Add("monster_attack_pos",
                "(Attaque)",
                "(Attack)");
            Add("monster_defense_pos",
                "(Défense)",
                "(Defense)");
            Add("monster_counters",
                "{0} compteur{1}",
                "{0} counter{1}");

            // ── Zones du terrain (inspiré d'AccessibleArena ElementGroup) ──────
            // Correspondance : positions CardRoot → noms de zones lisibles.
            // Position 0-4  = Zone Monstre 1-5  (monster main zones)
            // Position 5-6  = Zone Extra 1-2    (extra monster zones)
            // Position 7-11 = Zone Sort/Piège 1-5 (spell/trap zones)
            // Position 12   = Zone Terrain      (field spell zone)
            Add("zone_monster",   "Zone Monstre {0}",     "Monster Zone {0}");
            Add("zone_extra",     "Zone Extra {0}",       "Extra Zone {0}");
            Add("zone_spelltrap", "Zone Sort/Piège {0}",  "Spell/Trap Zone {0}");
            Add("zone_fieldspell","Zone Terrain",          "Field Spell Zone");
            Add("zone_unknown",   "Zone {0}",              "Zone {0}");
            // Format d'une entrée de carte avec zone : "{zone} : {info carte}"
            Add("field_card_with_zone", "{0} : {1}", "{0}: {1}");

            // ===== BUTTONS — ColorContainerPatch =====
            Add("btn_maintenance",    "Maintenance",                     "Maintenance");
            Add("btn_bug",            "Signaler un problème",            "Report an issue");
            Add("btn_notification",   "Notifications",                   "Notifications");
            Add("btn_input",          "Saisie",                          "Input");
            Add("btn_auto_build",     "Construction automatique",        "Auto-build");
            Add("btn_bookmark_add",   "Ajouter aux favoris",             "Add to bookmarks");
            Add("btn_bookmarks",      "Cartes favorites",                "Bookmarked cards");
            Add("btn_how_to_get",     "Comment obtenir",                 "How to get");
            Add("btn_related_cards",  "Cartes associées",                "Related cards");
            Add("btn_add",            "Ajouter +1",                      "Add +1");
            Add("btn_remove",         "Retirer -1",                      "Remove -1");
            Add("btn_card_list",      "Liste de cartes",                 "Card list");
            Add("btn_card_history",   "Historique de la carte",          "Card history");
            Add("btn_copy_deck",      "Copier le deck",                  "Copy deck");
            Add("btn_save",           "Sauvegarder",                     "Save");
            Add("btn_menu",           "Menu",                            "Menu");
            Add("btn_duel_menu",      "Menu duel",                       "Duel menu");
            Add("btn_show_pack",      "Afficher les cartes du pack",     "Show pack cards");
            Add("btn_secret_pack",    "Pack secret",                     "Secret pack");
            Add("btn_regulation",     "Réglementation",                  "Regulation");
            Add("btn_switch_display", "Changer l'affichage",             "Switch display");
            Add("btn_filters",        "Filtres",                         "Filters");
            Add("btn_sort",           "Trier",                           "Sort");
            Add("btn_clear_filters",  "Effacer les filtres",             "Clear filters");
            Add("btn_sort_asc",       "{0}, de bas en haut",             "{0}, ascending");
            Add("btn_sort_desc",      "{0}, de haut en bas",             "{0}, descending");
            Add("btn_increment",      "Augmenter la quantité",           "Increment quantity");
            Add("btn_decrement",      "Diminuer la quantité",            "Decrement quantity");
            Add("btn_play",           "Jouer",                           "Play");
            Add("btn_ok",             "OK",                              "OK");
            Add("btn_show_owned",     "Afficher les cartes possédées",   "Show owned cards");
            Add("btn_bulk_delete",    "Supprimer les decks en masse",    "Bulk delete decks");
            Add("btn_neuron",         "Lien avec Yu-Gi-Oh Database",     "Link with Yu-Gi-Oh Database");
            Add("tab_my_deck",        "Mon deck",                        "My Deck");
            Add("tab_rental",         "Deck prêté",                      "Loaner Deck");

            // Dismantle / Create
            Add("dismantle_cant",
                "Démanteler (non démantable)",
                "Dismantle (cannot be dismantled)");
            Add("dismantle_cost",
                "Démanteler : {0} CP",
                "Dismantle for: {0} CP");
            Add("create_cost",
                "Créer la carte : {0} CP",
                "Create card for: {0} CP");

            // Chapter duel
            Add("chapter_duel",
                "Duel, {0} étoiles",
                "Duel, {0} stars");

            // DuelListCard
            Add("duel_list_card",
                "Sélection de carte en duel",
                "Duel card selection");

            // ===== SELECTION BUTTON — context processors =====
            Add("friends_add",
                "Ajouter un ami",
                "Add friend");
            Add("event_banner",
                "Bannière d'événement",
                "Event banner");
            Add("profile_level",
                "{0}, niveau {1}",
                "{0}, level {1}");
            Add("duel_field_card_selected",
                "Carte sélectionnée sur le terrain",
                "Card selected on field");
            Add("new_deck",
                "Nouveau deck",
                "New deck");
            Add("deck_rename",
                "Renommer le deck",
                "Rename deck");
            Add("deck_auto_build",
                "Construction automatique",
                "Auto-build");
            Add("deck_category",
                "{0}, catégorie : {1}",
                "{0}, category: {1}");
            Add("mission_info",
                "{0}\nRécompense : {1}\nTemps restant : {2}",
                "{0}\nReward: {1}\nTime left: {2}");
            Add("duelpass_info",
                "{0} pass, grade {1}, quantité : {2}",
                "{0} pass, grade {1}, quantity: {2}");
            Add("duelpass_normal",
                "Normal",
                "Normal");
            Add("duelpass_gold",
                "Gold",
                "Gold");
            Add("notification_status",
                "\nStatut : {0}",
                "\nStatus: {0}");

            // ===== SHOP — PACK BROWSER =====
            Add("shop_pack_info",
                "{0}\nCatégorie : {1}\nExpire : {2}\nPrix : {3}",
                "{0}\nCategory: {1}\nExpires: {2}\nPrice: {3}");
            Add("shop_no_limit",
                "Aucune limite",
                "No limit");

            // ===== SHOP — CARD PACK (opening) =====
            Add("card_pack_entry",
                "Rareté : {0}. Nouveau : {1}. Possédé : {2}",
                "Rarity: {0}. New: {1}. Owned: {2}");
            Add("rarity_normal",  "Normale",    "Normal");
            Add("rarity_rare",    "Rare",       "Rare");
            Add("rarity_super",   "Super Rare", "Super Rare");
            Add("rarity_ultra",   "Ultra Rare", "Ultra Rare");
            Add("yes",            "Oui",        "Yes");
            Add("no",             "Non",        "No");

            // ===== SETTINGS =====
            Add("settings_slider",
                "{0}\nValeur : {1} sur {2}",
                "{0}\nValue: {1} of {2}");
            Add("settings_mode",
                "{0} : {1}",
                "{0}: {1}");

            // ===== GENERAL MENU NAVIGATOR =====
            Add("nav_position",
                ", {0} sur {1}",
                ", {0} of {1}");

            // ===== DUEL — MENU COMMANDES =====
            Add("cmd_menu",
                "Actions : {0}",
                "Actions: {0}");
            Add("cmd_attack",    "Attaquer",              "Attack");
            Add("cmd_action",    "Activer l'effet",       "Activate Effect");
            Add("cmd_summon_sp", "Invoquer (spéciale)",   "Special Summon");
            Add("cmd_summon",    "Invoquer",              "Normal Summon");
            Add("cmd_reverse",   "Retourner",             "Flip");
            Add("cmd_set_monst", "Poser le monstre",      "Set Monster");
            Add("cmd_set",       "Poser sort/piège",      "Set Spell/Trap");
            Add("cmd_pendulum",  "Pendule",               "Pendulum");
            Add("cmd_turn_atk",  "Mode Attaque",          "Attack Position");
            Add("cmd_turn_def",  "Mode Défense",          "Defense Position");
            Add("cmd_surrender", "Abandonner",            "Surrender");
            Add("cmd_look",      "Voir",                  "View");

            // ===== TOPICS / BANNER =====
            Add("topic_banner",
                "Actualité, page {0}",
                "News, page {0}");

            // ===== DUEL MODE BUTTON =====
            Add("duel_mode_complete",
                "{0}, complété : {1}",
                "{0}, completed: {1}");

            // ===== MATCHMAKING =====
            Add("match_searching",
                "Recherche d'un adversaire en cours…",
                "Searching for an opponent…");
            Add("match_found",
                "Adversaire trouvé ! Préparation du duel.",
                "Opponent found! Preparing duel.");
            Add("match_timeout",
                "Délai de recherche dépassé.",
                "Search timed out.");

            // ===== DECK EDITOR =====
            Add("deck_card_added",
                "{0} ajoutée au deck.",
                "{0} added to deck.");
            Add("deck_card_removed",
                "{0} retirée du deck.",
                "{0} removed from deck.");
            Add("deck_editing",
                "Édition du deck : {0}.",
                "Editing deck: {0}.");
            Add("deck_renamed",
                "Deck renommé : {0}.",
                "Deck renamed: {0}.");
            Add("deck_saved",
                "Deck sauvegardé.",
                "Deck saved.");
            Add("deck_saved_named",
                "Deck \"{0}\" sauvegardé.",
                "Deck \"{0}\" saved.");

            // ===== DECK SELECT (avant duel) =====
            Add("deck_select_focus",
                "Deck sélectionné : {0}",
                "Selected deck: {0}");

            // ===== CARD CRAFT (création / démantèlement) =====
            Add("craft_create",
                "Créer : {0}",
                "Create: {0}");
            Add("craft_boost_create",
                "Création boostée : {0}",
                "Boost create: {0}");
            Add("craft_dismantle",
                "Démanteler : {0}",
                "Dismantle: {0}");
            Add("craft_result_generic",
                "Carte fabriquée : {0}",
                "Card crafted: {0}");

            // ===== DÉ / PILE-FACE (LatePatches — DuelView) =====
            Add("dice_you",
                "vous",
                "you");
            Add("dice_opponent",
                "l'adversaire",
                "opponent");
            Add("dice_result",
                "Dé : {0} obtient {1}",
                "Dice: {0} rolls {1}");
            Add("coin_heads",
                "pile",
                "heads");
            Add("coin_tails",
                "face",
                "tails");
            Add("coin_result",
                "Pile ou face : {0} obtient {1}",
                "Coin flip: {0} gets {1}");

            // ===== MULLIGAN =====
            Add("mulligan_open",
                "Mulligan : {0} cartes en main. Garder ou remplacer ?",
                "Mulligan: {0} cards in hand. Keep or replace?");

            // ===== RÉSULTAT DE DUEL =====
            Add("duel_win",
                "Victoire !",
                "Victory!");
            Add("duel_lose",
                "Défaite.",
                "Defeat.");
            Add("duel_draw",
                "Égalité.",
                "Draw.");

            // ===== SHOP =====
            Add("shop_opened",
                "Boutique ouverte.",
                "Shop opened.");

            // ===== DIALOG DUEL (DialogStatePatch) =====
            Add("dialog_opened",
                "{0}",        // Le nom du type de dialog est passé — pas de préfixe superflu
                "{0}");
            Add("choice_first_player_dialog",
                "Choix du premier joueur.",
                "Choosing first player.");

            // ===== VUES / ÉCRANS (ViewControllerPatch.Show_Postfix) =====
            Add("view_opened",
                "{0}",        // Nom du ViewController — déjà localisé par le jeu
                "{0}");

            // ===== TITRES D'ÉCRANS (ViewControllerPatch.ScreenTitles) =====
            Add("screen_home",          "Accueil",              "Home");
            Add("screen_duel",          "Duel",                 "Duel");
            Add("screen_deck",          "Decks",                "Decks");
            Add("screen_solo",          "Solo",                 "Solo");
            Add("screen_shop",          "Boutique",             "Shop");
            Add("screen_missions",      "Missions",             "Missions");
            Add("screen_notifications", "Notifications",        "Notifications");
            Add("screen_settings",      "Paramètres",           "Settings");
            Add("screen_duel_pass",     "Duel Pass",            "Duel Pass");
            Add("screen_deck_edit",     "Éditeur de deck",      "Deck Editor");
            Add("screen_deck_browser",  "Navigateur de decks",  "Deck Browser");
            Add("screen_card_browser",  "Navigateur de cartes", "Card Browser");
            Add("screen_matching",      "Recherche de duel",    "Matchmaking");
            Add("screen_deck_select",   "Sélection de deck",    "Deck Selection");

            // ===== CHAMPS DE TEXTE (InputFieldPatch) =====
            Add("input_focused",
                "{0} — vide",
                "{0} — empty");
            Add("input_focused_with_content",
                "{0} — {1}",
                "{0} — {1}");
            Add("input_exited",
                "Champ de texte quitté.",
                "Exited text field.");
            Add("input_field_generic",
                "Champ de texte",
                "Text field");

            // ===== CASES À COCHER / INTERRUPTEURS (TogglePatch) =====
            Add("toggle_on",    "Activé",   "On");
            Add("toggle_off",   "Désactivé","Off");
            Add("toggle_state",
                "{0} : {1}",
                "{0}: {1}");

            // ===== NAVIGATION — LIMITES DE LISTE (SelectionButtonPatch) =====
            Add("nav_boundary",
                "Limite de la liste.",
                "End of list.");

            // ===== CARD SELECTION LIST (CardSelectionListPatch) =====
            Add("card_sel_list_open",
                "Sélection de carte — {0} : {1} carte{2} disponible{2}.",
                "Card selection — {0}: {1} card{2} available.");
            Add("card_sel_list_open_nocount",
                "Sélection de carte — {0}.",
                "Card selection — {0}.");
            Add("card_sel_cursor",
                "{0}, {1} sur {2}",
                "{0}, {1} of {2}");

            // Types de liste
            Add("sel_type_summon",         "Invocation",              "Summon");
            Add("sel_type_spsummon",       "Invocation Spéciale",     "Special Summon");
            Add("sel_type_monster_effect", "Effet de monstre",        "Monster Effect");
            Add("sel_type_magic_trap",     "Sort ou Piège",           "Spell or Trap");
            Add("sel_type_flip",           "Retournement",            "Flip");
            Add("sel_type_attack",         "Attaque",                 "Attack");
            Add("sel_type_chain",          "Chaîne",                  "Chain");
            Add("sel_type_check_timing",   "Vérification du timing",  "Check Timing");
            Add("sel_type_normal",         "Sélection normale",       "Normal Selection");
            Add("sel_type_selection",      "Sélection de carte",      "Card Selection");
            Add("sel_type_grave",          "Cimetière",               "Graveyard");
            Add("sel_type_extra",          "Extra Deck",              "Extra Deck");
            Add("sel_type_deck",           "Deck",                    "Deck");
            Add("sel_type_opp_hand",       "Main adverse",            "Opponent Hand");
            Add("sel_type_generic",        "Sélection",               "Selection");

            // ===== DUEL TIMER (DuelTimerPatch) =====
            Add("timer_warning_60",
                "Attention : 60 secondes restantes.",
                "Warning: 60 seconds remaining.");
            Add("timer_warning_30",
                "Attention : 30 secondes — fin de tour imminente.",
                "Warning: 30 seconds — turn ending soon.");
            Add("timer_warning_10",
                "URGENT : 10 secondes !",
                "URGENT: 10 seconds!");
            Add("timer_duel_warning_120",
                "Attention : 2 minutes restantes dans le duel.",
                "Warning: 2 minutes remaining in the duel.");
            Add("timer_duel_warning_60",
                "Attention : 1 minute restante dans le duel.",
                "Warning: 1 minute remaining in the duel.");
            Add("timer_duel_warning_30",
                "URGENT : 30 secondes dans le duel !",
                "URGENT: 30 seconds in the duel!");

            // ===== CARD REPORT TELOP (CardReportTelopPatch) =====
            Add("card_report_telop",
                "{0} : {1}",
                "{0}: {1}");

            // ===== MODE SOLO (MenuMiscPatch) =====
            Add("solo_mode_opened",
                "Mode Solo.",
                "Solo Mode.");
        }

        // ── WithVerbose helper (pattern Strings.cs WithDetail) ─────────────────

        /// <summary>
        /// Indique si le mode verbeux est actif (annonces détaillées).
        /// Lit la ConfigEntry BepInEx "verbose_announcements".
        /// Valeur par défaut : true (comportement existant inchangé).
        /// </summary>
        public static bool Verbose
        {
            get
            {
                try
                {
                    return Plugin.Instance?.CfgVerbose?.Value ?? true;
                }
                catch { return true; }
            }
        }

        /// <summary>
        /// Concatène un détail optionnel à un message principal si le mode verbeux est actif.
        /// Utilisation : Loc.WithVerbose(core, detail)
        /// Inspiré de Strings.cs.WithDetail(core, detail).
        /// </summary>
        public static string WithVerbose(string core, string detail)
            => Verbose && !string.IsNullOrWhiteSpace(detail) ? $"{core}. {detail}" : core;

        #endregion
    }
}

