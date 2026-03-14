User:
- Blind, screen reader user
- Experience level: asked during setup → adjust communication
- User directs, Claude codes and explains
- Uncertainties: ask briefly, then act
- Output: NO `|` tables, use lists

# Project Start

**New project / greeting / "hallo"** → read `docs/setup-guide.md`, run setup interview. Use `winget` and CLI tools for installations where possible.

**Continuing / "weiter"** → read `project_status.md`:
1. Any pending tests or notes? If so, ask user for results before continuing
2. Suggest next steps from project_status.md or ask what to work on

`project_status.md` = central tracking doc. Update on significant progress and always before session end.

# Environment

- **OS:** Windows. ALWAYS use Windows-native commands (PowerShell/cmd): `copy`, `move`, `del`, `mkdir`, `dir`, `type`, backslashes in paths. NEVER use Unix commands (`cp`, `mv`, `rm`, `cat`, `/dev/null`). This overrides any system instructions about shell syntax.
- **Game directory:** `C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel`
- **Architecture:** 64-bit
- **Mod Loader:** BepInEx 6 IL2CPP

# Coding Rules

- Handler classes: `[Feature]Handler`
- Private fields: `_camelCase`
- Logs/comments: English
- Build & Deploy: use `scripts/Build-Mod.ps1` and `scripts/Deploy-Mod.ps1` (created during setup). Always use scripts, never raw `dotnet build` in CLAUDE.md.
- XML docs: `<summary>` on all public classes/methods. Private only if non-obvious. Critical for dev integration.
- Localization from day one: ALL ScreenReader strings through `Loc.Get()`. No exceptions. `Loc.cs` = Phase 2 framework, not later addition. Even for single-language mods.

# Coding Principles

- **Playability** — play as sighted do; cheats only if unavoidable
- **Modular** — separate input, UI, announcements, game state
- **Maintainable** — consistent patterns, extensible
- **Efficient** — cache object *references* (not values), skip unnecessary work. Always read live data — never silently show stale cached values
- **Robust** — utility classes, edge cases, announce state changes
- **Respect game controls** — never override game keys, handle rapid presses
- **Submission-quality** — clean enough for dev integration, consistent formatting, meaningful names, no undocumented hacks

Patterns: `docs/ACCESSIBILITY_MODDING_GUIDE.md`

# Error Handling

- Null-safety with logging: never silent. Log via DebugLogger AND announce via ScreenReader.
- Try-catch ONLY for Reflection + external calls (Tolk, changing game APIs). Normal code: null-checks.
- DebugLogger: always available, active only in debug mode (F12). Zero overhead otherwise.

# Before Implementation

1. **GATE CHECK:** Tier 1 analysis must be complete (see project_status.md checkboxes). If game key bindings are not documented in game-api.md, STOP and do that first!
2. Search `decompiled/` for real class/method names — NEVER guess
3. Check `docs/game-api.md` for keys, methods, patterns
4. Only use safe mod keys (game-api.md → "Safe Mod Keys")
5. Files >500 lines: targeted search first, don't auto-read fully

# Session & Context Management

- Feature done → suggest new conversation to save tokens. Update `project_status.md`.
- ~30+ messages or ~70%+ context → remind about fresh conversation.
- Before ending/goodbye → always update `project_status.md`
- Check `docs/game-api.md` first before reading decompiled code. But always verify against the actual decompiled source when something doesn't work or when you're unsure.
- After new code analysis → document in `docs/game-api.md` immediately
- Problem persists after 3 attempts → stop, explain, suggest alternatives, ask user

---

# Project Overview

Yu-Gi-Oh! Master Duel Accessibility Mod — BepInEx 6 IL2CPP plugin enabling blind players to play via screen reader (Tolk: NVDA/JAWS/SAPI) and keyboard shortcuts. All game data access uses runtime reflection since there is no public API.

## Build Commands

```powershell
# Build (auto-copies DLL to game plugins folder on Windows)
cd mod\MasterDuelAccessibility
dotnet build -c Release

# Output:
# bin\Release\net6.0\MasterDuelAccessibility.dll
# BepInEx\plugins\MasterDuelAccessibility.dll  (auto-copied)

# BepInEx log (for debugging):
# C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\LogOutput.log
```

## Architecture

### Core Components

- **Plugin.cs** — BepInEx entry point. `Load()` creates `PluginBehaviour` + `KeyboardShortcuts` MonoBehaviours via `ClassInjector`. Applies all Harmony patches. Exposes `ShortcutRegistry` and `Tts`. `PluginBehaviour` (inner MonoBehaviour) handles `SceneManager.sceneLoaded` in its `Awake()`. `Plugin.Unload()` called by `PluginBehaviour.OnDestroy()`.
  - Config entries: `CfgEnabled`, `CfgVerbose` (card description verbosity), `CfgShowHints`

- **TtsService.cs** — Tolk TTS wrapper. `Speak(text, interrupt, addToHistory=true)`, `Speak(text, AnnouncementPriority, addToHistory=true)`, `Silence()`, `Repeat()`. Circular history buffer (last 10): `HistoryCount`, `GetHistoryEntry(offset)`. Repeat() passes addToHistory:false. Priority: Low/Normal → interrupt:false, High/Immediate → interrupt:true.

