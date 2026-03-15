# MasterDuelAccessibility — Plan de couverture complète

Date : 2026-03-15 (mis à jour)
Objectif : couvrir l'intégralité des fonctionnalités du jeu du premier lancement à l'utilisation quotidienne.

Légende :
- DONE = implémenté et déployé
- PARTIAL = partiellement couvert (écran détecté mais contenu pas lu)
- TODO = pas encore implémenté
- SKIP = pas pertinent pour l'accessibilité (animation pure, test interne, etc.)

Sources : 240 ViewControllers, 80+ Widgets, 60+ namespaces dans Assembly-CSharp décompilé.

---

## 1. DÉMARRAGE ET ÉCRAN TITRE

Statut global : DONE

### 1.1 Logos et séquence de boot
- DONE — TitleScreenPatch : BootSequence.Start → annonce "Chargement..."
- DONE — TitleScreenPatch : SystemProgress.DispProgress → progression affichée
- DONE — TitleScreenPatch : KonamiLogoViewController → "Logo Konami, appuyez pour continuer"
- DONE — TitleScreenPatch : UnityLogoViewController → "Logo Unity"
- DONE — TitleScreenPatch : OnDemandLogoViewController → "Chargement des ressources"
- DONE — TitleScreenPatch : PreTitleSequneceViewController → "Cinématique de présentation"

### 1.2 Écran titre
- DONE — TitleScreenPatch : TitleViewController.NotificationStackEntry → "Écran titre"
- DONE — TitleScreenPatch : TitleViewController.StartGame → "Démarrage du jeu"
- DONE — TitleScreenPatch : TitleDemoViewController → "Cinématique de démo"
- DONE — TitleScreenPatch : TitleSettingMenuViewController → "Paramètres"
- DONE — TitleScreenPatch : TitleDataLinkDialogViewController → "Liaison de compte"

### 1.3 Téléchargement et chargement
- DONE — DownloadViewControllerPatch : DownloadViewController → progression téléchargement
- DONE — TitleScreenPatch : LoadingViewController → "Chargement..." avec cooldown 3s

### 1.4 Première connexion / Inscription
- DONE — RegistrationPatch : GameEntrySequenceViewController / V2 → "Création de compte."
- DONE — RegistrationPatch : GameEntryApprovalViewController → "Approbation requise."
- DONE — RegistrationPatch : AgeGateViewController → "Vérification d'âge."
- DONE — RegistrationPatch : AgeSelectViewController → "Âge actuel : N. (de X à Y)" (lit m_ageCurrent/Min/Max)
- DONE — RegistrationPatch : BirthdateSelectViewController → "Date de naissance."
- DONE — RegistrationPatch : CountrySelectViewController → "Pays : [nom]." (lit m_currentNameText)
- DONE — RegistrationPatch : USAStateSelectViewController → "État : [nom]." (lit m_currentNameText)
- DONE — RegistrationPatch : FirstLanguageSelectViewController → "Sélection de langue."
- DONE — RegistrationPatch : TermOfServiceViewController → "Conditions d'utilisation."
- DONE — RegistrationPatch : PrivacyPolicyViewController → "Politique de confidentialité."

### 1.5 Tutoriel
- DONE — TutorialPatch : InitialSettingsViewController → "Configuration initiale. Saisissez votre nom de duel."
- DONE — TutorialPatch : CardFlyingViewController.Start() → lit IList<string> msgList → messages du tutoriel
- DONE — ScenarioPatch (existant) : ScenarioViewController → "Scénario : [nom]." (LatePatches)

---

## 2. ÉCRAN D'ACCUEIL (HOME)

Statut global : DONE (essentiel) — ISV bannières TODO

### 2.1 Navigation principale
- DONE — ViewControllerPatch : HomeViewController détecté → "Accueil"
- DONE — SelectionButtonPatch : boutons de menu navigables (DUEL, DECK, SHOP, SOLO, etc.)
- DONE — ColorContainerPatch : boutons icônes cliquables au focus (Enter/hover)

### 2.2 Barre d'en-tête (HeaderFooter)
- DONE — HeaderPatch : raccourci H = gemmes (gemText/gemButtonText) + badge notifications (btnNotice enfants) + cadeaux en attente (btnPresent enfants)
  - Namespace : YgomGame.Menu.HeaderViewController (singleton via instance property)
  - Badge lu via GetComponents&lt;Component&gt;() + IsAssignableFrom + TMP_Text walk (IL2CPP-safe)
  - SKIP : CP (craft points) — absent du header ; uniquement dans CardBrowserViewController.CardDetailWidget.cpText

### 2.3 Bonus et récompenses quotidiennes
- DONE — LoginBonusPatch : LoginBonusViewController.OnCreatedView → "Bonus de connexion. Jour N sur M. Récompense : [label] ×Q [statut]"
  - Dump : YgomGame.Menu, m_MapWidget (LoginBonusMapWidet 0xE8)
  - Lit progress (int property) = index 0-based du jour actuel
  - Lit slotWidgets (LoginBonusSlotWidget[]) → slot[progress].labelText + rewardNum + recievedCover
- DONE — RegistrationPatch : GemRestoreOnLoginViewController → "Restauration de gemmes en cours." (cas rare, namespace global, annonce générique suffisante)
- DONE — PresentBoxPatch : PresentBoxViewController.OnCreatedView → "X cadeaux dans la boîte"
  - OnItemSetData(GameObject, int) → item focalisé : nom carte / "Gemmes × N" / "Objet cosmétique"

### 2.4 Événements et bannières
- DONE — HomeMiscPatch : HomeAnnounceViewController.NotificationStackEntry → "Annonce en cours." (namespace global, pas de champs TMP_Text directs)
- DONE — HomeMiscPatch : HomeActionViewController.OnCreatedView → "Actions disponibles : N." (lit actionList IEnumerable count)
- DONE — EventNotifyPatch : EventNotifyViewController.Open(string[] messages, Action) → messages joints
- DONE (PARTIAL) — SelectionButtonPatch.ProcessTopicsBanner : TopicsBannerWidget → lit ScrollRectPageSnap.hpage

### 2.5 Sous-menus
- DONE — HomeMiscPatch : HomeSubMenuViewController.NotificationStackEntry → "Sous-menu. Utilisez les flèches pour naviguer."
- DONE — HomeMiscPatch : PreHomeViewController.NotificationStackEntry → "Chargement de l'accueil." (cooldown 3s)

---

## 3. DUEL — AVANT LE MATCH

Statut global : DONE (essentiel)

### 3.1 Sélection et matchmaking
- DONE — DeckSelectPatch : sélection du deck (nom + mode : Ranked, Solo, Room, etc.)
  - 17 modes couverts (Ranked, Solo, PVE, Room, Tournament, Free, Cup, WCS, etc.)
- DONE — MatchingPatch : matchmaking (SEARCHING, MATCHING, TIMEOUT)

### 3.2 Démarrage du duel
- DONE — DuelMiscPatch : ChoiceFirstPlayerDialog → "Tu joues en premier" / "L'adversaire..."
- DONE — DuelMiscPatch : DuelView.OnDiceResult → "Toi : 4, Adversaire : 2"
- DONE — DuelMiscPatch : DuelView.OnCoinResult → "Pile" / "Face"
- DONE — DuelMiscPatch : DuelMulliganDialog → "Mulligan : X cartes, garder ou relancer ?"
- DONE — DuelStartPatch : DuelStartViewController.NotificationStackEntry → "Duel commençant." (noms chargés async via PlayerSet.myid — non lisibles à ce stade)
- DONE — DuelStartPatch : DuelStartViewController_Team.NotificationStackEntry → "Duel commençant." (patché séparément, override IL2CPP)
- DONE — DuelStartPatch : DuelStartOverlayViewController_Team.NotificationStackEntry → "Duel d'équipe commençant."
- DONE — DialogStatePatch : DuelCoinDialog.Open(string message,...) → message lu via PatchOpenWithMessage
- DONE — DialogStatePatch : DuelDiceDialog.Open(string message,...) → message lu via PatchOpenWithMessage
- SKIP — DuelSettingDialogViewController : classe essentiellement vide (seulement un constructeur dans le dump)

---

## 4. DUEL — PENDANT LE MATCH

Statut global : DONE (très complet — 40+ patches)

### 4.1 Points de vie et phases
- DONE — DuelHudPatch : LP.ChangeLP / SetLP → "PV : 8000 → 5500 (-2500)"
- DONE — PhasePatch / DuelEventPatch : Draw, Standby, Main1, Battle, Main2, End
- DONE — DuelEventPatch : changement de tour annoncé

