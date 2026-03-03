using System;
using UnityEngine;

namespace MasterDuelAccessibility.Models
{
    /// <summary>
    /// Définition d'un raccourci clavier enregistré dans le <see cref="ShortcutRegistry"/>.
    /// Inspiré de MTGA AccessibleArena — ShortcutDefinition + IShortcutRegistry.
    ///
    /// Différences par rapport à MTGA :
    ///   - <c>Description</c> → <c>DescriptionLocKey</c> : clé Loc pour le bilinguisme FR/EN.
    ///     La description réelle est résolue à la demande via <c>Loc.Get(DescriptionLocKey)</c>.
    ///   - Ajout de <c>ActiveCondition</c> : prédicat contextuel.
    ///     Ex. : <c>() => KeyboardShortcuts.IsInDuel</c> pour les raccourcis duel uniquement.
    ///     Si null, le raccourci est toujours actif.
    ///
    /// Sémantique du Modifier :
    ///   null              → aucun modificateur spécifique (catch-all : accepte tout)
    ///   KeyCode.LeftShift → déclenche seulement si Shift est enfoncé
    ///   KeyCode.LeftAlt   → déclenche seulement si Alt est enfoncé
    /// </summary>
    public sealed class ShortcutDefinition
    {
        public KeyCode     Key              { get; }
        public KeyCode?    Modifier         { get; }
        /// <summary>
        /// Deuxième modificateur optionnel (ex. Ctrl+Shift+F4 → Modifier=Ctrl, SecondModifier=Shift).
        /// ProcessKey vérifie les deux ; BuildHelpText les affiche dans l'ordre Modifier+SecondModifier+Key.
        /// </summary>
        public KeyCode?    SecondModifier   { get; }
        public string      DescriptionLocKey{ get; }
        public Action      Action           { get; }
        public Func<bool>? ActiveCondition  { get; }

        public ShortcutDefinition(
            KeyCode     key,
            KeyCode?    modifier,
            string      descriptionLocKey,
            Action      action,
            Func<bool>? activeCondition = null,
            KeyCode?    secondModifier  = null)
        {
            Key               = key;
            Modifier          = modifier;
            SecondModifier    = secondModifier;
            DescriptionLocKey = descriptionLocKey;
            Action            = action;
            ActiveCondition   = activeCondition;
        }

        /// <summary>
        /// Retourne la représentation textuelle localisée de la combinaison de touches.
        /// Ex. : "Maj+F4", "Espace", "Alt"
        /// Adapté de MTGA ShortcutDefinition.GetKeyString() avec support FR/EN via Loc.
        /// </summary>
        public string GetKeyString()
        {
            string keyStr = Key switch
            {
                KeyCode.Space                              => Loc.Get("key_space"),
                KeyCode.LeftAlt  or KeyCode.RightAlt      => Loc.Get("key_alt"),
                KeyCode.LeftControl or KeyCode.RightControl=> Loc.Get("key_ctrl"),
                KeyCode.LeftShift or KeyCode.RightShift   => Loc.Get("key_shift"),
                >= KeyCode.F1 and <= KeyCode.F15           => Key.ToString(), // F1–F15 identiques
                _                                          => Key.ToString()
            };

            if (Modifier == null) return keyStr;

            string modStr = Modifier.Value switch
            {
                KeyCode.LeftShift  or KeyCode.RightShift   => Loc.Get("key_shift"),
                KeyCode.LeftControl or KeyCode.RightControl => Loc.Get("key_ctrl"),
                KeyCode.LeftAlt    or KeyCode.RightAlt     => Loc.Get("key_alt"),
                _                                           => Modifier.Value.ToString()
            };

            if (SecondModifier != null)
            {
                string mod2Str = SecondModifier.Value switch
                {
                    KeyCode.LeftShift  or KeyCode.RightShift   => Loc.Get("key_shift"),
                    KeyCode.LeftControl or KeyCode.RightControl => Loc.Get("key_ctrl"),
                    KeyCode.LeftAlt    or KeyCode.RightAlt     => Loc.Get("key_alt"),
                    _                                           => SecondModifier.Value.ToString()
                };
                return $"{modStr}+{mod2Str}+{keyStr}";
            }

            return $"{modStr}+{keyStr}";
        }
    }
}
