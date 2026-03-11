using MasterDuelAccessibility.Models;

namespace MasterDuelAccessibility.Interfaces
{
    /// <summary>
    /// Interface for the text-to-speech announcement service.
    ///
    /// Inspiré de AccessibleArena.Core.Interfaces.IAnnouncementService.
    ///
    /// Avantages :
    ///   - Testabilité : les patches peuvent être testés avec un mock ITtsService
    ///   - Découplage : les patches ne dépendent plus de TtsService directement
    ///   - Extension : permet de remplacer l'implémentation Tolk par une autre
    ///
    /// Usage dans les patches :
    ///   var tts = Plugin.Instance?.Tts as IAnnouncementService;
    ///   tts?.Announce("Message", AnnouncementPriority.High);
    /// </summary>
    public interface IAnnouncementService
    {
        /// <summary>
        /// Prononce un message avec la priorité spécifiée.
        /// Low/Normal → ne coupe pas la lecture en cours.
        /// High/Immediate → interrompt la lecture.
        /// </summary>
        void Announce(string message, AnnouncementPriority priority = AnnouncementPriority.Normal);

        /// <summary>
        /// Prononce un message en interrompant immédiatement la lecture en cours.
        /// Équivalent à Announce(message, AnnouncementPriority.Immediate).
        /// </summary>
        void AnnounceInterrupt(string message);

        /// <summary>
        /// Prononce un message uniquement si le mode verbeux est activé.
        /// Utilisé pour les descriptions longues (cartes, etc.).
        /// </summary>
        void AnnounceVerbose(string message, AnnouncementPriority priority = AnnouncementPriority.Normal);

        /// <summary>
        /// Relit le dernier message prononcé (commande F2).
        /// </summary>
        void RepeatLastAnnouncement();

        /// <summary>
        /// Coupe la lecture en cours (commande F5).
        /// </summary>
        void Silence();

        /// <summary>Active ou désactive le service TTS.</summary>
        void SetEnabled(bool enabled);

        /// <summary>Indique si le service TTS est actuellement actif.</summary>
        bool IsEnabled { get; }
    }
}