### 4.2 Événements de jeu (DuelEventPatch — 25+ ViewTypes)
- DONE — Invocations : normale (4), spéciale (58) avec sous-types :
  - Fusion (0), SpFusion (1), Synchro (2), Rituel (3), Xyz (4), Pendule (5), Lien (6), Maximum (7)
  - Retournement (CutinSummon type 4), Invocation par effet (type 5)
- DONE — Attaques : DuelAttackPatch → "Magicien Sombre (2500 ATK) attaque Dragon Blanc (3000 ATK)"
- DONE — Destruction (ViewType 23), bannissement (17), envoi au cimetière (26)
- DONE — Activation d'effet (72) avec contexte : terrain (1), main (2), cimetière (5)
- DONE — Pioches (68), recherches (11 via CardMove), défausses (10/17)
- DONE — Chaînes (60), résolution (63), annulation/negate (36)
- DONE — Équipement (37), retournement face cachée (28)
- DONE — Résultats pièce (61) et dé (62) détaillés (valeurs individuelles)
- DONE — Pensée CPU (80), fin de duel (2) avec résultat (Win/Lose/Draw)
- DONE — DuelStart (1), CutinDraw (68 pioche début de tour), DuelEnd (2)

### 4.3 Dialogs de duel
- DONE — DuelConfirmDialog : confirmation oui/non (6-param + 4-param)
- DONE — DuelSelectDialog : sélection parmi options (via DialogStatePatch)
- DONE — DuelOkDialog : message informatif (3-param)
- DONE — DuelInfoDialog : message non-interactif / cancelable
- DONE — DuelPullDownDialog : liste multi-sélection (5-param)
- DONE — DuelRitualDialog : conditions rituelle (Begin + SetCount)
- DONE — DialogStatePatch : DuelDialogBase.ShowUI / HideUI
- DONE — DialogStatePatch : MessageDialog.SetMessage(string msg) → annonce msg ; Open() n'a pas de params donc PatchOpenWithMessage était sans effet (MonoBehaviour, pas DuelDialogBase)
- DONE — DialogStatePatch : EffectTaskRunDialog.RunDialog() (private) → lit champ `text` via réflexion + dédup ; fallback "Résolution en cours."

### 4.4 Navigation de terrain et commandes
- DONE — CardCommandPatch : menu d'actions carte (6 params, CommandBit bitmask)
- DONE — CommandOperationPatch : navigation commandes (Attack, Summon, Set, etc.)
- DONE — DuelCursorPatch : curseur terrain (OnCursorEnter + OnSelectField)
- DONE — SelectStandOperationPatch : placement zone + position (ATK/DEF face visible/cachée)
- DONE — CardCommandExPatch : menu position monstre (FrontAtk/FrontDef/BackDef)
- DONE — CardSelectionListPatch : listes de sélection (SetList + SetCursor + Tab cycle)
- DONE — DuelEffectQueuePatch : messages flash + barre info (300ms dédup + exact-string dédup)
- DONE — DuelTimerPatch : alertes vocales timer (60s, 30s, 10s)
- DONE — CardInfoPatch : info carte complète (nom, ATK/DEF, niveau/rang/lien, type, description)
- DONE — CardReportTelopPatch : bandeau stats post-effet ("+500 ATK", etc.)

### 4.5 Raccourcis clavier en duel
- DONE — C / Shift+C : main joueur (noms des cartes) / nombre main adverse
- DONE — G / Shift+G : cimetière joueur (liste) / cimetière adverse
- DONE — X / Shift+X : cartes bannies joueur / adversaire
- DONE — M / Shift+M : terrain joueur (monstres + sorts) / terrain adverse
- DONE — E / Shift+E : Extra Deck joueur / taille Extra Deck adverse
- DONE — T : état complet "Tour X, Phase Main, PV 8000 vs 5000"
- DONE — L : PV uniquement "Toi 8000, Adversaire 5000"
- DONE — D : taille des decks "Ton deck : 30, Adversaire : 28"
- DONE — I : info carte (rélit la dernière carte affichée)
- DONE — S : relire l'instruction courante ("Choisissez une cible", etc.)
- DONE — O : aperçu adversaire "Adversaire: PV, N cartes main, deck M, cimetière K"
- DONE — P : annonce la phase courante uniquement
- DONE — F : lit la carte dans la zone sort/magie de terrain (position 12)
- DONE — 1-5 : lire la Nième carte en main (1=première, 5=cinquième)
- DONE — Shift+1-5 : zones monstres adverses (positions 0-4)
- DONE — 6-9 / Shift+6-9 : zones sorts/pièges joueur/adversaire (positions 7-10)
- DONE — 0 / Shift+0 : zone magie terrain joueur/adversaire (position 12)
- DONE — Tab : cycle dans CardSelectionList / avance de phase
- DONE — F1 : aide raccourcis (liste contextuelle)
- DONE — F3 (hors duel) : annonce l'écran courant
- DONE — F12 : historique TTS (10 derniers messages, navigable)

---

## 5. DUEL — APRÈS LE MATCH

Statut global : DONE (essentiel)

### 5.1 Résultat immédiat
- DONE — DuelMiscPatch : DuelResultDialog → "Victoire !" / "Défaite" / "Égalité"
- DONE — DuelEventPatch : ViewType 2 (DuelEnd) avec Engine.ResultType

### 5.2 Écran de résultat détaillé
- DONE — DuelResultPatch : DuelResultViewController.OnCreatedView → résumé résultat + mode de jeu + boutons disponibles
  - ReadScoreReward : lit m_TotalScore (int 0x58, dump-confirmé) ; fallback TMP_Text walk
- DONE — DuelResultMiscPatch : DuelResultViewController_Solo.NotificationStackEntry → "Résultat solo." (global namespace)
- DONE — DuelResultMiscPatch : DuelistCupResultViewController.NotificationStackEntry → "Duelist Cup. [win/lose/draw]. DP avant : X, après : Y (delta)." (lit bDP/aDP/resultType via réflexion)
- DONE — DuelResultMiscPatch : ColosseumDuelResultViewController_Rate.NotificationStackEntry → "Résultat Colosseum. [win/lose/draw]." (lit resultType ; valeurs rating dans EOM, non lisibles directement)
- DONE — DuelpassResultViewPatch : DuelpassResultViewController.OnGradeUp + OnEndProgressBarAnimation
  - OnGradeUp → "Palier supérieur ! Palier X." (interrupt:true)
  - OnEndAnimation → "Duel Pass. Palier actuel : X. Prochain palier : Y."

### 5.3 Replay
- DONE — ReplayPatch : ProfileReplayViewController.NotificationStackEntry → "Replays. N replay(s)." (lit replayInfos IEnumerable count ; YgomGame.Menu)
- DONE — ReplayPatch : RoomReplayViewController.NotificationStackEntry → "Replays du salon. N replay(s)." (lit dataList IEnumerable count ; YgomGame.Room)
- DONE — ReplayPatch : DuelLiveReplayDialogViewController.NotificationStackEntry → "Replay en direct. Choisissez un deck." (YgomGame.DuelLive)

---

## 6. DECKS

Statut global : DONE

### 6.1 Éditeur de deck
- DONE — DeckEditPatch : ajout/retrait carte, renommage, sauvegarde, focus éditeur
- DONE — CardBrowserPatch : navigateur cartes intégré (auto-lecture + pagination)
- DONE — CardInfoPatch : lecture nom + stats + description de chaque carte
- DONE — FilterSelectViewPatch : dialog filtres multi-sélection (actif/inactif)
- DONE — DeckEditMiscPatch : DeckEditSubMenuViewController.NotificationStackEntry → "Sous-menu deck."
- DONE — DeckEditMiscPatch : DeckNameEditDialog.NotificationStackEntry → "Renommer le deck."
- DONE — SearchBoxDialogPatch : SearchBoxDialog.NotificationStackEntry + Open(string, Action)
  - Lit m_InputFieldText.text → "Recherche de carte : [mot-clé]." ou "Saisissez le nom."
  - Applied via Plugin.ApplyPatches()
- DONE — DeckEditMiscPatch : FilterDialog.NotificationStackEntry → "Filtres avancés."
- DONE — DeckEditMiscPatch : AutoBuildDialog.NotificationStackEntry → "Construction automatique."
  - Tous appliqués via LatePatches.ApplyMenuScenePatches()

