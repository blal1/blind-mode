using HarmonyLib;
using UnityEngine;


namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Bloque les touches de nos raccourcis TTS (F1-F12, Espace, Alt) quand le jeu
    /// lit directement Input.GetKeyDown — le même pattern que le mod MTGA
    /// AccessibleArena (EventSystemPatch.GetKeyDown_Postfix + KeyboardManagerPatch).
    ///
    /// Problème résolu : pendant un duel, des systèmes internes du jeu peuvent
    /// lire Input.GetKeyDown(KeyCode.Space) ou des touches de fonction et déclencher
    /// des actions non souhaitées lorsque l'utilisateur navigue via le TTS.
    ///
    /// Stratégie :
    ///   - Postfix sur Input.GetKeyDown(KeyCode) : met __result = false pour les
    ///     touches que nous gérons UNIQUEMENT si le jeu n'est PAS censé les voir.
    ///   - Le flag InputBlockPatch.BlockedThisFrame est mis à true pour que notre
    ///     KeyboardShortcuts.Update() sache que la pression a été enregistrée.
    ///
    /// Touches bloquées :
    ///   F1-F12 (partout) — raccourcis TTS
    ///   Alt gauche/droit (partout) — lecture infos carte
    ///   Espace (en duel) — lecture des PV
    ///   Ctrl gauche/droit (en duel) — les utilisateurs NVDA appuient sur Ctrl pour
    ///     silencer la synthèse vocale ; le jeu ne doit pas intercepter ce Ctrl.
    ///     Pattern MTGA KeyboardManagerPatch : « prevents game's native full control
    ///     toggle from firing when blind users press Ctrl to silence NVDA speech. »
    ///   Escape (optionnel, quand BlockEscape=true) — pour les futures modales du mod.
    ///     Pattern MTGA KeyboardManagerPatch.BlockEscape.
    ///
    /// NOTE : Ctrl n'est bloqué qu'en duel. En menu, Ctrl+Z (undo) etc. restent actifs.
    /// </summary>
    internal static class InputBlockPatch
    {
        // Cache scène courante par frame (évite les allocations répétées)
        private static int   _lastCachedFrame = -1;
        private static bool  _cachedIsInDuel  = false;

        /// <summary>
        /// Indique que la touche a été bloquée ce frame — permet à KeyboardShortcuts
        /// de savoir qu'il doit tout de même traiter la touche TTS même si le jeu
        /// a « consommé » l'événement. Réinitialisé chaque frame par Plugin.OnUpdate().
        /// </summary>
        public static bool BlockedThisFrame { get; private set; }

        /// <summary>
        /// Quand true, la touche Escape est bloquée (pour les modales futures du mod).
        /// Pattern MTGA KeyboardManagerPatch.BlockEscape :
        ///   « Set by WebBrowserAccessibility to prevent settings menu from opening. »
        /// Nous l'utilisons pour empêcher le jeu de fermer nos éventuels overlays d'aide.
        /// </summary>
        public static bool BlockEscape { get; set; }

        internal static void ResetFrameState()
        {
            BlockedThisFrame = false;
        }

        // ────────────────────────────────────────────────────────────────────────
        // Détecter si on est en duel (cache par frame, évite GetKeyDown() répétés)
        // ────────────────────────────────────────────────────────────────────────
        private static bool IsInDuel()
        {
            int frame = Time.frameCount;
            if (frame != _lastCachedFrame)
            {
                _lastCachedFrame = frame;
                _cachedIsInDuel  = KeyboardShortcuts.IsInDuel;
            }
            return _cachedIsInDuel;
        }

        // ────────────────────────────────────────────────────────────────────────
        // Décider si cette touche doit être retirée du jeu
        // ────────────────────────────────────────────────────────────────────────
        private static bool ShouldBlock(KeyCode key)
        {
            // Escape : bloqué seulement quand le mod a une modale active
            // (prévu pour de futurs overlays d'aide ou de paramétrage du mod).
            if (key == KeyCode.Escape && BlockEscape)
                return true;

            // Alt gauche / droit — lecture infos carte (partout)
            if (key == KeyCode.LeftAlt || key == KeyCode.RightAlt)
                return true;

            // F1-F12 — raccourcis TTS (partout)
            if (key >= KeyCode.F1 && key <= KeyCode.F12)
                return true;

            // Espace — lire les PV / état duel (seulement en duel)
            if (key == KeyCode.Space && IsInDuel())
                return true;

            // Ctrl gauche / droit — seulement en duel.
            // Les utilisateurs de NVDA pressent Ctrl pour silencer la voix ; le jeu
            // ne doit pas voir ce Ctrl (risque de déclencher un raccourci interne).
            // Pattern MTGA : KeyboardManagerPatch.ShouldBlockKey bloque LeftControl /
            // RightControl en DuelScene pour la même raison.
            if ((key == KeyCode.LeftControl || key == KeyCode.RightControl) && IsInDuel())
                return true;

            // Touches lettrées utilisées comme raccourcis de zone en duel —
            // bloquées seulement en duel et hors champ de saisie.
            // Pattern MTGA : lettre-touches C/G/X/S... consommées uniquement pendant le duel.
            if (IsInDuel() && !InputFieldPatch.IsActive)
            {
                if (key == KeyCode.C || key == KeyCode.G || key == KeyCode.X ||
                    key == KeyCode.M || key == KeyCode.T || key == KeyCode.L ||
                    key == KeyCode.D || key == KeyCode.E || key == KeyCode.I ||
                    key == KeyCode.S || key == KeyCode.O || key == KeyCode.P ||
                    key == KeyCode.F)
                    return true;

                // Touches numériques (0-9) bloquées en duel pour accès direct aux cartes/zones
                if (key >= KeyCode.Alpha0 && key <= KeyCode.Alpha9)
                    return true;
            }

            return false;
        }

        // ────────────────────────────────────────────────────────────────────────
        // Patch : Input.GetKeyDown(KeyCode)
        // Postfix — modifie __result APRÈS la lecture Unity
        // ────────────────────────────────────────────────────────────────────────
        public static void GetKeyDown_Postfix(KeyCode key, ref bool __result)
        {
            if (!__result) return;  // déjà false — rien à faire
            if (!Plugin.Instance?.Tts?.Enabled ?? false) return;  // TTS désactivé

            if (ShouldBlock(key))
            {
                // Signale à KeyboardShortcuts que la touche a été vue même si le jeu
                // ne la voit plus (permet une utilisation future pour replay / debug).
                BlockedThisFrame = true;

                // Retire la touche du jeu — il ne recevra plus l'événement
                __result = false;
            }
        }
    }
}
