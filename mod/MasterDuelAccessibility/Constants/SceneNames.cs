namespace MasterDuelAccessibility.Constants
{
    /// <summary>
    /// Constants for Unity scene names used by Yu-Gi-Oh! Master Duel.
    ///
    /// Usage in LatePatches.Initialize(sceneName) :
    ///   bool isDuel = sceneName.IndexOf(SceneNames.DuelScene, ...) >= 0;
    ///
    /// Inspiré de AccessibleArena.Core.Constants.SceneNames.
    /// </summary>
    public static class SceneNames
    {
        // ── Scènes principales ────────────────────────────────────────────────

        /// <summary>
        /// Scène de duel principal. Toutes les classes duel-spécifiques sont disponibles.
        /// Identifiée par "Duel" dans le nom de scène Unity.
        /// </summary>
        public const string DuelScene = "Duel";

        /// <summary>
        /// Écran titre (logo Konami + bouton démarrer).
        /// Scène chargée au lancement avant la connexion.
        /// </summary>
        public const string TitleScene = "Title";

        /// <summary>
        /// Scène d'accueil principale (Hub / Home).
        /// Chargée après la connexion — contient les menus principaux.
        /// </summary>
        public const string HomeScene = "Home";

        /// <summary>
        /// Scène vide utilisée pendant les transitions entre scènes.
        /// Le nom peut être une chaîne vide ou "Bootstrap".
        /// </summary>
        public const string BootstrapScene = "Bootstrap";

        // ── Identifiants partiels (utilisés pour IndexOf) ────────────────────

        /// <summary>
        /// Sous-chaîne présente dans tout nom de scène de duel.
        /// Compatible avec la vérification insensible à la casse.
        /// </summary>
        public const string DuelSceneFragment = "duel";
    }
}
