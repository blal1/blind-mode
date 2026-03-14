# MasterDuelAccessibility — Plan de couverture complète

Date : 2026-03-14 (mis à jour)
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

Statut global : DONE (essentiel), PARTIAL (fonctionnalités secondaires)

### 6.1 Éditeur de deck
- DONE — DeckEditPatch : ajout/retrait carte, renommage, sauvegarde, focus éditeur
- DONE — CardBrowserPatch : navigateur cartes intégré (auto-lecture + pagination)
- DONE — CardInfoPatch : lecture nom + stats + description de chaque carte
- DONE — FilterSelectViewPatch : dialog filtres multi-sélection (actif/inactif)
- TODO — DeckEditSubMenuViewController : sous-menu (copier, supprimer, renommer deck)
- TODO — DeckNameEditDialog : dialog de renommage deck
- DONE — SearchBoxDialogPatch : SearchBoxDialog.NotificationStackEntry + Open(string, Action)
  - Lit m_InputFieldText.text → "Recherche de carte : [mot-clé]." ou "Saisissez le nom."
  - Applied via Plugin.ApplyPatches()
- TODO — FilterDialog : filtres avancés (attribut, type, niveau, ATK/DEF, etc.)
- TODO — AutoBuildDialog : construction automatique de deck (IA suggère)

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
- TODO — BatchDismantleDialog : démantèlement en lot
  - Données à lire : nombre de cartes sélectionnées, CP total à obtenir
- TODO — CardRelativeBrowserViewController : cartes liées (même archétype, etc.)

### 6.4 Accessoires / Cosmétiques de deck
- TODO — SetAccessoryDialog : personnalisation du deck
  - Données à lire : protège-cartes actuel, terrain de duel, compagnon (mate),
    icône de joueur, cadre de profil
  - Namespace : YgomGame.Deck
- TODO — IconViewerViewController : aperçu d'une icône
- TODO — ItemPreviewViewController : aperçu d'un objet cosmétique

### 6.5 Decks de structure
- TODO — StructureDeckSelectViewController : sélection d'un deck de structure à acheter
  - Données à lire : nom, contenu, prix
- TODO — StructureDeckSelectBackableViewController : sélection avec retour
- TODO — StructureDeckObtainViewController : deck de structure obtenu
  - Annonce : "Deck de structure 'Nom' obtenu !"

### 6.6 Tirage d'essai
- TODO — TrialDrawViewController : simuler une pioche avec un deck
  - Données à lire : 5 cartes piochées (noms), possibilité de relancer
  - Namespace : YgomGame.DeckBrowser

### 6.7 Recherche via Neuron
- TODO — NeuronDeckSearchViewController : recherche de deck via l'app Neuron
  - Import de deck depuis un QR code ou un ID

---

## 7. BOUTIQUE (SHOP)

Statut global : PARTIAL

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
- TODO — ConfirmRegDialogProductWidget : confirmation d'achat
  - Données à lire : nom du produit, prix, devise, contenu
- TODO — BuyButtonGroupWidget : boutons d'achat (quantité, prix total)

### 7.3 Boutique de gemmes (achat payant)
- TODO — GemShopViewController : liste des lots de gemmes
  - Données à lire : quantité de gemmes, prix réel (€/$)
- TODO — GemShopPermissionViewController : consentement avant achat
- TODO — GemShopApprovalViewController : approbation d'achat (parental, etc.)
- TODO — GemGetHistoryViewController : historique des achats de gemmes

### 7.4 Tickets et échanges
- TODO — TicketInventoryViewController : inventaire de tickets
  - Données à lire : type de ticket, quantité, utilisation possible
- TODO — ItemExchangeViewController : échange d'objets (tickets → cartes, etc.)
- TODO — GetHistoryViewController : historique des objets obtenus
- TODO — ItemGetHistoryViewController : historique détaillé

### 7.5 Aperçus produits
- TODO — ProductWidget / ProductContainerWidget : infos produit dans la liste
- TODO — ProductShowcaseWidget : vitrine de produit (bannière animée)
  - Namespace : YgomGame.Shop.ProductViewer
- TODO — HighlightWidget : produit mis en avant

---

## 8. OUVERTURE DE PACKS (LOTTERY)

Statut global : PARTIAL

