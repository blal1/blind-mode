using System;
using UnityEngine.UI;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Annonce les changements d'état des cases à cocher/interrupteurs Unity.
    /// Inspiré de Strings.cs AccessibleArena : Toggled, Selected, Deselected.
    ///
    /// Patche UnityEngine.UI.Toggle.Set(bool value, bool sendCallback) :
    ///   - Appelée à chaque changement de valeur (programmatique ou via clic).
    ///   - On filtre les changements programmatiques (sendCallback=false) pour ne
    ///     lire que les actions utilisateur.
    ///
    /// Anti-spam : cooldown de 200 ms entre deux annonces du même toggle.
    /// </summary>
    internal static class TogglePatch
    {
        private static DateTime _lastToggleAt = DateTime.MinValue;
        private static readonly TimeSpan Cooldown = TimeSpan.FromMilliseconds(200);

        // Postfix pour Toggle.Set(bool value, bool sendCallback)
        // __0 = value (bool), __1 = sendCallback (bool)
        public static void Set_Postfix(Toggle __instance, bool __0, bool __1)
        {
            // Ignorer les changements programmatiques (sendCallback = false)
            // — ils sont initialisés par le jeu, pas par l'utilisateur.
            if (!__1) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                // Anti-spam
                var now = DateTime.Now;
                if (now - _lastToggleAt < Cooldown) return;
                _lastToggleAt = now;

                // Résoudre le label du toggle (texte enfant ou nom du GameObject)
                string label = ResolveToggleLabel(__instance);

                // Annoncer : "Paramètre : Activé" ou "Paramètre : Désactivé"
                string stateKey = __0 ? "toggle_on" : "toggle_off";
                tts.Speak(Loc.Get("toggle_state", label, Loc.Get(stateKey)), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        /// <summary>
        /// Cherche le texte associé au toggle dans ses descendants,
        /// puis se rabat sur le nom du GameObject.
        /// </summary>
        private static string ResolveToggleLabel(Toggle toggle)
        {
            // Cherche un TMPro.TMP_Text dans les enfants
            var tmp = toggle.GetComponentInChildren<TMPro.TMP_Text>();
            if (tmp != null && !string.IsNullOrWhiteSpace(tmp.text))
                return tmp.text.Trim();

            // Cherche un UnityEngine.UI.Text legacy dans les enfants
            var legacy = toggle.GetComponentInChildren<UnityEngine.UI.Text>();
            if (legacy != null && !string.IsNullOrWhiteSpace(legacy.text))
                return legacy.text.Trim();

            // Fallback sur le nom du GameObject
            return toggle.gameObject.name;
        }
    }
}