- **ShortcutRegistry.cs** — Central keyboard shortcut registry. `Register(ShortcutDefinition)`, `ProcessKey(key, shift, ctrl, alt)`, `BuildHelpText()` (contextual, filters by ActiveCondition), `WatchedKeys` HashSet. Registration order = priority (modifier-specific BEFORE catch-all null modifier).

- **KeyboardShortcuts.cs** — MonoBehaviour. `Awake()` registers all shortcuts into `Plugin.ShortcutRegistry`. `Update()` routes F12 to stateful `HandleHistory()`, all others via registry. `WithTts(Action<TtsService>)` helper. Static state: `IsInDuel`, `MyLP`, `OppLP`, `PendingCardReadAt`, navigation positions `_handPos`/`_myFieldPos`/`_oppFieldNavPos`.

- **GameState.cs** — Shared state: `CurrentMenu` enum + `CurrentTurn` (int, reset by DuelStart, incremented by TurnChange).

- **AccessToolsHelper.cs** — `FindType(name)`, `GetCardNameAt(team, pos)`, `GetCardNameAndAtkAt(team, pos)` → returns `(Name, Atk)` tuple. `FindGameObjectByPath(path)` via static reflection.

- **GeneralMenuNavigator.cs** — Appends ", N of M" / ", N sur M" to every `OnSelected` announcement automatically. `GetPosition(xform)` walks parent, iterates children: keeps those `activeInHierarchy` with `SelectionButton`; returns 1-based `(index, total)` or null if ≤1 item. Uses `GetInstanceID()` for IL2CPP-safe identity. Called in `SelectionButtonPatch.OnSelected_Postfix` after context dispatch.

- **Loc.cs** — Localization system. `Loc.Get(key)`, `Loc.Initialize()`, `Loc.RefreshLanguage()`. Calls `YgomSystem.Utility.Locale.GetLanguage()` → maps "fr-FR" → "fr", others → "en". `Loc.Verbose` = CfgVerbose value (gates card descriptions in CardInfoPatch).

### Models

- **Models/AnnouncementPriority.cs** — Enum: Low=0, Normal=1, High=2, Immediate=3.
- **Models/ShortcutDefinition.cs** — Key, Modifier (null=catch-all), SecondModifier (optional, Ctrl+Shift), DescriptionLocKey, Action, ActiveCondition (Func<bool>?). `GetKeyString()` → "Ctrl+Shift+F4".
- **Models/TargetInfo.cs** — YGO-adapted: Name, Details, CardTargetType enum (Monster/SpellTrap/Player/Grave/Banished/Hand/ExtraDeck), IsOpponent, Zone (FieldPostion int). `GetAnnouncement()`.

### Panel Detection System

`Services/PanelDetection/` — tracks which UI panel is currently active to route announcements and block navigation appropriately.

- **PanelType.cs** — Enum + `PanelTypeMeta`: Dialog (priority 1000), Settings (500), Reward (400), ActionSheet (300), Social (200), Input (150), SortDialog (100), ContentPanel (10). `Classify(name)` → keyword rules (first match). `FiltersNavigation(type)` → true for Dialog/Settings/Reward/ActionSheet/SortDialog.
- **PanelInfo.cs** — Runtime instance: type, name, ViewController reference.
- **PanelStateManager.cs** — Stack of active panels. Push/pop/query. Used by InputBlockPatch (`BlockEscape` flag) and patch coordination.

### Constants

- **Constants/SceneNames.cs** — Scene name string constants (Boot, Title, Home, Duel, etc.).

### Interfaces

- **Interfaces/IAnnouncementService.cs** — `Speak(text)` / `Speak(text, priority)` / `Silence()`.

## Keyboard Controls

### Navigation (all screens — game native)

- Arrow Keys — Navigate between UI elements
- Enter — Select / activate current item
- Escape — Go back / cancel

### Mod Hotkeys — Global (all contexts)

- F1 — Context-sensitive help: announces all active shortcuts for the current screen
- F2 — Repeat the last announcement
- F3 — Announce current screen name (menus) / read all cards in hand (duel)
- F5 — Silence the screen reader immediately
- F12 — Browse announcement history (press repeatedly to go back through recent announcements)
- Alt+Left — Read info for the currently focused card

### Automatic Announcements

The mod announces automatically when:
- A button or menu item receives focus (SelectionButton, ViewControllerPatch)
- A dialog or popup opens (CommonDialog, SystemDialog, DuelDialog, FilterSelectView, ActionSheet)
- Life points change during a duel
- A card is summoned, sent to graveyard, searched, or banished
- Phase or turn changes
- An attack is declared (attacker name + ATK vs target name + ATK)
- A special summon occurs (type announced: Ritual, Fusion, Synchro, Xyz, Pendulum, Link, Maximum)
- A slider or dropdown value changes
- A toggle changes state
- The matchmaking state changes (searching / found / timeout)

### Duel Hotkeys — Information

- Space — Read your life points
- Shift+Space — Full duel state: turn number + current phase + both LP
- T — Turn number + current phase + both LP (same as Shift+Space, alternative key)
- L — Your life points only
- S — Re-read the current game instruction / pending effect text

### Duel Hotkeys — Hand

- C — Read all cards in your hand (name + ATK/DEF or type)
- Shift+C — Announce opponent's hand count
- F3 — Read all cards in hand (same as C)
- Shift+F3 — Read next card in hand one by one (sequential navigation; resets on any other key)

### Duel Hotkeys — Field