### 6.2 Liste des decks
- DONE — DeckSelectPatch : sélection deck (nom + mode, 17 modes)
- DONE — DeckBrowserPatch : DeckBrowserViewController.NotificationStackEntry
  - Lit m_DeckName (string), m_NumMainCards (int), m_NumExtraCards (int), m_BrowserType (enum)
  - Annonce : "[Nom]. Deck principal : N cartes. Extra Deck : M cartes."
  - BrowserType : Solo/NPC/Structure/Public/Neuron → label adapté
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : navigation ISV entre decks (OnItemSetData)

### 6.3 Création et démantèlement de cartes
- DONE — CardCraftPatch : CardCraftDialog.Open (5 params) → mode craft/dismantle + carte
- DONE — CardCraftResultPatch : résultat de fabrication
- DONE — CardCraftPatch : BatchDismantleDialog.NotificationStackEntry
  - Lit m_DismantleCards (List count) → "Démantèlement en lot : N cartes." ou générique
- DONE — CardCraftPatch : CardRelativeBrowserViewController.NotificationStackEntry
  - Lit m_Mrk (int cardId) → "Cartes liées : [nom]." ou "Cartes liées."

### 6.4 Accessoires / Cosmétiques de deck
- DONE — MiscViewsPatch : SetAccessoryDialog.NotificationStackEntry
  - Lit m_TextTile (TMP_Text) → titre localisé du dialog ou "Personnalisation du deck."
  - Namespace : YgomGame.Deck
- DONE — MiscViewsPatch : IconViewerViewController.NotificationStackEntry → "Aperçu d'icône."
- DONE — MiscViewsPatch : ItemPreviewViewController.NotificationStackEntry
  - Lit m_ItemCategoryText + m_ItemNameText → "[catégorie] : [nom]."

### 6.5 Decks de structure
- DONE — StructureDeckPatch : StructureDeckSelectViewController.NotificationStackEntry → "Sélection du deck de structure."
- DONE — StructureDeckPatch : StructureDeckSelectBackableViewController.NotificationStackEntry → "Sélection du deck de structure."
- DONE — StructureDeckPatch : StructureDeckObtainViewController.NotificationStackEntry → "Deck de structure obtenu."
  - Namespace : YgomGame.Menu pour tous. Applied via LatePatches.

### 6.6 Tirage d'essai
- DONE — DeckBrowserPatch : TrialDrawViewController.NotificationStackEntry → "Tirage d'essai."
  - Namespace : YgomGame.DeckBrowser. Applied via LatePatches.

### 6.7 Recherche via Neuron
- DONE — MiscViewsPatch : NeuronDeckSearchViewController.NotificationStackEntry → "Recherche Neuron."
  - Namespace : YgomGame.Menu. Applied via LatePatches.

---

## 7. BOUTIQUE (SHOP)

Statut global : DONE (essentiel)

### 7.1 Navigation boutique
- DONE — ViewControllerPatch : ShopViewController détecté → "Boutique"
- DONE — SelectionButtonPatch : ProcessPacks (nom, prix, limite, état "new")
- DONE — ShopViewControllerPatch : ShopViewController.NotificationStackEntry + OnClickMainTab
  - Lit m_ShowcaseData.currentCategoryId → GetCategoryData(id).labelText (IShopProductGruopData)
  - Annonce : "Boutique — [catégorie]." à l'ouverture et lors des changements d'onglet
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : navigation produits (ISV via OnFocusProductLine)

### 7.2 Achat de produits
- DONE — ShopBuyPatch : NotificationStackEntry + OnFocusChanged + page nav
- DONE — ShopBuyPatch : OnChangedSelectionItem (fix BindingFlags appliqué)
- DONE — ShopBuyWidgetPatch : ConfirmRegDialogProductWidget.InnerBinding (YgomGame.Shop)
  - Lit headerText / hasText / numText (champs publics 0x30–0x40) → "Confirmation : [prod]. [has]. [num]."
  - Applied via LatePatches.ApplyMenuScenePatches()
- DONE — ShopBuyWidgetPatch : BuyButtonGroupWidget.Binding (namespace global)
  - Lit productName via ProductContext param + m_ButtonCtx.numText / priceText
  - Fix namespace : "BuyButtonGroupWidget" (global) pas "YgomGame.Shop.BuyButtonGroupWidget"
  - Annonce : "Acheter : [nom]. [quantité]. [prix]."
  - Applied via LatePatches.ApplyMenuScenePatches()

### 7.3 Boutique de gemmes (achat payant)
- DONE — ShopMiscPatch : GemShopViewController.NotificationStackEntry → "Boutique de gemmes."
- DONE — ShopMiscPatch : GemShopPermissionViewController.NotificationStackEntry → "Consentement requis."
- DONE — ShopMiscPatch : GemShopApprovalViewController.NotificationStackEntry → "Approbation requise."
- DONE — ShopMiscPatch : GemGetHistoryViewController.NotificationStackEntry → "Historique des achats."
  - Namespace : YgomGame.GemShop / YgomGame.Menu / YgomGame.GemGetHistory. Applied via LatePatches.

### 7.4 Tickets et échanges
- DONE — ShopMiscPatch : TicketInventoryViewController.NotificationStackEntry → "Inventaire de tickets."
- DONE — ShopMiscPatch : ItemExchangeViewController.NotificationStackEntry → "Échange d'objets."
- DONE — ShopMiscPatch : ItemGetHistoryViewController.NotificationStackEntry → "Historique des objets."
  - Generic dispatcher via _locKeys dict keyed by FullName. Applied via LatePatches.
- SKIP — GetHistoryViewController : non trouvé dans le dump sous ce nom exact

### 7.5 Aperçus produits
- SKIP — ProductWidget / ProductContainerWidget : boutons dans ISV → couvert par SelectionButtonPatch.ProcessPacks
- SKIP — ProductShowcaseWidget : animation pure, pas de texte accessible
- SKIP — HighlightWidget : contenu lu via SelectionButtonPatch

---

## 8. OUVERTURE DE PACKS (LOTTERY)

Statut global : DONE (essentiel)

### 8.1 Portail de loterie
- DONE — ViewControllerPatch : LotteryPortal détecté → "Portail de packs"
- DONE — LotteryPortalPatch : LotteryPortalViewController.NotificationStackEntry → "Portail de packs — [nom pack]"
  - Dump : YgomGame.Lottery, m_Id (int 0xE8)
  - Tente de résoudre le nom via YgomGame.Lottery.LotteryData.GetName(int) — fallback titre générique
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : vérifier que LotteryData.GetName existe en runtime et retourne un nom lisible

### 8.2 Ouverture de pack
- SKIP — CardPackOpenViewController : animation pure, aucun texte utile pendant l'ouverture
- SKIP — LotteryResultViewController : révélation drag-to-reveal — LotteryRewardPatch couvre le résumé complet
- SKIP — CardPackOpenResultViewController : résultat déjà couvert par LotteryRewardPatch
- DONE — MiscViewsPatch : LotteryFirstInfoViewController.NotificationStackEntry → "Premier achat — informations."
- DONE — MiscViewsPatch : LotteryFirstViewViewController.NotificationStackEntry → "Premier achat — aperçu."
- DONE — MiscViewsPatch : LotterySubmissionViewController.NotificationStackEntry → "Confirmation d'achat de pack."
  - Namespace : YgomGame.Lottery. Applied via LatePatches.

### 8.3 Résultat et historique
- DONE — LotteryRewardPatch : OnCreatedView → annonce toutes les cartes obtenues
- DONE — LotteryRewardPatch : SetCardButtonAction → mapping bouton → carte
- DONE — LotteryRewardPatch : OnUpdateEntity + FocusCallback (ISV navigation)
- DONE — MiscViewsPatch : LotteryHistoryViewController.NotificationStackEntry → "Historique des packs ouverts."
  - Namespace : YgomGame.Lottery. Applied via LatePatches.
- DONE — LotteryCardSelectViewController : NSE patché (Fix 76) — annonce vue (Collection/Deck) + taille du pool
  - Namespace : YgomGame.CardPoolSelect (CardPoolSelectViewController possible)
  - Nécessite analyse dump avant implémentation

### 8.4 Taux et packs secrets
- DONE — MiscViewsPatch : CardPackRateListViewController.NotificationStackEntry → "Taux de drop."
- DONE — MiscViewsPatch : SecretPackObtainViewController.NotificationStackEntry
  - Lit m_PackName (string) → "Pack secret débloqué : [nom]." ou générique
  - Namespace : YgomGame.CardPack. Applied via LatePatches.

