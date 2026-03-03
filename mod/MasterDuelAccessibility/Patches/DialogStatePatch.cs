using HarmonyLib;

using System;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch runtime pour détecter l'ouverture / fermeture des dialogs de duel
    /// et annoncer leur contenu via TTS.
    ///
    /// Inspiré de MTGA AccessibleArena — PanelStatePatch.Initialize() :
    ///   - Charge dynamiquement les types de dialog après le démarrage du jeu
    ///   - Patche ShowUI() / Open() pour annoncer l'ouverture et lire le message
    ///   - Patche HideUI() / OnClosed() pour annoncer la fermeture
    ///
    /// Dialogs ciblés (héritent tous de DuelDialogBase) :
    ///   ┌─────────────────────────────────┬────────────────────────────────────────┐
    ///   │ Type                            │ Méthode d'ouverture pertinente         │
    ///   ├─────────────────────────────────┼────────────────────────────────────────┤
    ///   │ DuelOkDialog                    │ Open(string message, ...)              │
    ///   │ DuelDiceDialog                  │ Open(string message, ...)              │
    ///   │ DuelCoinDialog                  │ Open(string message, ...)              │
    ///   │ DuelConfirmDialog               │ Open(string message, ...)              │
    ///   │ DuelSelectDialog                │ Open(string message, ...)              │
    ///   │ DuelRitualDialog                │ Open(...)                              │
    ///   │ MessageDialog                   │ Open(string message, ...)              │
    ///   │ DuelInfoDialog                  │ ShowUI / Open                          │
    ///   │ ChoiceFirstPlayerDialog         │ ReqOpen(int choicePlayer, ...)         │
    ///   └─────────────────────────────────┴────────────────────────────────────────┘
    ///
    /// Stratégie :
    ///   1. Patch postfix sur ShowUI() hérité de DuelDialogBase — commun à tous
    ///   2. Patch postfix spécialisé sur Open(string message, ...) pour lire le message
    ///   3. Patch postfix sur HideUI() / OnClosed() pour annoncer la fermeture
    ///
    /// Appelé depuis LatePatches.Initialize lors du chargement de la scène duel.
    /// </summary>
    internal static class DialogStatePatch
    {
        private static bool _applied = false;

        /// <summary>
        /// Applique tous les patches de dialog duel.
        /// Doit être appelé depuis <see cref="LatePatches.Initialize"/> en scène duel.
        /// </summary>
        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[DialogStatePatch] Initialisation des patches de dialog duel...");

            // ── 1. Patch la base DuelDialogBase.ShowUI et HideUI ─────────────
            // Tous les dialogs héritent de DuelDialogBase. Patcher la base couvre
            // automatiquement DuelOkDialog, DuelDiceDialog, DuelCoinDialog, etc.

            PatchBaseClass(harmony,
                "YgomGame.Duel.DuelDialogBase", "ShowUI",
                nameof(DuelDialogBase_ShowUI_Postfix));

            PatchBaseClass(harmony,
                "YgomGame.Duel.DuelDialogBase", "HideUI",
                nameof(DuelDialogBase_HideUI_Postfix));

            // ── 2. Patches spécialisés sur Open() pour lire le message ───────

            // DuelOkDialog.Open(string message, string buttonText, ...)
            PatchOpenWithMessage(harmony, "YgomGame.Duel.DuelOkDialog", "Open");

            // DuelDiceDialog.Open(string message, ...)
            PatchOpenWithMessage(harmony, "YgomGame.Duel.DuelDiceDialog", "Open");

            // DuelCoinDialog.Open(string message, ...)
            PatchOpenWithMessage(harmony, "YgomGame.Duel.DuelCoinDialog", "Open");

            // DuelConfirmDialog.Open(string message, ...)
            PatchOpenWithMessage(harmony, "YgomGame.Duel.DuelConfirmDialog", "Open");

            // DuelSelectDialog.Open(string message, ...)
            PatchOpenWithMessage(harmony, "YgomGame.Duel.DuelSelectDialog", "Open");

            // MessageDialog.Open(string message, ...)
            PatchOpenWithMessage(harmony, "YgomGame.Duel.MessageDialog", "Open");

            // ChoiceFirstPlayerDialog - utilise ReqOpen au lieu d'Open
            PatchBaseClass(harmony,
                "YgomGame.Duel.ChoiceFirstPlayerDialog", "ShowUI",
                nameof(ChoiceFirstPlayer_ShowUI_Postfix));

            _applied = true;
            Plugin.Instance?.LogMsg("[DialogStatePatch] Patches de dialog duel appliqués.");
        }

        // ── Helpers d'application de patches ─────────────────────────────────

        private static void PatchBaseClass(
            HarmonyLib.Harmony harmony,
            string typeName,
            string methodName,
            string patchMethodName)
        {
            try
            {
                var type = LatePatches.FindType(typeName);
                if (type == null)
                {
                    Plugin.Instance?.LogWarn($"[DialogStatePatch] Type '{typeName}' introuvable.");
                    return;
                }

                var method = type.GetMethod(methodName,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn($"[DialogStatePatch] '{typeName}.{methodName}' introuvable.");
                    return;
                }

                var patchMethod = typeof(DialogStatePatch).GetMethod(
                    patchMethodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                if (patchMethod == null)
                {
                    Plugin.Instance?.LogWarn($"[DialogStatePatch] Méthode patch '{patchMethodName}' introuvable.");
                    return;
                }

                harmony.Patch(method, postfix: new HarmonyMethod(patchMethod));
                Plugin.Instance?.LogMsg($"[DialogStatePatch] ✓ {typeName}.{methodName}");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DialogStatePatch] Échec {typeName}.{methodName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Patche TOUTES les surcharges de Open() qui ont un premier paramètre string (message).
        /// Utilise le postfix générique <see cref="OpenWithMessage_Postfix"/>.
        /// </summary>
        private static void PatchOpenWithMessage(
            HarmonyLib.Harmony harmony,
            string typeName,
            string methodName)
        {
            try
            {
                var type = LatePatches.FindType(typeName);
                if (type == null)
                {
                    Plugin.Instance?.LogWarn($"[DialogStatePatch] Type '{typeName}' introuvable pour Open().");
                    return;
                }

                // On patche TOUTES les surcharges dont le premier param est string
                var methods = type.GetMethods(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .Where(m => m.Name == methodName
                                && m.GetParameters().Length > 0
                                && m.GetParameters()[0].ParameterType == typeof(string))
                    .ToArray();

                if (methods.Length == 0)
                {
                    Plugin.Instance?.LogWarn($"[DialogStatePatch] Aucun Open(string, ...) sur '{typeName}'.");
                    return;
                }

                var patchMethod = typeof(DialogStatePatch).GetMethod(
                    nameof(OpenWithMessage_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                foreach (var m in methods)
                {
                    try
                    {
                        harmony.Patch(m, postfix: new HarmonyMethod(patchMethod));
                        var paramStr = string.Join(", ", m.GetParameters().Select(p => p.ParameterType.Name));
                        Plugin.Instance?.LogMsg($"[DialogStatePatch] ✓ {typeName}.{methodName}({paramStr})");
                    }
                    catch (Exception ex)
                    {
                        Plugin.Instance?.LogErr($"[DialogStatePatch] Échec override {m}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DialogStatePatch] Échec PatchOpenWithMessage {typeName}: {ex.Message}");
            }
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        /// <summary>
        /// Appelé après <c>DuelDialogBase.ShowUI()</c> sur N'IMPORTE QUEL dialog duel.
        /// Annonce l'ouverture générique du dialog par son nom de type.
        /// Les dialogs avec Open(string message) auront leur message annoncé séparément.
        /// </summary>
        private static void DuelDialogBase_ShowUI_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var typeName = __instance?.GetType().Name ?? "Dialog";
                tts.Speak(Loc.Get("dialog_opened", typeName), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// Appelé après <c>DuelDialogBase.HideUI()</c> sur N'IMPORTE QUEL dialog duel.
        /// Annonce la fermeture si le TTS est actif.
        /// </summary>
        private static void DuelDialogBase_HideUI_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Ne pas annoncer la fermeture pour éviter le bruit, sauf en debug.
                // Décommenter si besoin :
                // tts.Speak(Loc.Get("dialog_closed"), interrupt: false, addToHistory: false);
            }
            catch { }
        }

        /// <summary>
        /// Appelé après n'importe quel <c>Open(string message, ...)</c> sur un dialog duel.
        /// Lit le message du dialog à voix haute avec interruption (c'est une notification critique).
        /// Le paramètre <paramref name="__0"/> est le premier paramètre de Open — le message string.
        /// </summary>
        private static void OpenWithMessage_Postfix(object __instance, string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var message = __0 ?? "";
                if (!string.IsNullOrWhiteSpace(message))
                    tts.Speak(message, interrupt: true);
            }
            catch { }
        }

        /// <summary>
        /// Postfix spécifique pour <c>ChoiceFirstPlayerDialog.ShowUI()</c> —
        /// qui détermine qui joue en premier (lancer de pièce / dé).
        /// Annonce en priorité maximale.
        /// </summary>
        private static void ChoiceFirstPlayer_ShowUI_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                tts.Speak(Loc.Get("choice_first_player_dialog"), interrupt: true);
            }
            catch { }
        }
    }
}
