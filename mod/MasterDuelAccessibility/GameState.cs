namespace MasterDuelAccessibility
{
    /// <summary>
    /// Shared state between all patches.
    /// Tracks the current active menu for contextual announcements.
    /// </summary>
    internal static class GameState
    {
        public enum Menu
        {
            None,
            Duel,
            Deck,
            Solo,
            Shop,
            Missions,
            Notifications,
            Settings,
            DuelPass,
            CardBrowser, // Navigateur de cartes (recherche/filtres)
        }

        /// <summary>Currently displayed menu.</summary>
        internal static Menu CurrentMenu = Menu.None;

        /// <summary>
        /// Numéro du tour en cours (incrémenté par PhasePatch.TurnChange_Postfix,
        /// réinitialisé à 0 par DuelEventPatch.DuelStart_Postfix).
        /// </summary>
        internal static int CurrentTurn = 0;

        /// <summary>
        /// Libellé localisé de la phase en cours (ex. "Phase Principale 1").
        /// Mis à jour par PhasePatch.PhaseChange_Postfix.
        /// Chaîne vide tant que le premier changement de phase n'a pas eu lieu.
        /// </summary>
        internal static string CurrentPhaseLabel = "";

        /// <summary>
        /// Joueur dont c'est le tour : 0 = joueur local, 1 = adversaire.
        /// Mis à jour par PhasePatch.TurnChange_Postfix.
        /// </summary>
        internal static int CurrentPlayer = 0;

        /// <summary>
        /// ViewController names that identify each top-level menu.
        /// Matching VCs trigger an announcement AND set the menu context.
        /// Key = logical VC name (suffix stripped by SafeGetName).
        /// </summary>
        internal static readonly System.Collections.Generic.Dictionary<string, Menu> MenuNames =
            new System.Collections.Generic.Dictionary<string, Menu>
        {
            { "DUEL",          Menu.Duel          },
            { "DECK",          Menu.Deck          },
            { "SOLO",          Menu.Solo          },
            { "SHOP",          Menu.Shop          },
            { "MISSION",       Menu.Missions      },
            { "Notifications", Menu.Notifications },
            { "Game Settings", Menu.Settings      },
            { "Duel Pass",     Menu.DuelPass      },
        };

        /// <summary>
        /// Sub-screen ViewController names that inherit a menu context without triggering
        /// a new announcement (announcement is handled by ViewControllerPatch.Show_Postfix).
        /// </summary>
        internal static readonly System.Collections.Generic.Dictionary<string, Menu> VcMenuContextMap =
            new System.Collections.Generic.Dictionary<string, Menu>
        {
            { "SoloMode",             Menu.Solo        },
            { "SoloGate",             Menu.Solo        },
            { "SoloSelectChapter",    Menu.Solo        },
            { "DeckEdit",             Menu.Deck        },
            { "DeckBrowser",          Menu.Deck        },
            { "DeckSelect",           Menu.Deck        },
            { "CardBrowser",          Menu.CardBrowser },
            { "ShopBuy",              Menu.Shop        },
            { "LotteryPortal",        Menu.Shop        },
            { "PvpMenuMatching",      Menu.Duel        },
            { "PvpMenuMatching_Room", Menu.Duel        },
            { "PvpMenuMatching_Team", Menu.Duel        },
            // Colosseum sub-screens inherit Duel context
            { "ColosseumStart",          Menu.Duel },
            { "ColosseumInfo",           Menu.Duel },
            { "ColosseumHistory",        Menu.Duel },
            { "ColosseumRanking",        Menu.Duel },
            { "ColosseumReward",         Menu.Duel },
            { "ColosseumSelectVersus",   Menu.Duel },
            // TDY sub-screens inherit Duel context
            { "TDYMap",                  Menu.Duel },
            { "TdyResult",               Menu.Duel },
            // Certification sub-screens (no top-level menu key; treat as None-derived)
            { "CertificationConfirm",         Menu.None },
            { "CertificationDetail",          Menu.None },
            { "CertificationExplanation",     Menu.None },
            { "CertificationDuelFieldDialog", Menu.None },
            { "CertificationWriting",         Menu.None },
            { "CertificationWritingReslut",   Menu.None },
        };

        /// <summary>
        /// ViewController names for overlays/dialogs that should preserve the current
        /// menu context when focused (they sit on top of the active screen).
        /// </summary>
        internal static readonly System.Collections.Generic.HashSet<string> VcKeepContextNames =
            new System.Collections.Generic.HashSet<string>(System.StringComparer.OrdinalIgnoreCase)
        {
            "FilterSelect", "SortDialog_Card", "SortDialog_CardFile", "SortDialog_Solo",
            "PasswordDialog", "SystemDialog", "CommonDialog", "ActionSheet",
        };

        internal static string MenuLabel(Menu m) => m switch
        {
            Menu.Duel          => Loc.Get("menu_duel"),
            Menu.Deck          => Loc.Get("menu_deck"),
            Menu.Solo          => Loc.Get("menu_solo"),
            Menu.Shop          => Loc.Get("menu_shop"),
            Menu.Missions      => Loc.Get("menu_missions"),
            Menu.Notifications => Loc.Get("menu_notifications"),
            Menu.Settings      => Loc.Get("menu_settings"),
            Menu.DuelPass      => Loc.Get("menu_duelpass"),
            Menu.CardBrowser   => Loc.Get("menu_card_browser"),
            _                  => string.Empty,
        };
    }
}