---

## 9. MODE SOLO

Statut global : DONE (essentiel)

### 9.1 Carte du monde
- DONE — ViewControllerPatch : Solo détecté → "Mode Solo"
- DONE — SelectionButtonPatch : boutons Solo navigables (ProcessDuelMenu)
- DONE — SoloModeViewController : MiscViewsPatch.SoloMode_Postfix (NSE) → "Mode Solo — carte du monde." + ScreenTitles "SoloMode"
  - Données riches (portails, progression) : TODO optionnel

### 9.2 Portails et chapitres
- DONE — SoloGatePatch : SoloGateViewController.NotificationStackEntry
  - Lit mainDataList.Count pour annoncer le nombre de portails
  - Annonce : "Portails Solo — N portail(s)."
  - Applied via LatePatches.ApplyMenuScenePatches()
  - DONE — SoloGatePatch : OnItemSetDataMain postfix — annonce "Portail : [nom], N sur M." (Fix 2026-03-15 suite 3)
- DONE — SoloChapterPatch : SoloSelectChapterViewController.ChapterMap.OnClickChapter
  - Accès via GetNestedType("ChapterMap") + FindMethod par nombre de paramètres
  - Lit strChapter + IsCleared/IsCompleted + status enum (-1=UNOPEN)
  - Annonce : "Chapitre : [nom]. [statut]."
  - Applied via LatePatches.ApplyMenuScenePatches()
- DONE — MiscViewsPatch : SoloPortalViewController.NotificationStackEntry → "Portail Solo."
  - Namespace : YgomGame.Solo. Applied via LatePatches.

### 9.3 Déroulement et résultats
- DONE — MiscViewsPatch : SoloStartProductionViewController.NotificationStackEntry → "Démarrage de la production."
  - Annonce : "Début du chapitre : [nom]"
- DONE — MiscViewsPatch : SoloClearViewController.NotificationStackEntry
  - Lit champ type (ClearType enum : RENTAL=0, MYDECK=1, COMPLETE=2, GOAL=3)
  - Annonce : "Victoire Solo !" / "Solo terminé !" / "Objectif atteint !" selon ClearType
- DONE — ScenarioPatch : ScenarioViewController.NotificationStackEntry
  - Lit m_ScenarioName (string 0xD8) → "Scénario : [nom]." ou "Scénario Solo."
  - Applied via LatePatches.ApplyMenuScenePatches()
- DONE — MiscViewsPatch : ScenarioVolumeViewController.NotificationStackEntry → "Sélection de volume."
  - Namespace : YgomGame.Scenario. Applied via LatePatches.

---

## 10. PVP / MATCHMAKING / ROOMS

Statut global : DONE (essentiel)

### 10.1 Matchmaking standard
- DONE — MatchingPatch : PvpMenuMatchingViewController.SetActiveView (SEARCHING/MATCHING/TIMEOUT)
- DONE — MatchingPatch : PvpMenuMatchingViewControllerBase.NotificationStackEntry
  - Annonce le type d'écran à l'ouverture selon la sous-classe concrète
  - PvpMenuMatchingViewController → "matchmaking_ranked"
  - PvpMenuMatchingViewController_Room → "matchmaking_room" (salon privé)
  - PvpMenuMatchingViewController_Team → "matchmaking_team" (équipe)
  - PvpMenuMatchingViewController_WcsFinal → "matchmaking_wcs" (WCS Finals)
- DONE — MatchingPatch : PvpMenuMatchingViewController_Room.SetActiveView (INIT=0 silencieux, SEARCHING=1, MATCHING=2, TIMEOUT=3)
- DONE — MatchingPatch : PvpMenuMatchingViewController_WcsFinal.SetActiveView (même enum)
  - Note : PvpMenuMatchingViewController_Team n'a pas de SetActiveView dans le dump

### 10.2 Salons privés (Room)
- DONE — RoomViewControllerPatch : RoomViewController.NotificationStackEntry
  - Lit roomBehaviour.roomInfo.roomName + memberNum/memberMax
  - Annonce : "Salon : [nom]. N sur M joueur(s)." ou "Salon."
  - Applied via LatePatches.ApplyMenuScenePatches()
  - DONE — RoomViewControllerPatch : RoomMemberViewController.UpdateEntity postfix — annonce "{nom}. V{win} D{lose} N{draw}." (Fix 71)
- DONE — RoomPatch : RoomCreateViewController.NotificationStackEntry → "Créer un salon."
- DONE — RoomPatch : RoomEntryViewController.NotificationStackEntry
  - Lit champ mode (RoomEntryViewController.Mode NORMAL=0, SPECTER=1)
  - Annonce : "Rejoindre un salon." / "Rejoindre en tant que spectateur."
- DONE — RoomPatch : RoomInfoViewController.NotificationStackEntry
  - Lit roomName, roomMemberCurrent, roomMemberMax
  - Annonce : "Salon : [nom]. N sur M joueur(s)."
- DONE — RoomPatch : RoomInviteViewController.NotificationStackEntry → "Inviter un ami."
- DONE — RoomPatch : RoomMemberViewController.NotificationStackEntry → "Membres du salon."
- DONE — ReplayPatch (existant) : RoomReplayViewController.NotificationStackEntry → "Replays du salon. N replay(s)."

### 10.3 Duel test (amis)
- SKIP — TestDuelEntryViewController : hérite DuelStartViewController (pas de NSE propre, couvert par DuelStartPatch)
- SKIP — TestDuelEntryViewController_Team : hérite DuelStartViewController_Team (couvert par DuelStartPatch)
- DONE — MatchingPatch : TestDuelMatchingViewController.NotificationStackEntry → "Matchmaking duel test."
- DONE — MatchingPatch : TestDuelMatchingViewController.SetActiveView (SEARCHING=0, MATCHING=1, TIMEOUT=2)

---

## 11. PROFIL ET SOCIAL

Statut global : DONE (essentiel)

### 11.1 Profil joueur
- DONE — ViewControllerPatch : Profile/ProfileEdit/ProfileCardCheck détectés
- DONE — SelectionButtonPatch : ProcessProfile (nom, rang, etc.)
- DONE — ProfilePatch : ProfileViewController.NotificationStackEntry
  - Lit profileCard (ProfileCard 0x198) → m_ProfileDic → "name" + "level"
  - Annonce : "Profil de [nom]. Niveau [niveau]." / "Profil de [nom]." / "Profil."
  - Applied via LatePatches.ApplyMenuScenePatches()
- DONE — ProfileMiscPatch : ProfileDataViewController.NotificationStackEntry → "Données du profil."
  - Namespace : YgomGame.Menu. Applied via LatePatches.
- DONE — ProfileMiscPatch : ProfileEditViewController.NotificationStackEntry → "Édition du profil."
  - Has public property `currentItemName` but empty at NSE time. Generic announce suffisant.
- DONE — ProfileMiscPatch : ProfileCardCheckViewController.NotificationStackEntry → "Vérification des cartes du profil."

### 11.2 Amis
- DONE — FriendViewControllerPatch : FriendViewController.NotificationStackEntry
  - Lit m_FollowNumText (TMP_Text 0x1E8) → "Amis — N suivi(s)." ou "Amis."
  - Applied via LatePatches.ApplyMenuScenePatches()
  - DONE — FriendViewControllerPatch : FriendListWidget.OnSelectedEntityWidget postfix — annonce "{nom}. En ligne/Hors ligne." (Fix 70)
- DONE — ProfileMiscPatch : FriendSearchViewController.NotificationStackEntry → "Recherche d'ami."
  - Applied via LatePatches.

---

## 12. MISSIONS

Statut global : PARTIAL

### 12.1 Écran principal
- DONE — SelectionButtonPatch : ProcessMissionsMenu (nom + récompense + temps)
- DONE — MissionViewControllerPatch : MissionViewController.NotificationStackEntry + TabInitialEntry(bool)
  - Lit m_ContentType (MissionContentType : Mission=0, PanelMission=1)
  - Annonce : "Missions — Missions." ou "Missions — Panel Missions."
  - Applied via LatePatches.ApplyMenuScenePatches()

### 12.2 Collecte de récompenses
- DONE — MissionMiscPatch : MissionBulkRecieveDialogWidget.OnPostAllInserted()
  - Lit totalItems (List<EntryItemListData.Context> 0x48) count
  - Annonce : "X récompense(s) collectée(s)." ou "Récompenses collectées."
  - Namespace : YgomGame.Mission. Applied via LatePatches.