### 8.1 Portail de loterie
- DONE — ViewControllerPatch : LotteryPortal détecté → "Portail de packs"
- DONE — LotteryPortalPatch : LotteryPortalViewController.NotificationStackEntry → "Portail de packs — [nom pack]"
  - Dump : YgomGame.Lottery, m_Id (int 0xE8)
  - Tente de résoudre le nom via YgomGame.Lottery.LotteryData.GetName(int) — fallback titre générique
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : vérifier que LotteryData.GetName existe en runtime et retourne un nom lisible

### 8.2 Ouverture de pack
- TODO — CardPackOpenViewController : animation d'ouverture
  - Données à lire : nom du pack ouvert, nombre de packs à ouvrir
  - Namespace : YgomGame.CardPack.Open
  - Sous-namespaces : Actor (animations), Sequence (étapes), Widget (UI)
- TODO — LotteryResultViewController : révélation drag-to-reveal
  - Données à lire : chaque carte révélée (nom + rareté)
  - NOTE : card IDs dans closures lambda — LotteryRewardPatch donne le résumé
- TODO — CardPackOpenResultViewController : résultat final (liste complète)
- TODO — LotteryFirstInfoViewController : info premier achat (bonus garanti)
- TODO — LotteryFirstViewViewController : première vue d'un pack
- TODO — LotterySubmissionViewController : confirmation d'achat de pack

### 8.3 Résultat et historique
- DONE — LotteryRewardPatch : OnCreatedView → annonce toutes les cartes obtenues
- DONE — LotteryRewardPatch : SetCardButtonAction → mapping bouton → carte
- DONE — LotteryRewardPatch : OnUpdateEntity + FocusCallback (ISV navigation)
- TODO — LotteryHistoryViewController : historique des packs ouverts
  - Données à lire : date, pack, cartes obtenues
- TODO — LotteryCardSelectViewController : sélection de carte garantie
  - Données à lire : liste des cartes disponibles, rareté
  - Namespace : YgomGame.CardPoolSelect (CardPoolSelectViewController possible)

### 8.4 Taux et packs secrets
- TODO — CardPackRateListViewController : liste de taux de drop
  - Données à lire : probabilité par rareté (UR, SR, R, N)
- TODO — SecretPackObtainViewController : pack secret débloqué
  - Annonce : "Pack secret 'Nom' débloqué !"

---

## 9. MODE SOLO

Statut global : PARTIAL

### 9.1 Carte du monde
- DONE — ViewControllerPatch : Solo détecté → "Mode Solo"
- DONE — SelectionButtonPatch : boutons Solo navigables (ProcessDuelMenu)
- TODO — SoloModeViewController : carte du monde solo
  - Données à lire : portails disponibles, progression globale
  - Navigation clavier entre portails (nécessite analyse du SelectorManager)

### 9.2 Portails et chapitres
- DONE — SoloGatePatch : SoloGateViewController.NotificationStackEntry
  - Lit mainDataList.Count pour annoncer le nombre de portails
  - Annonce : "Portails Solo — N portail(s)."
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : navigation ISV entre portails (OnItemSetDataMain)
- DONE — SoloChapterPatch : SoloSelectChapterViewController.ChapterMap.OnClickChapter
  - Accès via GetNestedType("ChapterMap") + FindMethod par nombre de paramètres
  - Lit strChapter + IsCleared/IsCompleted + status enum (-1=UNOPEN)
  - Annonce : "Chapitre : [nom]. [statut]."
  - Applied via LatePatches.ApplyMenuScenePatches()
- TODO — SoloPortalViewController : animation d'entrée dans un portail

### 9.3 Déroulement et résultats
- TODO — SoloStartProductionViewController : cinématique de démarrage
  - Annonce : "Début du chapitre : [nom]"
- TODO — SoloClearViewController : écran de victoire solo
  - Données à lire : récompenses obtenues, chapitre suivant disponible
- DONE — ScenarioPatch : ScenarioViewController.NotificationStackEntry
  - Lit m_ScenarioName (string 0xD8) → "Scénario : [nom]." ou "Scénario Solo."
  - Applied via LatePatches.ApplyMenuScenePatches()
- TODO — ScenarioVolumeViewController : sélection de volume scénario

---

## 10. PVP / MATCHMAKING / ROOMS

Statut global : PARTIAL

