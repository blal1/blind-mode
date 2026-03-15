## Phase actuelle
Phase 2 — Développement actif du mod d'accessibilité.

## Mod
- Nom : MasterDuelAccessibility
- Framework : BepInEx 6 IL2CPP, Unity 6 (6000.0.61f1)
- Build : `dotnet build -c Release` depuis `mod/MasterDuelAccessibility/`
- DLL sortie : `bin/Release/net6.0/MasterDuelAccessibility.dll`

## Architecture
- Plugin.cs — entrée BepInEx, Config, TtsService, ShortcutRegistry, ApplyPatches()
- PluginBehaviour — MonoBehaviour IL2CPP, Update() + scèneLoaded
- KeyboardShortcuts — MonoBehaviour IL2CPP, registre raccourcis F1-F12
- TtsService.cs — wrapper Tolk (NVDA/JAWS/SAPI), historique circulaire
- ShortcutRegistry.cs — registre centralisé des raccourcis clavier
- Loc.cs — localisation fr/en/de (~90+ clés)
- GameState.cs — état partagé (CurrentMenu, CurrentTurn)
- AccessToolsHelper.cs — helpers réflexion (FindType, GetCardNameAt, etc.)
- GeneralMenuNavigator.cs — suffixe ", N sur M" dans SelectionButton

## Patches appliqués au démarrage (Plugin.ApplyPatches)

### Duel — PV et phases
- DuelHudPatch : DuelLP.ChangeLP / SetLP — annonce LP + delta
- PhasePatch : délégué via DuelEventPatch (ViewType 5/6)

### Navigation menus
- SelectionButtonPatch : SelectionButton.OnSelected / OnPointerClick / OnDeselected
- ColorContainerPatch : ColorContainerGraphic.SetColor + ColorContainerImage.SetColor
- ViewControllerPatch : ViewController.OnFocusChanged / OnBack

### Info carte
- CardInfoPatch : CardInfo.SetDescriptionArea — annonce nom + stats + desc (gated par CfgVerbose)

### Duel — événements
- DuelEventPatch : DuelClient.RunEffect (25+ ViewTypes) / Awake / OnDestroy
- DuelDialogPatch : DuelConfirmDialog.Open (6-param + 4-param)
- DuelAttackPatch : DuelClient.InvokeDecideAttackTarget — attaque déclarée

### Navigateur / Éditeur
- CardBrowserPatch : CardBrowserViewController.Start / OnPageChanged
- DeckEditPatch : StartCardAddEffect / RemoveFromDeck (2p) / OnSubmitDeckName / OnClickSaveButton / OnFocusChanged
- DeckSelectPatch : DeckSelectViewController2.OnFocusChanged

### Matchmaking / Fabrication
- MatchingPatch : PvpMenuMatchingViewController.SetActiveView
- CardCraftPatch : CardCraftDialog.Open (5-param)
- CardCraftResultPatch : CardCraftResultDialog.GetResultMessage

### Contrôles Unity (patches sur types Unity directs)
- InputBlockPatch : Input.GetKeyDown — bloque Ctrl/Esc/Space/Enter selon contexte
- EventSystemPatch : StandaloneInputModule.SendMoveEventToSelectedObject / SendSubmitEventToSelectedObject — bloque Tab Unity
- InputFieldPatch : TMP_InputField.OnSelect / OnDeselect
- TogglePatch : UnityEngine.UI.Toggle.Set
- SliderPatch : UnityEngine.UI.Slider.Set
- DropdownPatch : TMP_Dropdown.Show / set_value / Hide
- CardReportTelopPatch : bandeau stats post-effet (ex: "+500 ATK")

### Duel — divers (Plugin.ApplyPatches)
- InputDigitViewPatch : InputDigitViewController.OnCreatedView / OnValueAdded — sélecteur de nombre
- FilterSelectViewPatch : FilterSelectViewController.OpenFilterSelect — dialog filtres multi-sélection

## Patches appliqués dynamiquement (LatePatches — par scène)

### Scène Duel
- CardCommandPatch : CardCommand.Open (6-param) — menu commandes
- CommandOperationPatch : CommandOperation.SetCursor — navigation commandes
- DuelCursorPatch : RunEffectWorker.OnCursorEnter — curseur terrain
- SelectStandOperationPatch : SelectStandOperation.BeginSpSummon — placement invocation spéciale
- DuelRitualDialogPatch : DuelRitualDialog.Begin / SetCount — invocation rituelle
- DuelEffectQueuePatch : InstantMessage.ReqOpen / RunEffectWorker.infoMessage — file d'effets
- CardSelectionListPatch : CardSelectionList.SetList / SetCursor — listes de sélection de cartes
- DuelTimerPatch : alertes vocales timer 60s/30s/10s
- DialogStatePatch : DuelSelectDialog.Open — dialog de sélection
- DuelMiscPatch (dans LatePatches.cs) :
  - DuelView.OnDiceResult — résultat dé
  - DuelView.OnCoinResult — pile ou face
  - DuelMulliganDialog.Open — mulligan
  - DuelResultDialog.Open — victoire/défaite/égalité

### Scène Menu
- MenuMiscPatch (dans LatePatches.cs) :
  - ShopViewController.Open — ouverture boutique
  - SoloModeViewController.Open — ouverture Solo

## Localisation
- Loc.cs : fr (primaire) + en (fallback) + de — ~90+ clés
- Tous les patches utilisent Loc.Get() — aucun string TTS codé en dur

## Issues connues / TODO
- Tests en jeu non confirmés :
  - DeckSelectPatch → lecture nom deck avant duel
  - CardCraftPatch → annonce ouverture création/démantèlement
  - CardCraftResultPatch → lecture résultat post-fabrication
  - Double-annonce potentielle : DeckSelectViewController2 vs ViewControllerPatch
  - CommonDialogPatch → vérifier que toutes les variantes Open*Dialog s'annoncent
  - DuelInfoDialogPatch → vérifier que les messages informatifs s'annoncent en duel
  - duel_flip_facedown / duel_negate / duel_equip → vérifier déclenchement ViewTypes 28/36/37
- CardBrowser : chemin "Template(Clone){0}" peut varier — à vérifier en jeu
- DeckSelectPatch : lastSet privé — si inaccessible, fallback index 0
- CardCraftPatch : injection positionnelle Harmony (__1=CraftMode, __2=cardID) à vérifier

## Ressources de référence
- Dump complet : `dump/dump.cs`
- Interop (source pour patches) : `BepInEx/interop/Assembly-CSharp.dll`
- DevTools décompilé : `DevTools/Decompiled/`

## Travaux récents (session 2026-03-08)
Checklist menu-accessibility-checklist.md passée sur tous les écrans.

### Fix 1 — ChoiceFirstPlayerDialog + DuelOkDialog (LatePatches.cs + DuelMiscPatch)
- ChoiceFirstPlayerDialog.ReqOpen → annonce "Tu joues en premier" / "L'adversaire joue en premier"
- DuelOkDialog.Open (3 params) → annonce le message localisé du jeu
- Helper TryPatchByParamCount ajouté à LatePatches

### Fix 2 — ScreenTitles complétés (ViewControllerPatch.cs)
Noms de vues secondaires ajoutés (certains à vérifier en jeu) :
- "ShopBuy" → "Boutique — Achat" (confirmé depuis prefab)
- "SortDialog_Card/CardFile/Solo" → libellés tri (confirmés depuis prefabs)
- "FilterSelect" → "Filtres" (confirmé depuis prefab)
- "SoloGate", "SoloSelectChapter", "PasswordDialog" → à vérifier en jeu

### Fix 3 — DeckSelect mode (DeckSelectPatch.cs)
- Lit m_SelectMode via réflexion
- Annonce maintenant : "{mode} — Deck sélectionné : {nom}"
- 17 modes couverts (Ranked, Solo, PVE, Room, Tournament, Free, Cup, WCS, etc.)
- Loc : deck_select_focus_mode + deck_mode_* ajoutés

