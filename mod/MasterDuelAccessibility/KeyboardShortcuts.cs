using System;
using System.Reflection;
using Il2CppInterop.Runtime.InteropTypes;
using MasterDuelAccessibility.Models;
using MasterDuelAccessibility.Patches;
using UnityEngine;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// MonoBehaviour injecté via ClassInjector pour intercepter les raccourcis clavier.
    ///
    /// Raccourcis disponibles :
    /// ──────────────────────────────────────────────────────────────
    ///  Touche        KeyCode   Contexte   Action
    /// ────────────────────────────────────────────────────────────────
    ///  Espace          32      Duel       Lire les points de vie
    ///  Maj+Espace      32      Duel       État du duel (tour + phase + PV)
    ///  Alt gauche     308      Partout    Lire les infos carte en cours
    ///  F1             282      Partout    Lire la liste des raccourcis
    ///  F2             283      Partout    Répéter le dernier texte lu
    ///  F3             284      Duel       Lire toutes les cartes en main
    ///  F4             285      Duel       Lire les cartes sur le terrain
    ///  Maj+F4         285      Duel       Lire le terrain adverse
    ///  F5             286      Partout    Couper la lecture (silence)
    ///  F6             287      Duel       Lire le cimetière (joueur)
    ///  F7             288      Duel       Lire les cartes bannies (joueur)
    ///  F8             289      Duel       Lire l'Extra Deck (joueur)
    ///  F9             290      Duel       Lire le cimetière adversaire
    ///  F10            291      Duel       Taille des decks (moi + adv)
    ///  F11            292      Duel       Nombre de cartes en main adverse
    ///  F12            293      Partout    Historique des annonces (remonte dans le passé)
    /// ────────────────────────────────────────────────────────────────
    /// </summary>
    public class KeyboardShortcuts : MonoBehaviour
    {
        // Constructeur requis par Il2CppInterop
        public KeyboardShortcuts(IntPtr pointer) : base(pointer) { }

        // État duel — mis à jour par DuelEventPatch
        internal static bool IsInDuel = false;
        internal static int  MyLP     = 8000;
        internal static int  OppLP    = 8000;

        // Scheduled delayed card read (set by SelectionButtonPatch.OnPointerClick)
        internal static DateTime PendingCardReadAt = DateTime.MinValue;

        // Position de navigation dans l'historique des annonces (-1 = début / non actif)
        private static int _historyPos = -1;

        // Positions de navigation carte par carte (−1 = inactif, réinitialisé à chaque autre touche)
        // Inspiré du pattern MTGA IShortcutRegistry : navigation contextuelle dans une liste.
        private static int _handPos        = -1;  // Shift+F3 : main du joueur
        private static int _myFieldPos     = -1;  // Ctrl+F4  : terrain du joueur
        private static int _oppFieldNavPos = -1;  // Ctrl+Shift+F4 : terrain adverse

        // Fallback si le registre n'est pas encore initialisé
        private static string HelpText =>
            Plugin.Instance?.ShortcutRegistry.BuildHelpText()
            ?? Loc.Get("help_text");

        /// <summary>
        /// Enregistre tous les raccourcis dans le ShortcutRegistry du Plugin.
        /// Inspiré de MTGA IShortcutRegistry.RegisterShortcut(...).
        ///
        /// Règle d'ordre : les variantes AVEC modificateur sont enregistrées AVANT
        /// le catch-all SANS modificateur pour qu'elles aient la priorité.
        /// Ex. : Maj+Espace (état duel) avant Espace (PV seuls).
        ///
        /// ActiveCondition = () => IsInDuel pour les raccourcis duel uniquement.
        /// null = toujours actif (F1, F2, F5, Alt).
        /// </summary>
        public void Awake()
        {
            var r = Plugin.Instance?.ShortcutRegistry;
            if (r == null) return;

            // ── Raccourcis globaux (toujours actifs) ─────────────────────────

            // Alt — Infos carte
            r.Register(new ShortcutDefinition(
                (KeyCode)308, null, "shortcut_alt",
                () => WithTts(ReadCurrentCard)));

            // F1 — Aide (texte dynamique depuis le registre)
            r.Register(new ShortcutDefinition(
                (KeyCode)282, null, "shortcut_f1",
                () => WithTts(t => t.Speak(HelpText, interrupt: true))));

            // F2 — Répéter
            r.Register(new ShortcutDefinition(
                (KeyCode)283, null, "shortcut_f2",
                () => Plugin.Instance?.Tts?.Repeat()));

            // F5 — Silence
            r.Register(new ShortcutDefinition(
                (KeyCode)286, null, "shortcut_f5",
                () => Plugin.Instance?.Tts?.Silence()));

            // ── Raccourcis duel uniquement ────────────────────────────────────

            // Maj+Espace — État complet du duel (avant Espace pour priorité)
            r.Register(new ShortcutDefinition(
                (KeyCode)32, KeyCode.LeftShift, "shortcut_shift_space",
                () => WithTts(ReadDuelStatus),
                () => IsInDuel));

            // Espace — PV des joueurs
            r.Register(new ShortcutDefinition(
                (KeyCode)32, null, "shortcut_space",
                () => WithTts(t => t.Speak(Loc.Get("duel_lp_status", MyLP, OppLP), interrupt: true)),
                () => IsInDuel));

            // Shift+F3 — Carte suivante dans la main (avant F3 pour priorité)
            // Note : géré par Update() (stateful). L'entrée sert uniquement à l'aide F1.
            r.Register(new ShortcutDefinition(
                (KeyCode)284, KeyCode.LeftShift, "shortcut_shift_f3",
                () => WithTts(HandleHandCardNav),
                () => IsInDuel));

            // F3 — Toutes les cartes en main
            r.Register(new ShortcutDefinition(
                (KeyCode)284, null, "shortcut_f3",
                () => WithTts(ReadHandCards),
                () => IsInDuel));

            // Ctrl+Shift+F4 — Carte suivante sur le terrain adverse (avant Ctrl+F4 pour priorité)
            // Note : géré par Update() (stateful). L'entrée sert uniquement à l'aide F1.
            r.Register(new ShortcutDefinition(
                (KeyCode)285, KeyCode.LeftControl, "shortcut_ctrl_shift_f4",
                () => WithTts(HandleOppFieldCardNav),
                () => IsInDuel,
                secondModifier: KeyCode.LeftShift));

            // Ctrl+F4 — Carte suivante sur le terrain (avant Shift+F4 et F4 pour priorité)
            // Note : géré par Update() (stateful). L'entrée sert uniquement à l'aide F1.
            r.Register(new ShortcutDefinition(
                (KeyCode)285, KeyCode.LeftControl, "shortcut_ctrl_f4",
                () => WithTts(HandleMyFieldCardNav),
                () => IsInDuel));

            // Maj+F4 — Terrain adverse (avant F4 pour priorité)
            r.Register(new ShortcutDefinition(
                (KeyCode)285, KeyCode.LeftShift, "shortcut_shift_f4",
                () => WithTts(ReadOppFieldCards),
                () => IsInDuel));

            // F4 — Terrain du joueur
            r.Register(new ShortcutDefinition(
                (KeyCode)285, null, "shortcut_f4",
                () => WithTts(ReadFieldCards),
                () => IsInDuel));

            // F6 — Cimetière
            r.Register(new ShortcutDefinition(
                (KeyCode)287, null, "shortcut_f6",
                () => WithTts(ReadGraveCards),
                () => IsInDuel));

            // Ctrl+F7 — Cartes bannies adversaires (avant F7 pour priorité)
            r.Register(new ShortcutDefinition(
                (KeyCode)288, KeyCode.LeftControl, "shortcut_ctrl_f7",
                () => WithTts(ReadOppBanishedCards),
                () => IsInDuel));

            // F7 — Cartes bannies
            r.Register(new ShortcutDefinition(
                (KeyCode)288, null, "shortcut_f7",
                () => WithTts(ReadBanishedCards),
                () => IsInDuel));

            // Ctrl+F8 — Taille Extra Deck adversaire (avant F8 pour priorité)
            r.Register(new ShortcutDefinition(
                (KeyCode)289, KeyCode.LeftControl, "shortcut_ctrl_f8",
                () => WithTts(ReadOppExtraDeckCount),
                () => IsInDuel));

            // F8 — Extra Deck
            r.Register(new ShortcutDefinition(
                (KeyCode)289, null, "shortcut_f8",
                () => WithTts(ReadExtraDeck),
                () => IsInDuel));

            // F9 — Cimetière adversaire
            r.Register(new ShortcutDefinition(
                (KeyCode)290, null, "shortcut_f9",
                () => WithTts(ReadOppGrave),
                () => IsInDuel));

            // F10 — Taille des decks
            r.Register(new ShortcutDefinition(
                (KeyCode)291, null, "shortcut_f10",
                () => WithTts(ReadDeckCount),
                () => IsInDuel));

            // F11 — Main adverse (nombre uniquement — confidentialité)
            r.Register(new ShortcutDefinition(
                (KeyCode)292, null, "shortcut_f11",
                () => WithTts(ReadOppHandCount),
                () => IsInDuel));

            // Tab — Avancer la phase / passer la priorité (duel uniquement)
            // Note : le déclenchement est géré dans Update() (early-exit, avant la remise
            // à zéro des positions de navigation). L'action ici est vide — uniquement pour
            // que BuildHelpText() inclue ce raccourci dans l'aide F1.
            r.Register(new ShortcutDefinition(
                KeyCode.Tab, null, "shortcut_tab",
                () => { },   // handled in Update() early exit
                () => IsInDuel));

            Plugin.Instance?.LogMsg($"[Shortcuts] Registre initialisé avec {r.GetAll().Count} raccourcis.");
        }

        public void Update()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            // Pending card read triggered by a click on a preview element
            if (PendingCardReadAt != DateTime.MinValue && DateTime.Now >= PendingCardReadAt)
            {
                PendingCardReadAt = DateTime.MinValue;
                ReadCurrentCard(tts);
                return;
            }

            // Calcul précoce des modificateurs — nécessaire pour les raccourcis
            // avec état ET pour le registre.
            bool shift = Input.GetKey((KeyCode)304) || Input.GetKey((KeyCode)303);
            bool ctrl  = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
            bool alt   = Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);

            // ── Raccourcis AVEC ÉTAT — traités AVANT anyKeyDown pour préserver la position ──
            // Inspiré du pattern MTGA : les actions stateful retournent tôt avant la remise
            // à zéro, comme F12/Historique dans MTGA AccessibleArena.

            // F12 — Historique des annonces (stateful)
            if (Input.GetKeyDown((KeyCode)293))
            {
                HandleHistory(tts);
                return;
            }

            // Shift+F3 — Navigation carte par carte dans la main (duel uniquement)
            if (IsInDuel && Input.GetKeyDown((KeyCode)284) && shift && !ctrl && !alt)
            {
                HandleHandCardNav(tts);
                return;
            }

            // Ctrl+Shift+F4 — Navigation carte par carte sur le terrain adverse (duel uniquement)
            // (Vérifié AVANT Ctrl+F4 pour la priorité : plus spécifique — deux modificateurs)
            if (IsInDuel && Input.GetKeyDown((KeyCode)285) && ctrl && shift && !alt)
            {
                HandleOppFieldCardNav(tts);
                return;
            }

            // Ctrl+F4 — Navigation carte par carte sur le terrain du joueur (duel uniquement)
            if (IsInDuel && Input.GetKeyDown((KeyCode)285) && ctrl && !shift && !alt)
            {
                HandleMyFieldCardNav(tts);
                return;
            }

            // Tab — Avancer la phase / passer la priorité (duel uniquement)
            // Inspiré du pattern AccessibleArena UIActivator : déclencher programmatiquement
            // un bouton de l'interface jeu via réflexion (PhaseSelect3D.OnClickButtonPhase).
            // Tab = "passer au suivant / confirmer" — conventionnel pour un lecteur d'écran.
            if (IsInDuel && Input.GetKeyDown(KeyCode.Tab) && !ctrl && !alt)
            {
                HandlePhaseAdvance(tts);
                return;
            }

            // Tout autre appui réinitialise TOUTES les positions de navigation
            if (Input.anyKeyDown)
            {
                _historyPos     = -1;
                _handPos        = -1;
                _myFieldPos     = -1;
                _oppFieldNavPos = -1;
            }

            // Déléguer tous les autres raccourcis au registre
            // Inspiré de IShortcutRegistry.ProcessKey(KeyCode, bool shift, bool ctrl, bool alt)
            var registry = Plugin.Instance?.ShortcutRegistry;
            if (registry == null) return;

            foreach (var key in registry.WatchedKeys)
            {
                if (Input.GetKeyDown(key))
                {
                    registry.ProcessKey(key, shift, ctrl, alt);
                    break;  // Une seule touche par frame
                }
            }
        }

        // ── F12 : Historique (stateful, hors registre) ───────────────────────

        private static void HandleHistory(TtsService tts)
        {
            if (tts.HistoryCount == 0)
            {
                tts.Speak(Loc.Get("history_empty"), interrupt: true, addToHistory: false);
                return;
            }
            _historyPos = Math.Min(_historyPos + 1, tts.HistoryCount - 1);
            var entry = tts.GetHistoryEntry(_historyPos)!;
            tts.Speak(
                Loc.Get("history_entry", _historyPos + 1, tts.HistoryCount, entry),
                interrupt: true, addToHistory: false);
        }

        // ── Shift+F3 : Navigation carte par carte dans la main ───────────────

        /// <summary>
        /// Cycle through hand cards one by one, reading just the current card.
        /// Position wraps around. Resets when any other key is pressed.
        /// </summary>
        private static void HandleHandCardNav(TtsService tts)
        {
            var names = CollectCardNames(hand: true, team: 0);
            if (names.Length == 0)
            {
                tts.Speak(Loc.Get("hand_empty"), interrupt: true, addToHistory: false);
                _handPos = -1;
                return;
            }
            _handPos = (_handPos + 1) % names.Length;
            tts.Speak(
                Loc.Get("hand_card_nav", names[_handPos], _handPos + 1, names.Length),
                interrupt: true, addToHistory: false);
        }

        // ── Ctrl+F4 / Ctrl+Shift+F4 : Navigation carte par carte sur le terrain ─

        /// <summary>
        /// Cycle through my field cards one by one with full stats (ATK/DEF/position/counters).
        /// </summary>
        private static void HandleMyFieldCardNav(TtsService tts)
        {
            var names = CollectCardNames(hand: false, team: 0);
            if (names.Length == 0)
            {
                tts.Speak(Loc.Get("field_empty"), interrupt: true, addToHistory: false);
                _myFieldPos = -1;
                return;
            }
            _myFieldPos = (_myFieldPos + 1) % names.Length;
            tts.Speak(
                Loc.Get("field_card_nav", names[_myFieldPos], _myFieldPos + 1, names.Length),
                interrupt: true, addToHistory: false);
        }

        /// <summary>
        /// Cycle through opponent field cards one by one.
        /// Face-down cards are announced as "face-down card" (privacy-safe).
        /// </summary>
        private static void HandleOppFieldCardNav(TtsService tts)
        {
            var names = CollectCardNames(hand: false, team: 1);
            if (names.Length == 0)
            {
                tts.Speak(Loc.Get("opp_field_empty"), interrupt: true, addToHistory: false);
                _oppFieldNavPos = -1;
                return;
            }
            _oppFieldNavPos = (_oppFieldNavPos + 1) % names.Length;
            tts.Speak(
                Loc.Get("opp_field_card_nav", names[_oppFieldNavPos], _oppFieldNavPos + 1, names.Length),
                interrupt: true, addToHistory: false);
        }

        // ── Tab : Avancer la phase / passer la priorité ──────────────────────

        /// <summary>
        /// Simule un clic sur le bouton de phase (PhaseSelect3D) pour avancer la phase
        /// ou passer la priorité sans utiliser la souris.
        ///
        /// Stratégie (inspirée d'AccessibleArena UIActivator) :
        ///   1. Trouver l'instance active de PhaseSelect3D via FindObjectsOfType
        ///   2. Appeler PhaseSelect3D.OnClickButtonPhase() via réflexion
        ///
        /// Le TTS de confirmation vient de PhasePatch.PhaseChange_Postfix — aucun message
        /// additionnel nécessaire ici si la phase change. On n'annonce que si le bouton
        /// est indisponible (phase non encore sélectionnable).
        /// </summary>
        private static void HandlePhaseAdvance(TtsService tts)
        {
            try
            {
                var phaseType = AccessToolsHelper.FindType("PhaseSelect3D");
                if (phaseType == null)
                {
                    tts.Speak(Loc.Get("phase_btn_unavailable"), interrupt: true, addToHistory: false);
                    return;
                }

                var instances = FindObjectsOfType(phaseType);
                if (instances == null || instances.Length == 0)
                {
                    tts.Speak(Loc.Get("phase_btn_unavailable"), interrupt: true, addToHistory: false);
                    return;
                }

                var clickMethod = phaseType.GetMethod(
                    "OnClickButtonPhase",
                    System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                foreach (var inst in instances)
                {
                    if (inst == null) continue;

                    // Vérifier que le GO est actif (le bouton de phase est parfois caché
                    // pendant le tour adversaire ou la résolution d'un effet).
                    var goProp = inst.GetType().GetProperty("gameObject");
                    var go     = goProp?.GetValue(inst);
                    var active = go?.GetType()
                        .GetProperty("activeInHierarchy")?.GetValue(go) as bool?;
                    if (active != true) continue;

                    clickMethod?.Invoke(inst, null);
                    // PhasePatch annoncera le changement de phase — pas besoin d'annonce ici.
                    return;
                }

                // Aucune instance active — le bouton est indisponible (tour adverse, etc.)
                tts.Speak(Loc.Get("phase_btn_unavailable"), interrupt: true, addToHistory: false);
            }
            catch { }
        }

        // ── Helper : exécute une action avec TtsService ───────────────────────

        private static void WithTts(Action<TtsService> action)
        {
            var t = Plugin.Instance?.Tts;
            if (t != null) action(t);
        }

        // ── Lecture des infos carte ──────────────────────────────────────────

        private static void ReadCurrentCard(TtsService tts)
        {
            try
            {
                // ── Navigateur de cartes : lecture par slot de page ─────────
                if (CardBrowserPatch.IsActive())
                {
                    int idx = CardBrowserPatch.GetCurrentPage() % 3;
                    string detailPath =
                        "UI/OverlayCanvas/DialogManager/CardBrowser/CardBrowserUI(Clone)/" +
                        $"Scroll View/Viewport/Content/Template(Clone){idx}/" +
                        "CardInfoDetail_Browser(Clone)";
                    var browserGO  = AccessToolsHelper.FindGameObjectByPath(detailPath);
                    var detailType = AccessToolsHelper.FindType("CardInfoDetail");
                    if (browserGO != null && detailType != null)
                    {
                        var getComp = browserGO.GetType().GetMethod(
                            "GetComponent",
                            BindingFlags.Public | BindingFlags.Instance,
                            null, new[] { typeof(Type) }, null);
                        var detail = getComp?.Invoke(browserGO, new object[] { detailType });
                        if (detail != null)
                        {
                            string announcement = CardInfoPatch.BuildAnnouncement(detail);
                            if (!string.IsNullOrWhiteSpace(announcement))
                                tts.Speak(announcement, interrupt: true);
                            return;
                        }
                    }
                }

                // ── CardInfo standard (duel, éditeur de deck, boutique…) ────
                // Cherche CardInfo ET CardInfoDetail pour couvrir tous les contextes.
                foreach (var typeName in new[] { "CardInfo", "CardInfoDetail" })
                {
                    var cardInfoType = AccessToolsHelper.FindType(typeName);
                    if (cardInfoType == null) continue;

                    var instances = FindObjectsOfType(cardInfoType);
                    if (instances == null) continue;

                    foreach (var inst in instances)
                    {
                        var goProp = inst.GetType().GetProperty("gameObject");
                        var go     = goProp?.GetValue(inst);
                        var active = go?.GetType()
                            .GetProperty("activeInHierarchy")?.GetValue(go) as bool?;
                        if (active != true) continue;

                        string announcement = CardInfoPatch.BuildAnnouncement(inst);
                        if (!string.IsNullOrWhiteSpace(announcement))
                        {
                            tts.Speak(announcement, interrupt: true);
                            return;
                        }
                    }
                }
            }
            catch { tts.Speak(Loc.Get("card_not_available")); }
        }

        // ── Lecture main / terrain ───────────────────────────────────────────

        private static void ReadHandCards(TtsService tts)
        {
            try
            {
                var names = CollectCardNames(hand: true, team: 0);
                string msg = names.Length > 0
                    ? Loc.Get("hand_cards",
                        names.Length,
                        names.Length > 1 ? "s" : "",
                        string.Join(", ", names))
                    : Loc.Get("hand_empty");
                tts.Speak(msg, interrupt: true);
            }
            catch { tts.Speak(Loc.Get("hand_error")); }
        }

        private static void ReadFieldCards(TtsService tts)
        {
            try
            {
                var names = CollectCardNames(hand: false, team: 0);
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("field_cards", string.Join(", ", names))
                        : Loc.Get("field_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("field_error")); }
        }

        private static void ReadOppFieldCards(TtsService tts)
        {
            try
            {
                var names = CollectCardNames(hand: false, team: 1);
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("opp_field_cards", string.Join(", ", names))
                        : Loc.Get("opp_field_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("opp_field_error")); }
        }

        private static void ReadDuelStatus(TtsService tts)
        {
            string key = GameState.CurrentPlayer == 0 ? "duel_status_yours" : "duel_status_opp";
            string msg = Loc.Get(key, GameState.CurrentTurn, MyLP, OppLP);
            if (!string.IsNullOrEmpty(GameState.CurrentPhaseLabel))
                msg += " " + GameState.CurrentPhaseLabel + ".";
            tts.Speak(msg, interrupt: true);
        }

        private static void ReadGraveCards(TtsService tts)
        {
            try
            {
                // position 16 = Grave (BindingDuelFieldCards.FieldPostion.Grave)
                var names = CollectCardNamesAt(16);
                string plural = names.Length == 1 ? "" : "s";
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("grave_cards", names.Length, plural, string.Join(", ", names))
                        : Loc.Get("grave_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("grave_error")); }
        }

        private static void ReadBanishedCards(TtsService tts)
        {
            try
            {
                // position 17 = Exclusion (banished zone)
                var names = CollectCardNamesAt(17);
                string plural = names.Length == 1 ? "" : "s";
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("banished_cards", names.Length, plural, string.Join(", ", names))
                        : Loc.Get("banished_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("banished_error")); }
        }

        private static void ReadExtraDeck(TtsService tts)
        {
            try
            {
                // position 14 = DeckEx (Extra Deck)
                var names = CollectCardNamesAt(14);
                string plural = names.Length == 1 ? "" : "s";
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("extra_deck_cards", names.Length, plural, string.Join(", ", names))
                        : Loc.Get("extra_deck_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("extra_deck_error")); }
        }

        private static void ReadOppGrave(TtsService tts)
        {
            try
            {
                // position 16 = Grave, team 1 = opponent
                var names = CollectCardNamesAt(16, team: 1);
                string plural = names.Length == 1 ? "" : "s";
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("opp_grave_cards", names.Length, plural, string.Join(", ", names))
                        : Loc.Get("opp_grave_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("opp_grave_error")); }
        }

        private static void ReadOppBanishedCards(TtsService tts)
        {
            try
            {
                // position 17 = Exclusion (banished zone), team 1 = opponent
                var names = CollectCardNamesAt(17, team: 1);
                string plural = names.Length == 1 ? "" : "s";
                tts.Speak(
                    names.Length > 0
                        ? Loc.Get("opp_banished_cards", names.Length, plural, string.Join(", ", names))
                        : Loc.Get("opp_banished_empty"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("opp_banished_error")); }
        }

        private static void ReadOppExtraDeckCount(TtsService tts)
        {
            try
            {
                // position 14 = DeckEx (Extra Deck), team 1 = opponent
                // Count only — opponent Extra Deck card names are private
                int count = CountCardsAt(14, team: 1);
                string plural = count == 1 ? "" : "s";
                tts.Speak(Loc.Get("opp_extra_deck_count", count, plural), interrupt: true);
            }
            catch { tts.Speak(Loc.Get("opp_extra_deck_error")); }
        }

        private static void ReadDeckCount(TtsService tts)
        {
            try
            {
                // position 15 = Deck (main deck, both players)
                int myCount  = CountCardsAt(15, team: 0);
                int oppCount = CountCardsAt(15, team: 1);
                tts.Speak(Loc.Get("deck_count",
                    myCount,  myCount  == 1 ? "" : "s",
                    oppCount, oppCount == 1 ? "" : "s"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("deck_error")); }
        }

        private static void ReadOppHandCount(TtsService tts)
        {
            try
            {
                // position 13 = Hand, team 1 = opponent
                // Count only — card names are hidden in real duels (privacy-safe)
                int count = CountCardsAt(13, team: 1);
                tts.Speak(Loc.Get("opp_hand_count", count, count == 1 ? "" : "s"),
                    interrupt: true);
            }
            catch { tts.Speak(Loc.Get("opp_hand_error")); }
        }

        /// <summary>
        /// Collecte les noms des cartes d'une équipe via réflexion sur CardRoot.
        ///
        /// Utilise Content.Instance.GetName(cardId) pour résoudre l'identifiant
        /// numérique en nom lisible (pas de dépendance compile-time sur Assembly-CSharp).
        ///
        /// team=0 = joueur local (défaut), team=1 = adversaire.
        /// Pour team=1, les cartes face cachée sont annoncées sans leur nom (vie privée).
        ///
        /// CardRoot.position (int public) correspond à BindingDuelFieldCards.FieldPostion :
        ///   0-12 = zones de jeu (monstres, sorts/pièges, zone terrain)
        ///   13   = main (Hand)
        /// </summary>
        private static string[] CollectCardNames(bool hand, int team = 0)
        {
            // For field cards, collect (position, entry) pairs so we can sort by zone.
            // Sorting gives logical order: Monster 1-5 → Extra 1-2 → Spell/Trap 1-5 → Field Spell.
            // Inspired by AccessibleArena ElementGroupAssigner which classifies elements by
            // their position in the parent hierarchy into semantic groups.
            var fieldEntries = hand
                ? null
                : new System.Collections.Generic.List<(int pos, string entry)>();
            var result = hand
                ? new System.Collections.Generic.List<string>()
                : null;

            try
            {
                // ── 1. Obtenir Content.Instance et la méthode GetName ───────
                var contentType = AccessToolsHelper.FindType("Content");
                if (contentType == null) return Array.Empty<string>();

                var instanceProp = contentType.GetProperty("Instance",
                    BindingFlags.Public | BindingFlags.Static);
                var contentInstance = instanceProp?.GetValue(null);
                if (contentInstance == null) return Array.Empty<string>();

                var getNameMethod = contentType.GetMethod("GetName",
                    BindingFlags.Public | BindingFlags.Instance,
                    null,
                    new[] { typeof(int), typeof(bool) },
                    null);
                if (getNameMethod == null) return Array.Empty<string>();

                // ── 2. Récupérer tous les CardRoot actifs ────────────────────
                var rootType = AccessToolsHelper.FindType("CardRoot");
                if (rootType == null) return Array.Empty<string>();

                var roots = FindObjectsOfType(rootType);
                if (roots == null) return Array.Empty<string>();

                var pub = BindingFlags.Public | BindingFlags.Instance;
                var teamProp     = rootType.GetProperty("team",             pub);
                var cardIdProp   = rootType.GetProperty("cardId",           pub);
                var isFaceProp   = rootType.GetProperty("isFace",           pub);
                var isAttackProp = rootType.GetProperty("isAttack",         pub);
                var atkProp      = rootType.GetProperty("atk",              pub);
                var defProp      = rootType.GetProperty("def",              pub);
                var counterProp  = rootType.GetProperty("validCounterCount",pub);
                var posField     = rootType.GetField("position",            pub);

                // ── 3. Filtrer et résoudre les noms ──────────────────────────
                // Hand = 13, Terrain = 0-12
                foreach (var root in roots)
                {
                    if (root == null) continue;

                    if (teamProp?.GetValue(root) is not int t || t != team) continue;

                    int pos = posField?.GetValue(root) is int p ? p : -1;
                    bool isHand  = pos == 13;
                    bool isField = pos is >= 0 and <= 12;

                    if (hand && !isHand)  continue;
                    if (!hand && !isField) continue;

                    if (cardIdProp?.GetValue(root) is not int cardId || cardId <= 0) continue;

                    string? name = getNameMethod.Invoke(contentInstance,
                        new object[] { cardId, false }) as string;
                    if (string.IsNullOrWhiteSpace(name)) continue;

                    if (!hand)
                    {
                        // Monster zones = positions 0-6 (main 0-4, extra 5-6)
                        bool isMonsterZone = pos <= 6;
                        bool isFace  = isFaceProp?.GetValue(root)  is bool f  && f;
                        bool isAtk   = isAttackProp?.GetValue(root) is bool ia ? ia : true;
                        int  counters = counterProp?.GetValue(root) is int  c  ? c  : 0;

                        string cardInfo;
                        if (!isFace)
                        {
                            cardInfo = team != 0
                                ? Loc.Get("card_face_down_unknown")   // opponent: hide name
                                : name! + Loc.Get("card_face_down");  // own: name + "(face cachée)"
                        }
                        else
                        {
                            cardInfo = name!;
                            if (isMonsterZone)
                            {
                                int atk = atkProp?.GetValue(root) is int a ? a : -1;
                                int def = defProp?.GetValue(root) is int d ? d : -1;
                                if (atk >= 0 && def >= 0)
                                    cardInfo += $" ATK {atk} DEF {def}";
                                cardInfo += " " + Loc.Get(isAtk ? "monster_attack_pos" : "monster_defense_pos");
                                if (counters > 0)
                                    cardInfo += " " + Loc.Get("monster_counters", counters, counters > 1 ? "s" : "");
                            }
                        }

                        // Prepend zone label — analogous to AccessibleArena ElementGroup prefix
                        // so the user always knows which zone a card occupies.
                        string entry = Loc.Get("field_card_with_zone", GetZoneName(pos), cardInfo);
                        fieldEntries!.Add((pos, entry));
                    }
                    else
                    {
                        result!.Add(name!);
                    }
                }
            }
            catch { /* réflexion silencieuse */ }

            if (hand)
                return result!.ToArray();

            // Sort field entries by position so they appear in logical zone order:
            // Monster 1-5 (0-4) → Extra 1-2 (5-6) → Spell/Trap 1-5 (7-11) → Field Spell (12)
            fieldEntries!.Sort((a, b) => a.pos.CompareTo(b.pos));
            var sorted = new string[fieldEntries.Count];
            for (int i = 0; i < fieldEntries.Count; i++) sorted[i] = fieldEntries[i].entry;
            return sorted;
        }

        /// <summary>
        /// Collecte les noms des cartes à une position et une équipe précises.
        /// team=0 = joueur local (défaut), team=1 = adversaire.
        /// Positions utiles : 14=Extra Deck, 16=Cimetière, 17=Bannis.
        /// </summary>
        private static string[] CollectCardNamesAt(int targetPosition, int team = 0)
        {
            var result = new System.Collections.Generic.List<string>();
            try
            {
                var contentType = AccessToolsHelper.FindType("Content");
                if (contentType == null) return Array.Empty<string>();

                var instanceProp = contentType.GetProperty("Instance",
                    BindingFlags.Public | BindingFlags.Static);
                var contentInstance = instanceProp?.GetValue(null);
                if (contentInstance == null) return Array.Empty<string>();

                var getNameMethod = contentType.GetMethod("GetName",
                    BindingFlags.Public | BindingFlags.Instance,
                    null,
                    new[] { typeof(int), typeof(bool) },
                    null);
                if (getNameMethod == null) return Array.Empty<string>();

                var rootType = AccessToolsHelper.FindType("CardRoot");
                if (rootType == null) return Array.Empty<string>();

                var roots = FindObjectsOfType(rootType);
                if (roots == null) return Array.Empty<string>();

                var teamProp   = rootType.GetProperty("team",   BindingFlags.Public | BindingFlags.Instance);
                var cardIdProp = rootType.GetProperty("cardId", BindingFlags.Public | BindingFlags.Instance);
                var posField   = rootType.GetField("position",  BindingFlags.Public | BindingFlags.Instance);

                foreach (var root in roots)
                {
                    if (root == null) continue;
                    if (teamProp?.GetValue(root) is not int t || t != team) continue;

                    int pos = posField?.GetValue(root) is int p ? p : -1;
                    if (pos != targetPosition) continue;

                    if (cardIdProp?.GetValue(root) is not int cardId || cardId <= 0) continue;

                    string? name = getNameMethod.Invoke(contentInstance,
                        new object[] { cardId, false }) as string;
                    if (!string.IsNullOrWhiteSpace(name))
                        result.Add(name!);
                }
            }
            catch { /* réflexion silencieuse */ }
            return result.ToArray();
        }

        /// <summary>
        /// Compte les CarRoot à une position/équipe sans résolution de nom.
        /// Utilisé pour le compteur de deck (position 15).
        /// </summary>
        private static int CountCardsAt(int targetPosition, int team = 0)
        {
            int count = 0;
            try
            {
                var rootType = AccessToolsHelper.FindType("CardRoot");
                if (rootType == null) return 0;

                var roots = FindObjectsOfType(rootType);
                if (roots == null) return 0;

                var pub      = BindingFlags.Public | BindingFlags.Instance;
                var teamProp = rootType.GetProperty("team",    pub);
                var posField = rootType.GetField("position",   pub);

                foreach (var root in roots)
                {
                    if (root == null) continue;
                    if (teamProp?.GetValue(root) is not int t || t != team) continue;
                    if (posField?.GetValue(root) is int pos && pos == targetPosition)
                        count++;
                }
            }
            catch { }
            return count;
        }

        // ── Zone names (inspired by AccessibleArena ElementGroup) ────────────

        /// <summary>
        /// Maps a CardRoot field position (0–12) to a readable zone label.
        /// Analogous to AccessibleArena ElementGroupAssigner.DetermineGroup() which
        /// classifies UI elements by their parent path/position.
        ///
        /// Position → Zone :
        ///   0–4  : Monster Zone 1–5   (main monster zones)
        ///   5–6  : Extra Zone 1–2     (extra monster zones, centre)
        ///   7–11 : Spell/Trap Zone 1–5
        ///   12   : Field Spell Zone
        /// </summary>
        private static string GetZoneName(int pos) => pos switch
        {
            >= 0 and <= 4   => Loc.Get("zone_monster",    pos + 1),
            5 or 6          => Loc.Get("zone_extra",       pos - 4),
            >= 7 and <= 11  => Loc.Get("zone_spelltrap",  pos - 6),
            12              => Loc.Get("zone_fieldspell"),
            _               => Loc.Get("zone_unknown",    pos)
        };

        // ── Helpers réflexion Unity IL2CPP ───────────────────────────────────

        private static object? FindObjectOfType(Type t)
        {
            try
            {
                // UnityEngine.Object.FindObjectOfType<T>() → version non-générique
                var method = typeof(UnityEngine.Object).GetMethod(
                    "FindObjectOfType",
                    BindingFlags.Public | BindingFlags.Static,
                    null,
                    new[] { typeof(Type) },
                    null);
                return method?.Invoke(null, new object[] { t });
            }
            catch { return null; }
        }

        private static object[]? FindObjectsOfType(Type t)
        {
            try
            {
                var method = typeof(UnityEngine.Object).GetMethod(
                    "FindObjectsOfType",
                    BindingFlags.Public | BindingFlags.Static,
                    null,
                    new[] { typeof(Type) },
                    null);
                var result = method?.Invoke(null, new object[] { t });
                if (result is Array arr)
                {
                    var list = new object[arr.Length];
                    for (int i = 0; i < arr.Length; i++) list[i] = arr.GetValue(i)!;
                    return list;
                }
                return null;
            }
            catch { return null; }
        }
    }
}