- SKIP — MissionGoalWidget : ElementWidgetBase, pas de VC ni de NSE
  - Le bouton "Collecter" est un SelectionButton → couvert par SelectionButtonPatch
- SKIP — MissionTabWidget : ElementWidgetBase, ses onglets sont des SelectionButtons
  - Le `label` et `isOn` peuvent être lus via SelectionButtonPatch si nécessaire

### 12.3 Panel Missions (événements carte)
- DONE — PanelMissionContent : MiscViewsPatch.PanelMission_Postfix → "Mission événement." (NSE hook)
- DONE — MapWidget / PanelWidget : PanelMissionContent.OnSelectedPanel(PanelWidget) postfix
  → "{titre}. {progression}." (ex: "Missions quotidiennes. 3/5.") (Fix 80)

---

## 13. DUEL PASS

Statut global : PARTIAL

### 13.1 Écran principal
- DONE — ViewControllerPatch : DuelPass détecté → "Pass de Duel"
- DONE — SelectionButtonPatch : ProcessDuelPass (type + grade + quantité)
- DONE — DuelPassRewardPatch : récompenses Duel Pass (ISV, OnUpdateEntity)
- DONE — DuelPassViewControllerPatch : DuelPassViewController.NotificationStackEntry
  - Lit progressBar (DuelpassProgressBarWidget 0xD0) → currentGradeText + nextGradeText (TMP_Text)
  - Annonce : "Duel Pass. Palier actuel : X. Prochain palier : Y."
  - Applied via LatePatches.ApplyMenuScenePatches()

### 13.2 Résultat post-duel
- DONE — DuelpassResultViewPatch : DuelpassResultViewController.OnGradeUp(int) + OnEndProgressBarAnimation()
  - OnGradeUp → "Palier supérieur ! Palier X." (interrupt:true)
  - OnEndAnimation → "Duel Pass. Palier actuel : X. Prochain palier : Y."
  - Applied via LatePatches.ApplyMenuScenePatches()

---

## 14. SAISON / RANKED

Statut global : DONE (essentiel)

### 14.1 Rang actuel
- DONE — ViewControllerPatch : SeasonPoint/History/Ranking détectés
- DONE — SeasonPointPatch : SeasonPointViewController.NotificationStackEntry
  - Lit myGroup (ElementObjectManager 0x178) → traverse TMP_Text enfants pour rang/points
  - Annonce : "Points de saison. [texte rang]." ou "Points de saison."
  - Applied via LatePatches.ApplyMenuScenePatches()
- DONE — SeasonMiscPatch : SeasonPointTopMenuViewController.NotificationStackEntry → "Menu saison."

### 14.2 Historique et classement
- DONE — SeasonMiscPatch : SeasonPointHistoryViewController.NotificationStackEntry → "Historique de saison."
- DONE — SeasonMiscPatch : SeasonPointRankingViewController.NotificationStackEntry → "Classement saison."
- DONE — SeasonMiscPatch : SeasonResultViewController.NotificationStackEntry → "Résultat de saison."

### 14.3 Équipes saison
- DONE — SeasonMiscPatch : SeasonPointTeamCreateViewController.NotificationStackEntry → "Créer une équipe."
- DONE — SeasonMiscPatch : SeasonPointTeamCreateDialogViewController.NotificationStackEntry → "Créer une équipe."
- DONE — SeasonMiscPatch : SeasonPointTeamParticipateViewController.NotificationStackEntry → "Rejoindre une équipe."
- DONE — SeasonMiscPatch : SeasonPointTeamTopViewController.NotificationStackEntry → "Classement équipe."
  - Namespace : YgomGame.SeasonPoint. Applied via LatePatches.

---

## 15. PARAMÈTRES

Statut global : DONE (essentiel)

### 15.1 Menu principal
- DONE — ViewControllerPatch : Settings détecté → "Paramètres"
- DONE — SelectionButtonPatch : ProcessSettingsMenu (valeur slider, texte mode)
- DONE — SliderPatch : annonce valeur + label du slider
- DONE — DropdownPatch : annonce option sélectionnée ("option N sur M")
- DONE — TogglePatch : annonce toggle on/off
- DONE — SettingsMiscPatch : SettingMenuViewController.NotificationStackEntry
  - Lit currentPage (Page enum : General=0, Duel=1, Audience=2, CrossPlay=3, Privacy=4)
  - Annonce : "Paramètres — [page]."

### 15.2 Paramètres spécifiques
- DONE — SettingsMiscPatch : LanguageSelectViewController.NotificationStackEntry
  - Lit m_currentLangText (TMP_Text) → "Sélection de langue. [langue actuelle]."
- DONE — SettingsMiscPatch : PrivacySettingsViewController.NotificationStackEntry → "Paramètres de confidentialité."
- DONE — TitleScreenPatch : TitleSettingMenuViewController.NotificationStackEntry → "Paramètres."
  - Accessible avant connexion (YgomGame.SubMenu namespace)
  - All applied via LatePatches.

---

## 16. NOTIFICATIONS

Statut global : PARTIAL

### 16.1 Panneau principal
- DONE — ViewControllerPatch : Notifications détecté → "Notifications"
- DONE — NotificationPatch : NotificationStackEntry (ouverture + compteur non-lu)
- DONE — NotificationPatch : UpdateNotification + UpdateEntityCallback (fix BindingFlags appliqué)
- DONE — SelectionButtonPatch : ReadNotificationText (corps + catégorie)

### 16.2 Contenu détaillé
- DONE — NotificationPatch : body field (0x40) lu + StripMarkup() (regex <[^>]+>) → corps inclus dans l'annonce ISV (Fix 68)
- DONE — NotificationPatch : UpdateNotification_Postfix annonce maintenant "{onglet} — N élément(s), M non lue(s)." (Fix 68)
- DONE — NotificationPatch : CountTabUnread() par onglet → badge non-lu inclus dans annonce onglet (Fix 68)

---

## 17. DIALOGS COMMUNS

Statut global : DONE (essentiel)

### 17.1 Dialogs génériques
- DONE — CommonDialogPatch : 12 variantes (Alert, Confirm, Error, YesNo, CheckBox, etc.)
- DONE — InputDigitViewPatch : sélecteur numérique (ex: "Payer X LP")
- DONE — FilterSelectViewPatch : filtre multi-sélection (actif/inactif)

### 17.2 Dialogs manquants
- DONE — SystemDialogPatch : SystemDialog.OpenFatalErrorDialog / OpenMaintenanceDialog / OpenSystemDialogCore
  - Namespace : YgomSystem.UI (SystemDialog)
  - FatalError : annonce system_error avec le message textuel
  - Maintenance : lit dict "title"/"upper_message"/"lower_message" via reflection
  - Appliqué au démarrage (Plugin.ApplyPatches) — CRITIQUE couvert
- DONE — ActionSheetPatch : ActionSheetViewController.NotificationStackEntry
  - Lit m_DisplayEntryButtonDatas (List<EntryData>) → filtre interactable=true → liste options
  - Lit titre via get_arg1() en parcourant la hiérarchie de base
  - Annonce : "[Titre]. Options : A, B, C." ou "Menu contextuel. Options : A, B, C."
  - Applied via Plugin.ApplyPatches()
- DONE — MiscViewsPatch : PlaceHolderDialogViewController.NSE → "Chargement en cours."
- DONE — MiscViewsPatch : SaveDialogViewController.NSE → "Enregistrement en cours."
  SaveDialogViewController.Open (8 params) → "[title]. [message]."
- DONE — MiscViewsPatch : TextureImageDialogViewController.NSE → lit champ `caption` → "Aperçu d'image." ou texte
- DONE — MiscViewsPatch : PasswordDialogViewController.NSE → lit INPUT_LABEL → "Saisie : [label]."
- DONE — InformDialogFallbackPatch : découverte dynamique des sous-classes InformDialogViewControllerBase
  - Enumère tous les types .NET chargés à l'exécution via AppDomain.CurrentDomain.GetAssemblies()
  - Détecte les sous-classes concrètes (non-abstract) en remontant la chaîne de base par nom
  - Ignore les types dans KnownHandled (déjà couverts par un patch dédié) — 16 types listés
  - Pour les types inconnus : patch NSE avec bypassOriginal=true + Generic_Postfix
  - Generic_Postfix : annonce "Dialog : [NomStrippé]." (strip ViewController/Dialog suffixes)
  - Loc key : "inform_dialog_generic" → "Dialog : {0}." / "Dialog: {0}."
  - Appliqué dans LatePatches.ApplyMenuScenePatches() après MiscViewsPatch
  - Filet de sécurité pour les futures mises à jour jeu ajoutant de nouveaux InformDialogs

