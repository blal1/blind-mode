## Phase actuelle
Phase 2 — Développement actif du mod d'accessibilité.

## Mod
- Nom : MasterDuelAccessibility
- Framework : MelonLoader v0.7.1, Unity 6 (6000.0.61f1), IL2CPP
- Build : `dotnet build -c Release` depuis `mod/MasterDuelAccessibility/`
- DLL sortie : `bin/Release/net6.0/MasterDuelAccessibility.dll`

## Fonctionnalités implémentées
- TTS via Tolk (NVDA, JAWS, SAPI) — TtsService.cs
- Raccourcis clavier F1-F12, Espace, Maj+Espace, Alt — KeyboardShortcuts.cs
- Annonces LP (DuelHudPatch), phase/tour (PhasePatch)
- Navigation menus — SelectionButtonPatch avec dispatch contextuel par menu
- Boutons icône — ColorContainerPatch (trigger corrigé : mode Enter=2)
- Info carte — CardInfoPatch (SetDescriptionArea)
- Événements duel — DuelEventPatch (20+ ViewType)
- Dialogues duel — DuelDialogPatch
- Navigateur de cartes — CardBrowserPatch (auto-lecture au scroll + ouverture)
- Éditeur de deck — DeckEditPatch (ajout, retrait, renommage, sauvegarde, focus)
- Matchmaking — MatchingPatch (searching/found/timeout)
- Sélection de deck avant duel — DeckSelectPatch (OnFocusChanged → nom du deck)
- Création/démantèlement de carte — CardCraftPatch (Open → nom + mode)
- Résultat de fabrication — CardCraftResultPatch (GetResultMessage → message)

## Patches actifs
- DuelHudPatch : DuelLP.ChangeLP / SetLP
- PhasePatch : PhaseSelectWindow.PhaseChange / TurnChange
- SelectionButtonPatch : SelectionButton.OnSelected / OnPointerClick / OnDeselected
- ColorContainerPatch : ColorContainerGraphic.SetColor + ColorContainerImage.SetColor
- ViewControllerPatch : ViewController.OnFocusChanged / OnBack
- CardInfoPatch : CardInfo.SetDescriptionArea
- DuelEventPatch : DuelClient.RunEffect / Awake / OnDestroy
- DuelDialogPatch : DuelConfirmDialog.Open (2 surcharges) / DuelSelectDialog.Open
- CardBrowserPatch : CardBrowserViewController.Start / OnPageChanged
- DeckEditPatch :
  - DeckEditViewController2.StartCardAddEffect
  - DeckEditViewController2.RemoveFromDeck (2-param)
  - DeckEditViewController2.OnSubmitDeckName
  - DeckEditViewController2.OnClickSaveButton
  - DeckEditViewController2.OnFocusChanged
- MatchingPatch : PvpMenuMatchingViewController.SetActiveView
- CardCommandPatch : CardCommand.Open (6-param)
- DuelAttackPatch : DuelClient.InvokeDecideAttackTarget
- **DeckSelectPatch** : DeckSelectViewController2.OnFocusChanged
- **CardCraftPatch** : CardCraftDialog.Open (5-param)
- **CardCraftResultPatch** : CardCraftResultDialog.GetResultMessage

## Travaux récents (session actuelle)
- DeckSelectPatch.OnFocusChanged_Postfix : annonce nom du deck sélectionné
- CardCraftPatch.Open_Postfix : annonce "Créer / Démanteler / Création boostée : {carte}"
- CardCraftResultPatch.GetResultMessage_Postfix : lit le message de résultat du jeu
- Loc : ajout clés deck_select_focus, craft_create, craft_boost_create, craft_dismantle, craft_result_generic
- Build : 0 erreur

## Localisation
- Loc.cs créé : français (primary) + anglais (fallback), ~90 clés
- Loc.Initialize() appelé dans Plugin.OnInitializeMelon()
- Tous les patches utilisent Loc.Get() — aucun string TTS codé en dur restant

## Issues connues / TODO
- Tests : aucun test unitaire (réflexion IL2CPP difficile à mocker)
- CommanderButton et menus spéciaux non couverts
- Navigateur de cartes (CardBrowser) : chemin "Template(Clone){0}" peut varier — à vérifier en jeu
- Loc : seules fr/en supportées — envisager ja-JP pour joueurs japonais
- ProcessPacks : FindGameObjectByPath dépend du chemin exact — à vérifier en jeu
- DeckSelectPatch : lastSet est privé — si inaccessible en jeu, fallback sur index 0
- CardCraftPatch : méthode statique => injection positionnelle Harmony (__1 = CraftMode, __2 = cardID) à vérifier
- DeckSelectViewController2.OnFocusChanged peut doubler avec ViewControllerPatch — à surveiller en jeu

## Ressources de référence
- BlindMode source décompilé : `blind mode/DevTools/Decompiled/`
- Dump complet du jeu : `dump/dump.cs`
- DLLs interop : `BepInEx/interop/Assembly-CSharp.dll`

## Notes pour la prochaine session
- Tester en jeu : DeckSelectPatch → lecture du nom deck avant duel
- Tester : CardCraftPatch → annonce lors de l'ouverture du dialog création/démantèlement
- Tester : CardCraftResultPatch → lecture du résultat post-fabrication
- Vérifier double-annonce potentielle : DeckSelectViewController2.OnFocusChanged vs ViewControllerPatch
- Envisager : prise en charge japonais dans Loc
- Envisager : DeckSelectViewController2 — lire aussi le mode de sélection (Ranked, Solo, etc.)

