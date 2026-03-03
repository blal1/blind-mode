using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les dialogues en duel :
    ///
    ///   DuelConfirmDialog.Open(message, rightButtonText, leftButtonText, ...)
    ///     → Annonce le message + les deux boutons (oui/non, gauche/droite).
    ///     Exemple : "Voulez-vous activer l'effet ? Oui. Non."
    ///
    ///   DuelSelectDialog.Open(message, infoList, ...)
    ///     → Annonce le message de sélection.
    ///     Exemple : "Choisissez un effet à activer."
    ///
    /// Champs lus via réflexion (aucune dépendance compile-time sur Assembly-CSharp) :
    ///   DuelConfirmDialog : textMessage, textLeftButton, textRightButton
    ///   DuelSelectDialog  : textMessage
    /// </summary>
    internal static class DuelDialogPatch
    {
        // ── DuelConfirmDialog.Open ────────────────────────────────────────────
        // Signature : Open(string message, string rightButtonText, string leftButtonText,
        //                  Action<Result,bool> resultCallback, Action openCallback, bool useFieldView)
        // Nous lisons directement les paramètres de la méthode (injection Harmony par nom).
        public static void ConfirmDialog_Open_Postfix(string message, string rightButtonText, string leftButtonText)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            string announcement = message ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(rightButtonText))
                announcement += $" {rightButtonText.Trim()}.";
            if (!string.IsNullOrWhiteSpace(leftButtonText))
                announcement += $" {leftButtonText.Trim()}.";

            tts.Speak(announcement.Trim(), interrupt: true);
        }

        // Surcharge sans libellés de boutons explicites :
        // Open(string message, Action<Result,bool> resultCallback, Action openCallback, bool useFieldView)
        public static void ConfirmDialog_OpenSimple_Postfix(string message)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || string.IsNullOrWhiteSpace(message)) return;
            tts.Speak(message.Trim(), interrupt: true);
        }

        // ── DuelSelectDialog.Open ─────────────────────────────────────────────
        // Signature : Open(string message, List<Info> infoList, int defaultIndex,
        //                  Action<int,bool> resultCallback, Action openCallback)
        public static void SelectDialog_Open_Postfix(string message)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || string.IsNullOrWhiteSpace(message)) return;
            tts.Speak(message.Trim(), interrupt: true);
        }
    }
}