---

## 18. ÉVÉNEMENTS ET COLOSSEUM

Statut global : DONE (core)

### 18.1 Colosseum (événement principal)
- DONE — ColosseumViewController : ScreenTitles entry → "screen_colosseum" (ViewControllerPatch auto-announce)
- DONE — ColosseumStartViewController : MiscViewsPatch.ColosseumStart_Postfix — reads prefabType (STANDARD/TOURNAMENT/WCS) → Loc key
- DONE — ColosseumInfoViewController : MiscViewsPatch.ColosseumInfo_Postfix → "Informations Colosseum."
- DONE — ColosseumInfoEditSceneViewController : ScreenTitles "ColosseumInfoEditScene" → "Colosseum." (ViewControllerPatch auto-announce)
- DONE — ColosseumConfirmAgreementViewController : ScreenTitles "ColosseumConfirmAgreement" → "screen_colosseum_confirm"
- DONE — ColosseumConfirmGroupViewController : ScreenTitles "ColosseumConfirmGroup" → "screen_colosseum"

### 18.2 Résultats et classements Colosseum
- DONE — ColosseumResultViewController.NSE → "Résultat Colosseum."
- DONE — ColosseumResultViewController_Wcs : ScreenTitles (full key) → "screen_colosseum_result"
- DONE — ColosseumResultVersusViewController : ScreenTitles "ColosseumResultVersus" → "screen_colosseum_result_versus"
- DONE — ColosseumResultEditSceneViewController : ScreenTitles "ColosseumResultEditScene" → "screen_colosseum_result"
- DONE — ColosseumHistoryViewController : MiscViewsPatch.ColosseumHistory_Postfix → "Historique Colosseum."
- DONE — ColosseumRankingViewController : MiscViewsPatch.ColosseumRanking_Postfix → "Classement Colosseum."
- DONE — ColosseumRankingViewController_Rate : MiscViewsPatch.ColosseumRankingRate_Postfix → "Classement Colosseum — Rating." (NSE RVA non-vide)
- DONE — ColosseumRankingDuelistCupViewController : ScreenTitles "ColosseumRankingDuelistCup" → "screen_colosseum_ranking_cup"
- DONE — ColosseumRankingEditSceneViewController : ScreenTitles "ColosseumRankingEditScene" → "screen_colosseum_ranking"
- DONE — ColosseumSelectVersusViewController : MiscViewsPatch.ColosseumVersus_Postfix → "Sélection d'adversaire."

### 18.3 Récompenses Colosseum
- DONE — ColosseumRewardViewController : MiscViewsPatch.ColosseumReward_Postfix → "Récompenses Colosseum."
- DONE — ColosseumRewardDiceRallyViewController : MiscViewsPatch.ColosseumRewardDiceRally_Postfix → "Récompenses Colosseum — Dice Rally." (bypass empty stub)
- DONE — ColosseumRewardDuelistCupViewController : ScreenTitles "ColosseumRewardDuelistCup" → "screen_colosseum_reward"
- DONE — ColosseumRewardTournamentViewController : ScreenTitles "ColosseumRewardTournament" → "screen_colosseum_reward"
- DONE — ColosseumRankEventRewardViewController : ScreenTitles "ColosseumRankEventReward" → "screen_colosseum_reward"

### 18.4 Dice Rally (événement spécial)
- DONE — DiceRallyMapEditorViewController : MiscViewsPatch.DiceRallyMapEditor_Postfix → "Éditeur de carte Dice Rally." (namespace: DiceRallyMapEditor)
- DONE — DiceRallyEffectDialogViewController : ScreenTitles "DiceRallyEffectDialog" → "screen_dice_rally_effect"
- DONE — DiceResultViewController : ScreenTitles "DiceResult" → "screen_dice_result"
- DONE — DiceRallySubMenuViewController : MiscViewsPatch.DiceRallySubMenu_Postfix → "Dice Rally." (namespace: YgomGame.SubMenu)

---

## 19. ÉQUIPE (TEAM)

Statut global : DONE

### 19.1 Création et gestion
- DONE — TeamCreateViewController.NSE → "Création d'équipe."
- DONE — TeamDesignationViewController.NSE → "Attribution des rôles."
- DONE — TeamInfoViewController.NSE → "Informations d'équipe."
- DONE — TeamNameSelectViewController.NSE → "Sélection du nom d'équipe."
- DONE — TeamRegulationSetSelectViewController.NSE → "Sélection des règles."

### 19.2 Membres et matchmaking
- DONE — TeamMemberViewController.NSE → "Membres de l'équipe."
- DONE — TeamInviteViewController.NSE → "Invitation à l'équipe."
- DONE — TeamLeaderMatchingViewController.NSE → "Recherche d'adversaire (chef)."
- DONE — TeamMemberMatchingViewController.NSE → "En attente du match."
- DONE — TeamMemberMatchedViewController.NSE → "Match trouvé !"
- DONE — TeamWaitingWindowViewController.NSE → "En attente..."

### 19.3 Résultats et salle
- DONE — TeamResultViewController.NSE → "Résultat d'équipe."
- DONE — TeamResultEffectViewController.NSE → "Résultat d'équipe." (shared postfix)
- DONE — TeamRoomViewController.NSE → "Salon d'équipe."
- DONE — TeamRoomEditSceneViewController : ScreenTitles "TeamRoomEditScene" → "screen_team_room" (has NotificationStack not NSE — dump confirmed YgomGame.Team)

---

## 20. WCS (WORLD CHAMPIONSHIP SERIES)

Statut global : PARTIAL

### 20.1 Portail WCS
- DONE — TopMenuViewController (YgomGame.WCS.Portal).NSE → "Menu WCS."
- DONE — WatchMenuViewController.NSE → "Spectateur WCS."
- DONE — WCSBattleInfoBaseViewController.NSE → "Informations de combat WCS."

### 20.2 Arène et timer
- DONE — WCSFinal_ColosseumViewController : MiscViewsPatch.WcsFinalArena_Postfix → "Arène WCS."
- DONE — WCSFinal_TimerViewController : MiscViewsPatch.WcsFinalTimer_Postfix → "Minuterie WCS." (reads time fields)
- DONE — WCSFinal_TimerSettingViewController : MiscViewsPatch.WcsFinalTimerSetting_Postfix → "Paramètres du timer WCS Finale." (bypass empty stub)

### 20.3 Équipes et tableaux
- DONE — WCSTeamRoomViewController.NSE → "Salon d'équipe WCS."
- DONE — WCSTeamTableViewController : ScreenTitles "WCSTeamTable" → "screen_wcs_team_table"
- DONE — WCSTeamTableViewControllerBase : ScreenTitles (full key) → "screen_wcs_team_table"
- DONE — WCSTeamTableViewControllerVer2 : ScreenTitles (full key) → "screen_wcs_team_table"

### 20.4 Prédictions
- DONE — WinPredictionViewController : ScreenTitles "WinPrediction" → "screen_wcs_prediction"
- DONE — WinPredictionPlayersViewController : ScreenTitles "WinPredictionPlayers" → "screen_wcs_prediction"
- DONE — WinPredictionRewardViewController : ScreenTitles "WinPredictionReward" → "screen_wcs_prediction_reward"
- DONE — WinPredictionTogglePageViewController : ScreenTitles "WinPredictionTogglePage" → "screen_wcs_prediction"

---

## 21. TDY (TAG DUEL — DUEL EN ÉQUIPE PVE)

Statut global : DONE (core)

- DONE — TDYMapViewController : MiscViewsPatch.TdyMap_Postfix → "Carte Tag Duel."
- DONE — TdyResultViewController : MiscViewsPatch.TdyResult_Postfix — reads m_IsCompleteKizuna → "Résultat Tag Duel [— Kizuna complète !]."
- DONE — TdyDuelTransitionViewController : ScreenTitles "TdyDuelTransition" → "screen_tdy_duel"
- SKIP — TdyCutInViewController : classe de base abstraite, pas de NSE direct ; sous-classes couvertes individuellement
- DONE — TdyChainCutInViewController : ScreenTitles "TdyChainCutIn" → "screen_tdy_chain"
- DONE — TdyGetKizunaCutInViewController : ScreenTitles "TdyGetKizunaCutIn" → "screen_tdy_kizuna_get"
- DONE — TdyCompleteKizunaCutInViewController : ScreenTitles "TdyCompleteKizunaCutIn" → "screen_tdy_kizuna_complete"

