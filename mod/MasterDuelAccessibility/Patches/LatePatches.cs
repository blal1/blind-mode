using HarmonyLib;

using System;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches appliqués dynamiquement au chargement d'une scène.
    ///
    /// Inspiré du pattern MTGA AccessibleArena :
    ///   PanelStatePatch.Initialize() + UXEventQueuePatch.Initialize()
    ///
    /// Pourquoi ? Certains types (ex: classes duel-spécifiques) ne sont chargés en
    /// mémoire que quand la scène correspondante est active. Les patcher au démarrage
    /// échoue silencieusement car les types n'existent pas encore.
    ///
    /// Utilisation :
    ///   Plugin.OnSceneWasLoaded() → LatePatches.Initialize(sceneName)
    ///
    /// Scènes connues de Master Duel observées dans le dump :
    ///   "Duel"     : scène de duel principale
    ///   "Title"    : écran titre / chargement
    ///   ""         : scène vide pendant transitions
    ///
    /// Pour chaque scène, on tente de patcher les types disponibles et on ignore
    /// silencieusement ceux qui sont introuvables.
    /// </summary>
    internal static class LatePatches
    {
        private static HarmonyLib.Harmony? _harmonyLate;

        /// <summary>
        /// Appelé depuis Plugin.OnSceneWasLoaded à chaque changement de scène.
        /// </summary>
        internal static void Initialize(string sceneName, HarmonyLib.Harmony sharedHarmony)
        {
            _harmonyLate = sharedHarmony;

            bool isDuel = sceneName.IndexOf("duel", StringComparison.OrdinalIgnoreCase) >= 0;

            if (isDuel)
                ApplyDuelScenePatches();
            else
                ApplyMenuScenePatches();
        }

        // ── Patches actifs uniquement en scène duel ──────────────────────────

        private static void ApplyDuelScenePatches()
        {
            Plugin.Instance?.LogMsg("[LatePatches] Application des patches de scène duel...");

            // Patch DuelView.OnDiceResult — annonce le résultat du lancer de dés
            // (détermine qui commence — information critique pour l'accessibilité)
            TryPatchPostfix(
                "YgomGame.Duel.DuelView", "OnDiceResult",
                typeof(DuelMiscPatch), nameof(DuelMiscPatch.OnDiceResult_Postfix));

            // Patch DuelView.OnCoinResult — annonce pile ou face
            TryPatchPostfix(
                "YgomGame.Duel.DuelView", "OnCoinResult",
                typeof(DuelMiscPatch), nameof(DuelMiscPatch.OnCoinResult_Postfix));

            // Patch DuelMulliganDialog.Open — annonce la phase de mulligan
            TryPatchPostfix(
                "YgomGame.Duel.DuelMulliganDialog", "Open",
                typeof(DuelMiscPatch), nameof(DuelMiscPatch.MulliganDialog_Open_Postfix));

            // Patch DuelResultDialog.Open — annonce victoire / défaite / égalité
            TryPatchPostfix(
                "YgomGame.Duel.DuelResultDialog", "Open",
                typeof(DuelMiscPatch), nameof(DuelMiscPatch.ResultDialog_Open_Postfix));

            // Déléguer les dialogs de duel à DialogStatePatch (pattern MTGA PanelStatePatch)
            DialogStatePatch.Initialize(_harmonyLate!);

            // File d'effets duel — messages flash et barre d'info (pattern MTGA UXEventQueuePatch)
            // Reset préalable pour permettre la ré-application en cas de multi-duel.
            DuelEffectQueuePatch.Reset();
            DuelEffectQueuePatch.Initialize(_harmonyLate!);

            // Listes de sélection de cartes (CardSelectionList.SetList + SetCursor)
            CardSelectionListPatch.Reset();
            CardSelectionListPatch.Initialize(_harmonyLate!);

            // Timer de duel — alertes vocales à 60s/30s/10s
            DuelTimerPatch.Reset();
            DuelTimerPatch.Initialize(_harmonyLate!);

            Plugin.Instance?.LogMsg("[LatePatches] Patches duel appliqués.");
        }

        // ── Patches actifs hors duel ─────────────────────────────────────────

        private static void ApplyMenuScenePatches()
        {
            Plugin.Instance?.LogMsg("[LatePatches] Application des patches de scène menu...");

            // Patch ShopViewController.Open — annonce l'ouverture du shop
            TryPatchPostfix(
                "YgomGame.Shop.ShopViewController", "Open",
                typeof(MenuMiscPatch), nameof(MenuMiscPatch.ShopOpen_Postfix));

            // Patch SoloModeViewController.Open — annonce l'entrée dans le mode solo
            TryPatchPostfix(
                "YgomGame.Solo.SoloModeViewController", "Open",
                typeof(MenuMiscPatch), nameof(MenuMiscPatch.SoloOpen_Postfix));

            Plugin.Instance?.LogMsg("[LatePatches] Patches menu appliqués.");
        }

        // ── Helper ───────────────────────────────────────────────────────────

        private static void TryPatchPostfix(
            string typeName,
            string methodName,
            Type   patchClass,
            string patchMethod)
        {
            try
            {
                var type = FindType(typeName);
                if (type == null)
                {
                    Plugin.Instance?.LogWarn($"[LatePatches] Type '{typeName}' introuvable.");
                    return;
                }

                var method =
                    (MethodInfo?)AccessTools.Method(type, methodName)
                    ?? type.GetMethods().FirstOrDefault(m => m.Name == methodName);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn($"[LatePatches] Méthode '{typeName}.{methodName}' introuvable.");
                    return;
                }

                var postfixInfo = patchClass.GetMethod(
                    patchMethod, BindingFlags.Public | BindingFlags.Static);

                if (postfixInfo == null)
                {
                    Plugin.Instance?.LogWarn($"[LatePatches] Postfix '{patchMethod}' introuvable sur {patchClass.Name}.");
                    return;
                }

                _harmonyLate!.Patch(method, postfix: new HarmonyMethod(postfixInfo));
                Plugin.Instance?.LogMsg($"[LatePatches] ✓ {typeName}.{methodName}");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LatePatches] Échec {typeName}.{methodName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Recherche un type dans tous les assemblies chargés, en testant d'abord
        /// le nom complet puis le nom simple (sans namespace).
        /// Pattern identique à MTGA AccessibleArena.PanelStatePatch.FindType().
        /// </summary>
        internal static Type? FindType(string fullName)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    // 1. Nom exact avec namespace
                    var t = assembly.GetType(fullName);
                    if (t != null) return t;

                    // 2. Nom simple uniquement (fallback sans namespace)
                    foreach (var type in assembly.GetTypes())
                    {
                        if (type.Name == fullName || type.FullName == fullName)
                            return type;
                    }
                }
                catch { /* assembly partiellement chargé */ }
            }
            return null;
        }
    }

    // =========================================================================
    // Patch handlers pour les événements duel divers
    // =========================================================================

    internal static class DuelMiscPatch
    {
        // Annonce le résultat du lancer de dés (qui commence)
        // DuelView.OnDiceResult(int player, int value)
        public static void OnDiceResult_Postfix(int __0, int __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // __0 = joueur (0=moi, 1=adversaire), __1 = valeur du dé
                string playerKey = __0 == 0 ? "dice_you" : "dice_opponent";
                tts.Speak(Loc.Get("dice_result", Loc.Get(playerKey), __1), interrupt: true);
            }
            catch { }
        }

        // Annonce le résultat de pile ou face
        // DuelView.OnCoinResult(int player, int side) — side: 0=pile, 1=face
        public static void OnCoinResult_Postfix(int __0, int __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string playerKey = __0 == 0 ? "dice_you" : "dice_opponent";
                string sideKey   = __1 == 0 ? "coin_heads" : "coin_tails";
                tts.Speak(Loc.Get("coin_result", Loc.Get(playerKey), Loc.Get(sideKey)), interrupt: true);
            }
            catch { }
        }

        // Annonce l'ouverture du dialog de mulligan
        // DuelMulliganDialog.Open(int count, ...)
        public static void MulliganDialog_Open_Postfix(int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("mulligan_open", __0), interrupt: true);
            }
            catch { }
        }

        // Annonce le résultat final du duel (victoire / défaite / égalité)
        // DuelResultDialog.Open(int result, ...) — result: 0=win, 1=lose, 2=draw
        public static void ResultDialog_Open_Postfix(int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string key = __0 switch
                {
                    0 => "duel_win",
                    1 => "duel_lose",
                    _ => "duel_draw"
                };
                tts.Speak(Loc.Get(key), interrupt: true);
            }
            catch { }
        }
    }

    // =========================================================================
    // Patch handlers pour les menus divers
    // =========================================================================

    internal static class MenuMiscPatch
    {
        // Annonce l'ouverture du shop
        public static void ShopOpen_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("shop_opened"), interrupt: false);
            }
            catch { }
        }

        // Annonce l'ouverture du mode Solo
        public static void SoloOpen_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("solo_mode_opened"), interrupt: false);
            }
            catch { }
        }
    }
}
