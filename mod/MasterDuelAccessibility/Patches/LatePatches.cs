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

            // Patch DuelStartViewController / DuelStartViewController_Team / DuelStartOverlayViewController_Team
            // Annonce l'écran d'introduction du duel (section 3.2)
            DuelStartPatch.Reset();
            DuelStartPatch.Apply(_harmonyLate!);

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

            // Premier joueur — annonce qui joue en premier (pile/face ou aléatoire)
            TryPatchPostfix(
                "ChoiceFirstPlayerDialog", "ReqOpen",
                typeof(DuelMiscPatch), nameof(DuelMiscPatch.ChoiceFirstPlayer_ReqOpen_Postfix));

            // Dialog OK simple en duel (message déjà localisé par le jeu)
            // Patch la surcharge à 3 params : Open(string, Action<bool>, Action)
            TryPatchByParamCount(
                "DuelOkDialog", "Open", 3,
                typeof(DuelMiscPatch), nameof(DuelMiscPatch.DuelOkDialog_Open_Postfix));

            // Menu de position de monstre (Face-Up Attack / Face-Up Defense / Face-Down Defense)
            // CardCommandEx.Open(int cardID, int face, Vector3 screenPoint)
            TryPatchByParamCount(
                "CardCommandEx", "Open", 3,
                typeof(CardCommandExPatch), nameof(CardCommandExPatch.Open_Postfix));

            // Liste multi-sélection en duel (ordre de chaîne, choix de cibles groupés, etc.)
            // DuelPullDownDialog.Open(string, List<string>, int, Action<List<int>,bool>, Action) — 5 params
            TryPatchByParamCount(
                "DuelPullDownDialog", "Open", 5,
                typeof(DuelPullDownDialogPatch), nameof(DuelPullDownDialogPatch.Open_Postfix));

            // DuelInfoDialog.ReqOpen — messages informatifs en duel (non-interactifs)
            // ReqOpen(string message, Place, bool cancelable, Action, Action, bool, Action, Action)
            TryPatchPostfix(
                "DuelInfoDialog", "ReqOpen",
                typeof(DuelInfoDialogPatch), nameof(DuelInfoDialogPatch.ReqOpen_Postfix));

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

            // Dialog Rituel — annonce les conditions d'invocation rituelle
            DuelRitualDialogPatch.Reset();
            DuelRitualDialogPatch.Initialize(_harmonyLate!);

            // Navigation dans le menu de commande (CommandOperation.SetCursor)
            // Annonce la commande courante quand le joueur navigue dans le menu d'action
            CommandOperationPatch.Reset();
            CommandOperationPatch.Initialize(_harmonyLate!);

            // Curseur sur le terrain (RunEffectWorker.OnCursorEnter)
            // Annonce la carte/zone sous le curseur pendant la sélection de cibles
            DuelCursorPatch.Reset();
            DuelCursorPatch.Initialize(_harmonyLate!);

            // Placement d'invocation spéciale (SelectStandOperation.BeginSpSummon)
            // Annonce le mode de sélection : zone à choisir ou position du monstre
            SelectStandOperationPatch.Reset();
            SelectStandOperationPatch.Initialize(_harmonyLate!);

            Plugin.Instance?.LogMsg("[LatePatches] Patches duel appliqués.");
        }

        // ── Patches actifs hors duel ─────────────────────────────────────────

        private static void ApplyMenuScenePatches()
        {
            Plugin.Instance?.LogMsg("[LatePatches] Application des patches de scène menu...");

            // ShopViewController and SoloModeViewController have no Open() method.
            // Screen entry is announced by ViewControllerPatch.OnFocusChanged via ScreenTitles.

            // Patch DuelPassViewController.NotificationStackEntry — palier actuel + prochain palier
            DuelPassViewControllerPatch.Reset();
            DuelPassViewControllerPatch.Apply(_harmonyLate!);

            // Patch SoloGateViewController — annonce le nombre de portails + portail focalisé
            SoloGatePatch.Reset();
            SoloGatePatch.Apply(_harmonyLate!);

            // Patch SoloSelectChapterViewController.ChapterMap.OnClickChapter — annonce le chapitre cliqué
            SoloChapterPatch.Reset();
            SoloChapterPatch.Apply(_harmonyLate!);

            // Patch MissionViewController — annonce l'onglet actif à l'entrée
            MissionViewControllerPatch.Reset();
            MissionViewControllerPatch.Apply(_harmonyLate!);

            // Patch DuelpassResultViewController — montée de palier post-duel
            DuelpassResultViewPatch.Reset();
            DuelpassResultViewPatch.Apply(_harmonyLate!);

            // Patch LoginBonusViewController.OnCreatedView — annonce le bonus quotidien (Jour N sur M)
            LoginBonusPatch.Reset();
            LoginBonusPatch.Apply(_harmonyLate!);

            // Patch LotteryPortalViewController.NotificationStackEntry — annonce l'ouverture du portail
            LotteryPortalPatch.Reset();
            LotteryPortalPatch.Apply(_harmonyLate!);

            // Patch LotteryRewardViewContorller.OnCreatedView — annonce les cartes obtenues
            LotteryRewardPatch.Initialize(_harmonyLate!);

            // Patch ShopBuyViewController — annonce le produit sélectionné, navigation pages
            ShopBuyPatch.Apply(_harmonyLate!);

            // Patch NotificationViewController — annonce l'ouverture et les onglets
            NotificationPatch.Apply(_harmonyLate!);

            // Patch DuelPassRewardListViewController — annonce les récompenses du Duel Pass
            DuelPassRewardPatch.Apply(_harmonyLate!);

            // Patch DuelResultViewController — annonce résultat détaillé post-duel
            DuelResultPatch.Reset();
            DuelResultPatch.Apply(_harmonyLate!);

            // Patch DuelResultViewController_Solo, DuelistCupResultViewController,
            // ColosseumDuelResultViewController_Rate (section 5.2)
            DuelResultMiscPatch.Reset();
            DuelResultMiscPatch.Apply(_harmonyLate!);

            // Patch ProfileReplayViewController, RoomReplayViewController,
            // DuelLiveReplayDialogViewController (section 5.3)
            ReplayPatch.Reset();
            ReplayPatch.Apply(_harmonyLate!);

            // Patch PresentBoxViewController — boîte cadeaux avec ISV navigation
            PresentBoxPatch.Reset();
            PresentBoxPatch.Apply(_harmonyLate!);

            // Patch ScenarioViewController.NotificationStackEntry — scénario Solo
            ScenarioPatch.Reset();
            ScenarioPatch.Apply(_harmonyLate!);

            // Patch FriendViewController.NotificationStackEntry — liste d'amis
            FriendViewControllerPatch.Reset();
            FriendViewControllerPatch.Apply(_harmonyLate!);

            // Patch RoomViewController.NotificationStackEntry — salon privé
            RoomViewControllerPatch.Reset();
            RoomViewControllerPatch.Apply(_harmonyLate!);

            // Patch Room VCs secondaires — création, entrée, info, invitation, membres (section 10.2)
            RoomPatch.Reset();
            RoomPatch.Apply(_harmonyLate!);

            // Patch DeckBrowserViewController.NotificationStackEntry + TrialDrawViewController
            DeckBrowserPatch.Reset();
            DeckBrowserPatch.Apply(_harmonyLate!);

            // Patch StructureDeckSelectViewController / ObtainViewController — decks de structure
            StructureDeckPatch.Reset();
            StructureDeckPatch.Apply(_harmonyLate!);

            // Patch SeasonPointViewController.NotificationStackEntry — points de saison
            SeasonPointPatch.Reset();
            SeasonPointPatch.Apply(_harmonyLate!);

            // Patch ProfileViewController.NotificationStackEntry — profil joueur
            ProfilePatch.Reset();
            ProfilePatch.Apply(_harmonyLate!);

            // Patch ProfileData/Edit/CardCheck/FriendSearch (sections 11.1-11.2)
            ProfileMiscPatch.Reset();
            ProfileMiscPatch.Apply(_harmonyLate!);

            // Patch SeasonPoint secondary VCs (section 14)
            SeasonMiscPatch.Reset();
            SeasonMiscPatch.Apply(_harmonyLate!);

            // Patch Settings VCs (section 15)
            SettingsMiscPatch.Reset();
            SettingsMiscPatch.Apply(_harmonyLate!);

            // Patch remaining DeckEdit dialogs (section 6.1)
            DeckEditMiscPatch.Reset();
            DeckEditMiscPatch.Apply(_harmonyLate!);

            // Patch MissionBulkRecieveDialogWidget.OnPostAllInserted (section 12.2)
            MissionMiscPatch.Reset();
            MissionMiscPatch.Apply(_harmonyLate!);

            // Patch ShopViewController.NotificationStackEntry + OnClickMainTab + OnFocusProductLine
            ShopViewControllerPatch.Reset();
            ShopViewControllerPatch.Apply(_harmonyLate!);

            // Patch widgets d'achat : ConfirmRegDialogProductWidget + BuyButtonGroupWidget
            ShopBuyWidgetPatch.Reset();
            ShopBuyWidgetPatch.Apply(_harmonyLate!);

            // Patch boutique secondaire (gemmes, tickets, échanges, historique)
            ShopMiscPatch.Reset();
            ShopMiscPatch.Apply(_harmonyLate!);

            // Patches divers : cosmétiques deck, Neuron, lottery secondaires, packs
            MiscViewsPatch.Reset();
            MiscViewsPatch.Apply(_harmonyLate!);

            // Patch DownloadViewController — téléchargement initial
            DownloadViewControllerPatch.Reset();
            DownloadViewControllerPatch.Apply(_harmonyLate!);

            // Patch HomeAnnounceViewController, HomeActionViewController,
            // HomeSubMenuViewController, PreHomeViewController — sections 2.4 / 2.5
            HomeMiscPatch.Reset();
            HomeMiscPatch.Apply(_harmonyLate!);

            // Patch ViewController.NotificationStackEntry/Remove — détecte l'ouverture
            // des panneaux secondaires (Settings, LoginBonus, PresentBox, FriendSearch, etc.)
            // Pattern inspiré de AccessibleArena PanelStatePatch.Initialize().
            MenuPanelStatePatch.Reset();
            MenuPanelStatePatch.Apply(_harmonyLate!);

            Plugin.Instance?.LogMsg("[LatePatches] Patches menu appliqués.");
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        private static void TryPatchByParamCount(
            string typeName,
            string methodName,
            int    paramCount,
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

                var method = System.Array.Find(type.GetMethods(), m =>
                    m.Name == methodName && m.GetParameters().Length == paramCount);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn($"[LatePatches] '{typeName}.{methodName}' ({paramCount} params) introuvable.");
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
                Plugin.Instance?.LogMsg($"[LatePatches] ✓ {typeName}.{methodName} ({paramCount} params)");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[LatePatches] Échec {typeName}.{methodName}/{paramCount}: {ex.Message}");
            }
        }

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
                tts.Speak(Loc.Get("dice_result", Loc.Get(playerKey), __1), interrupt: false);
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
                tts.Speak(Loc.Get("coin_result", Loc.Get(playerKey), Loc.Get(sideKey)), interrupt: false);
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
                tts.Speak(Loc.Get("mulligan_open", __0), interrupt: false);
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
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }

        // Annonce qui joue en premier.
        // ChoiceFirstPlayerDialog.ReqOpen(int choicePlayer, int firstPlayer, bool coinFace, float showTime)
        //   firstPlayer : 0 = joueur local, 1 = adversaire
        public static void ChoiceFirstPlayer_ReqOpen_Postfix(int __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string key = __1 == 0 ? "first_player_you" : "first_player_opp";
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }

        // Annonce le message d'un dialog OK simple en duel.
        // DuelOkDialog.Open(string message, Action<bool> resultCallback, Action openCallback)
        //   __0 = message déjà localisé par le jeu
        public static void DuelOkDialog_Open_Postfix(string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (!string.IsNullOrWhiteSpace(__0))
                    tts.Speak(__0, interrupt: false);
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

    // =========================================================================
    // CardCommandEx — menu de position de monstre (Attaque / Défense / Face cachée)
    // =========================================================================

    internal static class CardCommandExPatch
    {
        /// <summary>
        /// Postfix pour CardCommandEx.Open(int cardID, int face, Vector3 screenPoint).
        ///
        /// __0 = cardID (int) — résolu en nom via Content.GetName
        /// __1 = face   (int) — 0 = face cachée, 1 = face visible
        ///
        /// Annonce le nom de la carte et les positions disponibles (lues depuis
        /// le tableau `buttons` via réflexion sur les boutons actifs).
        /// </summary>
        public static void Open_Postfix(object __instance, int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Résoudre le nom de la carte
                string? cardName = AccessToolsHelper.GetCardName(__0);

                // Lire les boutons actifs dans le menu
                var buttonsField = __instance.GetType()
                    .GetField("buttons", BindingFlags.NonPublic | BindingFlags.Instance);
                var buttonsArray = buttonsField?.GetValue(__instance) as System.Array;

                var positions = new System.Collections.Generic.List<string>(3);
                if (buttonsArray != null)
                {
                    foreach (var btn in buttonsArray)
                    {
                        if (btn == null) continue;
                        // Lire root (ElementObjectManager) → activeInHierarchy pour savoir si visible
                        var rootField = btn.GetType().GetField("root",
                            BindingFlags.Public | BindingFlags.Instance);
                        var root = rootField?.GetValue(btn);
                        if (root == null) continue;

                        // Vérifier si actif (ElementObjectManager wraps a GameObject)
                        var goField = root.GetType().GetField("gameObject",
                            BindingFlags.Public | BindingFlags.Instance);
                        var go = goField?.GetValue(root) as UnityEngine.GameObject;
                        if (go == null || !go.activeInHierarchy) continue;

                        // Lire le champ battlePosition (StandType)
                        var posField = btn.GetType().GetField("battlePosition",
                            BindingFlags.Public | BindingFlags.Instance);
                        if (posField?.GetValue(btn) is int pos)
                        {
                            string posLabel = pos switch
                            {
                                0 => Loc.Get("pos_front_atk"),
                                1 => Loc.Get("pos_front_def"),
                                2 => Loc.Get("pos_back_def"),
                                _ => string.Empty,
                            };
                            if (!string.IsNullOrEmpty(posLabel))
                                positions.Add(posLabel);
                        }
                    }
                }

                string msg = string.IsNullOrWhiteSpace(cardName)
                    ? Loc.Get("card_command_ex_nocard", string.Join(", ", positions))
                    : Loc.Get("card_command_ex", cardName!, string.Join(", ", positions));

                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }
    }

    // =========================================================================
    // DuelInfoDialog — messages informatifs en duel (non-interactifs ou cancelables)
    // =========================================================================

    internal static class DuelInfoDialogPatch
    {
        /// <summary>
        /// Postfix pour DuelInfoDialog.ReqOpen(
        ///   string message, DuelInfoDialogBase.Place place,
        ///   bool cancelable, Action cancelCallback, Action closeCallback,
        ///   bool decidable, Action decisionCallback, Action actCallback).
        ///
        /// __0 = message — texte informatif localisé par le jeu
        ///
        /// Utilisé pour afficher des messages d'effet ou d'information contextuels
        /// pendant le duel (non-interactifs ou avec boutons Annuler/Décision).
        /// </summary>
        public static void ReqOpen_Postfix(string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (!string.IsNullOrWhiteSpace(__0))
                    tts.Speak(__0, interrupt: false);
            }
            catch { }
        }
    }

    // =========================================================================
    // DuelPullDownDialog — liste multi-sélection en duel
    // =========================================================================

    internal static class DuelPullDownDialogPatch
    {
        /// <summary>
        /// Postfix pour DuelPullDownDialog.Open(
        ///   string message, List&lt;string&gt; selectionList,
        ///   int selectNum, Action&lt;List&lt;int&gt;, bool&gt; resultCallback, Action openCallback).
        ///
        /// __0 = message       — texte du prompt localisé par le jeu
        /// __1 = selectionList — liste des options (strings déjà localisés)
        /// __2 = selectNum     — nombre d'éléments à sélectionner
        /// </summary>
        public static void Open_Postfix(string __0, object __1, int __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Lire la liste d'options via IEnumerable
                var options = new System.Collections.Generic.List<string>();
                if (__1 is System.Collections.IEnumerable enumerable)
                {
                    foreach (var item in enumerable)
                    {
                        var s = item?.ToString();
                        if (!string.IsNullOrWhiteSpace(s))
                            options.Add(s!);
                    }
                }

                string prompt = string.IsNullOrWhiteSpace(__0)
                    ? Loc.Get("pulldown_select", __2)
                    : __0;

                string announcement = options.Count > 0
                    ? Loc.Get("pulldown_open", prompt, __2, string.Join(", ", options))
                    : Loc.Get("pulldown_open_nolist", prompt, __2);

                tts.Speak(announcement, interrupt: false);
            }
            catch { }
        }
    }
}