---

## 22. AUTO-DUEL

Statut global : PARTIAL

- DONE — AutoDuelLauncherViewController : ScreenTitles entry "screen_autoduel" — max coverage (VC has no fields/methods beyond shared stub)
- DONE — AutoDuelViewController : ScreenTitles entry "screen_autoduel" — max coverage (VC has no fields/methods beyond shared stub)

---

## 23. DUEL LIVE (SPECTATEUR)

Statut global : PARTIAL

- DONE — DuelLiveViewController : NSE patché (Fix 75) — annonce "Duel en direct."
- DONE — DuelLiveReplayDialogViewController : ReplayPatch.NSE → "Replay en direct. Choisissez un deck."
- DONE — DuelLiveSelectCardDialogViewController : MiscViewsPatch.DuelLiveSelectCard_Postfix → "Duel Live — Sélection de carte." (namespace: YgomGame.DuelLive)
- DONE — DuelLiveWCSFilterDialog : ScreenTitles "DuelLiveWCSFilter" → "screen_duel_live_wcs_filter"

---

## 24. CERTIFICATION

Statut global : DONE

- DONE — CertificationConfirmViewController.NSE → "Certification — confirmation."
- DONE — CertificationDetailViewController.NSE → "Certification — détails."
- DONE — CertificationExplanationViewController.NSE → "Certification — explication."
- DONE — CertificationDuelFieldDialogViewController.NSE → "Certification — terrain de duel."
- DONE — CertificationWritingViewController.NSE → "Certification — questions."
- DONE — CertificationWritingReslutViewController.NSE → reads isSuccess + correctAnswerNum → "Certification : [Réussi/Échoué]. N bonne(s) réponse(s)."
  Tous implémentés via MiscViewsPatch (session 2026-03-15).

---

## 25. CARD FILE (COLLECTION DE CARTES)

Statut global : PARTIAL

- DONE — ViewControllerPatch.ScreenTitles : CardFile → "Collection de cartes." (via Show_Postfix)
  CardFileTable → "Collection de cartes." (même clé)
- DONE — CardFileViewController : MiscViewsPatch.CardFile_Postfix (NSE) → reads cfManager.cfi.possessingCardNum / totalCardNum → "Collection : N / M cartes (X%)"
- DONE — CardFileTableViewController : NSE → "Fichiers de cartes. N fichier(s)." + OnEntityUpdate ISV → "{nom}. {progression}." (Fix 77)
- DONE — CardFileCardGetDialog : MiscViewsPatch.CardFileCardGet_Postfix (NSE, namespace YgomGame.CardFile) → reads m_BeforeHaveNum/m_AfterHaveNum/m_CompleteNum
- DONE — CardListBrowserRegulationFilterViewController : ScreenTitles "CardListBrowserRegulationFilter" → "screen_regulation_filter"

---

## 26. CODES PROMO ET MARKET

Statut global : PARTIAL

### 26.1 Codes promo
- DONE — ViewControllerPatch.ScreenTitles : PromoCodes → "Codes promo." (via Show_Postfix)
- TODO — PromoCodesViewController : détails (champs code actif, résultat)
  - CodeInputWidget : champ de saisie
  - BannerWidget : bannière résultat
  - Namespace : YgomGame.PromoCodes

### 26.2 Market / Échanges
- TODO — MarketPoolViewController : pool de marché
  - Namespace : YgomGame.Market

---

## 27. PRIX ET RÉCOMPENSES SPÉCIALES

Statut global : DONE

- DONE — TurnOverPrizeOpenViewController : MiscViewsPatch.TurnOverPrizeOpen_Postfix → "Ouverture du lot."
- DONE — TurnOverPrizeCollabEditViewController : MiscViewsPatch.TurnOverPrizeCollab_Postfix → "Tour des prix — Édition collaboration." (bypass empty stub RVA 0x3E4080)
  - Namespace : YgomGame.Prize.TurnOverPrize
- DONE — TurnOverPrizeViewerViewController : ScreenTitles "TurnOverPrizeViewer" → "screen_turn_over"
- DONE — TurnOverPrizeItemViewerViewController : ScreenTitles "TurnOverPrizeItemViewer" → "screen_turn_over"

---

## 28. CONTRÔLES GÉNÉRIQUES (UI)

Statut global : DONE

### 28.1 Input et navigation
- DONE — InputBlockPatch : blocage touches contextuelles (Ctrl, Esc, Space, Enter, lettres duel)
- DONE — EventSystemPatch : blocage Tab Unity (parasite), blocage Submit parasite
- DONE — InputFieldPatch : détection champ de saisie actif (IsActive flag)
- DONE — GeneralMenuNavigator : suffixe ", N sur M" sur tous les SelectionButton

### 28.2 Contrôles standard
- DONE — TogglePatch : toggle on/off avec label
- DONE — SliderPatch : valeur slider avec label (150ms cooldown)
- DONE — DropdownPatch : dropdown Show/set_value/Hide ("option N sur M", 200ms dédup)
- DONE — CardReportTelopPatch : bandeau stats post-effet ("+500 ATK", etc.)

### 28.3 ISV (InfinityScrollView) — Pattern générique
- DONE — Pattern ISV implémenté dans LotteryRewardPatch et DuelPassRewardPatch
- DONE — ProfileReplayViewController.OnItemSetData(GameObject, int) — ISV navigation replay personnel
  → Annonce textes TMP visibles (résultat, mode, date) — dédup par (index, texte) (Fix 81)
- DONE — RoomReplayViewController.UpdateEntity(GameObject, int) — ISV navigation replay salon
  → Annonce textes TMP visibles — dédup par (index, texte) (Fix 81)
- SKIP — Missions ISV : navigation déjà couverte par SelectionButtonPatch.ProcessMissionsMenu
- SKIP — Historique (GetHistoryViewController) : pagination L/R, pas d'ISV
- SKIP — DuelLive ISV : ProductWidget (SelectionButton) → couvert par SelectionButtonPatch.ProcessPacks

---

## 29. SONDAGES ET AIDE

Statut global : DONE (ScreenTitles)

- DONE — EnqueteViewController : ScreenTitles "Enquete" → "screen_enquete" (ViewControllerPatch auto-announce)
- DONE — EnqueteCardSelectViewController : ScreenTitles "EnqueteCardSelect" → "screen_enquete_card"
- DONE — HelpViewController : ScreenTitles "Help" → "screen_help" (ViewControllerPatch auto-announce)
- DONE — WebHelpViewController : ScreenTitles "WebHelp" → "screen_web_help"
- DONE — InquiryViewController : ScreenTitles "Inquiry" → "screen_inquiry"
- DONE — CreditViewController : ScreenTitles "Credit" → "screen_credits"

---

## 30. LIAISON DE DONNÉES / COMPTE

Statut global : DONE

- DONE — ConsoleDataLinkViewController : ScreenTitles "ConsoleDataLink" → "screen_console_link"
- DONE — ConsoleDataLinkInheritViewController : ScreenTitles "ConsoleDataLinkInherit" → "screen_console_link"
- DONE — ConsoleDataLinkRegistViewController : ScreenTitles "ConsoleDataLinkRegist" → "screen_console_link"

---

## 31. ÉLÉMENTS TRANSVERSAUX (non liés à un écran spécifique)

### 31.1 Localisation
- DONE — Loc.cs : fr (primaire) + en (fallback) + de — ~100+ clés
- DONE — Tous les patches utilisent Loc.Get() — aucun string TTS codé en dur
- DONE — Support japonais (ja) — ~70 clés dans _japanese, fallback anglais pour les clés manquantes (Fix 79)
- TODO — Support espagnol (es), portugais (pt), italien (it), coréen (ko)
  - Priorité basse : ajouter quand demandé par la communauté

### 31.2 Gestion d'erreurs réseau
- DONE — SystemDialogPatch : SystemDialog erreurs réseau/maintenance — CRITIQUE couvert
- DONE — Annonce automatique déconnexion : UINetworkHandler.networkDisconnectErrorDialog prefix → "Connexion perdue." interrupt (Fix 78)

### 31.3 Raccourcis clavier hors duel
- DONE — F1 : aide raccourcis
- DONE — F3 : annonce l'écran courant
- DONE — F12 : historique TTS
- DONE — H : annonce gemmes + badge notifications non lues + cadeaux en attente (HeaderPatch)
- DONE — N : nombre de notifications non lues — KeyboardShortcuts.ReadNotificationCount() + NotificationPatch.CountUnread()
- DONE — P : progression actuelle (Duel Pass / Missions / Saison) — KeyboardShortcuts + ActiveInstance caches (Fix 74)

