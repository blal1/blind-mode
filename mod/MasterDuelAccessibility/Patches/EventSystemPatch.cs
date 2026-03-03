using HarmonyLib;
using UnityEngine;
using UnityEngine.EventSystems;


namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches sur l'EventSystem Unity pour bloquer la navigation parasite.
    ///
    /// Inspiré du mod MTGA AccessibleArena (EventSystemPatch.cs) — trois problèmes résolus :
    ///
    /// 1. NAVIGATION PAR FLÈCHES dans un champ de saisie :
    ///    Unity traite Up/Down dans l'EventSystem AVANT notre Update(), donc sans ce patch
    ///    appuyer ↑/↓ dans un InputField fait sortir le focus du champ et navigue vers le
    ///    prochain Selectable — comportement indésirable pour les utilisateurs de lecteur d'écran.
    ///    → Prefix sur SendMoveEventToSelectedObject : retourne false si un InputField est actif.
    ///
    /// 2. TOUCHE TAB :
    ///    Unity traite Tab dans EventSystem.Update() AVANT notre Update(). Sans ce patch,
    ///    Tab peut activer des dropdowns ou déplacer le focus dans l'ordre de navigation
    ///    Unity (qui diffère de notre logique de menu). Le blocage global de Tab dans
    ///    SendMoveEventToSelectedObject garantit que la touche reste neutre dans le jeu.
    ///    Pattern MTGA : « Our mod handles all Tab navigation via BaseNavigator.HandleInput(). »
    ///    (Nous n'avons pas de navigateur Tab, mais bloquer Tab évite des effets de bord.)
    ///
    /// 3. TOUCHE ENTRÉE / SUBMIT :
    ///    Master Duel détecte l'appui sur la touche Entrée de deux façons :
    ///      a) Via Unity EventSystem Submit  → bloqué par SendSubmitEventToSelectedObject
    ///      b) Via Input.GetKeyDown direct   → déjà bloqué par InputBlockPatch.GetKeyDown_Postfix
    ///
    /// Ce patch gère le cas (a), en particulier pour éviter qu'un bouton « OK » dans un
    /// dialog duel soit déclenché automatiquement pendant que l'utilisateur lit les options.
    ///
    /// NOTE : Le blocage de la touche ENTRÉE ici est intentionnellement MINIMAL pour ne pas
    ///        rompre la navigation clavier native. Il est activé seulement dans les contextes
    ///        où un champ de texte est actif (IsEditingInputField).
    /// </summary>
    [HarmonyPatch]
    public static class EventSystemPatch
    {
        // ── Détection d'un champ de saisie actif ─────────────────────────────

        /// <summary>
        /// Retourne true si un InputField Unity (legacy UI ou TMP) est actuellement
        /// en mode édition — c'est-à-dire si l'utilisateur est en train de taper du texte.
        /// </summary>
        private static bool IsEditingInputField()
        {
            var current = EventSystem.current;
            if (current == null) return false;

            var selected = current.currentSelectedGameObject;
            if (selected == null) return false;

            // Unity UI legacy InputField
            var inputField = selected.GetComponent<UnityEngine.UI.InputField>();
            if (inputField != null && inputField.isFocused)
                return true;

            // TMP InputField
            var tmpInput = selected.GetComponent<TMPro.TMP_InputField>();
            if (tmpInput != null && tmpInput.isFocused)
                return true;

            // YgomSystem.UI.ExtendedInputField (hérite de InputField)
            // — couvert par le check InputField.isFocused ci-dessus

            return false;
        }

        // ── Patch 1 : StandaloneInputModule.SendMoveEventToSelectedObject ────
        //
        // Bloque la navigation directionnelle quand l'utilisateur édite un champ,
        // ET bloque Tab globalement (Unity traite Tab ici en mode « Move »).
        //
        // Pattern MTGA : EventSystemPatch.SendMoveEventToSelectedObject_Prefix bloque
        // Tab avec Input.GetKey(KeyCode.Tab) pour que Unity ne déclenche jamais de
        // navigation spatiale avec Tab — notre code en a le contrôle exclusif.

        [HarmonyPatch(typeof(StandaloneInputModule), "SendMoveEventToSelectedObject")]
        [HarmonyPrefix]
        public static bool SendMoveEventToSelectedObject_Prefix()
        {
            if (IsEditingInputField())
            {
                // Bloquer toute navigation directionnelle pendant la saisie
                return false;
            }

            // Bloquer Tab depuis Unity EventSystem.
            // Unity traite Tab ici AVANT notre Update(), ce qui peut ouvrir des dropdowns
            // ou déplacer le focus dans un ordre imprévu. Notre mod ne gère pas Tab
            // pour la navigation, mais le blocage empêche des effets de bord dans les menus.
            if (Input.GetKey(KeyCode.Tab))
            {
                return false;
            }

            return true;
        }

        // ── Patch 2 : StandaloneInputModule.SendSubmitEventToSelectedObject ──
        //
        // Bloque la touche Submit (Entrée) quand l'utilisateur édite un champ de saisie.
        // Exemple : dans DeckNameEditDialog, appuyer sur Entrée NE DOIT PAS valider
        // le formulaire tant que le champ est encore focalisé.

        [HarmonyPatch(typeof(StandaloneInputModule), "SendSubmitEventToSelectedObject")]
        [HarmonyPrefix]
        public static bool SendSubmitEventToSelectedObject_Prefix()
        {
            // Bloquer le Submit quand l'utilisateur est en train de taper dans un champ
            if (IsEditingInputField())
            {
                return false;
            }

            return true;
        }
    }
}