### 10.1 Matchmaking standard
- DONE — MatchingPatch : PvpMenuMatchingViewController (SEARCHING/MATCHING/TIMEOUT)
- TODO — PvpMenuMatchingViewController_Room : matchmaking salon privé
- TODO — PvpMenuMatchingViewController_Team : matchmaking équipe
- TODO — PvpMenuMatchingViewController_WcsFinal : matchmaking WCS Finals

### 10.2 Salons privés (Room)
- DONE — RoomViewControllerPatch : RoomViewController.NotificationStackEntry
  - Lit roomBehaviour.roomInfo.roomName + memberNum/memberMax
  - Annonce : "Salon : [nom]. N sur M joueur(s)." ou "Salon."
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : navigation membres (ISV), détails règles
- TODO — RoomCreateViewController : création de salon
  - Données à saisir : nom, mot de passe, règles, ban list
- TODO — RoomEntryViewController : rejoindre un salon (saisir ID/mot de passe)
- TODO — RoomInfoViewController : détails d'un salon
- TODO — RoomInviteViewController : inviter un ami
- TODO — RoomMemberViewController : liste des membres (statut : prêt/pas prêt)
- TODO — RoomReplayViewController : replay dans salon

### 10.3 Duel test (amis)
- TODO — TestDuelEntryViewController : entrée en duel test
- TODO — TestDuelEntryViewController_Team : duel test en équipe
- TODO — TestDuelMatchingViewController : matchmaking duel test

---

## 11. PROFIL ET SOCIAL

Statut global : PARTIAL

### 11.1 Profil joueur
- DONE — ViewControllerPatch : Profile/ProfileEdit/ProfileCardCheck détectés
- DONE — SelectionButtonPatch : ProcessProfile (nom, rang, etc.)
- DONE — ProfilePatch : ProfileViewController.NotificationStackEntry
  - Lit profileCard (ProfileCard 0x198) → m_ProfileDic → "name" + "level"
  - Annonce : "Profil de [nom]. Niveau [niveau]." / "Profil de [nom]." / "Profil."
  - Applied via LatePatches.ApplyMenuScenePatches()
- TODO — ProfileDataViewController : données détaillées (historique de rang, stats)
- TODO — ProfileEditViewController : édition profil
  - Données à modifier : icône, titre, commentaire, cadre, compagnon (mate)
- TODO — ProfileCardCheckViewController : vérification des cartes du profil

### 11.2 Amis
- DONE — FriendViewControllerPatch : FriendViewController.NotificationStackEntry
  - Lit m_FollowNumText (TMP_Text 0x1E8) → "Amis — N suivi(s)." ou "Amis."
  - Applied via LatePatches.ApplyMenuScenePatches()
  - TODO : navigation ISV (liste amis), statuts en ligne
- TODO — FriendSearchViewController : recherche d'ami (par ID)
  - Saisie de l'ID + résultat (nom, rang)

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
- TODO — MissionBulkRecieveDialogWidget : collecte groupée
  - Annonce : "X récompenses collectées : [liste]"
- TODO — MissionGoalWidget : objectif individuel (bouton "Collecter")
- TODO — MissionTabWidget : onglets de missions (badge non-lu)

### 12.3 Panel Missions (événements carte)
- TODO — PanelMission (YgomGame.PanelMission)
  - MapWidget : carte d'événement avec cases
  - PanelWidget : case individuelle (récompense, progression)

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

Statut global : PARTIAL

### 14.1 Rang actuel
- DONE — ViewControllerPatch : SeasonPoint/History/Ranking détectés
- DONE — SeasonPointPatch : SeasonPointViewController.NotificationStackEntry
  - Lit myGroup (ElementObjectManager 0x178) → traverse TMP_Text enfants pour rang/points
  - Annonce : "Points de saison. [texte rang]." ou "Points de saison."
  - Applied via LatePatches.ApplyMenuScenePatches()
- TODO — SeasonPointTopMenuViewController : menu principal saison

### 14.2 Historique et classement
- TODO — SeasonPointHistoryViewController : historique des saisons passées
  - Données à lire : rang atteint, récompenses obtenues
- TODO — SeasonPointRankingViewController : classement global
  - Données à lire : position, points, joueur le mieux classé
- TODO — SeasonResultViewController : résultat de fin de saison
  - Annonce : récompenses de fin de saison

