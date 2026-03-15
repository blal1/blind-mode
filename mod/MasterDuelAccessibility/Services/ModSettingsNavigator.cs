using System;
using System.Collections.Generic;
using MasterDuelAccessibility.Patches;
using UnityEngine;

namespace MasterDuelAccessibility.Services
{
    /// <summary>
    /// Menu de paramètres du mod navigable en jeu.
    /// Inspiré de AccessibleArena ModSettingsNavigator.
    ///
    /// Comportement :
    ///   Ctrl+F1 (hors menu actif) → ouvre, annonce titre + nb options.
    ///   Ctrl+F1 ou Escape         → ferme, sauvegarde via BepInEx.
    ///   Flèche Bas / Haut         → option suivante / précédente.
    ///   Home / End                → première / dernière option.
    ///   Entrée ou Espace          → bascule l'option courante, annonce nouvelle valeur.
    ///   Toutes les autres         → bloquées.
    ///
    /// Paramètres exposés :
    ///   1. Synthèse vocale (CfgEnabled)  — activer/désactiver le TTS entièrement
    ///   2. Descriptions de cartes (CfgVerbose) — mode verbeux/concis
    ///   3. Indices de raccourcis (CfgShowHints) — hints dans les annonces
    ///
    /// Les BepInEx ConfigEntry<bool> se sauvegardent automatiquement lors de la
    /// modification de leur Value. Pas de fichier JSON séparé nécessaire.
    /// </summary>
    internal class ModSettingsNavigator
    {
        private readonly List<SettingItem> _items;
        private int _currentIndex;
        private bool _isActive;

        public bool IsActive => _isActive;

        // ── Modèle d'un élément de paramètre ─────────────────────────────────

        private class SettingItem
        {
            public string NameKey  { get; init; } = "";
            public Func<string> GetValue { get; init; } = () => "";
            public Action Toggle  { get; init; } = () => { };
        }

        // ── Construction ──────────────────────────────────────────────────────

        public ModSettingsNavigator()
        {
            _items = BuildItems();
        }

        private static List<SettingItem> BuildItems() => new()
        {
            new SettingItem
            {
                NameKey  = "setting_tts_enabled",
                GetValue = () => GetBoolDisplay(Plugin.Instance?.CfgEnabled?.Value),
                Toggle   = () =>
                {
                    var cfg = Plugin.Instance?.CfgEnabled;
                    if (cfg != null) cfg.Value = !cfg.Value;
                }
            },
            new SettingItem
            {
                NameKey  = "setting_verbose",
                GetValue = () => GetBoolDisplay(Plugin.Instance?.CfgVerbose?.Value),
                Toggle   = () =>
                {
                    var cfg = Plugin.Instance?.CfgVerbose;
                    if (cfg != null) cfg.Value = !cfg.Value;
                    // Loc.Verbose lit CfgVerbose.Value dynamiquement — pas besoin de le setter.
                }
            },
            new SettingItem
            {
                NameKey  = "setting_hints",
                GetValue = () => GetBoolDisplay(Plugin.Instance?.CfgShowHints?.Value),
                Toggle   = () =>
                {
                    var cfg = Plugin.Instance?.CfgShowHints;
                    if (cfg != null) cfg.Value = !cfg.Value;
                }
            },
        };

        private static string GetBoolDisplay(bool? value)
            => value == true ? Loc.Get("setting_on") : Loc.Get("setting_off");

        // ── Cycle ouverture/fermeture ─────────────────────────────────────────

        public void Toggle()
        {
            if (_isActive) Close();
            else Open();
        }

        public void Open()
        {
            if (_isActive) return;
            _isActive = true;
            _currentIndex = 0;
            InputBlockPatch.ModMenuActive = true;

            Plugin.Instance?.Tts?.Speak(
                Loc.Get("settings_menu_open", _items.Count), interrupt: true);
        }

        public void Close()
        {
            if (!_isActive) return;
            _isActive = false;
            // BepInEx ConfigEntry sauvegarde automatiquement sur Value change.
            InputBlockPatch.ModMenuActive = false;
            Plugin.Instance?.Tts?.Speak(Loc.Get("settings_menu_closed"), interrupt: true);
        }

        // ── Gestion des entrées ───────────────────────────────────────────────

        /// <summary>
        /// Traite les touches quand le menu est actif.
        /// Retourne true → bloque TOUS les autres traitements d'entrée.
        /// </summary>
        public bool HandleInput()
        {
            if (!_isActive) return false;

            bool ctrl = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);

            // Ctrl+F1 ou Escape : fermer
            if ((Input.GetKeyDown((KeyCode)282) && ctrl) || Input.GetKeyDown(KeyCode.Escape))
            {
                Close();
                return true;
            }

            // Entrée ou Espace : basculer le paramètre courant
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                ActivateCurrent();
                return true;
            }

            // Flèche bas : option suivante
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveNext();
                return true;
            }

            // Flèche haut : option précédente
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MovePrevious();
                return true;
            }

            // Home : première option
            if (Input.GetKeyDown(KeyCode.Home))
            {
                MoveFirst();
                return true;
            }

            // End : dernière option
            if (Input.GetKeyDown(KeyCode.End))
            {
                MoveLast();
                return true;
            }

            // Bloquer tout le reste
            return true;
        }

        // ── Activation ────────────────────────────────────────────────────────

        private void ActivateCurrent()
        {
            if (_currentIndex < 0 || _currentIndex >= _items.Count) return;
            var item = _items[_currentIndex];
            item.Toggle();
            Plugin.Instance?.Tts?.Speak(
                Loc.Get("setting_changed", Loc.Get(item.NameKey), item.GetValue()),
                interrupt: true, addToHistory: false);
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
            var item = _items[_currentIndex];
            Plugin.Instance?.Tts?.Speak(
                Loc.Get("setting_item", _currentIndex + 1, _items.Count,
                    Loc.Get(item.NameKey), item.GetValue()),
                interrupt: true, addToHistory: false);
        }

        private static void SpeakEdge(string key)
            => Plugin.Instance?.Tts?.Speak(Loc.Get(key), interrupt: false, addToHistory: false);
    }
}
