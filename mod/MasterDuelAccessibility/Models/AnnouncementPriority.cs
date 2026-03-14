namespace MasterDuelAccessibility.Models
{
    /// <summary>
    /// Niveaux de priorité pour les annonces vocales via TtsService.
    /// Inspiré de MTGA AccessibleArena — IAnnouncementService.AnnouncementPriority.
    ///
    /// Mapping vers TtsService.Speak(interrupt) :
    ///   Low / Normal  → interrupt: false  (mise en queue, ne coupe pas la lecture)
    ///   High          → interrupt: false  (événements importants, mis en queue)
    ///   Immediate     → interrupt: false  (priorité absolue, mis en queue)
    /// </summary>
    public enum AnnouncementPriority
    {
        Low       = 0,  // Info accessoire, mise en queue silencieuse
        Normal    = 1,  // Navigation, menus — mise en queue standard
        High      = 2,  // Événements duel importants — mise en queue
        Immediate = 3,  // Résultat, abandon, cible imposée — mise en queue
    }
}