### 14.3 Équipes saison
- TODO — SeasonPointTeamCreateViewController : créer une équipe
- TODO — SeasonPointTeamCreateDialogViewController : dialog de création
- TODO — SeasonPointTeamParticipateViewController : rejoindre une équipe
- TODO — SeasonPointTeamTopViewController : classement équipe

---

## 15. PARAMÈTRES

Statut global : PARTIAL

### 15.1 Menu principal
- DONE — ViewControllerPatch : Settings détecté → "Paramètres"
- DONE — SelectionButtonPatch : ProcessSettingsMenu (valeur slider, texte mode)
- DONE — SliderPatch : annonce valeur + label du slider
- DONE — DropdownPatch : annonce option sélectionnée ("option N sur M")
- DONE — TogglePatch : annonce toggle on/off
- TODO — SettingMenuViewController : lecture des titres de sections
  - Données à lire : catégories (Son, Graphiques, Contrôles, Langue, etc.)
  - Namespace : YgomGame.Settings

### 15.2 Paramètres spécifiques
- TODO — LanguageSelectViewController : changement de langue
  - Liste des langues disponibles, langue actuelle
- TODO — PrivacySettingsViewController : paramètres de confidentialité
- DONE — TitleScreenPatch : TitleSettingMenuViewController.NotificationStackEntry → "Paramètres."
  - Accessible avant connexion (YgomGame.SubMenu namespace)

---

## 16. NOTIFICATIONS

Statut global : PARTIAL

### 16.1 Panneau principal
- DONE — ViewControllerPatch : Notifications détecté → "Notifications"
- DONE — NotificationPatch : NotificationStackEntry (ouverture + compteur non-lu)
- DONE — NotificationPatch : UpdateNotification + UpdateEntityCallback (fix BindingFlags appliqué)
- DONE — SelectionButtonPatch : ReadNotificationText (corps + catégorie)

### 16.2 Contenu détaillé
- TODO — Lecture complète du corps de notification (HTML/texte long)
  - Les notifications peuvent contenir du markdown (MDMarkup)
  - Namespace : YgomGame.MDMarkup (MDMarkupAssetViewController)
- TODO — Onglets : Nouvelles, Maintenance, Bugs — navigation entre onglets
- TODO — Badge non-lu sur chaque onglet

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
- TODO — PlaceHolderDialogViewController : placeholder (chargement en cours)
- TODO — SaveDialogViewController : sauvegarde en cours
- TODO — TextureImageDialogViewController : aperçu d'image (protège-cartes, terrain)
- TODO — PasswordDialog / PasswordDialogViewController : saisie de mot de passe
  - Données à lire : titre ("Entrez le mot de passe du salon")
- TODO — InformDialogViewControllerBase : dialog d'information (base class)

---

## 18. ÉVÉNEMENTS ET COLOSSEUM

Statut global : TODO

### 18.1 Colosseum (événement principal)
- TODO — ColosseumViewController : écran principal
  - Données à lire : événement actif, règles, dates, rang actuel
- TODO — ColosseumStartViewController : démarrage participation
- TODO — ColosseumInfoViewController : informations détaillées
- TODO — ColosseumInfoEditSceneViewController : info avec scène animée
- TODO — ColosseumConfirmAgreementViewController : confirmation participation
- TODO — ColosseumConfirmGroupViewController : confirmation groupe

### 18.2 Résultats et classements Colosseum
- TODO — ColosseumResultViewController : résultat
- TODO — ColosseumResultViewController_Wcs : résultat WCS
- TODO — ColosseumResultVersusViewController : résultat versus
- TODO — ColosseumResultEditSceneViewController : résultat avec scène
- TODO — ColosseumHistoryViewController : historique
- TODO — ColosseumRankingViewController : classement
- TODO — ColosseumRankingViewController_Rate : classement par rating
- TODO — ColosseumRankingDuelistCupViewController : classement Duelist Cup
- TODO — ColosseumRankingEditSceneViewController : classement avec scène
- TODO — ColosseumSelectVersusViewController : sélection adversaire

