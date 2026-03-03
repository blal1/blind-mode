namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour ViewController :
    ///   - OnFocusChanged(bool setfocus) : détecte l'entrée dans un menu principal
    ///     et annonce son nom. Met à jour GameState.CurrentMenu.
    ///   - OnBack() : réinitialise le menu quand on revient à l'écran Home.
    ///
    /// Les noms de ViewController correspondant aux menus sont définis dans
    /// GameState.MenuNames (ex. "DUEL", "DECK", "SHOP"...).
    /// </summary>
    internal static class ViewControllerPatch
    {
        // Cache pour éviter de ré-annoncer le même écran lors de redraws UI
        private static string _lastAnnouncedView = "";
        private static System.DateTime _lastAnnouncedAt = System.DateTime.MinValue;
        private static readonly System.TimeSpan ViewAnnounceCooldown = System.TimeSpan.FromSeconds(1.5);

        /// <summary>
        /// Mappe les noms de ViewController (lus via réflexion) vers des clés de localisation.
        /// Inspiré de Strings.cs AccessibleArena : ScreenDecks, ScreenProfile, ScreenStore...
        /// Noms inconnus sont annoncés tels quels (fallback).
        /// </summary>
        private static readonly System.Collections.Generic.Dictionary<string, string> ScreenTitles =
            new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
        {
            // Menus principaux (aussi couverts par OnFocusChanged via GameState.MenuNames)
            { "DUEL",            "screen_duel"        },
            { "DECK",            "screen_deck"        },
            { "SOLO",            "screen_solo"        },
            { "SHOP",            "screen_shop"        },
            { "MISSION",         "screen_missions"    },
            { "Notifications",   "screen_notifications" },
            { "Game Settings",   "screen_settings"    },
            { "Duel Pass",       "screen_duel_pass"   },
            // Vues secondaires
            { "DeckBrowser",          "screen_deck_browser"  },
            { "DeckEdit",             "screen_deck_edit"     },
            { "CardBrowser",          "screen_card_browser"  },
            { "PvpMenuMatching",      "screen_matching"      },
            { "Home",                 "screen_home"          },
            { "DeckSelect",           "screen_deck_select"   },
        };

        /// <summary>Résout un nom de ViewController en libellé lisible via Loc.</summary>
        private static string ResolveName(string vcName)
        {
            if (ScreenTitles.TryGetValue(vcName, out var key))
                return Loc.Get(key);
            return vcName; // fallback : nom brut
        }
        // Postfix pour : ViewController.OnFocusChanged(bool setfocus)
        public static void OnFocusChanged_Postfix(object __instance, bool setfocus)
        {
            if (!setfocus) return; // on ignore la perte de focus

            try
            {
                var nameProp = __instance.GetType()
                    .GetProperty("name",
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.Instance);
                string? vcName = nameProp?.GetValue(__instance)?.ToString();
                if (string.IsNullOrEmpty(vcName)) return;

                if (GameState.MenuNames.TryGetValue(vcName, out var menu))
                {
                    GameState.CurrentMenu = menu;
                    // Utiliser le titre lisible plutôt que le label brut du menu
                    string label = ResolveName(vcName);
                    if (!string.IsNullOrEmpty(label))
                        Plugin.Instance?.Tts?.Speak(label, interrupt: false);
                }
            }
            catch { /* réflexion silencieuse */ }
        }

        // Postfix pour : ViewController.OnBack()
        public static void OnBack_Postfix(object __instance)
        {
            try
            {
                // Vérifie si on est revenu à l'écran Home
                var managerProp = __instance.GetType()
                    .GetProperty("manager",
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.Instance);
                var manager = managerProp?.GetValue(__instance);
                if (manager == null) return;

                var getFocusMethod = manager.GetType().GetMethod(
                    "GetFocusViewController",
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.Instance,
                    null,
                    new[] { typeof(bool) },
                    null);
                var focusVc = getFocusMethod?.Invoke(manager, new object[] { false });
                if (focusVc == null) return;

                var nameProp = focusVc.GetType()
                    .GetProperty("name",
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.Instance);
                string? focusName = nameProp?.GetValue(focusVc)?.ToString();

                if (focusName == "Home")
                    GameState.CurrentMenu = GameState.Menu.None;
            }
            catch { /* réflexion silencieuse */ }
        }
        /// <summary>
        /// Postfix pour ViewController.Show() ou ShowUI().
        /// Annonce l'ouverture d'un écran/vue au lecteur d'écran.
        ///
        /// Inspiré de PanelStatePatch.ShowPostfix dans AccessibleArena MTGA :
        ///   - Lit le nom du ViewController pour identifier l'écran
        ///   - Ignore les vues déjà annoncées récemment (cooldown 1.5 s)
        ///   - Ignore les vues dont le nom est vide ou correspond à un menu déjà géré
        ///     par ViewControllerPatch.OnFocusChanged_Postfix.
        /// </summary>
        public static void Show_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var nameProp = __instance.GetType()
                    .GetProperty("name",
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.Instance);
                string? vcName = nameProp?.GetValue(__instance)?.ToString();
                if (string.IsNullOrEmpty(vcName)) return;

                // Ignorer les vues qui correspondent à un menu principal —
                // elles sont déjà annoncées par OnFocusChanged_Postfix.
                if (GameState.MenuNames.ContainsKey(vcName)) return;

                // Utiliser le titre lisible depuis le dictionnaire
                string friendly = ResolveName(vcName);

                // Ignorer les vues déjà annoncées récemment (cooldown)
                var now = System.DateTime.Now;
                if (vcName == _lastAnnouncedView && now - _lastAnnouncedAt < ViewAnnounceCooldown)
                    return;

                _lastAnnouncedView = vcName;
                _lastAnnouncedAt   = now;

                // Annoncer l'ouverture de la vue avec faible priorité
                tts.Speak(Loc.Get("view_opened", friendly), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }
    }
}
