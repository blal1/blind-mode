using System;
using UnityEngine.UI;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Annonce les changements de valeur des curseurs (Slider) Unity.
    /// Inspiré de Strings.cs AccessibleArena : SliderChanged.
    ///
    /// Patche UnityEngine.UI.Slider.Set(float input, bool sendCallback) :
    ///   - Appelée à chaque changement de valeur (programmatique ou via interaction).
    ///   - On filtre les changements programmatiques (sendCallback=false) pour ne
    ///     lire que les actions utilisateur.
    ///
    /// Format d'annonce :
    ///   - Si min=0 et max=1 (slider normalisé) → affiche un pourcentage (ex. "Volume : 75%")
    ///   - Si wholeNumbers → affiche la valeur entière
    ///   - Sinon → arrondit à l'entier le plus proche
    ///
    /// Label résolu en cherchant un TMP_Text dans les frères/sœurs ou le parent direct.
    ///
    /// Anti-spam : cooldown de 150 ms entre deux annonces (le slider peut être déplacé
    /// rapidement — on ne veut pas inonder le TTS).
    /// </summary>
    internal static class SliderPatch
    {
        private static DateTime _lastAt = DateTime.MinValue;
        private static readonly TimeSpan Cooldown = TimeSpan.FromMilliseconds(150);

        // Postfix pour Slider.Set(float input, bool sendCallback)
        // __0 = input (float), __1 = sendCallback (bool)
        public static void Set_Postfix(Slider __instance, float __0, bool __1)
        {
            // Ignorer les changements programmatiques — seules les actions utilisateur comptent
            if (!__1) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                // Anti-spam : évite de saturer le TTS quand le slider est glissé rapidement
                var now = DateTime.Now;
                if (now - _lastAt < Cooldown) return;
                _lastAt = now;

                string label    = ResolveLabel(__instance);
                string valueStr = FormatValue(__instance, __0);

                tts.Speak(Loc.Get("slider_changed", label, valueStr), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── Formatage de la valeur ────────────────────────────────────────────

        private static string FormatValue(Slider slider, float value)
        {
            float min = slider.minValue;
            float max = slider.maxValue;

            // Slider normalisé [0,1] → pourcentage
            if (min == 0f && max == 1f)
                return $"{(int)(value * 100)}%";

            // Slider à nombres entiers
            if (slider.wholeNumbers)
                return ((int)value).ToString();

            // Cas général : arrondi à l'entier le plus proche
            return ((int)Math.Round(value)).ToString();
        }

        // ── Résolution du label ───────────────────────────────────────────────

        /// <summary>
        /// Cherche un TMP_Text dans les frères/sœurs du slider ou dans son parent direct.
        /// Priorité : TMP_Text sibling → parent TMP_Text → nom du GameObject.
        /// </summary>
        private static string ResolveLabel(Slider slider)
        {
            var parent = slider.transform.parent;
            if (parent != null)
            {
                // Chercher dans les frères/sœurs
                for (int i = 0; i < parent.childCount; i++)
                {
                    var child = parent.GetChild(i);
                    if (child.gameObject == slider.gameObject) continue;

                    var tmp = child.GetComponent<TMPro.TMP_Text>();
                    if (tmp != null && !string.IsNullOrWhiteSpace(tmp.text))
                        return tmp.text.Trim();
                }

                // Parent direct
                var parentTmp = parent.GetComponent<TMPro.TMP_Text>();
                if (parentTmp != null && !string.IsNullOrWhiteSpace(parentTmp.text))
                    return parentTmp.text.Trim();
            }

            return slider.gameObject.name;
        }
    }
}