### Fix 4 — CardCommandEx + DuelPullDownDialog (LatePatches.cs)
- CardCommandExPatch : CardCommandEx.Open(int, int, Vector3) → annonce "Position pour {carte} : Attaque face visible, ..."
  - Lit les boutons actifs via réflexion sur `buttons[]` / `root.gameObject.activeInHierarchy`
  - Positions : FrontAtk=0, FrontDef=1, BackDef=2
- DuelPullDownDialogPatch : DuelPullDownDialog.Open (5 params) → annonce message + nb à sélectionner + liste d'options
  - Lit selectionList via IEnumerable (strings déjà localisés par le jeu)
- Loc : pos_front_atk/def, pos_back_def, card_command_ex, pulldown_open ajoutés

## Travaux récents (session 2026-03-08 suite)

### Fix 5 — CommonDialogPatch (Patches/CommonDialogPatch.cs)
- Nouveau patch : YgomGame.Menu.CommonDialogViewController
- 12 variantes Open*Dialog patchées : OpenAlertDialog, OpenConfirmationDialog, OpenErrorDialog,
  OpenYesNoConfirmationDialog, OpenNoticeYesNoDialog, OpenCheckBoxDialog, etc.
- Toutes partagent (string title, string message, ...) → un seul postfix
- Loc : dialog_title_message ajouté (fr/en/de)

### Fix 6 — DuelInfoDialogPatch (LatePatches.cs)
- DuelInfoDialog.ReqOpen(string message, ...) → annonce __0 (message du jeu)
- Appliqué via TryPatchPostfix dans ApplyDuelScenePatches()

### Fix 7 — DuelEventPatch ViewTypes manquants
- ViewType 28 (CardFlipTurn) → "Carte retournée face cachée."
- ViewType 36 (CardDisable) → "Effet nié."
- ViewType 37 (CardEquip) → "Sort d'équipement activé."
- Loc : duel_flip_facedown / duel_negate / duel_equip (fr/en/de)

### Fix 8 — Revue complète des menus (ViewControllerPatch + Loc)
- ScreenTitles étendu : +24 nouvelles entrées (Lottery, Profile, Friend, Season, Colosseum, etc.)
- ResolveName amélioré : nettoyage PascalCase automatique pour tous les VC inconnus
  - "LotteryPortalViewController" → "Lottery Portal" (fallback lisible sans entrée dict)
  - Pattern: supprime suffixe ViewController/Dialog/Widget, espace devant majuscules
- Loc : ~25 clés screen_* ajoutées (fr/en/de)
- docs/SCREEN_REFERENCE.md mis à jour :
  - Table ScreenTitles complète (50 entrées)
  - Table ViewTypes corrigée (les IDs 3/4/7/8/9/30/31/33/35/40-50 étaient tous faux)
  - Section CommonDialogPatch ajoutée
  - Section DuelInfoDialogPatch ajoutée dans table Dialogs
  - Guide "Adding Support" mis à jour avec pattern ScreenTitles

## Travaux récents (session 2026-03-08 suite 2)

### Fix 9 — Raccourcis lettrés (modèle MTGA)
- InputFieldPatch : `IsActive` exposé (public static bool) — utilisé par InputBlockPatch
- ViewControllerPatch : `LastRawView` + `GetResolvedName()` exposés (internal static)
- InputBlockPatch : bloque C/G/X/M/T/L/D/E/I en duel (hors champ de saisie)
- KeyboardShortcuts : 17 nouveaux raccourcis lettrés, tous avec ActiveCondition=IsInDuel :
  - C / Maj+C : main joueur / nombre main adverse
  - G / Maj+G : cimetière / cimetière adverse
  - X / Maj+X : cartes bannies / bannies adversaires
  - M / Maj+M : terrain joueur / terrain adverse
  - E / Maj+E : Extra Deck / taille Extra Deck adverse
  - T : état duel complet (tour + phase + PV)
  - L : points de vie uniquement
  - D : taille des decks
  - I : infos carte (alias Alt)
- F3 hors duel : annonce l'écran courant (modèle MTGA F3 = "announce current screen")
- Loc : +18 clés (shortcut_c, shortcut_g, shortcut_x, shortcut_m, shortcut_e, shortcut_t,
  shortcut_l, shortcut_d, shortcut_i, shortcut_f3_menu, screen_current, screen_unknown +
  variantes Maj + allemand)

## Travaux récents (session 2026-03-08 suite 3)

### Fix 10 — S = relire l'instruction courante
- DuelEffectQueuePatch : `LastInfoMsg` + `LastInstantMsg` exposés (internal static)
- Loc : shortcut_s + duel_no_instruction (fr/en/de)
- InputBlockPatch : S bloqué en duel
- KeyboardShortcuts : ReadCurrentInstruction() — lit infoMessage en priorité, puis lastInstantMsg

### Fix 11 — Tab contextuel : cycle dans CardSelectionList (modèle MTGA Tab = cycle targets)
- CardSelectionListPatch : stocke `_activeInstance` + cache `_setCursorMethod`
- `ForceNextAnnounce` flag pour contourner la déduplication lors d'un déplacement programmatique
- `TryMoveNext()` : avance le curseur de 1 dans la liste active (wrap-around)
- KeyboardShortcuts.Update() : Tab → TryMoveNext() en priorité, sinon HandlePhaseAdvance()

## Travaux récents (session 2026-03-08 suite 4)

### Fix 12 — LotteryRewardPatch (Patches/LotteryRewardPatch.cs)
- Nouveau patch : YgomGame.Lottery.LotteryRewardViewContorller
- Cible : OnCreatedView() (protected override, NonPublic Instance)
- Postfix lit m_RewardItemList → EntryItemListData.contexts → itemId
- Résolution nom : Content.Instance.GetName(itemId) pour les cartes
- Fallback : libellé générique pour les objets non-carte (gemmes, CP…)
- Annonce : "Pack ouvert : Carte A, Carte B, ..." à l'ouverture de l'écran résumé
- Appliqué dans LatePatches.ApplyMenuScenePatches()
- Loc : lottery_reward_open + lottery_item_generic (fr/en/de)
- NOTE : LotteryResultViewController (animation drag-to-reveal) non patchée pour l'instant
  — card IDs dans des closures lambda complexes ; la solution OnCreatedView donne le résumé

### Fix 13 — LotteryRewardPatch : mapping bouton → carte (SetCardButtonAction)
- Patch SelectedCardsWidget.SetCardButtonAction (private, NonPublic Instance)
- Postfix stocke button.GetInstanceID() → mrk (cardId) dans _buttonCardMap
- SelectionButtonPatch.OnSelected_Postfix consulte le mapping : si trouvé → annonce le nom de carte
- Couvre la navigation clavier dans l'écran de révélation de packs

### Fix 14 — Résultats pièce/dé détaillés (DuelEventPatch)
- RunEffect_Postfix étendu avec __2 (param2) pour décoder les résultats
- RunCoin (61) : annonce "Pile !" ou "Face !" (1 pièce) ou "X pile(s), Y face(s)" (multi)
  - Hypothèse : param1 = numThrows, param2 = faceBits (bitmask, bit i = 1 → Front)
  - Log diagnostic : [DuelEventPatch] RunCoin p1=X p2=Y — à vérifier en jeu
- RunDice (62) : annonce "Dé : X !" avec la valeur
  - Hypothèse : param2 = valeur du dé (1-6), sinon param1
  - Log diagnostic similaire
- Loc : duel_coin_front / duel_coin_back / duel_coin_multi / duel_dice_result (fr/en/de)
- Fallback : si valeurs hors limites → annonce générique comme avant

