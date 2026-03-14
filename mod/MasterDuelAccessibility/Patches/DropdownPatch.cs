using System;
using System.Reflection;
using TMPro;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Annonce l'état des listes déroulantes TMP_Dropdown.
    /// Inspiré du pattern DropdownStateManager d'AccessibleArena.
    ///
    /// Trois hooks :
    ///   TMP_Dropdown.Show()      → annonce l'ouverture + supprime onValueChanged
    ///   TMP_Dropdown.set_value() → annonce la sélection (cooldown 200 ms)
    ///   TMP_Dropdown.Hide()      → restaure onValueChanged, réinitialise l'état
    ///
    /// Suppression de onValueChanged (pattern DROPDOWN_HANDLING.md) :
    ///   Quand une liste s'ouvre, on remplace m_OnValueChanged par un événement vide
    ///   pour éviter qu'une navigation dans les options ne déclenche une soumission
    ///   automatique du formulaire. Au Hide(), on restaure le callback et on le fire
    ///   avec la valeur sélectionnée (si différente de l'initiale).
    ///
    /// Label résolu depuis les frères/sœurs TMP_Text ou le nom du GameObject.
    /// </summary>
    internal static class DropdownPatch
    {
        private static int      _lastValue        = -1;
        private static int      _valueAtOpen      = -1;   // valeur au moment du Show()
        private static DateTime _lastValueAt      = DateTime.MinValue;
        private static readonly TimeSpan Cooldown = TimeSpan.FromMilliseconds(200);

        // ── onValueChanged suppression (pattern DropdownStateManager) ─────────
        // Référence au dropdown ouvert + callback sauvegardé
        private static object? _suppressedDropdown  = null;
        private static object? _savedOnValueChanged = null;
        private static FieldInfo? _onValueChangedField = null;

        // Postfix pour TMP_Dropdown.Show()
        public static void Show_Postfix(TMP_Dropdown __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                // Mémoriser la valeur courante pour éviter une double-annonce dans set_value
                _lastValue   = __instance.value;
                _valueAtOpen = __instance.value;
                _lastValueAt = DateTime.Now;

                // Supprimer onValueChanged pour éviter les soumissions automatiques
                // pendant que l'utilisateur navigue dans les options
                SuppressOnValueChanged(__instance);

                string current = GetOptionText(__instance, __instance.value);
                string label   = ResolveLabel(__instance);

                // Annonce avec interruption — ouvrir un dropdown est une action critique
                tts.Speak(Loc.Get("dropdown_opened", label, current), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // Postfix pour TMP_Dropdown.Hide()
        public static void Hide_Postfix(TMP_Dropdown __instance)
        {
            try
            {
                // Restaurer onValueChanged et le déclencher si la valeur a changé
                RestoreOnValueChanged(__instance);
            }
            catch { }
            finally
            {
                // Réinitialiser l'état interne dans tous les cas
                _lastValue   = -1;
                _valueAtOpen = -1;
                _lastValueAt = DateTime.MinValue;
            }
        }

        // Postfix pour TMP_Dropdown.set_value(int value)
        // __0 = nouvelle valeur (int)
        public static void SetValue_Postfix(TMP_Dropdown __instance, int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                // Ignorer si même valeur (initialisation sans changement)
                if (__0 == _lastValue) return;
                _lastValue = __0;

                // Anti-spam : Show() vient de s'exécuter avec la valeur initiale → ignorer
                var now = DateTime.Now;
                if (now - _lastValueAt < Cooldown) return;
                _lastValueAt = now;

                string selected = GetOptionText(__instance, __0);
                if (string.IsNullOrWhiteSpace(selected)) return;

                int total = __instance.options?.Count ?? 0;
                tts.Speak(
                    Loc.Get("dropdown_selected", selected, __0 + 1, total),
                    interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }

        // ── onValueChanged suppression helpers ────────────────────────────────

        /// <summary>
        /// Remplace m_OnValueChanged par un événement vide pour bloquer les soumissions
        /// automatiques du formulaire pendant la navigation dans la liste.
        /// Inspiré de DropdownStateManager.SuppressOnValueChanged() (AccessibleArena).
        /// </summary>
        private static void SuppressOnValueChanged(TMP_Dropdown dropdown)
        {
            try
            {
                if (_onValueChangedField == null)
                {
                    _onValueChangedField = typeof(TMP_Dropdown).GetField(
                        "m_OnValueChanged",
                        BindingFlags.NonPublic | BindingFlags.Instance);
                }

                if (_onValueChangedField == null) return;

                // Sauvegarder le callback existant
                _suppressedDropdown  = dropdown;
                _savedOnValueChanged = _onValueChangedField.GetValue(dropdown);

                // Remplacer par un événement vide
                var emptyEvent = new TMP_Dropdown.DropdownEvent();
                _onValueChangedField.SetValue(dropdown, emptyEvent);
            }
            catch { }
        }

        /// <summary>
        /// Restaure m_OnValueChanged et le déclenche si la valeur a changé depuis l'ouverture.
        /// Inspiré de DropdownStateManager.RestoreOnValueChanged() (AccessibleArena).
        /// </summary>
        private static void RestoreOnValueChanged(TMP_Dropdown dropdown)
        {
            // Uniquement pour le dropdown qu'on a supprimé
            if (!ReferenceEquals(dropdown, _suppressedDropdown)) return;
            if (_onValueChangedField == null || _savedOnValueChanged == null)
            {
                _suppressedDropdown  = null;
                _savedOnValueChanged = null;
                return;
            }

            try
            {
                // Restaurer le callback original
                _onValueChangedField.SetValue(dropdown, _savedOnValueChanged);

                // Déclencher le callback si la valeur a changé
                if (dropdown.value != _valueAtOpen && _valueAtOpen >= 0)
                {
                    var evt = _savedOnValueChanged as TMP_Dropdown.DropdownEvent;
                    evt?.Invoke(dropdown.value);
                }
            }
            catch { }
            finally
            {
                _suppressedDropdown  = null;
                _savedOnValueChanged = null;
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string GetOptionText(TMP_Dropdown dropdown, int index)
        {
            var options = dropdown.options;
            if (options == null || index < 0 || index >= options.Count) return "";
            return options[index]?.text?.Trim() ?? "";
        }

        /// <summary>
        /// Cherche un TMP_Text dans les frères/sœurs du dropdown ou dans le parent.
        /// Priorité : sibling TMP_Text → parent TMP_Text → nom du GameObject.
        /// </summary>
        private static string ResolveLabel(TMP_Dropdown dropdown)
        {
            var parent = dropdown.transform.parent;
            if (parent != null)
            {
                for (int i = 0; i < parent.childCount; i++)
                {
                    var child = parent.GetChild(i);
                    if (child.gameObject == dropdown.gameObject) continue;

                    var tmp = child.GetComponent<TMP_Text>();
                    if (tmp != null && !string.IsNullOrWhiteSpace(tmp.text))
                        return tmp.text.Trim();
                }

                var parentTmp = parent.GetComponent<TMP_Text>();
                if (parentTmp != null && !string.IsNullOrWhiteSpace(parentTmp.text))
                    return parentTmp.text.Trim();
            }

            return dropdown.gameObject.name;
        }
    }
}
