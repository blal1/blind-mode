using System;
using System.Collections.Generic;
using MasterDuelAccessibility.Models;

namespace MasterDuelAccessibility.Services.PanelDetection
{
    /// <summary>
    /// Source de vérité unique pour l'état des panneaux de menu dans Master Duel.
    /// Adapté de AccessibleArena.Core.Services.PanelDetection.PanelStateManager.
    ///
    /// Architecture :
    ///   - Les patches (MenuPanelStatePatch) signalent l'ouverture/fermeture via
    ///     ReportPanelOpened() / ReportPanelClosed().
    ///   - Les abonnés (TTS, navigateur) réagissent via les events.
    ///   - Aucune dépendance circulaire : le manager ne connaît pas les patches.
    ///
    /// Cycle de vie :
    ///   Plugin.ApplyPatches()    → PanelStateManager.Initialize()
    ///   Plugin.OnSceneLoaded()   → PanelStateManager.Instance.Reset()
    ///   PluginBehaviour.Update() → PanelStateManager.Instance.ValidatePanels() (toutes 30 frames)
    ///   MenuPanelStatePatch      → ReportPanelOpened / ReportPanelClosed
    /// </summary>
    public sealed class PanelStateManager
    {
        #region Singleton

        private static PanelStateManager? _instance;

        /// <summary>Instance globale créée par Plugin.Initialize().</summary>
        public static PanelStateManager? Instance => _instance;

        /// <summary>
        /// Crée et enregistre l'instance unique.
        /// Appelé une seule fois au démarrage du mod.
        /// </summary>
        public static PanelStateManager Initialize()
        {
            _instance = new PanelStateManager();
            Plugin.Instance?.LogMsg("[PanelStateManager] Instance créée.");
            return _instance;
        }

        private PanelStateManager() { }

        #endregion

        #region Events

        /// <summary>
        /// Déclenché quand le panneau actif (plus haute priorité, filtre la navigation) change.
        /// Paramètres : (ancien panneau ou null, nouveau panneau ou null).
        /// </summary>
        public event Action<PanelInfo?, PanelInfo?>? OnActivePanelChanged;

        /// <summary>
        /// Déclenché quand N'IMPORTE QUEL panneau est ouvert (y compris ContentPanel).
        /// Utilisé pour les annonces TTS.
        /// </summary>
        public event Action<PanelInfo>? OnAnyPanelOpened;

        /// <summary>
        /// Déclenché quand un panneau est fermé.
        /// </summary>
        public event Action<PanelInfo>? OnAnyPanelClosed;

        #endregion

        #region State

        /// <summary>Panneau actif (plus haute priorité + FiltersNavigation = true).</summary>
        public PanelInfo? ActivePanel { get; private set; }

        /// <summary>Stack de tous les panneaux actifs, triée par priorité décroissante.</summary>
        private readonly List<PanelInfo> _stack = new List<PanelInfo>();

        /// <summary>Debounce : instant du dernier changement de panneau.</summary>
        private DateTime _lastChangeAt = DateTime.MinValue;
        private static readonly TimeSpan DebounceWindow = TimeSpan.FromMilliseconds(150);

        #endregion

        #region Public API — signalement des détecteurs

        /// <summary>
        /// Signale l'ouverture d'un panneau.
        /// Appelé depuis MenuPanelStatePatch.VC_StackEntry_Postfix et handlers spécialisés.
        /// </summary>
        /// <param name="vcName">Nom canonique du VC (sans suffixe ViewController/Dialog).</param>
        /// <param name="type">Type forcé si connu, sinon PanelType.None pour auto-classification.</param>
        /// <param name="displayName">Nom d'affichage localisé, ou null pour auto-résolution.</param>
        /// <returns>True si le panneau a été ajouté (pas un doublon, pas ignoré).</returns>
        public bool ReportPanelOpened(string vcName, PanelType type = PanelType.None, string? displayName = null)
        {
            if (string.IsNullOrEmpty(vcName)) return false;
            if (PanelTypeMeta.ShouldIgnore(vcName)) return false;

            // Résoudre le type si non fourni
            if (type == PanelType.None)
                type = PanelTypeMeta.Classify(vcName);

            // Ignorer les ContentPanels anonymes (trop de bruit)
            // — on les laisse passer seulement si un displayName est fourni
            if (type == PanelType.ContentPanel && displayName == null) return false;

            // Vérifier doublon dans la stack
            if (_stack.Exists(p => p.Name.Equals(vcName, StringComparison.Ordinal)))
            {
                Plugin.Instance?.LogMsg($"[PanelStateManager] Doublon ignoré : {vcName}");
                return false;
            }

            // Debounce
            var now = DateTime.Now;
            bool debounced = now - _lastChangeAt < DebounceWindow;
            _lastChangeAt = now;

            // Créer et ajouter le PanelInfo
            var panel = displayName != null
                ? new PanelInfo(vcName, type, displayName)
                : PanelInfo.Create(vcName);

            _stack.Add(panel);
            _stack.Sort((a, b) => b.Priority.CompareTo(a.Priority));

            Plugin.Instance?.LogMsg($"[PanelStateManager] Opened: {panel}");

            if (!debounced)
            {
                OnAnyPanelOpened?.Invoke(panel);
                UpdateActivePanel();
            }

            return true;
        }

