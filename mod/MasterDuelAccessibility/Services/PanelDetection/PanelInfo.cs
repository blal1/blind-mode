using System;

namespace MasterDuelAccessibility.Services.PanelDetection
{
    /// <summary>
    /// Informations sur un panneau de menu actif dans Master Duel.
    /// Adapté de AccessibleArena.Core.Services.PanelDetection.PanelInfo.
    ///
    /// Contrairement à MTGA, les panneaux de Master Duel sont tous des ViewControllers
    /// (pas de GameObject direct). On utilise le nom de type comme identifiant canonique.
    /// </summary>
    public sealed class PanelInfo
    {
        // ── Propriétés ────────────────────────────────────────────────────────

        /// <summary>
        /// Nom canonique du panneau (nom du type ViewController sans suffixe).
        /// Ex : "Settings", "LoginBonus", "ActionSheet".
        /// </summary>
        public string Name { get; }

        /// <summary>Classification du panneau.</summary>
        public PanelType Type { get; }

        /// <summary>Priorité pour le tri de la stack (plus grand = plus au premier plan).</summary>
        public int Priority { get; }

        /// <summary>Vrai si ce panneau doit filtrer la navigation (overlay modal).</summary>
        public bool FiltersNavigation { get; }

        /// <summary>Nom localisé pour les annonces TTS.</summary>
        public string DisplayName { get; }

        /// <summary>Timestamp d'ouverture (pour debounce et logs).</summary>
        public DateTime OpenedAt { get; } = DateTime.Now;

        // ── Constructeur ──────────────────────────────────────────────────────

        public PanelInfo(string name, PanelType type, string displayName)
        {
            Name              = name;
            Type              = type;
            DisplayName       = displayName;
            Priority          = PanelTypeMeta.GetPriority(type);
            FiltersNavigation = PanelTypeMeta.FiltersNavigation(type);
        }

        // ── Factory ───────────────────────────────────────────────────────────

        /// <summary>
        /// Crée un PanelInfo à partir d'un nom de VC brut (tel que retourné par réflexion).
        /// Classifie automatiquement le type et résout le nom d'affichage.
        /// </summary>
        public static PanelInfo Create(string rawVcName, string? displayName = null)
        {
            var type    = PanelTypeMeta.Classify(rawVcName);
            var display = displayName ?? ResolveDisplayName(rawVcName, type);
            return new PanelInfo(rawVcName, type, display);
        }

        // ── Affichage ─────────────────────────────────────────────────────────

        /// <summary>
        /// Résout un nom d'affichage localisé depuis le nom de VC.
        /// Cherche d'abord dans les clés Loc (screen_xxx), puis génère un nom lisible.
        /// </summary>
        private static string ResolveDisplayName(string vcName, PanelType type)
        {
            // Tentative de clé Loc construite depuis le nom du VC
            string candidate = "screen_" + CamelToLower(vcName);
            string resolved  = Loc.Get(candidate);

            // Si la clé n'existe pas, Loc.Get retourne la clé elle-même
            if (resolved != candidate)
                return resolved;

            // Fallback : rendre lisible via CamelCase → espaces
            return AddSpaces(vcName);
        }

        /// <summary>Convertit "LoginBonus" en "login_bonus" pour chercher la clé Loc.</summary>
        private static string CamelToLower(string name)
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                if (i > 0 && char.IsUpper(name[i]) && !char.IsUpper(name[i - 1]))
                    sb.Append('_');
                sb.Append(char.ToLowerInvariant(name[i]));
            }
            return sb.ToString();
        }

        /// <summary>Insère des espaces avant chaque majuscule (CamelCase → Carte de visite).</summary>
        private static string AddSpaces(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            var sb = new System.Text.StringBuilder();
            sb.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) && !char.IsUpper(text[i - 1]))
                    sb.Append(' ');
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        // ── Égalité ───────────────────────────────────────────────────────────

        public override bool Equals(object? obj)
            => obj is PanelInfo other && Name.Equals(other.Name, StringComparison.Ordinal);

        public override int GetHashCode() => Name.GetHashCode();

        public override string ToString()
            => $"PanelInfo({Name}, {Type}, Priority={Priority}, Filters={FiltersNavigation})";
    }
}