---

## RÉSUMÉ STATISTIQUE

- Total ViewControllers/Dialogs dans le jeu : ~240 (hors variantes IL2Cpp et tests)
- Total Widgets pertinents : ~50
- Total Namespaces métier : ~60
- Couverts (DONE) : ~175  (mise à jour 2026-03-15)
  - Section 1 entière : 23 éléments (logos, titre, chargement, inscription, tutoriel)
  - Duel complet : 45+ patches (PV, phases, événements, commandes, raccourcis, démarrage)
  - Menus quotidiens : 25+ éléments (Home, Header, HomeMisc, Résultats, Replays…)
  - Contrôles UI : Toggle, Slider, Dropdown, InputField, EventSystem
  - Dialogs : CommonDialog 12 variantes, SystemDialog, ActionSheet, DuelDialogs, MessageDialog, EffectTaskRunDialog, InformDialogFallback
  - Événements saisonniers : Colosseum (~15), Team (~12), TDY (~7), DiceRally (~4), TurnOverPrize (~4), WCS (partiel)
  - Boutique : Shop + GemShop + Tickets + ConfirmRegDialog + BuyButtonGroup
  - Deck : CardCraft, BatchDismantle, AutoBuild, SetAccessory, TrialDraw, StructureDeck, CardFile, SearchBox
  - Certification : 6 écrans couverts
  - Divers : Sondages, ConsoleDataLink, PromoCodesScreenTitle, Colosseum, Ratings
- Partiellement couverts (PARTIAL) : ~8
  - ShopViewController (onglets OK, produits ISV manquant)
  - DeckBrowserViewController (ouverture OK, ISV manquant)
  - FriendViewController (ouverture OK, ISV liste amis manquant)
  - NotificationPatch (ouverture + navigation ISV OK, corps HTML non lu)
  - DuelistCupResultViewController (DP OK, classement global non lu)
  - ColosseumDuelResultViewController_Rate (résultat OK, delta rating non lu)
  - DuelLiveViewController — DONE (Fix 75)
  - AutoDuelViewController — DONE (ScreenTitles = max coverage)
- À faire (TODO) : ~18
  - ISV généralisé (Missions, Notifications, Amis, Replays, Boutique produits, SoloGate, DeckBrowser)
  - NotificationPatch contenu détaillé (corps HTML/MDMarkup)
  - PromoCodesViewController (champs code/résultat)
  - MarketPoolViewController
  - Raccourci P (progression Duel Pass/Missions/Saison hors duel)
  - Localisation : japonais, espagnol, portugais, italien, coréen
  - Connexion réseau silencieuse (sans dialog SystemDialog)
- Non pertinents (SKIP) : ~22

---

## PRIORITÉS D'IMPLÉMENTATION

### Priorité 1 — Critique (chaque session de jeu) — TOUTE COMPLÈTE ✓
1. ~~SystemDialog~~ — DONE (SystemDialogPatch : erreurs réseau, maintenance)
2. ~~LoginBonusViewController~~ — DONE (LoginBonusPatch : Jour N sur M + récompense + statut)
3. ~~PresentBoxViewController~~ — DONE (PresentBoxPatch : comptage + items ISV)
4. ~~HeaderViewController~~ — DONE (HeaderPatch : raccourci H = gemmes + badge notifications + cadeaux)
5. ~~DuelResultViewController~~ — DONE (DuelResultPatch : résumé + boutons)
6. ~~DownloadViewController~~ — DONE (DownloadViewControllerPatch : progression téléchargement)
7. ~~LotteryPortalViewController~~ — DONE (LotteryPortalPatch : nom du pack)

### Priorité 2 — Important (jeu quotidien complet) — TOUTE COMPLÈTE ✓
8.  ~~SoloGateViewController~~ — DONE (SoloGatePatch : N portails)
9.  ~~SoloSelectChapterViewController~~ — DONE (SoloChapterPatch : nom + statut chapitre)
10. ~~DuelPassViewController~~ — DONE (DuelPassViewControllerPatch : palier actuel/suivant)
11. ~~MissionViewController~~ — DONE (MissionViewControllerPatch : onglet actif)
12. ~~DeckBrowserViewController~~ — DONE (DeckBrowserPatch : nom + nb cartes) — ISV TODO
13. ~~SeasonPointViewController~~ — DONE (SeasonPointPatch : rang/points via EOM)
14. ~~ProfileViewController~~ — DONE (ProfilePatch : nom + niveau)
15. ~~FriendViewController~~ — DONE (FriendViewControllerPatch : N suivi(s)) — ISV TODO
16. ~~RoomViewController~~ — DONE (RoomViewControllerPatch : nom + N/M joueurs)
17. ~~SearchBoxDialog~~ — DONE (SearchBoxDialogPatch : mot-clé ou vide)
18. ~~ShopViewController~~ — DONE (ShopViewControllerPatch : catégorie active) — ISV TODO
19. ~~ScenarioViewController~~ — DONE (ScenarioPatch : m_ScenarioName)

### Priorité 3 — Fonctionnalités secondaires (prochaines cibles)
20. ~~BatchDismantleDialog~~ — DONE (CardCraftPatch)
21. ~~AutoBuildDialog~~ — DONE (DeckEditMiscPatch)
22. ~~SetAccessoryDialog~~ — DONE (MiscViewsPatch)
23. ~~TrialDrawViewController~~ — DONE (DeckBrowserPatch)
24. ~~StructureDeckSelectViewController~~ — DONE (StructureDeckPatch)
25. ~~CardFileViewController~~ — DONE (MiscViewsPatch : N/M cartes + %)
26. DuelLiveViewController — DONE (Fix 75 — NSE patch)
27. AutoDuelViewController — DONE (ScreenTitles = max coverage)
28. NotificationPatch contenu détaillé — lecture corps HTML complet (TODO)
29. ~~DuelStartViewController~~ — DONE (DuelStartPatch)
30. ~~MessageDialog / EffectTaskRunDialog~~ — DONE (DialogStatePatch)
31. ~~DuelResultViewController_Solo / DuelistCup / Colosseum~~ — DONE (DuelResultMiscPatch)
32. ~~ProfileReplayViewController / RoomReplayViewController / DuelLiveReplayDialogViewController~~ — DONE (ReplayPatch)
33. ~~HomeActionViewController / HomeAnnounceViewController / HomeSubMenuViewController / PreHomeViewController~~ — DONE (HomeMiscPatch)
34. ~~GemRestoreOnLoginViewController~~ — DONE (RegistrationPatch)

### Priorité 4 — Événements saisonniers
35. ~~ColosseumViewController + tous écrans associés (~15 VCs)~~ — DONE (MiscViewsPatch + ScreenTitles)
36. ~~TeamViewController + tous écrans associés (~12 VCs)~~ — DONE (MiscViewsPatch)
37. WCS ViewControllers — PARTIAL (~8 VCs, core done, WCSFinal timers + predictions done)
38. ~~DiceRally ViewControllers (~4 VCs)~~ — DONE (MiscViewsPatch + ScreenTitles)
39. ~~TDY ViewControllers (~7 VCs)~~ — DONE (MiscViewsPatch + ScreenTitles)
40. ~~TurnOverPrize ViewControllers (~4 VCs)~~ — DONE (MiscViewsPatch + ScreenTitles)

### Priorité 5 — Confort et complétude
41. ~~Écrans Tutoriel/Première connexion~~ — DONE (TutorialPatch + RegistrationPatch)
42. ~~CertificationViewController (~5 VCs)~~ — DONE (MiscViewsPatch : 6 écrans couverts)
43. PromoCodesViewController — TODO (ScreenTitles OK, champs code/résultat non lus)
44. ~~EnqueteViewController (sondages)~~ — DONE (ScreenTitles)
45. ~~ConsoleDataLinkViewController (liaison compte)~~ — DONE (ScreenTitles)
46. ~~GemShopViewController (achats payants)~~ — DONE (ShopMiscPatch)
47. ~~ConfirmRegDialogProductWidget / BuyButtonGroupWidget~~ — DONE (ShopBuyWidgetPatch)
48. ~~InformDialogFallbackPatch — filet de sécurité InformDialog~~ — DONE
49. Raccourcis hors duel : P (progression Duel Pass/Missions/Saison) — TODO
50. ISV généralisé (Missions, Notifications, Amis, Replays) — TODO
