using System.Collections.Generic;
using System.Text;
using MasterDuelAccessibility.Models;
using UnityEngine;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Registre central des raccourcis clavier du mod.
    /// Inspiré de MTGA AccessibleArena — IShortcutRegistry + ShortcutDefinition.
    ///
    /// Avantages vs. if-else hardcodé dans KeyboardShortcuts.Update() :
    ///   - Texte d'aide (F1) auto-généré et CONTEXTUEL (filtre les raccourcis inactifs)
    ///   - Les patches peuvent enregistrer leurs propres raccourcis depuis n'importe où
    ///   - Support déclaratif des modificateurs (Maj, Ctrl, Alt)
    ///   - Conditions d'activation contextuelles (ex. duel uniquement)
    ///
    /// Sémantique du Modifier dans ShortcutDefinition :
    ///   null              → aucun modificateur requis (catch-all, accepte tout état)
    ///   KeyCode.LeftShift → ne s'active que si Shift est enfoncé
    ///
    /// Ordre de priorité : les raccourcis enregistrés en PREMIER sont testés en PREMIER.
    /// → Enregistrez les variantes avec modificateur AVANT le catch-all sans modificateur
    ///   pour qu'elles aient la priorité.
    ///   Ex. Maj+F4 (terrain adverse) avant F4 (terrain du joueur).
    /// </summary>
    internal sealed class ShortcutRegistry
    {
        private readonly List<ShortcutDefinition> _shortcuts = new();

        /// <summary>
        /// Ensemble de toutes les touches surveillées.
        /// Auto-peuplé lors des enregistrements, utilisé par KeyboardShortcuts.Update()
        /// pour ne scanner que les touches connues chaque frame.
        /// </summary>
        internal HashSet<KeyCode> WatchedKeys { get; } = new();

        // ── Enregistrement ────────────────────────────────────────────────────

        /// <summary>
        /// Enregistre un raccourci. L'ordre d'enregistrement détermine la priorité.
        /// Inspiré de IShortcutRegistry.RegisterShortcut(...).
        /// </summary>
        public void Register(ShortcutDefinition def)
        {
            _shortcuts.Add(def);
            WatchedKeys.Add(def.Key);
        }

        // ── Traitement des touches ────────────────────────────────────────────

        /// <summary>
        /// Tente de déclencher le raccourci correspondant à la touche et aux modificateurs.
        /// Inspiré de IShortcutRegistry.ProcessKey(KeyCode, bool shift, bool ctrl, bool alt).
        /// </summary>
        /// <returns>true si un raccourci a été déclenché, false sinon.</returns>
        public bool ProcessKey(KeyCode key, bool shift, bool ctrl, bool alt)
        {
            foreach (var s in _shortcuts)
            {
                if (s.Key != key) continue;

                // Vérifier le modificateur principal déclaré
                bool modOk = s.Modifier switch
                {
                    KeyCode.LeftShift   or KeyCode.RightShift   => shift,
                    KeyCode.LeftControl or KeyCode.RightControl  => ctrl,
                    KeyCode.LeftAlt     or KeyCode.RightAlt      => alt,
                    null => true,  // catch-all : accepte tous les états de modificateurs
                    _    => false
                };
                if (!modOk) continue;

                // Vérifier le deuxième modificateur (ex. Ctrl+Shift+F4)
                if (s.SecondModifier != null)
                {
                    bool mod2Ok = s.SecondModifier.Value switch
                    {
                        KeyCode.LeftShift   or KeyCode.RightShift   => shift,
                        KeyCode.LeftControl or KeyCode.RightControl  => ctrl,
                        KeyCode.LeftAlt     or KeyCode.RightAlt      => alt,
                        _ => false
                    };
                    if (!mod2Ok) continue;
                }

                // Vérifier la condition d'activation contextuelle
                if (s.ActiveCondition != null && !s.ActiveCondition()) continue;

                s.Action();
                return true;
            }
            return false;
        }

        // ── Texte d'aide dynamique ────────────────────────────────────────────

        /// <summary>
        /// Construit un texte d'aide CONTEXTUEL listant uniquement les raccourcis actifs.
        /// Inspiré de IShortcutRegistry.GetAllShortcuts() + ShortcutDefinition.GetKeyString().
        ///
        /// Différence clé vs. le texte hardcodé en Loc.cs :
        ///   Ce texte est filtré par ActiveCondition — en dehors du duel, seuls les
        ///   raccourcis globaux (F1, F2, F5, Alt) apparaissent.
        ///   En duel, tous les raccourcis sont visibles.
        /// </summary>
        public string BuildHelpText()
        {
            var sb = new StringBuilder();
            bool first = true;

            foreach (var s in _shortcuts)
            {
                // Filtrer les raccourcis inactifs dans le contexte courant
                if (s.ActiveCondition != null && !s.ActiveCondition()) continue;

                if (!first) sb.Append(". ");
                sb.Append(s.GetKeyString());
                sb.Append(" : ");
                sb.Append(Loc.Get(s.DescriptionLocKey));
                first = false;
            }

            if (first) return Loc.Get("no_shortcuts_active");
            sb.Append('.');
            return sb.ToString();
        }

        /// <summary>
        /// Retourne toutes les définitions enregistrées (actives ou non).
        /// Utile pour le débogage ou l'affichage d'une liste complète.
        /// </summary>
        public IReadOnlyList<ShortcutDefinition> GetAll() => _shortcuts.AsReadOnly();
    }
}
