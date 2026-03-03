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
        /// ViewController names that identify each menu.
        /// Key = GameObject name of the ViewController.
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
            _                  => string.Empty,
        };
    }
}
