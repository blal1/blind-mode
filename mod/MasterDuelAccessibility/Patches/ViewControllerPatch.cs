using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

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

        /// <summary>Raw VC name last announced — used by F3 shortcut to repeat current screen.</summary>
        internal static string LastRawView => _lastAnnouncedView;

        /// <summary>Resolves a raw VC name to a human-readable label (public for KeyboardShortcuts).</summary>
        internal static string GetResolvedName(string rawName) => ResolveName(rawName);
        private static readonly System.TimeSpan ViewAnnounceCooldown = System.TimeSpan.FromSeconds(1.5);

        /// <summary>
        /// Mappe les noms de ViewController (lus via réflexion) vers des clés de localisation.
        /// Inspiré de Strings.cs AccessibleArena : ScreenDecks, ScreenProfile, ScreenStore...
        /// Noms inconnus sont annoncés tels quels (fallback).
        /// </summary>
        private static readonly System.Collections.Generic.Dictionary<string, string> ScreenTitles =
            new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
        {
            // ── Menus principaux (aussi couverts par OnFocusChanged via GameState.MenuNames) ──
            { "DUEL",            "screen_duel"        },
            { "DECK",            "screen_deck"        },
            { "SOLO",            "screen_solo"        },
            { "SHOP",            "screen_shop"        },
            { "MISSION",         "screen_missions"    },
            { "Notifications",   "screen_notifications" },
            { "Game Settings",   "screen_settings"    },
            { "Duel Pass",       "screen_duel_pass"   },
            // ── Navigation decks / cartes ────────────────────────────────────
            { "DeckBrowser",          "screen_deck_browser"  },
            { "DeckEdit",             "screen_deck_edit"     },
            { "CardBrowser",          "screen_card_browser"  },
            { "DeckSelect",           "screen_deck_select"   },
            // ── PvP / Matchmaking ─────────────────────────────────────────────
            { "PvpMenuMatching",      "screen_matching"      },
            { "PvpMenuMatching_Room", "screen_matching_room" },
            { "PvpMenuMatching_Team", "screen_matching_team" },
            // ── Accueil ───────────────────────────────────────────────────────
            { "Home",                 "screen_home"          },
            // ── Boutique / Packs ──────────────────────────────────────────────
            { "ShopBuy",              "screen_shop_buy"      },
            { "LotteryPortal",        "screen_lottery"       },
            { "LotteryResult",        "screen_lottery_result"},
            { "LotteryHistory",       "screen_lottery_history"},
            { "LotteryCardSelect",    "screen_lottery_card_select"},
            { "LotteryRewardView",    "screen_lottery_reward"},
            // ── Récompenses / Boîte cadeaux ───────────────────────────────────
            { "PresentBox",           "screen_present_box"   },
            // ── Profil / Social ───────────────────────────────────────────────
            { "Profile",              "screen_profile"       },
            { "ProfileData",          "screen_profile"       },
            { "ProfileEdit",          "screen_profile_edit"  },
            { "ProfileCardCheck",     "screen_profile_cards" },
            { "ProfileReplay",        "screen_profile_replay"},
            { "Friend",               "screen_friends"       },
            { "FriendSearch",         "screen_friends_search"},
            // ── Solo / Scénario ───────────────────────────────────────────────
            { "SoloGate",             "screen_solo_gate"     },
            { "SoloSelectChapter",    "screen_solo_chapter"  },
            // ── Saison ───────────────────────────────────────────────────────
            { "SeasonPoint",          "screen_season_ranking"},
            { "SeasonPointHistory",   "screen_season_history"},
            { "SeasonPointRanking",   "screen_season_ranking"},
            { "SeasonPointTopMenu",   "screen_season_ranking"},
            { "SeasonResult",         "screen_season_result" },
            // ── Échange d'objets ─────────────────────────────────────────────
            { "ItemExchange",         "screen_item_exchange" },
            // ── Colosseum ────────────────────────────────────────────────────
            { "ColosseumDuelResult",  "screen_colosseum_result" },
            { "WCSFinal_Colosseum",   "screen_colosseum"     },
            // ── Tri / Filtres ─────────────────────────────────────────────────
            { "SortDialog_Card",      "screen_sort_card"     },
            { "SortDialog_CardFile",  "screen_sort_cardfile" },
            { "SortDialog_Solo",      "screen_sort_solo"     },
            { "FilterSelect",         "screen_filter_select" },
            // ── Divers ────────────────────────────────────────────────────────
            { "PasswordDialog",       "screen_password"      },
        };

        // Suffixes à supprimer du nom brut du ViewController (fallback)
        private static readonly string[] _vcSuffixes =
            { "ViewController", "Dialog", "Widget" };

        /// <summary>
        /// Résout un nom de ViewController en libellé lisible.
        ///
        /// 1. Si le nom est dans ScreenTitles → retourne le libellé localisé.
        /// 2. Sinon, nettoyage automatique du nom brut :
        ///    a. Supprime les suffixes connus (ViewController, Dialog, Widget).
        ///    b. Sépare les mots en PascalCase par des espaces.
        ///       ex. "LotteryPortalViewController" → "Lottery Portal"
        ///       ex. "WCSProfile" → "WCS Profile"
        /// </summary>
        private static string ResolveName(string vcName)
        {
            if (ScreenTitles.TryGetValue(vcName, out var key))
                return Loc.Get(key);

            // Nettoyage automatique : supprime les suffixes connus
            string clean = vcName;
            foreach (var suffix in _vcSuffixes)
            {
                if (clean.Length > suffix.Length &&
                    clean.EndsWith(suffix, System.StringComparison.Ordinal))
                {
                    clean = clean.Substring(0, clean.Length - suffix.Length);
                    break;
                }
            }

            // Sépare PascalCase en mots :
            //   (?<=[a-z])(?=[A-Z])          "LotteryPortal" → "Lottery Portal"
            //   (?<=[A-Z])(?=[A-Z][a-z])     "WCSProfile"    → "WCS Profile"
            clean = System.Text.RegularExpressions.Regex.Replace(
                clean,
                @"(?<=[a-z])(?=[A-Z])|(?<=[A-Z])(?=[A-Z][a-z])",
                " ");

            return clean; // ex: "Lottery Portal", "WCS Profile", "Present Box"
        }
        /// <summary>
        /// Safely resolves the ViewController name from its instance.
        ///
        /// CRASH ROOT CAUSE (ErrorLog.log):
        ///   UnityEngine.Object.get_name() → il2cpp_runtime_invoke → AccessViolationException (FATAL)
        ///   This happens when the native IL2CPP object backing the VC has been partially freed
        ///   while the managed wrapper still exists (Unity 6 timing issue).
        ///
        /// FIX:
        ///   Instead of calling .name (native call through IL2CPP), we read the C# type name
        ///   of the managed wrapper. For YgomSystem.UI.ViewController subclasses, the type name
        ///   IS the ViewController identity (e.g. "DeckEditViewController2", "SoloModeViewController").
        ///   This is a pure .NET reflection call — zero native IL2CPP involvement, cannot crash.
        ///
        ///   We strip known suffixes ("ViewController2","ViewController","Dialog","Widget")
        ///   to get the logical name used in ScreenTitles and GameState.MenuNames.
        ///
        /// FALLBACK: if the type name ends with a numeric suffix we strip it too
        ///   (e.g. "DeckSelectViewController2" → "DeckSelect").
        /// </summary>
        private static string? SafeGetName(object instance)
        {
            if (instance == null) return null;
            try
            {
                // Primary: IL2CPP safety check (managed-side, no native call)
                if (instance is Il2CppObjectBase il2cppObj)
                {
                    if (il2cppObj.WasCollected || il2cppObj.Pointer == IntPtr.Zero)
                        return null;
                }

                // Read the C# type name — pure .NET, cannot trigger AccessViolationException
                string typeName = instance.GetType().Name;
                if (string.IsNullOrEmpty(typeName)) return null;

                // Strip common suffixes to get the logical VC name
                // Order matters: "ViewController2" before "ViewController"
                string[] suffixes = { "ViewController2", "ViewController", "Dialog", "Widget" };
                foreach (var s in suffixes)
                {
                    if (typeName.EndsWith(s, StringComparison.Ordinal))
                    {
                        typeName = typeName.Substring(0, typeName.Length - s.Length);
                        break;
                    }
                }

                return string.IsNullOrEmpty(typeName) ? null : typeName;
            }
            catch
            {
                return null;
            }
        }

        // Postfix pour : ViewController.OnFocusChanged(bool setfocus)
        public static void OnFocusChanged_Postfix(object __instance, bool setfocus)
        {
            if (!setfocus) return; // on ignore la perte de focus

            try
            {
                string? vcName = SafeGetName(__instance);
                if (string.IsNullOrEmpty(vcName)) return;

                if (GameState.MenuNames.TryGetValue(vcName, out var menu))
                {
                    GameState.CurrentMenu = menu;
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
                var managerProp = __instance.GetType()
                    .GetProperty("manager", BindingFlags.Public | BindingFlags.Instance);
                var manager = managerProp?.GetValue(__instance);
                if (manager == null) return;

                var getFocusMethod = manager.GetType().GetMethod(
                    "GetFocusViewController",
                    BindingFlags.Public | BindingFlags.Instance,
                    null,
                    new[] { typeof(bool) },
                    null);
                var focusVc = getFocusMethod?.Invoke(manager, new object[] { false });
                if (focusVc == null) return;

                string? focusName = SafeGetName(focusVc);
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
                string? vcName = SafeGetName(__instance);
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
