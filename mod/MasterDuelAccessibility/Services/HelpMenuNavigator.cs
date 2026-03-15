using System.Collections.Generic;
using MasterDuelAccessibility.Patches;
using UnityEngine;

namespace MasterDuelAccessibility.Services
{
    /// <summary>
    /// Menu d'aide navigable. Inspiré de AccessibleArena HelpNavigator.
    ///
    /// Comportement :
    ///   F1 (hors menu actif)  → ouvre le menu, annonce titre + nb éléments.
    ///   F1 ou Escape          → ferme le menu.
    ///   Flèche Bas / Haut     → élément suivant / précédent.
    ///   Home / End            → premier / dernier élément.
    ///   Toutes les autres     → bloquées (le menu intercepte toute entrée).
    ///
    /// Le contenu est construit à chaque ouverture depuis ShortcutRegistry.GetHelpItems(),
    /// ce qui garantit que seuls les raccourcis ACTIFS dans le contexte courant sont listés.
    /// Inspiré de HelpNavigator.BuildHelpItems() dans AccessibleArena MTGA.
    /// </summary>
    internal class HelpMenuNavigator
    {
        private readonly List<string> _items = new();
        private int _currentIndex;
        private bool _isActive;

        public bool IsActive => _isActive;

        // ── Cycle ouverture/fermeture ─────────────────────────────────────────

        public void Toggle()
        {
            if (_isActive) Close();
            else Open();
        }

        public void Open()
        {
            if (_isActive) return;

            RebuildItems();

            if (_items.Count == 0)
            {
                Plugin.Instance?.Tts?.Speak(Loc.Get("help_menu_empty"), interrupt: true);
                return;
            }

            _isActive = true;
            _currentIndex = 0;
            InputBlockPatch.ModMenuActive = true;

            Plugin.Instance?.Tts?.Speak(
                Loc.Get("help_menu_open", _items.Count), interrupt: true);
        }

        public void Close()
        {
            if (!_isActive) return;
            _isActive = false;
            InputBlockPatch.ModMenuActive = false;
            Plugin.Instance?.Tts?.Speak(Loc.Get("help_menu_closed"), interrupt: true);
        }

        // ── Reconstruction du contenu ─────────────────────────────────────────

        private void RebuildItems()
        {
            _items.Clear();
            var registry = Plugin.Instance?.ShortcutRegistry;
            if (registry == null) return;

            foreach (var (key, desc) in registry.GetHelpItems())
                _items.Add($"{key} : {desc}");
        }

        // ── Gestion des entrées (appelée avant le registre dans Update()) ──────

        /// <summary>
        /// Traite les touches quand le menu est actif.
        /// Retourne true → bloque TOUS les autres traitements d'entrée.
        /// Inspiré de HelpNavigator.HandleInput() dans AccessibleArena.
        /// </summary>
        public bool HandleInput()
        {
            if (!_isActive) return false;

            // F1 ou Escape : fermer
            if (Input.GetKeyDown((KeyCode)282) || Input.GetKeyDown(KeyCode.Escape))
            {
                Close();
                return true;
            }

            // Flèche bas : élément suivant
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveNext();
                return true;
            }

            // Flèche haut : élément précédent
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MovePrevious();
                return true;
            }

            // Home : premier élément
            if (Input.GetKeyDown(KeyCode.Home))
            {
                MoveFirst();
                return true;
            }

            // End : dernier élément
            if (Input.GetKeyDown(KeyCode.End))
            {
                MoveLast();
                return true;
            }

            // Bloquer tout le reste
            return true;
        }

        // ── Navigation ────────────────────────────────────────────────────────

        private void MoveNext()
        {
            if (_currentIndex >= _items.Count - 1)
            {
                if (_items.Count == 1) AnnounceCurrentItem();
                SpeakEdge("list_end");
                return;
            }
            _currentIndex++;
            AnnounceCurrentItem();
        }

        private void MovePrevious()
        {
            if (_currentIndex <= 0)
            {
                if (_items.Count == 1) AnnounceCurrentItem();
                SpeakEdge("list_begin");
                return;
            }
            _currentIndex--;
            AnnounceCurrentItem();
        }

        private void MoveFirst()
        {
            if (_currentIndex == 0) { SpeakEdge("list_begin"); return; }
            _currentIndex = 0;
            AnnounceCurrentItem();
        }

        private void MoveLast()
        {
            int last = _items.Count - 1;
            if (_currentIndex == last) { SpeakEdge("list_end"); return; }
            _currentIndex = last;
            AnnounceCurrentItem();
        }

        private void AnnounceCurrentItem()
        {
            if (_currentIndex < 0 || _currentIndex >= _items.Count) return;
            Plugin.Instance?.Tts?.Speak(
                Loc.Get("help_menu_item", _currentIndex + 1, _items.Count, _items[_currentIndex]),
                interrupt: true, addToHistory: false);
        }

        private static void SpeakEdge(string key)
            => Plugin.Instance?.Tts?.Speak(Loc.Get(key), interrupt: false, addToHistory: false);
    }
}