### 18.3 Récompenses Colosseum
- TODO — ColosseumRewardViewController : récompenses
- TODO — ColosseumRewardDiceRallyViewController : récompenses Dice Rally
- TODO — ColosseumRewardDuelistCupViewController : récompenses Duelist Cup
- TODO — ColosseumRewardTournamentViewController : récompenses tournoi
- TODO — ColosseumRankEventRewardViewController : récompenses rang

### 18.4 Dice Rally (événement spécial)
- TODO — DiceRallyMapEditorViewController : plateau de jeu (cases)
  - Données à lire : position actuelle, case suivante, effet de case
  - Namespace : YgomGame.DiceRally
- TODO — DiceRallyEffectDialogViewController : effet de case
- TODO — DiceResultViewController : résultat du lancer
  - Données à lire : valeur du dé, case atteinte, récompense
- TODO — DiceRallySubMenuViewController : sous-menu

---

## 19. ÉQUIPE (TEAM)

Statut global : TODO

### 19.1 Création et gestion
- TODO — TeamCreateViewController : création d'équipe
  - Données : nom, règles, membres max
- TODO — TeamDesignationViewController : attribution de rôles
- TODO — TeamInfoViewController : info équipe
- TODO — TeamNameSelectViewController : nom d'équipe
- TODO — TeamRegulationSetSelectViewController : sélection de règles (ban list)

### 19.2 Membres et matchmaking
- TODO — TeamMemberViewController : liste des membres
- TODO — TeamInviteViewController : invitation
- TODO — TeamLeaderMatchingViewController : leader lance le matchmaking
- TODO — TeamMemberMatchingViewController : membre en attente
- TODO — TeamMemberMatchedViewController : match trouvé
- TODO — TeamWaitingWindowViewController : fenêtre d'attente

### 19.3 Résultats et salle
- TODO — TeamResultViewController : résultat d'équipe
- TODO — TeamResultEffectViewController : effets visuels résultat
- TODO — TeamRoomViewController : salon d'équipe
- TODO — TeamRoomEditSceneViewController : édition salon

---

## 20. WCS (WORLD CHAMPIONSHIP SERIES)

Statut global : TODO

### 20.1 Portail WCS
- TODO — TopMenuViewController (YgomGame.WCS.Portal) : menu principal WCS
- TODO — WatchMenuViewController : spectateur WCS
- TODO — WCSBattleInfoBaseViewController : info combat

### 20.2 Arène et timer
- TODO — WCSFinal_ColosseumViewController : arène WCS
- TODO — WCSFinal_TimerViewController : timer WCS
- TODO — WCSFinal_TimerSettingViewController : paramètres timer

### 20.3 Équipes et tableaux
- TODO — WCSTeamRoomViewController : salon équipe WCS
- TODO — WCSTeamTableViewController / Base / Ver2 : tableau de match

### 20.4 Prédictions
- TODO — WinPredictionViewController : prédictions de victoire
- TODO — WinPredictionPlayersViewController : joueurs
- TODO — WinPredictionRewardViewController : récompenses prédiction
- TODO — WinPredictionTogglePageViewController : page de toggle

---

## 21. TDY (TAG DUEL — DUEL EN ÉQUIPE PVE)

Statut global : TODO

