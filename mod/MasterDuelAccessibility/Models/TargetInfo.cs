namespace MasterDuelAccessibility.Models
{
    /// <summary>
    /// Informations sur une carte ou un joueur sélectionnable en duel.
    /// Adaptée de MTGA AccessibleArena — TargetInfo, pour les zones de jeu Yu-Gi-Oh!
    ///
    /// Utilisations actuelles :
    ///   - Lecture du terrain (F4 / Maj+F4) — <see cref="GetAnnouncement()"/> pour chaque carte
    ///   - Lecture du cimetière, Extra Deck, main (avec détails contextuels)
    ///
    /// Usage prévu (navigator de ciblage futur) :
    ///   - Quand un effet demande de choisir une cible, construire une liste de TargetInfo
    ///     et naviguer avec les flèches pour entendre chaque cible et ses caractéristiques.
    /// </summary>
    public sealed class TargetInfo
    {
        /// <summary>
        /// Nom de la carte ou "Vous" / "Adversaire" pour les joueurs.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Détails contextuels :
        ///   Monstre  → "ATK 2500 DEF 2000, Attaque" (ou Défense)
        ///   Sort/Piège → "Sort actif" / "Piège posé"
        ///   Joueur   → "8000 PV"
        ///   Main     → "" (nom seul)
        /// </summary>
        public string Details { get; set; } = "";

        /// <summary>Type de zone ou de cible dans le contexte YGO.</summary>
        public CardTargetType Type { get; set; } = CardTargetType.Unknown;

        /// <summary>Appartient à l'adversaire (team = 1).</summary>
        public bool IsOpponent { get; set; }

        /// <summary>
        /// Position sur le terrain (BindingDuelFieldCards.FieldPostion).
        /// -1 si non applicable (cimetière, main, etc.).
        /// </summary>
        public int Zone { get; set; } = -1;

        /// <summary>
        /// Retourne l'annonce formatée pour le lecteur d'écran.
        /// Adapté de MTGA TargetInfo.GetAnnouncement() :
        ///   string.IsNullOrEmpty(Details) ? Name : $"{Name}, {Details}"
        /// </summary>
        public string GetAnnouncement() =>
            string.IsNullOrEmpty(Details) ? Name : $"{Name}, {Details}";

        public override string ToString() =>
            $"{Name} ({Type}){(IsOpponent ? " [Adv]" : "")}";
    }

    /// <summary>
    /// Types de cibles/zones en duel Yu-Gi-Oh!
    /// Adapté de MTGA CardTargetType (types Magic supprimés, zones YGO ajoutées).
    ///
    /// Correspondance avec BindingDuelFieldCards.FieldPostion :
    ///   Monster   → 0-6   (zones monstres principales + zones extra)
    ///   SpellTrap → 7-12  (zones sort/piège + zone terrain)
    ///   Hand      → 13
    ///   ExtraDeck → 14
    ///   Deck      → 15   (non utilisé comme cible directe, mais possible)
    ///   Grave     → 16
    ///   Banished  → 17
    /// </summary>
    public enum CardTargetType
    {
        Unknown,
        Monster,    // Zone monstre (positions 0-6)
        SpellTrap,  // Zone sort/piège (positions 7-12), zone terrain (12)
        Player,     // Cible joueur — attaque directe ou effet ciblant un joueur
        Grave,      // Cimetière (position 16)
        Banished,   // Cartes bannies / exclusion (position 17)
        Hand,       // Main (position 13)
        ExtraDeck,  // Extra Deck (position 14)
    }
}