        /// <summary>
        /// Signale la fermeture d'un panneau par son nom canonique.
        /// Appelé depuis MenuPanelStatePatch.VC_StackRemove_Postfix.
        /// </summary>
        public bool ReportPanelClosed(string vcName)
        {
            if (string.IsNullOrEmpty(vcName)) return false;

            var panel = _stack.Find(p => p.Name.Equals(vcName, StringComparison.Ordinal));
            if (panel == null)
            {
                // Recherche partielle (au cas où le suffix n'a pas été nettoyé)
                panel = _stack.Find(p =>
                    p.Name.IndexOf(vcName, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    vcName.IndexOf(p.Name, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (panel == null) return false;

            _stack.Remove(panel);
            Plugin.Instance?.LogMsg($"[PanelStateManager] Closed: {panel.Name}");

            OnAnyPanelClosed?.Invoke(panel);
            UpdateActivePanel();
            return true;
        }

        #endregion

        #region Public API — requêtes

        /// <summary>Vrai si un dialog (type Dialog) est actuellement dans la stack.</summary>
        public bool IsDialogActive => _stack.Exists(p => p.Type == PanelType.Dialog);

        /// <summary>Vrai si le panneau Paramètres est ouvert.</summary>
        public bool IsSettingsOpen => _stack.Exists(p => p.Type == PanelType.Settings);

        /// <summary>Vrai si un panneau du type donné est dans la stack.</summary>
        public bool IsPanelTypeActive(PanelType type) => _stack.Exists(p => p.Type == type);

        /// <summary>Vrai si un panneau avec ce nom est dans la stack.</summary>
        public bool IsPanelActive(string name) =>
            _stack.Exists(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// Retourne le GameObject à utiliser pour filtrer la navigation.
        /// Null si aucun overlay actif ne filtre la navigation.
        /// </summary>
        public PanelInfo? GetFilterPanel()
            => ActivePanel?.FiltersNavigation == true ? ActivePanel : null;

        /// <summary>Vue en lecture seule de la stack (pour débogage et navigation).</summary>
        public IReadOnlyList<PanelInfo> GetStack() => _stack.AsReadOnly();

        #endregion

        #region Cycle de vie

        /// <summary>
        /// Réinitialise complètement l'état (appelé à chaque changement de scène).
        /// </summary>
        public void Reset()
        {
            var old = ActivePanel;
            _stack.Clear();
            ActivePanel = null;
            _lastChangeAt = DateTime.MinValue;

            if (old != null)
                OnActivePanelChanged?.Invoke(old, null);

            Plugin.Instance?.LogMsg("[PanelStateManager] Reset.");
        }

        /// <summary>
        /// Vérification périodique : purge les panneaux dont le VC n'est plus actif.
        /// Appelé depuis PluginBehaviour.Update() toutes les 30 frames.
        ///
        /// Note : contrairement à MTGA, on n'a pas de référence GameObject directe.
        /// On se contente de garder la stack cohérente ; les VCs signalent leur fermeture
        /// via NotificationStackRemove, donc la purge est un filet de sécurité.
        /// Si la stack grossit anormalement (> 10 entrées), on la vide.
        /// </summary>
        public void ValidatePanels()
        {
            if (_stack.Count > 10)
            {
                Plugin.Instance?.LogWarn(
                    $"[PanelStateManager] Stack anormale ({_stack.Count} entrées) — reset.");
                Reset();
            }
        }

        #endregion

        #region Stack management (privé)

        private void UpdateActivePanel()
        {
            PanelInfo? newActive = null;

            // Premier panneau avec FiltersNavigation = true (déjà trié par priorité)
            foreach (var p in _stack)
            {
                if (p.FiltersNavigation)
                {
                    newActive = p;
                    break;
                }
            }

            if (ActivePanel?.Name != newActive?.Name)
            {
                var old  = ActivePanel;
                ActivePanel = newActive;

                Plugin.Instance?.LogMsg(
                    $"[PanelStateManager] ActivePanel: {old?.Name ?? "null"} → {newActive?.Name ?? "null"}");

                OnActivePanelChanged?.Invoke(old, newActive);
            }
        }

        #endregion
    }
}
