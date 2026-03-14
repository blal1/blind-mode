namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour YgomGame.Menu.CommonDialogViewController — dialogs génériques du menu.
    ///
    /// Couvre toutes les variantes de dialogs de confirmation, alerte et erreur :
    ///   - OpenAlertDialog(string title, string message, ...)
    ///   - OpenAlertDialogScroll(string title, string message, ...)
    ///   - OpenConfirmationDialog(string title, string message, ...)
    ///   - OpenConfirmationDialogScroll(string title, string message, ...)
    ///   - OpenConfirmationPartDialog(string title, string message, ...)
    ///   - OpenErrorDialog(string title, string message, ...)
    ///   - OpenYesNoConfirmationDialog(string title, string message, ...)
    ///   - OpenYesNoConfirmationDialogScroll(string title, string message, ...)
    ///   - OpenNoticeYesNoDialog(string title, string message, ...)
    ///   - OpenItemConfirmDialog(string title, string message, int itemId, ...)  [7 params]
    ///   - OpenItemConfirmDialog(string title, string message, bool, int, int, ...)  [9 params]
    ///   - OpenCheckBoxDialog(string title, string message, ...)
    ///
    /// Toutes ces méthodes statiques partagent la convention :
    ///   premier param  = string title
    ///   second param   = string message
    ///
    /// Un seul postfix est réutilisé pour chacune d'elles.
    /// Appliqué dans Plugin.ApplyPatches() au démarrage.
    /// </summary>
    internal static class CommonDialogPatch
    {
        /// <summary>
        /// Postfix commun pour tous les Open*Dialog de CommonDialogViewController.
        ///
        /// __0 = title   (string) — premier paramètre — peut être null ou vide
        /// __1 = message (string) — second paramètre — corps du dialog
        ///
        /// Si le titre et le message sont présents, annonce "Titre : Message".
        /// Si seulement l'un est présent, annonce l'autre seul.
        /// </summary>
        public static void Dialog_Postfix(string __0, string __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string title   = string.IsNullOrWhiteSpace(__0) ? "" : __0.Trim();
                string message = string.IsNullOrWhiteSpace(__1) ? "" : __1.Trim();

                string text = (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(message))
                    ? Loc.Get("dialog_title_message", title, message)
                    : !string.IsNullOrEmpty(title)
                        ? title
                        : message;

                if (!string.IsNullOrEmpty(text))
                    tts.Speak(text, interrupt: false);
            }
            catch { }
        }
    }
}