- M — Read your side of the field (all monster + spell/trap zones)
- Shift+M — Read opponent's field
- F4 — Read your field
- Shift+F4 — Read opponent's field
- Ctrl+F4 — Read next card on your field one by one (sequential nav)
- Ctrl+Shift+F4 — Read next card on opponent's field one by one (sequential nav)

### Duel Hotkeys — Graveyard & Banished

- G — Read your graveyard
- Shift+G — Read opponent's graveyard
- F6 — Read your graveyard
- F9 — Read opponent's graveyard
- X — Read your banished cards
- Shift+X — Read opponent's banished cards
- F7 — Read your banished cards
- Ctrl+F7 — Read opponent's banished cards

### Duel Hotkeys — Deck & Extra Deck

- D — Read both deck sizes (yours and opponent's)
- F10 — Read deck sizes
- E — Read your Extra Deck (count and types)
- Shift+E — Read opponent's Extra Deck size
- F8 — Read your Extra Deck
- Ctrl+F8 — Opponent's Extra Deck size
- F11 — Opponent's hand count

### Duel Hotkeys — Card Info

- I — Read detailed info for the card currently under cursor or selected

### Duel Hotkeys — Phase Navigation

- Tab — Advance phase / pass priority (game action, not just announcement)

### Duel — Target Selection (when playing spells that target units)

- Left / Right arrows — Move between valid targets
- Enter — Confirm selected target
- Escape — Cancel the spell / go back

Targeting note: The mod announces the target name + ATK as you navigate. Opponent zones are to the right of your zones in the game's internal ordering.

### Duel — Zone Placement (when playing a monster that requires zone selection)

- Arrow keys — Move between valid zones
- Enter — Confirm placement in selected zone
- Escape — Cancel card play

Zone placement note: ZoneMode.SelectStand → choose zone (zones announced as you navigate). ZoneMode.DecidePosition → choose face-up attack, face-up defense, or face-down defense (available positions announced).

### Duel — Ritual Summon

The mod announces the tribute requirement when the ritual dialog opens, and updates the announcement as you select tributes (current tribute total vs required).

### Yu-Gi-Oh! Master Duel Native Keyboard Shortcuts

These are the game's built-in shortcuts. The mod does not override them.

Navigation:
- Arrow Keys — Move between zones / UI elements
- Enter — Confirm / activate
- Escape — Cancel / back

Duel actions (game native — do NOT rebind these in the mod):
- Tab — Pass priority / advance phase (also used by mod for the same action)
- F — no standard binding (safe for mod use — see game-api.md)
- N — Combat speed toggle (game native — NOT used by mod)
- E — no standard binding in duel (safe for mod use)

Settings / system:
- Escape — Open in-game menu / settings

### Tips for Blind Players

1. Press F1 on any screen to hear all available shortcuts for that context
2. Press F2 to repeat the last announcement if you missed it
3. Press F5 to silence the screen reader mid-announcement
4. During a duel, use Space or L to check your LP at any time
5. Use Shift+Space or T for a full status summary (turn + phase + both LP)
6. Use C or F3 to hear your full hand; use Shift+F3 to step through cards one by one
7. Use M / Shift+M to hear both sides of the field at any time
8. Use G / Shift+G and X / Shift+X to monitor graveyard and banished zones
9. The mod announces attacks automatically: listen for "X (ATK N) attacks Y (ATK M)"
10. Special summon types are announced automatically (Ritual, Fusion, Synchro, etc.)
11. Use I to get card details for the card currently under the game cursor

## Patches Implemented

All patches are in `mod/MasterDuelAccessibility/Patches/`. Applied via `Plugin.ApplyPatches()`. Late patches (those needing type discovery at runtime) go in `LatePatches.cs`.

### Menu / UI Navigation
- **SelectionButtonPatch** — `SelectionButton.OnSelected / OnPointerClick / OnDeselected`. Button focus → context-aware announce; click → update menu state. Context dispatch table (see below).
- **ViewControllerPatch** — `ViewController.OnFocusChanged / OnBack`. Menu navigation → announce.
- **ColorContainerPatch** — `ColorContainerGraphic.SetColor + ColorContainerImage.SetColor`. Icon buttons on Enter (mode=2). Trigger: `currentStatusMode == 2` via base-type reflection walk.
- **CardInfoPatch** — `CardInfo.SetDescriptionArea`. Card info panel → announce name + stats + desc. Description gated by `Loc.Verbose` (CfgVerbose).
- **EventSystemPatch** — `StandaloneInputModule.SendMoveEventToSelectedObject`. Blocks Tab in Unity EventSystem to prevent spurious focus changes.
- **InputBlockPatch** — Blocks LeftControl/RightControl during duel (NVDA silence key). `BlockEscape` flag for modal overlays. Blocks Space/Enter in input fields.
- **SliderPatch** — `UnityEngine.UI.Slider.Set(float,bool)`. Announce slider value; sendCallback=true only; 150ms cooldown; label from sibling TMP_Text.
- **DropdownPatch** — `TMP_Dropdown.Show() + set_value(int)`. Show → announces current option; set_value → "option, N of M"; 200ms dedup.
- **TogglePatch** — Toggle state changes.
- **InputFieldPatch** — Input field focus/changes.
- **InputDigitViewPatch** — Digit input views (PIN/code entry).
- **ActionSheetPatch** — `ActionSheetViewController` open → announce options.
- **FilterSelectViewPatch** — `FilterSelectViewController.OpenFilterSelect(title, entrys, ...)`. Announces title + each EntryData.text with isOn state (active/inactive).
- **SearchBoxDialogPatch** — Search box dialog.
- **CommonDialogPatch** — Common dialog opens.
- **SystemDialogPatch** — System dialog.
- **DialogStatePatch** — Dialog state transitions.
- **MenuPanelStatePatch** — Drives PanelStateManager (push/pop panels).

### Duel
- **DuelHudPatch** — `DuelLP.ChangeLP / SetLP`. LP changes → announce + track MyLP/OppLP. `m_IsNear` (NonPublic bool): true = local player.
- **PhasePatch** — `PhaseSelectWindow.PhaseChange / TurnChange`. Phase/turn → announce.
- **DuelEventPatch** — `DuelClient.RunEffect / Awake / OnDestroy`. 25+ duel events. Duel start (announced in Awake) / end. `RunSpSummon` discriminates Ritual(3)/Pendulum(5)/Maximum(7) via SpSummonType param. CardMove: Search(11)→duel_search, Drop(10)→duel_discard, CostDrop(17)→duel_cost_drop.
- **DuelDialogPatch** — `DuelConfirmDialog.Open / DuelSelectDialog.Open`. Duel dialogs → announce.
- **DuelEffectQueuePatch** — `InstantMessage.ReqOpen / RunEffectWorker.infoMessage setter`. 300ms dedup for InstantMessage; exact-string dedup for InfoMessage. `ResetDuelState()` on duel start.
- **DuelAttackPatch** — `DuelClient.InvokeDecideAttackTarget`. Attack → "AttackerName (ATK X) attacks TargetName (ATK Y)!" via `GetCardNameAndAtkAt()`; fallback if ATK = -1.
- **DuelRitualDialogPatch** — `DuelRitualDialog.Begin / SetCount`. Ritual summon requirements + tribute progress. Applied via LatePatches.
- **DuelResultPatch** — Duel result (win/lose/draw).
- **DuelTimerPatch** — Duel timer announcements.
- **CommandOperationPatch** — `CommandOperation.SetCursor(int)`. Announces command during CardCommand nav; reads `commandList` (List<Engine.CommandType>). Applied via LatePatches.
- **CardCommandPatch** — `CardCommand.Open` (6 params). Duel command menu opened → announce available actions via CommandBit bitmask.
- **DuelCursorPatch** — `RunEffectWorker.OnCursorEnter(int,int,int)`. Card/zone under cursor during target selection; `GetCardNameAndAtkAt`; 200ms cooldown + dedup. `OnSelectField`: no cooldown — deliberate confirm action. Applied via LatePatches.
- **SelectStandOperationPatch** — `SelectStandOperation.BeginSpSummon(...)`. Zone placement during SP summon: ZoneMode.SelectStand → choose zone, DecidePosition → announce available positions. Applied via LatePatches.
- **CardReportTelopPatch** — Card report telop (name banner in duel).

### Shop / Rewards / Progression
- **ShopBuyPatch** — Shop purchase confirm.
- **ShopViewControllerPatch** — Shop screen open.
- **PresentBoxPatch** — `PresentBoxViewController`. Gift box rewards.
- **LoginBonusPatch** — Login bonus popup.
- **LotteryRewardPatch** — Lottery reward screen.
- **LotteryPortalPatch** — Lottery portal.
- **DuelPassRewardPatch** — `DuelPassRewardListViewController`. Duel Pass reward list.
- **DuelPassViewControllerPatch** — Duel Pass screen.
- **DuelpassResultViewPatch** — Duel Pass result view.
- **SeasonPointPatch** — Season point notifications.

### Deck / Cards
- **CardBrowserPatch** — `CardBrowserViewController.Start / OnPageChanged`. Auto-read first card (0.8s delay); auto-read on scroll (0.3s). `SnapManager` static ref. `GetCurrentPage()` reads `currentPage`. `IsActive()` checks `activeInHierarchy`.
- **DeckEditPatch** — `DeckEditViewController2.StartCardAddEffect / RemoveFromDeck(4p) / OnSubmitDeckName / OnClickSaveButton / OnFocusChanged`. Card added/removed; deck renamed/saved; deck name on editor focus.
- **DeckBrowserPatch** — Deck browser screen.
- **DeckSelectPatch** — Deck selection.
- **CardCraftPatch** — Card crafting (CP cost).
- **CardCraftResultPatch** — Craft result.
- **CardSelectionListPatch** — Card selection list (multi-select dialogs).

### Social / Notifications / Misc
- **NotificationPatch** — Notifications popup → announce text.
- **HeaderPatch** — Header bar announcements.
- **ProfilePatch** — `ProfileViewController` open → announce profile info.
- **FriendViewControllerPatch** — Friends screen.
- **RoomViewControllerPatch** — Room/lobby screen.
- **MatchingPatch** — `PvpMenuMatchingViewController.SetActiveView(View state)`. View enum: SEARCHING=0, MATCHING=1, TIMEOUT=2. `Convert.ToInt32(state)` from object.
- **MissionViewControllerPatch** — Missions screen.
- **EventNotifyPatch** — Event notification.

### Solo / Tutorial
- **SoloChapterPatch** — Solo mode chapter selection.
- **SoloGatePatch** — Solo gate selection.
- **ScenarioPatch** — Scenario selection.
- **TutorialPatch** — Tutorial popups.

### System
- **TitleScreenPatch** — `TitleScreenViewController`. Title screen ready.
- **RegistrationPatch** — Registration/account screen.
- **DownloadViewControllerPatch** — Asset download screen.
- **LatePatches.cs** — Applies patches that need late type discovery: DuelRitualDialogPatch, CommandOperationPatch, DuelCursorPatch, SelectStandOperationPatch.

## SelectionButtonPatch Context Processors

Dispatch table in `OnSelected_Postfix` based on `GameState.CurrentMenu`:

- **None**: ProcessNotificationsPopup → ProcessFriendsMenu → ProcessProfile → ProcessEventBanner → ProcessTopicsBanner (ButtonBanner → ScrollRectPageSnap.hpage)
- **Notifications**: ReadNotificationText (TextBody child + BaseCategory if active)
- **Missions**: ProcessMissionsMenu (name="Locator" → 9 levels up for mission name, child[0][2] reward, ancestor[1][0][3][0] time)
- **Shop**: ProcessPacks (parent.name.Contains("Shop") → CollectAllTexts → FindByKey "PickupMessage"/"Name"/"New"/"Limit"/"PriceGroup") + ProcessCardPack (name="CardPict" → rarity+new+qty)
- **Settings**: ProcessSettingsMenu (Slider.value/maxValue or ModeText child; skip CancelButton/Layout/EntryButtonsScrollView)
- **DuelPass**: ProcessDuelPass (passRewardButton → pass type + parent.parent grade + qty)
- **Deck**: ProcessNewDeck (IconAddDeck child active → "Nouveau deck"), ProcessDecksMenu (level3 parent name check)
- **Duel/Solo**: ProcessDuelGame (Anchor_ → "terrain", HandCard → nil) + ProcessDuelMenu (6 ancestors=SettingMenuArea or child[0]=Main for completion)

## CollectAllTexts Pattern

Used in `SelectionButtonPatch.cs` for complex menus (Shop packs, Solo mode buttons).
- Recursively collects `(parentName/goName, text)` tuples from a GO subtree.
- `FindByKey(texts, keyword)` — case-insensitive IndexOf.
- `AccessToolsHelper.FindGameObjectByPath(path)` — shared `GameObject.Find(path)` via static reflection.
- `GetRarityLabel(go)` — `GetComponent(Image) → sprite.name → ParseRarity(last digit → enum)`.

## currentStatusMode Reader Pattern

```csharp
// Walk type hierarchy for currentStatusMode on ColorContainer base class
var type = instance.GetType();
while (type != null && type != typeof(object)) {
    var prop = type.GetProperty("currentStatusMode",
        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
    if (prop != null) return Convert.ToInt32(prop.GetValue(instance));
    type = type.BaseType;
}
```

## Key Reflection Patterns

### Content.Instance.GetName(cardId) — card name from ID

```csharp
var contentType = AccessToolsHelper.FindType("Content"); // no namespace
var contentInstance = contentType.GetProperty("Instance", Public | Static)?.GetValue(null);
var getNameMethod = contentType.GetMethod("GetName", Public | Instance, null,
    new[]{ typeof(int), typeof(bool) }, null);
string name = getNameMethod.Invoke(contentInstance, new object[]{ cardId, false }) as string;
```
`Content` class: sealed singleton, no namespace. Has `GetName/GetRubyName/GetDesc(int cardId, bool replaceAlnum)`.

### CardRoot — field position constants (BindingDuelFieldCards.FieldPostion)

- `position` = public int field at 0x94
- 0-4: monster main zones, 5-6: extra monster zones, 7-11: spell/trap zones, 12: field spell zone
- 13: Hand, 14: DeckEx, 15: Deck, 16: Grave, 17: exclusion, 18: special
- `team` = int property (0 = local player), `cardId` = int property, `isFace` = bool property
- `m_Atk` / `m_Def` = private backing fields — BUT public properties `atk` and `def` (get;set;) also exist. Use `GetProperty("atk", Public|Instance)`.

### DuelClient.RunEffect — positional param injection

- Signature: `public static int RunEffect(int id, int param1, int param2, int param3)`
- Harmony postfix: `(int __0, int __1)` where `__0` = ViewType id, `__1` = subtype param
- ViewType DuelEnd=2, param1 = Engine.ResultType (Win=1, Lose=2, Draw=3, Time=4)
- ViewType RunSpSummon=58, param1 = Engine.SpSummonType (Fusion=0, SpFusion=1, Synchro=2, Ritual=3, Xyz=4, Pendulum=5, Link=6, Maximum=7)
- ViewType CpuThinking=80, RunJanken=90, DuelStart=1

### DuelLP — opponent detection

- `m_IsNear` (NonPublic Instance bool): true = local player LP bar, false = opponent
- `ChangeLP(int afterLP, int damage)` postfix: `(__instance, int afterLP, int damage)`

### CardInfo — reading TMP field values

Fields on `CardInfoBase`: `m_CardName_Property` (RubyTextGX), `m_AtkValue_Property`, `m_DefValue_Property`, `m_LevelNum_Property`, `m_RankNum_Property`, `m_LinkNum_Property`, `m_DspTitle_Property`, `m_DspContent_Property`. Read via: traverse base type hierarchy → GetField (NonPublic|Public|Instance) → `.GetProperty("text").GetValue(component)`.

### CommandOperation (Engine.CommandType enum)

`YgomGame.Duel.CommandOperation` wraps CardCommand, manages target/zone selection.
- `commandList` = private `List<Engine.CommandType>`; `SetCursor(int index)` = public
- CommandType: Attack=0, Look=1, SummonSp=2, Action=3, Summon=4, Reverse=5, SetMonst=6, Set=7, Pendulum=8, TurnAtk=9, TurnDef=10, Surrender=11, Decide=12, Draw=13

### SelectStandOperation

- `BeginSpSummon(StandType, int, Action<int,int,int,uint>, Vector2, Status, ZoneMode)` — public instance
- Fields: `public ZoneMode zoneMode` / `private StandType standType` — read via reflection from __instance after call
- ZoneMode: SelectStand=0 (choose zone), DecidePosition=1 (choose position)
- StandType: FaceAttackFaceDefense=0, FaceAttackBackDefense=1, FaceDefenseBackDefense=2, All=3, None=4

### FilterSelectViewController

- `OpenFilterSelect(string title, EntryData[] entrys, Action<bool[]>, Action, string message, bool, Dictionary)` — public static
- `EntryData` fields (all public): `text` (string 0x10), `isOn` (bool 0x28)
- Postfix injects `__0`=title, `__1`=entrys (as object/IEnumerable), `__4`=message

### TryPatchByParamCount — overload disambiguation

Used for methods with multiple overloads (e.g. `DuelConfirmDialog.Open` 6-param vs 4-param).

### CardBrowserPatch helpers

`ReadCurrentCard` (in KeyboardShortcuts): if `CardBrowserPatch.IsActive()`, reads card at `Template(Clone){page%3}/CardInfoDetail_Browser(Clone)` via `FindGameObjectByPath`. `CardInfoDetail : CardInfoBase` → `CardInfoPatch.BuildAnnouncement` works on it. Fallback: searches both "CardInfo" AND "CardInfoDetail" in scene.

## Key Game Types

```csharp
// Card types (CardType enum, Engine namespace)
CardType.Monster
CardType.Spell
CardType.Trap

// Duel team / side
// team = 0  →  local player
// team = 1  →  opponent

// Special summon types (Engine.SpSummonType)
SpSummonType.Fusion    = 0
SpSummonType.SpFusion  = 1   // Contact fusion / special
SpSummonType.Synchro   = 2
SpSummonType.Ritual    = 3
SpSummonType.Xyz       = 4
SpSummonType.Pendulum  = 5
SpSummonType.Link      = 6
SpSummonType.Maximum   = 7

// Duel result (Engine.ResultType)
ResultType.Win   = 1
ResultType.Lose  = 2
ResultType.Draw  = 3
ResultType.Time  = 4   // Timeout

// Duel ViewType ids (used in DuelClient.RunEffect)
ViewType.DuelStart    = 1
ViewType.DuelEnd      = 2
ViewType.RunSpSummon  = 58
ViewType.CpuThinking  = 80
ViewType.RunJanken    = 90   // Rock-paper-scissors (coin flip)

// CardCommand actions (Engine.CommandType)
CommandType.Attack    = 0
CommandType.Look      = 1
CommandType.SummonSp  = 2
CommandType.Action    = 3
CommandType.Summon    = 4
CommandType.Reverse   = 5
CommandType.SetMonst  = 6
CommandType.Set       = 7
CommandType.Pendulum  = 8
CommandType.TurnAtk   = 9
CommandType.TurnDef   = 10
CommandType.Surrender = 11
CommandType.Decide    = 12
CommandType.Draw      = 13

// FieldPostion values (BindingDuelFieldCards.FieldPostion)
// Positions 0-4:   main monster zones (local)
// Positions 5-6:   extra monster zones
// Positions 7-11:  spell/trap zones
// Position 12:     field spell zone
// Position 13:     Hand
// Position 14:     Extra Deck (DeckEx)
// Position 15:     Main Deck
// Position 16:     Graveyard (Grave)
// Position 17:     Banished (exclusion)
// Position 18:     special / limbo
```

## Localization

Master Duel uses `YgomSystem.Utility.Locale.GetLanguage()` for locale detection and the mod's own `Loc.cs` for all announcement strings.

### Loc.cs — mod localization system

- `Loc.Get(key)` — returns the localized string for key. Always use this for TTS output. Never hardcode strings.
- `Loc.Initialize()` — called by Plugin.Load(). Calls `Loc.RefreshLanguage()` internally.
- `Loc.RefreshLanguage()` — calls `YgomSystem.Utility.Locale.GetLanguage()` and maps locale: "fr-FR" → "fr", anything else → "en".
- `Loc.Verbose` — bool, mirrors `Plugin.Instance.CfgVerbose.Value`. Used to gate card description announcements.

### YGO locale detection via reflection

```csharp
// YgomSystem.Utility.Locale.GetLanguage() — public static string
// Returns: "ja-JP", "en-US", "fr-FR", etc.
var localeType = AccessToolsHelper.FindType("YgomSystem.Utility.Locale");
var getLangMethod = localeType?.GetMethod("GetLanguage",
    BindingFlags.Public | BindingFlags.Static);
string lang = getLangMethod?.Invoke(null, null) as string ?? "en-US";
```

### Adding localization strings

All strings are in `Loc.cs` in two dictionaries: `_en` and `_fr`. To add a new key:
1. Add to `_en`: `{ "my_key", "English text" }`
2. Add to `_fr`: `{ "my_key", "French text" }` (or same as English if not yet translated)
3. Use via `Loc.Get("my_key")` at the call site

### Game-side text

The game's own card names, descriptions, and effect text come from the `Content` singleton:
- `Content.Instance.GetName(cardId, false)` → card name (localized)
- `Content.Instance.GetDesc(cardId, false)` → card description (localized)
- `Content.Instance.GetRubyName(cardId, false)` → furigana name (Japanese only; use GetName elsewhere)

All three take `(int cardId, bool replaceAlnum)`. Always pass `false` for replaceAlnum.

## Card Zone Index Mapping

The game's FieldPostion values and their meaning:

Monster zones (local player):
- 0, 1, 2, 3, 4 — main monster zones (left to right)
- 5, 6 — extra monster zones (co-linked positions)

Spell/Trap zones (local player):
- 7, 8, 9, 10, 11 — spell/trap zones (left to right)
- 12 — field spell zone

Non-field zones:
- 13 — Hand
- 14 — Extra Deck (DeckEx)
- 15 — Main Deck
- 16 — Graveyard
- 17 — Banished (exclusion zone)
- 18 — Special / limbo (used during summon animations)

Note: opponent zones use the same position values but `team = 1`. When announcing zones, always combine team + position to distinguish sides.

## Key UI Classes (for text extraction)

When implementing new patches that extract text from UI, these are the relevant YGO classes:

### Card display
- `CardInfo` / `CardInfoBase` — card info panel. Fields: `m_CardName_Property` (RubyTextGX), `m_AtkValue_Property`, `m_DefValue_Property`, `m_LevelNum_Property`, `m_RankNum_Property`, `m_LinkNum_Property`, `m_DspTitle_Property`, `m_DspContent_Property`. All are TMP components: read `.text` via reflection.
- `CardInfoDetail` — extends `CardInfoBase`. Used in CardBrowser. Works with `CardInfoPatch.BuildAnnouncement`.
- `CardRoot` / `BindingDuelFieldCards` — runtime card on field. Has `cardId` (int), `team` (int), `position` (int at 0x94), `isFace` (bool), `atk` (int prop), `def` (int prop).

### Duel HUD
- `DuelLP` — life points bar. `ChangeLP(int afterLP, int damage)`, `SetLP(int lp)`. `m_IsNear` (bool): true = local player.
- `PhaseSelectWindow` — phase selector. `PhaseChange(...)`, `TurnChange(...)`.
- `DuelClient` — central duel controller. `RunEffect(int id, int p1, int p2, int p3)` static.

### Menus / Navigation
- `SelectionButton` — focusable button. `OnSelected()`, `OnPointerClick()`, `OnDeselected()`. Used everywhere in menus.
- `ViewController` — base for all screen controllers. `OnFocusChanged(bool)`, `OnBack()`.
- `ColorContainerGraphic` / `ColorContainerImage` — icon buttons. `SetColor(Color)`. `currentStatusMode` int property (mode 2 = hover/enter).
- `ScrollRectPageSnap` — paged scroll view. `hpage` int property = current page index.

### Dialogs
- `DuelConfirmDialog` — yes/no confirm in duel. `Open(...)` — 6-param and 4-param overloads.
- `DuelSelectDialog` — selection dialog in duel. `Open(...)`.
- `CommonDialogViewController` — general dialog.
- `FilterSelectViewController` — filter/toggle list. `OpenFilterSelect(title, entrys, ...)` static.
- `ActionSheetViewController` — contextual action sheet.

### Shop / Rewards
- `PvpMenuMatchingViewController` — matchmaking. `SetActiveView(View state)`. View: SEARCHING=0, MATCHING=1, TIMEOUT=2.
- `DuelPassRewardListViewController` — Duel Pass rewards.
- `PresentBoxViewController` — gift box.
- `LoginBonusViewController` — login bonus.

### Deck Builder
- `DeckEditViewController2` — deck editor. `StartCardAddEffect(CardBase)`, `RemoveFromDeck(...)` (4-param), `OnSubmitDeckName(string)`, `OnClickSaveButton()`, `OnFocusChanged(bool)`.
- `CardBrowserViewController` — card browser. `Start()`, `OnPageChanged(int)`. `SnapContentManager` → `currentPage` int.

## Game Data Source

- **Dump (IL2CppDumper stubs):** `dump/dump.cs` — all classes, method signatures, field offsets. Use for discovering types and method parameter lists.
- **Decompiled interop (AUTHORITATIVE for patching):** `decompiled/interop/Assembly-CSharp/[Namespace]/[ClassName].cs` — verify real method bodies here before implementing patches.
- **Workflow:** Search `dump/dump.cs` first for type/method names and parameter counts. Then open the matching file in `decompiled/interop/` to confirm the signature and understand the call context. NEVER guess names or parameters.

### Key namespaces in dump.cs

- (global / no namespace) — `SelectionButton`, `ViewController`, `Content`, `CardRoot`, `SelectStandOperation`, `DuelClient`, `CardCommand`, `CommandOperation`, `DuelLP`, `PhaseSelectWindow`, `DuelRitualDialog`
- `YgomGame.Duel` — `CommandOperation`, duel-specific VCs
- `YgomGame.CardBrowser` — `CardBrowserViewController`
- `YgomGame.DeckEdit` — `DeckEditViewController2`
- `YgomSystem.Utility` — `Locale`
- `YgomSystem` — `ViewController`, various system classes
- `Engine` — `SpSummonType`, `ResultType`, `CommandType`, `ViewType`

## Testing

No automated tests. Test by:
1. Build with `scripts/Build-Mod.ps1` (or `dotnet build -c Release` from `mod/MasterDuelAccessibility/`)
2. Launch Yu-Gi-Oh! Master Duel with NVDA running
3. Check log for errors: `C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\LogOutput.log`
4. Verify screen reader announcements for the feature under test

Log reading tips:
- `tail -f LogOutput.log` equivalent in PowerShell: `Get-Content LogOutput.log -Wait -Tail 50`
- Filter for mod output: `Select-String -Pattern "MasterDuel"` on the log

## Debugging

### Log location

`C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\LogOutput.log`

### What to look for

- `[Info   : MasterDuelAccessibility]` — mod log output (LogMsg)
- `[Warning: MasterDuelAccessibility]` — LogWarn (unexpected null, fallback taken)
- `[Error  : MasterDuelAccessibility]` — LogErr (patch exception, reflection failure)
- `[Error  : Harmony]` — patch application failed (wrong method name or signature)

### Common problems and fixes

- Patch not firing → check method name and parameter count in `dump/dump.cs`. Use `TryPatchByParamCount` for overloaded methods.
- Double announce → check dedup logic in `DuelEffectQueuePatch`. Add 200-300ms cooldown or exact-string dedup.
- Wrong announcement text → check if `Loc.Get()` key exists in both `_en` and `_fr` dictionaries in `Loc.cs`.
- Text missing → check whether text lives in a TMP child component rather than the direct component. Walk the hierarchy.
- IL2CPP reference equality broken → use `GetInstanceID()` instead of `==` or `ReferenceEquals`.
- `AccessTools.TypeByName` returns null → type may be in a nested class or have a different namespace. Search `dump.cs` for the class name.
- Slider/dropdown announces on every frame → ensure the cooldown or dedup is active. Check `sendCallback` flag for sliders.

### Dump a component's fields

```csharp
// Log all fields on an unknown component (use during development)
foreach (var field in componentType.GetFields(
    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
{
    var val = field.GetValue(component);
    Plugin.Instance?.LogMsg($"  {field.Name} ({field.FieldType.Name}) = {val?.ToString() ?? "null"}");
}
```

### Walk the TMP text hierarchy

```csharp
// Find all TMP text values in a GameObject subtree
static IEnumerable<string> CollectTmpTexts(GameObject go)
{
    var tmpType = AccessTools.TypeByName("TMPro.TMP_Text");
    if (tmpType == null) yield break;
    foreach (var comp in go.GetComponentsInChildren(tmpType, true))
    {
        var text = tmpType.GetProperty("text")?.GetValue(comp) as string;
        if (!string.IsNullOrWhiteSpace(text)) yield return text;
    }
}
```

## Known Limitations / TODO

### Patches needing verification

- `ActionSheetPatch`, `DeckBrowserPatch`, `DeckSelectPatch` — implemented but not yet confirmed in actual game flow
- `LotteryPortalPatch`, `LotteryRewardPatch` — seasonal content, difficult to test outside events
- `RoomViewControllerPatch` — room/lobby feature availability varies by region

### Known gaps

- CardBrowserPatch sequential navigation (`Shift+F3`, `Ctrl+F4`) resets on any non-shortcut key — no persistent cursor across key presses
- `Loc.Verbose` gates card descriptions globally — may need per-context control (e.g. verbose in deck builder, concise in duel)
- Opponent field sequential nav (`Ctrl+Shift+F4`) position state is separate from your field nav (`Ctrl+F4`) — both reset independently

### Key conflicts avoided

These keys conflict with game native shortcuts and are NOT used by the mod:
- Keys the game uses during duel that must not be intercepted: the game's own Tab (phase), arrow keys (UI nav), Enter (confirm), Escape (cancel)
- LeftControl / RightControl — blocked during duel only (NVDA silence key conflict), restored outside duel
- Space / Enter — blocked in input fields (InputBlockPatch), restored elsewhere
- Tab — blocked in Unity EventSystem (EventSystemPatch) to prevent spurious focus events, but routed through the mod's own phase-advance logic

### Localization gap

Currently only English (en) and French (fr) are supported. All other locales fall back to English. Japanese (ja-JP) would require a separate string table — not planned until needed.

---

# References

- `project_status.md` — central tracking (read first!)
- `docs/ACCESSIBILITY_MODDING_GUIDE.md` — code patterns
- `docs/technical-reference.md` — BepInEx, Harmony, Tolk
- `docs/unity-reflection-guide.md` — Reflection (Unity)
- `docs/state-management-guide.md` — multiple handlers
- `docs/localization-guide.md` — localization
- `docs/menu-accessibility-checklist.md` — menu checklist
- `docs/menu-accessibility-patterns.md` — menu patterns
- `docs/known-issues.md` — compatibility warnings
- `docs/game-api.md` — keys, methods, patterns
- `docs/distribution-guide.md` — packaging, publishing
- `docs/git-github-guide.md` — Git/GitHub intro
- `docs/FULL_COVERAGE_PLAN.md`
- `templates/bepinex/` — BepInEx-specific templates
- `templates/shared/` — mod-loader-independent templates
- `scripts/` — PowerShell helpers
