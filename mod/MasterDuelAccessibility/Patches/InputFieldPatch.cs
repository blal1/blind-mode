using System.Reflection;
using TMPro;
using UnityEngine;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Annonce l'état des champs de saisie (InputField TMP) au lecteur d'écran.
    /// Inspiré de Strings.cs AccessibleArena : EditingTextField, InputFieldContent,
    /// InputFieldEmpty, ExitedEditMode.
    ///
    /// Comportement :
    ///   OnSelect → annonce le label du champ + contenu actuel (ou "vide")
    ///   OnDeselect → annonce la sortie du champ de texte
    ///
    /// Label résolu en remontant la hiérarchie : cherche un TMP_Text sibling ou parent
    /// dont le nom contient "label", "title", "name" ou "placeholder" (insensible à la casse).
    /// Si aucun n'est trouvé, annonce simplement "Champ de texte".
    /// </summary>
    internal static class InputFieldPatch
    {
        // Guard : évite de ré-annoncer focus si le champ n'a pas changé
        private static TMP_InputField? _lastFocused;

        /// <summary>True when a text input field currently has keyboard focus.</summary>
        public static bool IsActive => _lastFocused != null;

        // ── OnSelect ─────────────────────────────────────────────────────────

        public static void OnSelect_Postfix(TMP_InputField __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                // Évite ré-annonce si le même champ est re-sélectionné sans avoir bougé
                if (ReferenceEquals(__instance, _lastFocused)) return;
                _lastFocused = __instance;

                string label   = ResolveLabel(__instance);
                string content = __instance.text ?? "";

                string msg = string.IsNullOrWhiteSpace(content)
                    ? Loc.Get("input_focused", label)
                    : Loc.Get("input_focused_with_content", label, content);

                tts.Speak(msg, interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── OnDeselect ───────────────────────────────────────────────────────

        public static void OnDeselect_Postfix(TMP_InputField __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                if (!ReferenceEquals(__instance, _lastFocused)) return;
                _lastFocused = null;

                tts.Speak(Loc.Get("input_exited"), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── Résolution du label du champ ─────────────────────────────────────

        /// <summary>
        /// Remonte la hiérarchie Unity pour trouver un TMP_Text qui fait office de label.
        /// Priorité : placeholder > parent label > sibling label > "Champ de texte".
        /// </summary>
        private static string ResolveLabel(TMP_InputField field)
        {
            // 1. Placeholder intégré (TMP_InputField.placeholder)
            var placeholder = field.placeholder as TMP_Text;
            if (placeholder != null && !string.IsNullOrWhiteSpace(placeholder.text))
                return placeholder.text.Trim();

            // 2. Chercher un TMP_Text label dans les parents (jusqu'à 4 niveaux)
            Transform? t = field.transform.parent;
            for (int depth = 0; depth < 4 && t != null; depth++, t = t.parent)
            {
                // Frères/sœurs du champ à ce niveau
                for (int i = 0; i < t.childCount; i++)
                {
                    var child = t.GetChild(i);
                    if (ReferenceEquals(child.gameObject, field.gameObject)) continue;

                    var tmp = child.GetComponent<TMP_Text>();
                    if (tmp != null && !string.IsNullOrWhiteSpace(tmp.text))
                    {
                        string n = child.name.ToLowerInvariant();
                        if (n.Contains("label") || n.Contains("title") ||
                            n.Contains("name")  || n.Contains("placeholder"))
                            return tmp.text.Trim();
                    }
                }

                // Le transform parent lui-même porte peut-être un TMP_Text label
                var parentTmp = t.GetComponent<TMP_Text>();
                if (parentTmp != null && !string.IsNullOrWhiteSpace(parentTmp.text))
                {
                    string n = t.name.ToLowerInvariant();
                    if (n.Contains("label") || n.Contains("title") || n.Contains("name"))
                        return parentTmp.text.Trim();
                }
            }

            return Loc.Get("input_field_generic");
        }
    }
}