- TODO — TDYMapViewController : carte TDY (plateau d'aventure)
  - Namespace : YgomGame.Tdy
  - TDYMapWidget : widget carte
  - Données à lire : position, nœuds, adversaires, récompenses
- TODO — TdyResultViewController : résultat TDY
- TODO — TdyDuelTransitionViewController : transition vers duel
- TODO — TdyCutInViewController : cut-in (animation partenaire)
- TODO — TdyChainCutInViewController : chaîne cut-in
- TODO — TdyGetKizunaCutInViewController : cut-in lien d'amitié
- TODO — TdyCompleteKizunaCutInViewController : cut-in amitié complété

---

## 22. AUTO-DUEL

Statut global : TODO

- TODO — AutoDuelLauncherViewController : lancement auto-duel
  - Données à lire : deck sélectionné, nombre de duels, mode
  - Namespace : YgomGame.AutoDuel
- TODO — AutoDuelViewController : duel en cours (IA joue)
  - Données à lire : statut (en cours, terminé), résultat, récompenses

---

## 23. DUEL LIVE (SPECTATEUR)

Statut global : TODO

- TODO — DuelLiveViewController : interface spectateur
  - Données à lire : noms des joueurs, PV, cartes sur terrain
  - Namespace : YgomGame.DuelLive
- TODO — DuelLiveReplayDialogViewController : dialogue replay
- TODO — DuelLiveSelectCardDialogViewController : dialogue sélection carte
- TODO — DuelLiveWCSFilterDialog : filtre WCS pour spectateur

---

## 24. CERTIFICATION

Statut global : TODO

- TODO — CertificationConfirmViewController : confirmation certification
  - Namespace : YgomGame.Certification
- TODO — CertificationDetailViewController : détails
- TODO — CertificationExplanationViewController : explication
- TODO — CertificationDuelFieldDialogViewController : dialog terrain
- TODO — CertificationWritingViewController : rédaction
- TODO — CertificationWritingReslutViewController : résultat

---

## 25. CARD FILE (COLLECTION DE CARTES)

Statut global : TODO

- TODO — CardFileViewController : collection de cartes
  - Données à lire : nombre total, pourcentage de complétion, filtres
  - Namespace : YgomGame.CardFile
- TODO — CardFileTableViewController : tableau de collection (grille)
- TODO — CardFileCardGetDialog : nouvelle carte obtenue
  - Annonce : "Nouvelle carte obtenue : [nom] ([rareté])"
- TODO — CardListBrowserRegulationFilterViewController : filtre par ban list
  - Namespace : YgomGame.Regulation

---

## 26. CODES PROMO ET MARKET

Statut global : TODO

### 26.1 Codes promo
- TODO — PromoCodesViewController : saisie de code promo
  - CodeInputWidget : champ de saisie
  - BannerWidget : bannière résultat
  - Namespace : YgomGame.PromoCodes

### 26.2 Market / Échanges
- TODO — MarketPoolViewController : pool de marché
  - Namespace : YgomGame.Market

---

## 27. PRIX ET RÉCOMPENSES SPÉCIALES

Statut global : TODO

- TODO — TurnOverPrizeOpenViewController : ouverture de prix (mini-jeu retournement)
  - Données à lire : cartes retournées, récompenses obtenues
  - Namespace : YgomGame.Prize.TurnOverPrize
- TODO — TurnOverPrizeViewerViewController : visualisation du plateau
- TODO — TurnOverPrizeItemViewerViewController : visualisation d'un item
- TODO — TurnOverPrizeCollabEditViewController : édition collaboration

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
- TODO — Généraliser le pattern ISV pour tous les écrans avec listes scrollables :
  - Patch OnUpdateEntity + FocusCallback pour chaque ViewController avec ISV
  - Cibles : Missions, Notifications, Amis, Replays, Historique, etc.
  - Namespace : YgomSystem.UI.InfinityScroll (Selector, SnapContentManager)

---

## 29. SONDAGES ET AIDE

Statut global : TODO

- TODO — EnqueteViewController : sondage Konami
  - Données à lire : questions, options de réponse
  - Namespace : YgomGame.Enquete
- TODO — EnqueteCardSelectViewController : sélection de carte pour sondage
- TODO — HelpViewController : aide en jeu
  - Texte scrollable, sections
  - Namespace : YgomGame.Help
- TODO — WebHelpViewController : aide web (ouvre un navigateur intégré)
- TODO — InquiryViewController : formulaire de contact support
- TODO — CreditViewController : crédits (texte scrollable)

---

## 30. LIAISON DE DONNÉES / COMPTE

Statut global : TODO

- TODO — ConsoleDataLinkViewController : liaison données console↔PC
  - Namespace : YgomGame.ConsoleDataLink
- TODO — ConsoleDataLinkInheritViewController : héritage de données
- TODO — ConsoleDataLinkRegistViewController : enregistrement liaison

---

## 31. ÉLÉMENTS TRANSVERSAUX (non liés à un écran spécifique)

### 31.1 Localisation
- DONE — Loc.cs : fr (primaire) + en (fallback) + de — ~100+ clés
- DONE — Tous les patches utilisent Loc.Get() — aucun string TTS codé en dur
- TODO — Support japonais (ja) — langue natale du jeu
- TODO — Support espagnol (es), portugais (pt), italien (it), coréen (ko)
  - Priorité basse : ajouter quand demandé par la communauté

### 31.2 Gestion d'erreurs réseau
- DONE — SystemDialogPatch : SystemDialog erreurs réseau/maintenance — CRITIQUE couvert
- TODO — Annonce automatique si le jeu perd la connexion (sans dialog)

### 31.3 Raccourcis clavier hors duel
- DONE — F1 : aide raccourcis
- DONE — F3 : annonce l'écran courant
- DONE — F12 : historique TTS
- DONE — H : annonce gemmes + badge notifications non lues + cadeaux en attente (HeaderPatch)
- TODO — N : nombre de notifications non lues — à implémenter (NotificationPatch.CountUnread() existe déjà, raccourci à enregistrer)
- TODO — P : progression actuelle (Duel Pass / Missions / Saison) — à implémenter

---

## RÉSUMÉ STATISTIQUE

- Total ViewControllers/Dialogs dans le jeu : ~240 (hors variantes IL2Cpp et tests)
- Total Widgets pertinents : ~50
- Total Namespaces métier : ~60
- Couverts (DONE) : ~127  (+20 cette session)
  - Section 1 entière : 23 éléments (logos, titre, chargement, inscription, tutoriel)
  - Duel complet : 45+ patches (PV, phases, événements, commandes, raccourcis, démarrage)
  - Menus quotidiens : 25+ éléments (Home, Header badge, HomeMisc, Résultats, Replays…)
  - Contrôles UI : Toggle, Slider, Dropdown, InputField, EventSystem
  - Dialogs : CommonDialog 12 variantes, SystemDialog, ActionSheet, DuelDialogs, MessageDialog, EffectTaskRunDialog
- Partiellement couverts (PARTIAL) : ~12
  - ShopViewController (onglets OK, produits ISV manquant)
  - DeckBrowserViewController (ouverture OK, ISV manquant)
  - FriendViewController (ouverture OK, ISV liste amis manquant)
  - NotificationPatch (ouverture + navigation ISV OK, corps HTML non lu)
  - DuelistCupResultViewController (DP OK, classement global non lu)
  - ColosseumDuelResultViewController_Rate (résultat OK, delta rating non lu)
- À faire (TODO) : ~81  (-14 soldés en DONE, -20 comptés dans DONE ci-dessus)
- Non pertinents (SKIP) : ~22  (DuelSettingDialogViewController + CP header ajoutés)

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
20. BatchDismantleDialog — démantèlement en lot
21. AutoBuildDialog — construction auto de deck
22. SetAccessoryDialog — cosmétiques (protège-cartes, terrain, mate)
23. TrialDrawViewController — tirage d'essai
24. StructureDeckSelectViewController — decks de structure
25. CardFileViewController — collection complète de cartes
26. DuelLiveViewController — mode spectateur
27. AutoDuelViewController — auto-duel
28. NotificationPatch contenu détaillé — lecture corps HTML complet
29. ~~DuelStartViewController~~ — DONE (DuelStartPatch)
30. ~~MessageDialog / EffectTaskRunDialog~~ — DONE (DialogStatePatch)
31. ~~DuelResultViewController_Solo / DuelistCup / Colosseum~~ — DONE (DuelResultMiscPatch)
32. ~~ProfileReplayViewController / RoomReplayViewController / DuelLiveReplayDialogViewController~~ — DONE (ReplayPatch)
33. ~~HomeActionViewController / HomeAnnounceViewController / HomeSubMenuViewController / PreHomeViewController~~ — DONE (HomeMiscPatch)
34. ~~GemRestoreOnLoginViewController~~ — DONE (RegistrationPatch)

### Priorité 4 — Événements saisonniers
29. ColosseumViewController + tous écrans associés (~15 VCs)
30. TeamViewController + tous écrans associés (~12 VCs)
31. WCS ViewControllers (~8 VCs)
32. DiceRally ViewControllers (~4 VCs)
33. TDY ViewControllers (~7 VCs)
34. TurnOverPrize ViewControllers (~4 VCs)

### Priorité 5 — Confort et complétude
35. ~~Écrans Tutoriel/Première connexion~~ — DONE (TutorialPatch + RegistrationPatch)
36. CertificationViewController (~5 VCs)
37. PromoCodesViewController
38. EnqueteViewController (sondages)
39. ConsoleDataLinkViewController (liaison compte)
40. GemShopViewController (achats payants)
41. Raccourcis hors duel supplémentaires : N (notifications), P (progression Duel Pass)
