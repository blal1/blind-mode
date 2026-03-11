using System;
using System.Collections.Generic;

namespace MasterDuelAccessibility.Services.PanelDetection
{
    /// <summary>
    /// Types de panneaux dans l'UI de Master Duel.
    /// Adapté de AccessibleArena.Core.Services.PanelDetection.PanelType.
    ///
    /// Dans Master Duel, tous les panneaux sont des ViewControllers (pas de CanvasGroup alpha-fade
    /// ni de IsOpen property standard), donc on se base sur le nom de classe pour classifier.
    /// </summary>
    public enum PanelType
    {
        /// <summary>Aucun panneau actif.</summary>
        None = 0,

        /// <summary>
        /// Dialogs de duel ou de menu : CommonDialogViewController, DuelOkDialog,
        /// DuelInfoDialog, ChoiceFirstPlayerDialog, DuelResultDialog, DuelMulliganDialog, etc.
        /// Priorité maximale — bloquent la navigation.
        /// </summary>
        Dialog = 1,

        /// <summary>
        /// Paramètres du jeu (SettingsViewController).
        /// Overlay modal qui filtre la navigation.
        /// </summary>
        Settings = 2,

        /// <summary>
        /// Panneaux de progression / bonus rapides :
        /// LoginBonusViewController, PresentBoxViewController, SeasonResultViewController,
        /// DuelPassRewardListViewController.
        /// Interrompent le flux normal avec une priorité haute.
        /// </summary>
        Reward = 3,

        /// <summary>
        /// Menu contextuel (ActionSheetViewController).
        /// Overlay court, priorité moyenne.
        /// </summary>
        ActionSheet = 4,

        /// <summary>
        /// Dialogs de tri (SortDialogViewController_*).
        /// Overlay léger.
        /// </summary>
        SortDialog = 5,

        /// <summary>
        /// Panneaux de recherche et de profil social :
        /// FriendSearchViewController, ProfileViewController, etc.
        /// </summary>
        Social = 6,

        /// <summary>
        /// Saisie de texte / code promo (PromoCodesViewController, InputFieldPatch targets).
        /// </summary>
        Input = 7,

        /// <summary>
        /// Tout autre ViewController non classifié (fallback).
        /// Panneau de contenu normal (ne filtre pas la navigation).
        /// </summary>
        ContentPanel = 99,
    }

    /// <summary>
    /// Fournit les métadonnées statiques par type de panneau.
    /// </summary>
    internal static class PanelTypeMeta
    {
        /// <summary>
        /// Priorité pour le tri de la stack. Plus grand = plus au premier plan.
        /// Dialog (1000) > Settings (500) > Reward (400) > ActionSheet (300) > Social (200) > Input (150) > SortDialog (100) > ContentPanel (10)
        /// </summary>
        public static int GetPriority(PanelType type) => type switch
        {
            PanelType.Dialog      => 1000,
            PanelType.Settings    => 500,
            PanelType.Reward      => 400,
            PanelType.ActionSheet => 300,
            PanelType.Social      => 200,
            PanelType.Input       => 150,
            PanelType.SortDialog  => 100,
            PanelType.ContentPanel => 10,
            _                     => 0,
        };

        /// <summary>
        /// Indique si ce type de panneau doit filtrer la navigation (modal overlay).
        /// Vrai pour les overlays qui bloquent l'accès aux éléments sous-jacents.
        /// </summary>
        public static bool FiltersNavigation(PanelType type) => type switch
        {
            PanelType.Dialog      => true,
            PanelType.Settings    => true,
            PanelType.Reward      => true,
            PanelType.ActionSheet => true,
            PanelType.SortDialog  => true,
            PanelType.Social      => false,   // amis : accessible en fond
            PanelType.Input       => false,
            PanelType.ContentPanel => false,
            _                     => false,
        };

        // ── Patterns de classification (insensibles à la casse) ───────────────

        private static readonly (string keyword, PanelType type)[] _classifyRules =
        {
            // Dialogs — vérifier en premier (mots clé les plus spécifiques)
            ("Dialog",       PanelType.Dialog),
            ("CommonDialog", PanelType.Dialog),
            ("OkDialog",     PanelType.Dialog),
            ("InfoDialog",   PanelType.Dialog),
            ("ReqOpen",      PanelType.Dialog),   // DuelInfoDialog, etc.
            // Settings
            ("Settings",     PanelType.Settings),
            // Rewards / Bonus
            ("LoginBonus",   PanelType.Reward),
            ("PresentBox",   PanelType.Reward),
            ("SeasonResult", PanelType.Reward),
            ("DuelPassReward", PanelType.Reward),
            // Action Sheet
            ("ActionSheet",  PanelType.ActionSheet),
            // Sort Dialog
            ("SortDialog",   PanelType.SortDialog),
            // Social
            ("FriendSearch", PanelType.Social),
            ("Friend",       PanelType.Social),
            ("Profile",      PanelType.Social),
            // Input / Codes promo
            ("PromoCodes",   PanelType.Input),
            ("PromoCode",    PanelType.Input),
        };

        /// <summary>
        /// Classifie un nom de VC (ou nom de panneau) en PanelType.
        /// Utilise les patterns ci-dessus dans l'ordre (premier match gagne).
        /// </summary>
        public static PanelType Classify(string name)
        {
            if (string.IsNullOrEmpty(name))
                return PanelType.None;

            foreach (var (keyword, type) in _classifyRules)
            {
                if (name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    return type;
            }

            return PanelType.ContentPanel;
        }

        // ── Panneaux ignorés ─────────────────────────────────────────────────

        private static readonly HashSet<string> _ignoredNames = new HashSet<string>(
            StringComparer.OrdinalIgnoreCase)
        {
            // Menus principaux — gérés par ViewControllerPatch.OnFocusChanged
            "DUEL", "DECK", "SOLO", "SHOP", "MISSION",
            "Notifications", "Game Settings", "Duel Pass", "Home",
            // Éléments d'UI décoratifs
            "NavBar", "TopBar", "SocialCornerIcon",
        };

        /// <summary>Retourne vrai si ce panneau ne doit jamais être suivi.</summary>
        public static bool ShouldIgnore(string name)
        {
            if (string.IsNullOrEmpty(name)) return true;
            return _ignoredNames.Contains(name);
        }
    }
}
