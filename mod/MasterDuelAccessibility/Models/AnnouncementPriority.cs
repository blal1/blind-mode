namespace MasterDuelAccessibility.Models
{
    /// <summary>
    /// Niveaux de priorité pour les annonces vocales via TtsService.
    /// Inspiré de MTGA AccessibleArena — IAnnouncementService.AnnouncementPriority.
    ///
    /// Mapping vers TtsService.Speak(interrupt) :
    ///   Low / Normal  → interrupt: false  (mise en queue, ne coupe pas la lecture)
    ///   High          → interrupt: true   (interrompt la lecture en cours)
    ///   Immediate     → interrupt: true   (priorité absolue, réservé aux événements critiques)
    /// </summary>
    public enum AnnouncementPriority
    {
        Low       = 0,  // Info accessoire, mise en queue silencieuse
        Normal    = 1,  // Navigation, menus — mise en queue standard
        High      = 2,  // Événements duel importants — interruption
        Immediate = 3,  // Résultat, abandon, cible imposée — interruption maximale
    }
}