### Fix 15 — Contexte activation/invocation (DuelEventPatch)
- CutinActivate (72) : annonce maintenant d'où vient l'activation
  - FromField=1 → "Effet activé depuis le terrain !"
  - FromHand=2 → "Effet activé depuis la main !"
  - FldGrave=5 → "Effet activé depuis le cimetière !"
  - Autres → fallback générique "Effet activé !"
  - Hypothèse : param1 = Engine.CutinActivateType — log pour vérification
- CutinSummon (69) : distinction Reverse(4) → "Invocation retournement" et SpByEffect(5) → "Invocation spéciale"
  - Hypothèse : param1 = Engine.CutinSummonType — log pour vérification
- Loc : duel_activate_field / duel_activate_hand / duel_activate_grave (fr/en/de)

### Fix 16 — Scripts Build-Mod.ps1 et Deploy-Mod.ps1
- scripts/Build-Mod.ps1 : wrapper dotnet build avec support -Debug
- scripts/Deploy-Mod.ps1 : copie DLL vers BepInEx/plugins, support -Build

## Notes pour la prochaine session
- Tester les nouveaux raccourcis lettrés (C/G/X/M/T/L/D/E/I) en duel — vérifier qu'aucun conflit avec le jeu
- Vérifier F3 en menu = annonce l'écran courant (ViewControllerPatch.LastRawView doit être peuplé)
- Tester S = relire l'instruction (infoMessage = instruction de bas d'écran, ex : "Choisissez une cible")
- Tester Tab en CardSelectionList = cycle les cartes de la liste (ex : lors d'une activation de chaîne)
- Tester LotteryRewardPatch :
  - Ouvrir un pack → vérifier que les cartes obtenues sont annoncées au chargement de l'écran résumé
  - Si m_RewardItemList est vide au moment de OnCreatedView : chercher hook alternatif (SetRewardData ou ISV callback)
  - Vérifier si les cartes non-cartes (gemmes…) produisent le libellé générique attendu
- Tester en jeu :
  - CommonDialogPatch → confirmation achat, suppression, erreurs réseau
  - DuelInfoDialogPatch → messages informatifs pendant effets de cartes
  - ViewTypes 28/36/37 → retournement, annulation, équipement
  - CardCommandEx → annonce position quand monstre posé/invoqué
  - DuelPullDownDialog → annonce liste de sélection
  - ChoiceFirstPlayerDialog → annonce premier joueur
  - DuelOkDialog → annonce message
  - DeckSelect → annonce mode (Ranked, Solo, etc.)
  - Vues secondaires : noter noms bruts pour SoloGate, SoloSelectChapter, PasswordDialog dans logs BepInEx
  - Nouvelles ScreenTitles : noter si noms LotteryPortal, PresentBox, Friend, Profile, SeasonPoint correspondent aux GO names
- Tester Fix 13 — LotteryRewardPatch mapping bouton :
  - Naviguer dans les cartes révélées après ouverture de pack → nom de carte annoncé ?
- Tester Fix 14 — Résultats pièce/dé :
  - Lancer une carte avec effet de pièce (ex: Second Coin Toss) → vérifier "Pile !" ou "Face !"
  - Si résultat incorrect, vérifier les logs : [DuelEventPatch] RunCoin p1=X p2=Y
  - Même chose pour les dés
- Tester Fix 15 — Contexte activation :
  - Activer un effet depuis le terrain → "Effet activé depuis le terrain !"
  - Activer un effet depuis la main → "Effet activé depuis la main !"
  - Si contexte incorrect, vérifier logs : [DuelEventPatch] CutinActivate type=X
### Fix 17 — LotteryReward ISV keyboard navigation
- Patch OnUpdateEntity(GameObject, int) : capture dataIndex → item name depuis m_RewardItemList
- Patch compiler-generated focus callback b__34_1(int idx, int preIdx) :
  annonce l'item focalisé quand l'utilisateur navigue au clavier dans l'InfinityScrollView
- _dataIndexNames dict : cleared à chaque OnCreatedView, populated par OnUpdateEntity
- Annonce format : "NomCarte, N sur M" (lottery_reward_item)
- Loc : lottery_reward_item (fr/en/de)
- NOTE : si b__34_1 introuvable en runtime (nom compiler-generated peut varier),
  fallback possible via SelectionItem.OnSelected (base RVA != SelectionButton RVA)

## Travaux récents (session 2026-03-10)

### Fix 18 — AccessViolationException crash (ViewControllerPatch.cs)
- SafeGetName() réécrit : utilise GetType().Name (pur .NET) au lieu de .name (natif IL2CPP)
- RÉSOLU : plus de crash au démarrage

### Fix 19 — BindingFlags IL2CPP (6 patches)
- IL2CPP interop rend TOUTES les méthodes publiques → BindingFlags.NonPublic seul ne trouve rien
- Corrigé : LotteryRewardPatch, ShopBuyPatch, NotificationPatch

### Fix 20 — Nouveaux raccourcis duel (inspirés Hearthstone Access)
- InputBlockPatch : bloque O, P, F, S, 0-9, Shift+0-9 en duel
- KeyboardShortcuts : nouveaux raccourcis duel :
  - O : aperçu adversaire (LP, main, deck, cimetière)
  - P : phase courante uniquement
  - F : carte dans la zone sort/magie de terrain (position 12)
  - 1-5 : Nième carte en main joueur
  - Shift+1-5 : zones monstres adverses (positions 0-4)
  - 6-9 / Shift+6-9 : zones sorts-pièges joueur/adversaire (positions 7-10)
  - 0 / Shift+0 : zone sort-magie de terrain joueur/adversaire
  - H (hors duel) : infos gemmes du header
- Loc : ~25 nouvelles clés pour ces raccourcis

### Fix 21 — SystemDialogPatch (Patches/SystemDialogPatch.cs)
- YgomSystem.UI.SystemDialog.OpenFatalErrorDialog / OpenMaintenanceDialog / OpenSystemDialogCore
- Annonce erreurs réseau, maintenance — CRITIQUE couvert

### Fix 22 — DuelResultPatch (Patches/DuelResultPatch.cs)
- DuelResultViewController.OnCreatedView → résumé résultat + mode de jeu + boutons disponibles
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 23 — PresentBoxPatch (Patches/PresentBoxPatch.cs)
- PresentBoxViewController.OnCreatedView → "X cadeaux dans la boîte"
- OnItemSetData → item focalisé dans ISV (carte / gemmes / cosmétiques)

### Fix 24 — HeaderPatch (Patches/HeaderPatch.cs)
- Lit gemmes depuis HeaderViewController.gemText/gemButtonText via reflection singleton
- Raccourci H hors duel → annonce solde de gemmes

### Analyse dump (docs/FULL_COVERAGE_PLAN.md)
- Plan mis à jour avec données dump précises pour :
  - LotteryPortalViewController, SoloGateViewController, SoloSelectChapterViewController
  - SeasonPointViewController, DuelPassViewController, MissionViewController
- Sections 17.2 (SystemDialog), 31.3 (H shortcut) marquées DONE
- Statistiques : ~72 DONE (+7), ~23 PARTIAL, ~125 TODO

### Fix 25 — LoginBonusPatch (Patches/LoginBonusPatch.cs)
- LoginBonusViewController.OnCreatedView → "Bonus de connexion. Jour N sur M. [label], ×Q, Disponible/Déjà réclamé"
- Lit m_MapWidget (LoginBonusMapWidet) → progress (int) + slotWidgets (LoginBonusSlotWidget[])
- LoginBonusSlotWidget : labelText (TMP_Text), rewardNum (TMP_Text), recievedCover (GameObject)
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 26 — LotteryPortalPatch (Patches/LotteryPortalPatch.cs)
- LotteryPortalViewController.NotificationStackEntry → "Portail de packs — [nom du pack]"
- Lit m_Id (int 0xE8) → tente YgomGame.Lottery.LotteryData.GetName(int) — fallback titre générique
- Applied via LatePatches.ApplyMenuScenePatches()
- NOTE : LotteryData.GetName à vérifier en runtime — si absent, fallback "Portail de packs"

### Inspirations MTGA AccessibleArena PanelDetection (session 2026-03-10)
- Étudié : PanelStateManager + HarmonyPanelDetector + ReflectionPanelDetector + AlphaPanelDetector
- Notre architecture est déjà équivalente (PanelStateManager + MenuPanelStatePatch)
- Patterns clés identifiés pour futures améliorations :
  - FiltersNavigation : scoper la navigation au panneau actif (dialogs, modales)
  - AlphaDetector : polling CanvasGroup.alpha pour panneaux sans Harmony hooks
  - OwnedPatterns : éviter les doubles détections entre détecteurs

## Travaux récents (session 2026-03-11)

### Fix 27 — DuelPassViewControllerPatch (Patches/DuelPassViewControllerPatch.cs)
- YgomGame.Duelpass.DuelPassViewController.NotificationStackEntry
- Lit progressBar (DuelpassProgressBarWidget private) → currentGradeText + nextGradeText (TMP_Text)
- Annonce : "Duel Pass. Palier actuel : X. Prochain palier : Y."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 28 — SoloGatePatch (Patches/SoloGatePatch.cs)
- SoloGateViewController.NotificationStackEntry
- Lit mainDataList.Count pour annoncer le nombre de portails
- Annonce : "Portails Solo — N portail(s)."
- Navigation individuelle laissée à SelectionButtonPatch.ProcessDuelMenu
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 29 — SoloChapterPatch (Patches/SoloChapterPatch.cs)
- SoloSelectChapterViewController.ChapterMap.OnClickChapter(SelectionButton, Chapter)
- Accès via GetNestedType("ChapterMap") + FindMethod par nombre de paramètres
- Lit strChapter + IsCleared/IsCompleted + status enum (-1=UNOPEN)
- Annonce : "Chapitre : [nom]. [statut]."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 30 — MissionViewControllerPatch (Patches/MissionViewControllerPatch.cs)
- YgomGame.Mission.MissionViewController.NotificationStackEntry + TabInitialEntry(bool)
- Lit m_ContentType (MissionContentType : Mission=0, PanelMission=1)
- Annonce : "Missions — [Missions/Panel Missions]."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 31 — DuelpassResultViewPatch (Patches/DuelpassResultViewPatch.cs)
- YgomGame.Duelpass.DuelpassResultViewController.OnGradeUp(int) + OnEndProgressBarAnimation()
- OnGradeUp → "Palier supérieur ! Palier X." (interrupt:true)
- OnEndAnimation → "Duel Pass. Palier actuel : X. Prochain palier : Y."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 32 — EventNotifyPatch (Patches/EventNotifyPatch.cs)
- EventNotifyViewController.Open(string[] messages, Action callback) — static
- Joint toutes les lignes non vides avec ". "
- Applied via Plugin.ApplyPatches()

### Fix 33 — ActionSheetPatch (Patches/ActionSheetPatch.cs)
- YgomGame.ActionSheet.ActionSheetViewController.NotificationStackEntry
- Lit m_DisplayEntryButtonDatas (List<EntryData>) → filtre interactable=true → liste options
- Lit titre via get_arg1() en parcourant la hiérarchie de base
- Annonce : "[Titre]. Options : A, B, C." ou "Menu contextuel. Options : A, B, C."
- Applied via Plugin.ApplyPatches()

### Loc.cs ajouts (session 2026-03-11)
Nouvelles clés fr/en/de :
- duelpass_grade_up, duelpass_grade_info, duelpass_grade_current
- solo_gate_open, solo_gate_open_count, solo_gate_item
- solo_gate_complete, solo_gate_clear, solo_gate_unlocked, solo_gate_locked, solo_gate_unknown
- solo_chapter_item, solo_chapter_unknown
- mission_screen_with_tab, mission_tab_selected, mission_tab_mission, mission_tab_panel
- action_sheet_open, action_sheet_with_title, action_sheet_options

## Notes pour la prochaine session
- Tests en jeu à valider :
  1. DuelPassViewControllerPatch — ouvrir Duel Pass → "Duel Pass. Palier actuel : X. Prochain palier : Y."
  2. SoloGatePatch — entrer Solo → "Portails Solo — N portail(s)."
  3. SoloChapterPatch — cliquer un chapitre → "Chapitre : [nom]. [statut]."
  4. MissionViewControllerPatch — ouvrir Missions → "Missions — [onglet actif]."
  5. DuelpassResultViewPatch — monter de palier → "Palier supérieur ! Palier X."
  6. EventNotifyPatch — popup d'événement → messages annoncés
  7. ActionSheetPatch — menu contextuel → "[Titre]. Options : A, B, C."
  8. Tous les tests précédents (LoginBonusPatch, LotteryPortalPatch, DuelResultPatch, etc.)
### Fix 34 — DeckBrowserPatch (Patches/DeckBrowserPatch.cs)
- YgomGame.DeckBrowser.DeckBrowserViewController.NotificationStackEntry
- Lit m_DeckName (string) + m_NumMainCards (int) + m_NumExtraCards (int)
- Lit m_BrowserType (enum) → label selon type (Solo, NPC, Structure, Public, Neuron)
- Annonce : "[Nom]. Deck principal : N cartes. Extra Deck : M cartes."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 35 — SeasonPointPatch (Patches/SeasonPointPatch.cs)
- YgomGame.SeasonPoint.SeasonPointViewController.NotificationStackEntry
- Lit myGroup (ElementObjectManager) → traverse TMP_Text children → rang/points
- Annonce : "Points de saison. [texte rang]." ou "Points de saison."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 36 — ProfilePatch (Patches/ProfilePatch.cs)
- YgomGame.Menu.ProfileViewController.NotificationStackEntry
- Lit profileCard (ProfileCard) → m_ProfileDic (Dictionary<string,object>) → "name" + "level"
- Annonce : "Profil de [nom]. Niveau [niveau]." / "Profil de [nom]." / "Profil."
- Applied via LatePatches.ApplyMenuScenePatches()

### Loc.cs ajouts (session 2026-03-11 suite)
- deck_browser_open, deck_browser_title, deck_browser_type_* (5 types)
- season_point_open, season_point_open_rank
- profile_open, profile_open_name, profile_open_name_level
(fr/en/de pour toutes)

### Fix 37 — ScenarioPatch (Patches/ScenarioPatch.cs)
- YgomGame.Scenario.ScenarioViewController.NotificationStackEntry
- Lit m_ScenarioName (string 0xD8)
- Annonce : "Scénario : [nom]." ou "Scénario Solo."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 38 — FriendViewControllerPatch (Patches/FriendViewControllerPatch.cs)
- YgomGame.Friend.FriendViewController.NotificationStackEntry
- Lit m_FollowNumText (TMP_Text 0x1E8) → texte du compteur de suivis
- Annonce : "Amis — N suivi(s)." ou "Amis."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 39 — RoomViewControllerPatch (Patches/RoomViewControllerPatch.cs)
- YgomGame.Room.RoomViewController.NotificationStackEntry
- Lit roomBehaviour.roomInfo.roomName + memberNum/memberMax
- Annonce : "Salon : [nom]. N sur M joueur(s)." ou "Salon."
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 40 — SearchBoxDialogPatch (Patches/SearchBoxDialogPatch.cs)
- YgomGame.Deck.SearchBoxDialog.NotificationStackEntry (+ fallback Open static)
- Lit m_InputFieldText.text pour le mot-clé éventuel
- Annonce : "Recherche de carte. Saisir le nom." ou "Recherche de carte : [mot-clé]."
- Applied via Plugin.ApplyPatches()

### Loc.cs ajouts (session 2026-03-11 suite 2)
- scenario_open, scenario_open_name
- friend_open, friend_open_count
- room_open, room_open_name, room_open_name_members
- search_box_open, search_box_open_keyword
(fr/en/de pour toutes)

### Fix 41 — ShopViewControllerPatch (Patches/ShopViewControllerPatch.cs)
- YgomGame.Shop.ShopViewController.NotificationStackEntry + OnClickMainTab
- Lit m_ShowcaseData.currentCategoryId → GetCategoryData(id).labelText
- Annonce : "Boutique — [catégorie]." à l'ouverture et lors des changements d'onglet
- Applied via LatePatches.ApplyMenuScenePatches()

### Fix 42 — DownloadViewControllerPatch (Patches/DownloadViewControllerPatch.cs)
- YgomGame.Menu.DownloadViewController.NotificationStackEntry + OnCreatedView
- Lit DownloadingText (TMP) + DownloadingStateText (TMP) + isDownloading (bool)
- Annonce : "Téléchargement. [texte]. [état]." (avec fallbacks progressifs)
- Applied via LatePatches.ApplyMenuScenePatches()

### Loc.cs ajouts (session 2026-03-11 suite 3)
- shop_vc_open, shop_open_category, shop_tab_selected
- download_open, download_in_progress, download_open_text, download_open_state
(fr/en/de pour toutes)

### Fix 43 — TitleScreenPatch étendu (section 1 FULL_COVERAGE_PLAN.md)
- PatchLogoViewControllers : KonamiLogo / UnityLogo / OnDemandLogo / PreTitleSequnece
  - Annonces : "Logo Konami. Appuyez sur Entrée pour continuer.", "Logo Unity.", "Chargement des ressources.", "Cinématique de présentation."
- PatchTitleExtras : TitleDemoViewController / TitleSettingMenuViewController / TitleDataLinkDialogViewController
  - TitleDemo : lit m_scenarioName → "Cinématique de démo : [nom]." ou générique
  - TitleSettingMenu (YgomGame.SubMenu) : "Paramètres. Utilisez les flèches pour naviguer."
  - TitleDataLink : lit MainText (ExtendedTMP 0x110) → "Liaison de compte. [texte]." ou générique
- PatchLoadingViewController : LoadingViewController.NotificationStackEntry avec cooldown 3s
  - Annonce : "Chargement en cours." (max 1× par 3s)
- Section 1.1 / 1.2 / 1.3 de FULL_COVERAGE_PLAN.md marquées DONE
- Build : 0 warning, 0 error

### Loc.cs ajouts (Fix 43)
- logo_konami, logo_unity, logo_on_demand, logo_pre_title
- title_demo, title_demo_named, title_settings, title_data_link, title_data_link_text
- loading_screen
(fr/en pour toutes)

## Priorité 2 — COMPLÈTE (18 éléments sur 18)
Tous les écrans "jeu quotidien complet" sont couverts.

## Section 1 FULL_COVERAGE_PLAN.md — ENTIÈREMENT COMPLÈTE (1.1 → 1.5)
Logos, titre, chargement, téléchargement, inscription, tutoriel — tout couvert.

### Fix 44 — RegistrationPatch (Patches/RegistrationPatch.cs)
Couvre 10 écrans d'inscription / première connexion (section 1.4) :
- GameEntrySequenceViewController + V2 → "Création de compte."
- GameEntryApprovalViewController → "Approbation requise."
- AgeGateViewController (YgomGame.Menu.AgeGate) → "Vérification d'âge."
- AgeSelectViewController → lit m_ageCurrent/Min/Max → "Âge actuel : N. (de X à Y)"
- BirthdateSelectViewController → "Date de naissance."
- CountrySelectViewController (YgomGame.Menu.CountrySelect) → lit m_currentNameText → "Pays : [nom]."
- USAStateSelectViewController (YgomGame.Menu.USAStateSelect) → lit m_currentNameText → "État : [nom]."
- FirstLanguageSelectViewController → "Sélection de langue."
- TermOfServiceViewController (YgomGame.Menu.TermOfService) → "Conditions d'utilisation."
- PrivacyPolicyViewController → "Politique de confidentialité."
Applied via Plugin.ApplyPatches().
Loc : 13 nouvelles clés reg_* (fr/en). Build : 0 warning, 0 error.

### Fix 45 — TutorialPatch (Patches/TutorialPatch.cs)
Couvre les écrans de tutoriel (section 1.5) :
- InitialSettingsViewController (YgomGame.Tutorial) → NotificationStackEntry()
  → "Configuration initiale. Saisissez votre nom de duel."
- CardFlyingViewController (YgomGame.Tutorial) → static Start(IList<string> msgList, UnityAction)
  → Lit les messages via IEnumerable → "Tutoriel. [messages]." ou générique
  → Meilleur hook que NotificationStackEntry car les textes sont disponibles dans msgList
- ScenarioViewController — déjà couvert par ScenarioPatch (existant)
Applied via Plugin.ApplyPatches().
Loc : tuto_initial_settings, tuto_card_flying, tuto_card_flying_messages (fr/en).
Section 1.5 COMPLÈTE. Section 1 entièrement couverte (1.1→1.5).
Build : 0 warning, 0 error.

## Section 1 FULL_COVERAGE_PLAN.md — ENTIÈREMENT COMPLÈTE (1.1 → 1.5)
Logos, titre, chargement, téléchargement, inscription, tutoriel — tout couvert.

## Travaux récents (session 2026-03-14)

### Fix 46 — HeaderPatch : badge notifications + cadeaux (Patches/HeaderPatch.cs)
- Ajout lecture du badge de btnNotice → nombre de notifications non lues
- Ajout lecture du badge de btnPresent → nombre de cadeaux en attente
- Pattern : walk des enfants du bouton → cherche TMP_Text actif avec contenu numérique
- Annonce H hors duel : "{N} gemmes. {M} notification(s) non lue(s). {K} cadeau(x) en attente."
- NOTE : CP (craft points) CONFIRMÉ absent du header (seul dans CardBrowserViewController.CardDetailWidget)
- Loc : header_unread_notif, header_presents (fr/en)
- Build : 0 warning, 0 error

### Fix 47 — NotificationPatch : navigation ISV complète (Patches/NotificationPatch.cs)
- UpdateEntity_Postfix : stocke maintenant head/category/date/isRead dans _itemData (Dictionary<int,NotifItem>)
- PatchIsvFocusCallback : cherche la méthode b__**(int,int) dans NotificationViewController → postfix IsvFocus_Postfix
  - Annonce : "[Titre]. [Catégorie]. [Date]." + "(non lue)" si non lue
  - 200ms dedup + dédup par index pour éviter les doubles
- CountUnread() exposé comme internal static → utilisé par HeaderPatch (badge H)
- GetItemTitle(int) exposé pour SelectionButtonPatch si besoin
- _activeInstance réinitialisé à l'ouverture, _itemData réinitialisé à chaque ouverture et changement d'onglet
- Loc : notif_unread_marker, notif_item (fr/en)
- Build : 0 warning, 0 error

## Section 2.2 (HeaderFooter) — COMPLÈTE
- Gemmes ✓ (fix 24)
- Badge notifications non lues ✓ (fix 46)
- Badge cadeaux en attente ✓ (fix 46)
- CP : SKIP — non disponible dans le header

## NotificationPatch — COMPLÈTE
- Ouverture panneau + comptage non lues ✓
- Changement d'onglet ✓
- Navigation ISV avec annonce titre/catégorie/date/statut ✓

### Fix 48 — GemRestoreOnLoginViewController (RegistrationPatch.cs)
- Écran rare : restauration de gemmes lors de la connexion (après achat annulé ou erreur)
- Namespace global — patché via PatchStackEntry standard dans RegistrationPatch.Apply()
- NotificationStackEntry → "Restauration de gemmes en cours." (interrupt:true)
- Pas de champs TMP_Text accessibles — annonce générique suffisante
- Loc : gem_restore_login (fr/en)
- FULL_COVERAGE_PLAN section 2.3 TODO GemRestoreOnLogin → DONE
- Build : 0 warning, 0 error

## Section 2.3 (Bonus quotidiennes) — COMPLÈTE
- LoginBonusPatch ✓ (fix 25)
- GemRestoreOnLoginViewController ✓ (fix 48)
- PresentBoxPatch ✓ (fix 23)

### Fix 49 — HomeMiscPatch (HomeMiscPatch.cs) — sections 2.4 / 2.5
- HomeAnnounceViewController.NotificationStackEntry → "Annonce en cours." (interrupt:false)
- HomeActionViewController.OnCreatedView → "Actions disponibles : N." via actionList IEnumerable count
- HomeSubMenuViewController.NotificationStackEntry → "Sous-menu. Utilisez les flèches pour naviguer."
- PreHomeViewController.NotificationStackEntry → "Chargement de l'accueil." (3s cooldown)
- Loc : home_announce, home_action, home_action_n, home_submenu, home_loading (fr/en)
- Enregistré dans LatePatches.ApplyMenuScenePatches()
- Build : 0 warning, 0 error

## Section 2.4 (Événements et bannières) — COMPLÈTE
- HomeAnnounceViewController ✓ (fix 49)
- HomeActionViewController ✓ (fix 49)

## Section 2.5 (Sous-menus) — COMPLÈTE
- HomeSubMenuViewController ✓ (fix 49)
- PreHomeViewController ✓ (fix 49)

### Fix 50 — DuelStartPatch (DuelStartPatch.cs) — section 3.2
- DuelStartViewController.NotificationStackEntry → "Duel commençant." (interrupt:true)
- DuelStartViewController_Team.NotificationStackEntry → "Duel commençant." (patched separately)
- DuelStartOverlayViewController_Team.NotificationStackEntry → "Duel d'équipe commençant."
- Loc : duel_start, duel_start_team (fr/en)
- Enregistré dans LatePatches.ApplyDuelScenePatches()

### Fix 51 — DialogStatePatch additions (section 4.3)
- MessageDialog.SetMessage(string msg) → announce msg (interrupt:true); Open() has no params so PatchOpenWithMessage was a no-op
- EffectTaskRunDialog.RunDialog() (private) → read `text` field via reflection; dedup per text value; fallback to "Résolution en cours."
- Loc : effect_task_dialog (fr/en)

### Fix 52 — DuelResultPatch enhancement (section 5.2)
- ReadScoreReward: now reads m_TotalScore (int 0x58, dump-confirmed); fallback TMP_Text walk
- DuelResultPatch still targets YgomGame.Menu.DuelResultViewController

### Fix 53 — DuelResultMiscPatch (DuelResultMiscPatch.cs) — section 5.2
- DuelResultViewController_Solo.NotificationStackEntry → "Résultat solo."
- DuelistCupResultViewController.NotificationStackEntry → "Duelist Cup. [win/lose/draw]. DP avant : X, après : Y (delta)."
- ColosseumDuelResultViewController_Rate.NotificationStackEntry → "Résultat Colosseum. [win/lose/draw]."
- Loc : result_solo, result_duelist_cup, result_colosseum, duel_result_unknown (fr/en)

### Fix 54 — ReplayPatch (ReplayPatch.cs) — section 5.3
- ProfileReplayViewController.NotificationStackEntry → "Replays. N replay(s)." (reads replayInfos count)
- RoomReplayViewController.NotificationStackEntry → "Replays du salon. N replay(s)." (reads dataList count)
- DuelLiveReplayDialogViewController.NotificationStackEntry → "Replay en direct. Choisissez un deck."
- Loc : replay_profile, replay_profile_empty, replay_room, replay_room_empty, replay_live (fr/en)
- Build : 0 warning, 0 error

## Notes pour la prochaine session
- Tester Fix 46 : presser H hors duel → vérifier "X gemmes, Y notification(s) non lue(s)"
- Tester Fix 47 : ouvrir panneau Notifications, naviguer avec les flèches → vérifier titres annoncés
  - Si ISV focus callback introuvable (log [NotificationPatch] ISV focus callback introuvable) → fallback déjà en place via SelectionButtonPatch.ReadNotificationText
- Tester Fix 49 : naviguer vers Home → vérifier "Chargement de l'accueil." / annonces HomeAction/SubMenu
- Tester Fix 50 : lancer un duel → vérifier "Duel commençant." à l'animation de démarrage
- Tester Fix 51 : résolution d'effet en duel → vérifier annonce message EffectTaskRunDialog
- Tester Fix 53 : jouer en Duelist Cup → vérifier annonce DP avant/après


## Travaux récents (session 2026-03-15)

### Fix 55 — FindSiblingText (SelectionButtonPatch.cs)
- Fallback ajouté AVANT ProcessContext : si ReadText retourne vide ou ≤2 chars, cherche un TMP_Text sibling
- Walk jusqu'à 3 niveaux parents, itère les frères, retourne le premier texte >2 chars
- Comparaison IL2CPP-safe via GetInstanceID() (pas de ReferenceEquals)
- Couvre les boutons toggle/radio où le label est un GO frère, pas enfant

### Fix 56 — VcMenuContextMap + auto-reset (GameState.cs + ViewControllerPatch.cs)
- GameState.VcMenuContextMap : mappe les sous-écrans → contexte de menu parent
  - SoloGate / SoloSelectChapter → Menu.Solo
  - DeckEdit / DeckBrowser / DeckSelect → Menu.Deck
  - CardBrowser → Menu.CardBrowser
  - ShopBuy / LotteryPortal → Menu.Shop
  - PvpMenuMatching* → Menu.Duel
- GameState.VcKeepContextNames : overlays qui préservent le contexte (FilterSelect, SortDialog, etc.)
- ViewControllerPatch.OnFocusChanged_Postfix : 4 branches :
  1. VC in MenuNames → announce + set context (existant)
  2. VC in VcKeepContextNames → préserve le contexte sans rien faire
  3. VC in VcMenuContextMap → set context silencieusement (Show_Postfix gère l'annonce)
  4. VC inconnu → reset à Menu.None (évite les contextes incorrects sur Profile, Amis, etc.)

### Fix 57 — Dialogs secondaires section 17.2 (MiscViewsPatch.cs)
- PlaceHolderDialogViewController.NSE → "Chargement en cours." (générique)
- TextureImageDialogViewController.NSE → lit le champ `caption` → "Aperçu d'image." ou texte du caption
- PasswordDialogViewController.NSE → lit `INPUT_LABEL` → "Saisie : [label]." ou générique
- SaveDialogViewController.NSE → "Enregistrement en cours."
- SaveDialogViewController.Open (8 params) → lit __0=title, __1=message → "[title]. [message]."

### Fix 58 — Écrans Collection et Codes promo (ViewControllerPatch.cs)
- ScreenTitles : CardFile → "screen_card_file" → "Collection de cartes."
- ScreenTitles : CardFileTable → "screen_card_file"
- ScreenTitles : PromoCodes → "screen_promo_codes" → "Codes promo."

### Fix 59 — Colosseum + TDY + PanelMission (MiscViewsPatch.cs + GameState.cs + ViewControllerPatch.cs)
- ColosseumStartViewController.NSE → lit prefabType (STANDARD/TOURNAMENT/WCS) → Loc key
- ColosseumInfoViewController.NSE → "Informations Colosseum."
- ColosseumHistoryViewController.NSE → "Historique Colosseum."
- ColosseumRankingViewController.NSE → "Classement Colosseum."
- ColosseumRewardViewController.NSE → "Récompenses Colosseum."
- ColosseumSelectVersusViewController.NSE → "Sélection d'adversaire."
- TDYMapViewController.NSE → "Carte Tag Duel."
- TdyResultViewController.NSE → lit m_IsCompleteKizuna → "Résultat Tag Duel [— Kizuna complète !]."
- PanelMissionContent.NSE → "Mission événement."
- ScreenTitles : Colosseum, AutoDuelLauncher, AutoDuel, DuelLive → screen_colosseum/screen_autoduel/screen_duel_live
- VcMenuContextMap : 6 Colosseum + 2 TDY sub-screens → Menu.Duel

### Fix 60 — Team + WCS + ColosseumResult (MiscViewsPatch.cs)
- 14 Team VCs (YgomGame.Team) : NSE → Loc keys (create/designation/info/name/regulation/member/invite/leader-matching/member-matching/matched/waiting/result/result-effect/room)
- 4 WCS VCs (YgomGame.WCS) : NSE → wcs_menu/wcs_watch/wcs_battle_info/wcs_team_room
- ColosseumResultViewController.NSE → "Résultat Colosseum."
- Certification (Fix 60b) : 6 VCs patchés
  - CertificationWritingReslutViewController : lit isSuccess + correctAnswerNum → "Certification : [Réussi/Échoué]. N bonne(s) réponse(s)."
- LotteryCardSelectViewController : ScreenTitles entry "screen_lottery_card_select"
- Build : 0 erreurs

### Loc.cs ajouts (session 2026-03-15)
- placeholder_dialog, texture_image_dialog, password_dialog, password_dialog_label, save_dialog
- screen_card_file, screen_promo_codes
- colosseum_start/tournament/wcs, colosseum_info/history/ranking/reward/versus
- tdy_map, tdy_result, tdy_result_kizuna
- panel_mission
- screen_colosseum, screen_autoduel, screen_duel_live
(fr/en pour toutes)

## Travaux récents (session 2026-03-15 suite)

### Fix 61 — 7 nouveaux patches NSE (MiscViewsPatch.cs + Loc.cs)
- DiceRallyMapEditorViewController → "Éditeur de carte Dice Rally."
- DiceRallySubMenuViewController → "Dice Rally."
- ColosseumRankingViewController_Rate → "Classement Colosseum — Rating."
- ColosseumRewardDiceRallyViewController → "Récompenses Colosseum — Dice Rally." (bypass stub)
- TurnOverPrizeCollabEditViewController → "Tour des prix — Édition collaboration." (bypass stub)
- WCSFinal_TimerSettingViewController → "Paramètres du timer WCS Finale." (bypass stub)
- DuelLiveSelectCardDialogViewController → "Duel Live — Sélection de carte."
Loc : 7 nouvelles clés (fr/en)

### Fix 62 — Crash PresentBox corrigé (MenuPanelStatePatch.cs)
- Root cause : PresentBoxViewController.NSE = RVA 0x3E4080 (shared empty stub) → récursion infinie
- Fix : NseEmptyStubSkip_Prefix() ajouté comme Harmony prefix sur PresentBox NSE
- Helper bypassOriginal ajouté aux deux surcharges PatchMethod()
- RÈGLE : toute classe avec NSE = RVA 0x3E4080 doit utiliser bypassOriginal: true
- Build : 0 erreurs

### Fix 63 — Menus mod navigables + raccourci N
- HelpMenuNavigator.cs : menu d'aide navigable, ouvert par F1
  - Flèche bas/haut : parcourir les raccourcis actifs ; Home/End : premier/dernier ; F1/Escape : fermer
  - InputBlockPatch.ModMenuActive = true bloque les touches de navigation du jeu
- ModSettingsNavigator.cs : menu paramètres navigable, ouvert par Ctrl+F1
  - 3 paramètres : TTS activé, descriptions verbeuses, indices de raccourcis
  - Flèche bas/haut : naviguer ; Entrée/Espace : basculer ; Ctrl+F1/Escape : fermer
  - BepInEx ConfigEntry<bool> : sauvegarde automatique
- ShortcutRegistry.cs : ajout de GetHelpItems()
- KeyboardShortcuts.cs : HelpNav + SettingsNav ; raccourci N → ReadNotificationCount()
- InputBlockPatch.cs : ModMenuActive bloque flèches/Home/End/Entrée/Espace/Escape/Backspace
- Loc.cs : 18 nouvelles clés (help_menu_*, settings_menu_*, setting_*, shortcut_ctrl_f1, shortcut_n)

### Fix 64 — 28 nouveaux écrans via ScreenTitles (ViewControllerPatch.cs + Loc.cs)
- Colosseum (9), TDY (4), WCS (4), DuelLive (1), WebHelp/EnqueteCardSelect (2),
  TurnOverPrizeItemViewer (1), ConsoleDataLinkInherit/Regist (2)
- Loc.cs : 12 nouvelles clés (screen_colosseum_ranking, screen_colosseum_reward, etc.)
- FULL_COVERAGE_PLAN : sections 18, 20, 21, 22, 27, 29, 30 → quasi-DONE

### Fix 65 — CardFileViewController + TeamRoomEditScene (MiscViewsPatch + ViewControllerPatch)
- CardFileViewController : NSE patch → lit cfManager.cfi.possessingCardNum + totalCardNum → "Collection : N / M cartes (X%)"
- TeamRoomEditSceneViewController : ScreenTitles "TeamRoomEditScene" → "screen_team_room"
- FULL_COVERAGE_PLAN : sections 25, 19 → DONE

## Travaux récents (session 2026-03-15 suite 2)

### Fix 66 — ShopBuyWidgetPatch : fix namespace + prix/quantité (Patches/ShopBuyWidgetPatch.cs)
- Bug corrigé : FindType("YgomGame.Shop.BuyButtonGroupWidget") → FindType("BuyButtonGroupWidget") (namespace global)
- Enhancement : lit m_ButtonCtx → extrait numText (quantité) + priceText (prix)
- Loc : shop_buy_widget_product mis à jour → "Acheter : {0}. {1}. {2}."

### Fix 67 — InformDialogFallbackPatch (Patches/InformDialogFallbackPatch.cs)
- Découverte dynamique de toutes les sous-classes de InformDialogViewControllerBase non couvertes
- AppDomain.CurrentDomain.GetAssemblies() → filtre types concrets → vérifie héritage
- KnownHandled : 16 noms déjà patchés individuellement → ignorés
- bypassOriginal = true (sécurité contre stubs vides RVA 0x3E4080)
- Generic_Postfix : supprime suffixes numériques + "ViewController2/ViewController/Dialog/Widget"
- Appliqué dans LatePatches.ApplyMenuScenePatches() après MiscViewsPatch.Apply()
- Loc : inform_dialog_generic → "Dialog : {0}." (fr/en)

### Docs (session 2026-03-15 suite 2)
- docs/FULL_COVERAGE_PLAN.md mis à jour : ~175 DONE, ~8 PARTIAL, ~18 TODO
- README.md réécrit : style SRWYAccess, raccourcis complets, FAQ 8 Q&R, Quick Reference

## Travaux récents (session 2026-03-15 suite 3)

### Fix 68 — NotificationPatch : corps de notification + badge non lue par onglet (NotificationPatch.cs)
- Ajout _bodyField → cache le champ body (string 0x40) de NotificationViewController.Data
- UpdateEntity_Postfix : stocke head/category/date/body/isRead dans _itemData
- BuildItemAnnouncement : appende le corps après les métadonnées (stripped via StripMarkup)
- StripMarkup(string) : regex <[^>]+> → supprime balises Unity rich-text
- UpdateNotification_Postfix : annonce "notif_tab_changed_unread" si non-lus sur l'onglet
- Nouveau helper CountTabUnread(object, int) + refactoring GetTabList()
- Loc : notif_tab_changed_unread (fr/en/de)

### Fix 69 — SoloGatePatch : German Loc string (Loc.cs)
- _german["solo_gate_isv_item"] = "Tor: {0}, {1} von {2}." ajouté

### Fix 70 — FriendViewControllerPatch : ISV navigation (FriendViewControllerPatch.cs)
- FriendListWidget.OnSelectedEntityWidget patché
- Lit playerName + isOnline depuis m_DisplayFriendContexts
- 300ms cooldown + dédup par pcode
- Loc : friend_isv_player, friend_online, friend_offline (fr/en/de)

### Fix 71 — RoomViewControllerPatch : ISV membres (RoomViewControllerPatch.cs)
- RoomMemberViewController.UpdateEntity(GameObject, int) patché
- Lit dataList[index] → name + win/lose/draw
- 300ms cooldown + dédup par index
- Loc : room_member_item (fr/en/de)

### Fix 72 — PromoCodesViewController (MiscViewsPatch.cs)
- NSE réel (RVA 0x8ED800) patché via PatchNSE
- Lit m_Behaviour.type (IPromoCodeBehaviour.Type : SerialCode=0, InviteSend=1, InviteReceive=2)
- Annonce mode : "Codes promo." / "Codes promo — envoi d'invitation." / "Codes promo — réception d'invitation."
- Loc : promo_invite_send, promo_invite_receive (fr/en/de)

### Fix 73 — MarketPoolViewController (MiscViewsPatch.cs)
- NSE stub vide (RVA 0x3E4080) → bypassOriginal: true ; postfix vide
- OnCreatedView (RVA 0x976690) patché directement via harmony.Patch
- Lit TMP_Text du child "Label" via transform.Find("Label")
- Annonce "Marché : {nom}." si texte disponible, sinon "Marché."
- Loc : market_pool_open_name (fr/en/de)

### Fix 74 — Raccourci P étendu : DuelPass + Saison + Missions
- SeasonPointPatch.ActiveInstance + GetCurrentAnnouncement() ajoutés
- MissionViewControllerPatch.ActiveInstance + GetCurrentAnnouncement() ajoutés
- KeyboardShortcuts.ReadDuelPassProgression() : annonce DuelPass → Saison → Missions séquentiellement
- Loc.shortcut_p_menu mis à jour : "Progression : Duel Pass + saison + missions" (fr/en/de)
- Build : 0 erreurs, 0 warnings

## Priorité 3 — Fonctionnalités secondaires (à compléter)
- CardFileTableViewController — pas de NSE, couvert par ScreenTitles "CardFileTable" → "screen_card_file"

## TODO généraux
- ISV généralisation : pattern OnUpdateEntity + FocusCallback pour tous les écrans listes scrollables
  (Missions, Replays, Historique, DuelLive — namespace YgomSystem.UI.InfinityScroll)
- Support japonais (ja) — Loc.cs _japanese dict (langue natale du jeu)
- Annonce déconnexion réseau automatique (sans dialog) — hook sur NetworkManager ou équivalent

## Notes pour la prochaine session
- Tester Fix 70 : naviguer dans la liste amis → "{nom}. En ligne/Hors ligne."
- Tester Fix 71 : ouvrir l'écran membres du salon → noms + W/L/D annoncés lors de la navigation
- Tester Fix 72 : ouvrir PromoCodesViewController → mode annoncé (code série / invitation)
- Tester Fix 73 : ouvrir MarketPoolViewController → nom du marché annoncé si lisible
- Tester Fix 74 : presser P hors duel après avoir visité DuelPass + SeasonPoint + Missions
  → vérifie les 3 annonces séquentielles

## Travaux récents (session 2026-03-15 suite 4)

### Fix 75 — DuelLiveViewController NSE (MiscViewsPatch.cs)
- YgomGame.DuelLive.DuelLiveViewController.NotificationStackEntry (RVA 0xA0D640, réel)
- Annonce : "Duel en direct." (screen_duel_live déjà existant)
- Section 22 PARTIAL → DONE
- Build : 0 erreurs

### Fix 76 — LotteryCardSelectViewController NSE (MiscViewsPatch.cs)
- LotteryCardSelectViewController.NotificationStackEntry (RVA 0xD9C590, réel)
- Lit currentView (protected ViewType 0x21C) : None=0, CardCollection=1, Deck=2
- Lit <m_CardPool>k__BackingField (List<CardBaseData> 0x198) pour la taille du pool
- Annonce : "Sélection de carte. Vue : Collection/Deck. N carte(s) dans le pool."
- Loc : lottery_card_select_collection/deck/open_view/open_count (fr/en/de)
- Section 8 PARTIAL → DONE
- Build : 0 erreurs

### AutoDuelLauncherViewController & AutoDuelViewController — SKIP
- Les deux VCs n'ont que le constructeur partagé RVA 0x3E3340 (stub vide)
- Aucun champ, aucune méthode propre — ScreenTitles = couverture maximale possible
- Section 22 AutoDuel → marqué DONE (max coverage)

### Fix 77 — CardFileTableViewController NSE + ISV (MiscViewsPatch.cs)
- NSE : annonce "Fichiers de cartes. N fichier(s)." ou "Fichiers de cartes." si count illisible
- ISV OnEntityUpdate : lit les TMP_Text de l'entité GO → nom (>2 chars) + progression ("12/25")
  → "Nom. 12/25." ou juste "Nom."
- Dedup par index + texte pour éviter doubles

### Fix 78 — network disconnect (MiscViewsPatch.cs)
- UINetworkHandler.networkDisconnectErrorDialog() prefix → "Connexion perdue." (interrupt: true)

### Fix 79 — Support japonais (Loc.cs)
- Ajout dictionnaire _japanese (~70 clés couvrant écrans, duel, raccourcis, dialogues)
- Détection : YgomSystem.Utility.Locale.GetLanguage() starts with "ja" → _currentLang = "ja"
- Fallback sur la clé anglaise si une clé manque dans _japanese (comportement existant)

## Notes pour la prochaine session
- Tester Fix 75 : ouvrir l'écran Duel Live → "Duel en direct." annoncé
- Tester Fix 76 : entrer dans LotteryCardSelectViewController → vue + nombre de cartes annoncés
  (si pool vide au moment de NSE, fallback "Sélection de carte" attendu)
- Tester Fix 77 : naviguer dans la liste des fichiers de cartes → nom + progression annoncés
- Tester Fix 78 : provoquer une déconnexion → "Connexion perdue." annoncé immédiatement
- Tester Fix 79 : lancer le jeu en japonais → vérifier les annonces en japonais

### Fix 80 — PanelMissionContent.OnSelectedPanel (MiscViewsPatch.cs)
- Patch `OnSelectedPanel(PanelWidget)` postfix dans PanelMissionContent
- Lit `titleText.text` et `progressText.text` (si `existsProgressText`) via reflection sur PanelWidget
- Annonce : "{titre}. {progression}." ou juste "{titre}."
- Nouveau Loc key : `panel_mission_item` ("{0}. {1}.")

### Fix 81 — ISV Replays (ReplayPatch.cs)
- `ProfileReplayViewController.OnItemSetData(GameObject, int)` — ISV replay personnel
- `RoomReplayViewController.UpdateEntity(GameObject, int)` — ISV replays salon
- Les deux collectent les TMP_Text non vides du GO de l'entité (max 4) → joint par ". "
- Dédup par (dataindex, texte) pour éviter répétition lors du scroll

## Notes pour la prochaine session
- Fix 75-81 à tester en jeu
- Couverture plan complète — plus de TODO techniques restants
