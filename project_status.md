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
- ViewControllerPatch : ViewController.OnFocusChanged / OnBack / ShowUI

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

## Notes pour la prochaine session
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
- Pistes restantes :
  - Corriger ScreenTitles si noms vues secondaires incorrects (vérifier logs)
  - Support japonais dans Loc
  - Revue complète : passer checklist sur menus manquants éventuels
