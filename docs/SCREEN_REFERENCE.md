# YGO Master Duel — Screen Reference

Quick reference for every screen and overlay handled by the mod.
For coding patterns see [BEST_PRACTICES.md](BEST_PRACTICES.md).
For duel event IDs see [EVENTS.md](EVENTS.md).

---

## Global Patches (active in every scene)

These patches fire regardless of which screen is active.

### SelectionButton Focus — `SelectionButtonPatch`
**Trigger:** `SelectionButton.OnSelected` / `OnPointerClick` / `OnDeselected`
**Priority:** base layer — all menu screens build on this

Every focusable menu element is a `SelectionButton`. The patch reads its text content and dispatches to the appropriate context processor (see Main Menu Screens below).

Position tracking is added automatically by `GeneralMenuNavigator`:
- Walks up the transform hierarchy to count active siblings with `SelectionButton`
- Appends ", N of M" when total > 1 (e.g., "Attack, 3 of 5")
- Uses `GetInstanceID()` for IL2CPP-safe comparison

### Icon Buttons — `ColorContainerPatch`
**Trigger:** `ColorContainerGraphic.SetColor` / `ColorContainerImage.SetColor`
**Condition:** `currentStatusMode == 2` (hover/Enter state, read via reflection on base class)

Icon-only buttons that have no `SelectionButton`. Dispatched by object name:

| Button name pattern | Announcement |
|---|---|
| `DuelListCard` | Clicks its own `SelectionButton` → triggers `CardInfoPatch` |
| `Button0` | `{parentLabel}, ascending` |
| `Button1` | `{parentLabel}, descending` |
| `ChapterDuel(Clone)` | Reads star count from `child[4]` at level-2 ancestor |
| `DismantleButton` / `CreateButton` | Reads CP cost from `child[6]` at level-2 ancestor |
| Default | Recursively collects all `TMP_Text` children |

### Screen Navigation — `ViewControllerPatch`
**Trigger:** `ViewController.OnFocusChanged(bool setfocus)` / `OnBack()` / `ShowUI()`

- `OnFocusChanged(true)` → looks up the ViewController's `name` property in `ScreenTitles` dict, announces friendly name, updates `GameState.CurrentMenu`
- `OnBack()` → detects return to `Home`, resets `GameState.CurrentMenu = None`
- `ShowUI()` → announces secondary views not covered by `OnFocusChanged` (1.5s cooldown dedup)

**ScreenTitles dictionary (ViewController name → Loc key):**

Names follow the Unity `GameObject.name` pattern = class name minus `ViewController` suffix.

**Fallback (unknown names):** `ResolveName` strips `ViewController`/`Dialog`/`Widget` suffix then converts PascalCase to words: `"LotteryPortalViewController"` → `"Lottery Portal"`.

| ViewController name | Loc key | Screen |
|---|---|---|
| `DUEL` | `screen_duel` | Duel menu |
| `DECK` | `screen_deck` | Deck management |
| `SOLO` | `screen_solo` | Solo mode |
| `SHOP` | `screen_shop` | Shop |
| `MISSION` | `screen_missions` | Missions |
| `Notifications` | `screen_notifications` | Notifications |
| `Game Settings` | `screen_settings` | Settings |
| `Duel Pass` | `screen_duel_pass` | Duel Pass |
| `DeckBrowser` | `screen_deck_browser` | Deck browser |
| `DeckEdit` | `screen_deck_edit` | Deck editor |
| `CardBrowser` | `screen_card_browser` | Card browser |
| `DeckSelect` | `screen_deck_select` | Deck selection |
| `PvpMenuMatching` | `screen_matching` | Matchmaking |
| `PvpMenuMatching_Room` | `screen_matching_room` | Room matchmaking |
| `PvpMenuMatching_Team` | `screen_matching_team` | Team matchmaking |
| `Home` | `screen_home` | Home |
| `ShopBuy` | `screen_shop_buy` | Shop — Purchase |
| `LotteryPortal` | `screen_lottery` | Open Packs |
| `LotteryResult` | `screen_lottery_result` | Pack Opening Result |
| `LotteryHistory` | `screen_lottery_history` | Pack History |
| `LotteryCardSelect` | `screen_lottery_card_select` | Card Selection (Lottery) |
| `LotteryRewardView` | `screen_lottery_reward` | Pack Reward |
| `PresentBox` | `screen_present_box` | Gift Box |
| `Profile` | `screen_profile` | Profile |
| `ProfileData` | `screen_profile` | Profile (data sub-view) |
| `ProfileEdit` | `screen_profile_edit` | Edit Profile |
| `ProfileCardCheck` | `screen_profile_cards` | Favorite Cards |
| `ProfileReplay` | `screen_profile_replay` | Profile Replays |
| `Friend` | `screen_friends` | Friends |
| `FriendSearch` | `screen_friends_search` | Search Friend |
| `SoloGate` | `screen_solo_gate` | Solo Gates *(verify in-game)* |
| `SoloSelectChapter` | `screen_solo_chapter` | Solo Chapters *(verify in-game)* |
| `SeasonPoint` | `screen_season_ranking` | Season Ranking |
| `SeasonPointHistory` | `screen_season_history` | Season History |
| `SeasonPointRanking` | `screen_season_ranking` | Season Ranking |
| `SeasonPointTopMenu` | `screen_season_ranking` | Season Top Menu |
| `SeasonResult` | `screen_season_result` | Season Results |
| `ItemExchange` | `screen_item_exchange` | Item Exchange |
| `ColosseumDuelResult` | `screen_colosseum_result` | Colosseum Result |
| `WCSFinal_Colosseum` | `screen_colosseum` | Colosseum |
| `SortDialog_Card` | `screen_sort_card` | Sort cards |
| `SortDialog_CardFile` | `screen_sort_cardfile` | Sort |
| `SortDialog_Solo` | `screen_sort_solo` | Sort Solo |
| `FilterSelect` | `screen_filter_select` | Filter selection |
| `PasswordDialog` | `screen_password` | Password entry *(verify in-game)* |

### Card Detail Panel — `CardInfoPatch`
**Trigger:** `CardInfo.SetDescriptionArea(…)`
**Condition:** Card info panel becomes visible (e.g., hover, Alt shortcut, CardBrowser scroll)

Reads from `CardInfoBase` fields via reflection on the type hierarchy:
- `m_CardName_Property` (RubyTextGX) → card name
- `m_LevelNum_Property` / `m_RankNum_Property` / `m_LinkNum_Property` → level/rank/link
- `m_AtkValue_Property` / `m_DefValue_Property` → ATK/DEF
- `m_DspTitle_Property` (type/archetype line)
- `m_DspContent_Property` → effect text (only when `Loc.Verbose` is true)

Format: `"{name}. Level {n}. ATK {atk} DEF {def}. {typeText}. {effectText}"`

### Text Fields — `InputFieldPatch`
**Trigger:** `TMP_InputField.OnSelect` / `OnDeselect`
- On select: announces field label + current content (or "— empty" if blank)
- On deselect: announces "Exited text field."
- Password fields: never read content, only "has N characters"

### Toggles — `TogglePatch`
**Trigger:** `UnityEngine.UI.Toggle.Set(bool, bool)`
- Announces "{label}: On/Off" using the sibling `TMP_Text` as label

### Sliders — `SliderPatch`
**Trigger:** `UnityEngine.UI.Slider.Set(float, bool sendCallback)`
**Condition:** `sendCallback = true` only, 150ms cooldown
- Finds label from nearest sibling `TMP_Text` in parent hierarchy
- Announces "{label}: {value}" (integer or % depending on range)

### Dropdowns — `DropdownPatch`
**Trigger:** `TMP_Dropdown.Show()` / `set_value(int)`
- `Show()` → "{label}: {currentOption}" (opening announcement)
- `set_value()` → "{option}, {N} of {total}" (selection announcement)
- 200ms dedup between Show and set_value to avoid double-announce

### Keyboard Input Blocking — `InputBlockPatch` + `EventSystemPatch`
- `InputBlockPatch` intercepts `Input.GetKeyDown`: blocks Left/RightControl (NVDA silence key) during duel, Space/Enter when a text field is focused, Escape when `InputBlockPatch.BlockEscape` is set
- `EventSystemPatch` patches `StandaloneInputModule.SendMoveEventToSelectedObject`: suppresses Tab in Unity's EventSystem to prevent spurious focus jumps

---

## Main Menu Screens

All main menu screens share `SelectionButtonPatch` as base. The dispatcher reads `GameState.CurrentMenu` and routes to the correct processor.

### Home Screen (`Menu.None`)

Processors tried in order when `CurrentMenu == None`:

1. **ProcessNotificationsPopup** — notification bell popup (6 ancestors = `NotificationWidget`)
2. **ProcessFriendsMenu** — `SearchButton` → "Add friend"; `OpenToggle` → friend name
3. **ProcessProfile** — `ButtonPlayer` → "{name}, level {n}" (child hierarchy walk)
4. **ProcessEventBanner** — `DuelShortcut` → "Event banner"
5. **ProcessTopicsBanner** — `ButtonBanner` → "News, page {n}" via `ScrollRectPageSnap.hpage`
6. Default — recursively reads all `TMP_Text` children

### Notifications Screen (`Menu.Notifications`)

- Reads `TextBody` child for notification text
- If `BaseCategory` is active, appends "\nStatus: {category text}"

### Missions Screen (`Menu.Missions`)

- Detects `name == "Locator"`, walks 9 ancestors to reach mission root
- Reads mission name, reward (child[0][2]), and time remaining (ancestor[1][0][3][0])
- Format: `"{name}\nReward: {reward}\nTime left: {time}"`

### Shop Screen (`Menu.Shop`)

**Pack browser:**
- `ProcessPacks` — fires when `parent.name.Contains("Shop")`
- Collects all texts via `CollectAllTexts()`, finds by key: `PickupMessage`, `Name`, `New`, `Limit`, `PriceGroup`
- Format: `"{pickup} - {name} ({new})\nCategory: {cat}\nExpires: {limit}\nPrice: {price}"`

**Card pack opening:**
- `ProcessCardPack` — fires when `name == "CardPict"`
- Reads rarity sprite name (last digit → enum), new/owned state
- Format: `"Rarity: {rarity}. New: {yes/no}. Owned: x{n}"`

**Craft dialogs:** see Card Craft section below.

### Settings Screen (`Menu.Settings`)

- Skips `CancelButton`, `Layout`, `EntryButtonsScrollView`
- Reads `Slider.value / maxValue` or `ModeText` child text
- Format slider: `"{label}\nValue: {n} of {max}"`
- Format mode: `"{label}: {mode}"`

### Duel Pass Screen (`Menu.DuelPass`)

- Fires on `name.Contains("passRewardButton")`
- Reads pass type (Normal/Gold from name), grade (parent.parent text), quantity
- Format: `"{type} pass, grade {grade}, quantity: {qty}"`

### Deck Browser Screen

**Patch:** `CardBrowserPatch` on `CardBrowserViewController`

| Event | Action |
|---|---|
| `Start` | Capture `SnapContentManager`; schedule first-card read at +0.8s |
| `OnPageChanged` | Schedule card read at +0.3s (debounce on scroll) |
| Alt key | `ReadCurrentCard()` → path `Template(Clone){page%3}/CardInfoDetail_Browser(Clone)` → `CardInfoPatch.BuildAnnouncement()` |

**Technical notes:**
- `SnapManager` static reference to captured `SnapContentManager`
- `GetCurrentPage()` reads `currentPage` (public int field)
- `IsActive()` checks `transform.gameObject.activeInHierarchy`
- Fallback: searches for both `"CardInfo"` and `"CardInfoDetail"` in scene if path fails

### Deck Editor Screen

**Patch:** `DeckEditPatch` on `DeckEditViewController2`

| Method | Announcement |
|---|---|
| `StartCardAddEffect(cardBase)` | "{cardName} added to deck." |
| `RemoveFromDeck` (4-param) | "{cardName} removed from deck." |
| `OnSubmitDeckName(deckName)` | "Deck renamed: {name}." |
| `OnClickSaveButton` | "Deck "{m_DeckName}" saved." |
| `OnFocusChanged(setfocus=true)` | "Editing deck: {name}." |

**Card name resolution:** reads `m_BaseData.CardID` from `CardBase`, calls `AccessToolsHelper.GetCardName(cardId)` via `Content.Instance.GetName(id, false)`.

### Deck Selection Screen

**Patch:** `DeckSelectPatch` on `DeckSelectViewController2.OnFocusChanged`

On focus gain, reads via reflection:
- `m_SelectMode` (protected field) → maps int to mode label (17 modes: Default=0, Ranked=1, PVE=2, Tournament=3, Solo=4, Room=5, Exhibition=6, Free=8, Cup=9, WCS=10, …)
- `m_Decks` list → `get_Item(selectedIndex)` → `DeckReference.name`
- Selected index from `lastSet` private field (fallback: 0)

Format: `"{mode} — Selected deck: {deckName}"`

### Matchmaking Screen

**Patch:** `MatchingPatch` on `PvpMenuMatchingViewController.SetActiveView(View state)`

| View enum | Announcement |
|---|---|
| SEARCHING=0 | "Searching for an opponent…" |
| MATCHING=1 | "Opponent found! Preparing duel." |
| TIMEOUT=2 | "Search timed out." |

`View` is a global namespace enum; `state` injected as `object`, cast via `Convert.ToInt32`.

### Card Craft Dialog

**Patch:** `CardCraftPatch` on `CardCraftDialog.Open` (5 params, positional injection)
- `__1` = `CraftMode` (int), `__2` = `cardID` (int)
- Announces: "Create: {cardName}" or "Dismantle: {cardName}" based on mode

**Patch:** `CardCraftResultPatch` on `CardCraftResultDialog.GetResultMessage`
- Postfix reads the return value (already-localized string from the game)
- Announces the result message directly

### Filter Select Dialog

**Patch:** `FilterSelectViewPatch` on `FilterSelectViewController.OpenFilterSelect`
**Applied in:** `Plugin.ApplyPatches` (static method, no scene restriction)

Parameters (positional injection): `__0`=title, `__1`=entrys array, `__4`=message

- Iterates `EntryData[]` via `IEnumerable`, reads `text` (string at 0x10) and `isOn` (bool at 0x28) via reflection
- Announces: "Filters: {title}" then each filter as "{label} (active/inactive)"

### Number Selector — `InputDigitViewPatch`

**Patch:** `InputDigitViewController.OnCreatedView` / `OnValueAdded`
- `OnCreatedView` → "Selection: {init}. Min {min}, max {max}." (with title if available)
- `OnValueAdded` → announces new value digit by digit

### Solo Mode

**Announced by:** `MenuMiscPatch.SoloModeViewController_Open_Postfix`
- Simply announces "Solo Mode." on screen open
- Covers `SoloModeViewController.Open`

### Generic Dialogs — `CommonDialogPatch`

**Applied in:** `Plugin.ApplyPatches` (global, all scenes)
**Target:** `YgomGame.Menu.CommonDialogViewController` static methods

All variants share signature `Open*Dialog(string title, string message, …)`. A single postfix reads `__0`=title and `__1`=message and announces:
- Both present → `"{title}: {message}"` (`dialog_title_message` key)
- Only title → title alone
- Only message → message alone

| Method patched | Typical use |
|---|---|
| `OpenAlertDialog` | Informational alert (OK only) |
| `OpenAlertDialogScroll` | Long-text alert |
| `OpenConfirmationDialog` | "Confirm?" (OK + Cancel) |
| `OpenConfirmationDialogScroll` | Long-text confirmation |
| `OpenConfirmationPartDialog` | Partial confirmation |
| `OpenErrorDialog` | Network / system error |
| `OpenYesNoConfirmationDialog` | Yes/No choice |
| `OpenYesNoConfirmationDialogScroll` | Long-text Yes/No |
| `OpenNoticeYesNoDialog` | Notice with Yes/No |
| `OpenCheckBoxDialog` | Checkbox list selection |
| `OpenItemConfirmDialog` (7-param) | Item purchase confirmation |
| `OpenItemConfirmDialog` (9-param) | Item purchase confirmation (with period/category) |

---

## Duel Scene

Duel patches are applied dynamically at scene load via `LatePatches.ApplyDuelScenePatches()`, triggered by `SceneManager.sceneLoaded` in `PluginBehaviour`.

### Life Points — `DuelHudPatch`

**Trigger:** `DuelLP.ChangeLP(int afterLP, int damage)` / `SetLP(int)`

- Player detection: `m_IsNear` (NonPublic bool) — true = local player, false = opponent
- `ChangeLP`: damage > 0 → damage announcement; damage < 0 → gain announcement
- `SetLP`: initialization announcement (start of duel)
- Tracks `GameState.MyLP` / `GameState.OppLP` for Shift+Space shortcut

### Phases and Turns — `PhasePatch`

**Trigger:** Delegated via `DuelEventPatch` (ViewType=5 TurnChange, ViewType=6 PhaseChange)

| ViewType | Announcement |
|---|---|
| TurnChange (5) | "Your turn, turn N." or "Opponent's turn, turn N." |
| PhaseChange (6) | Phase name (Draw/Standby/Main 1/Battle/Main 2/End) |

`GameState.CurrentTurn` incremented on each TurnChange; reset on DuelStart.

### Duel Events — `DuelEventPatch`

**Trigger:** `DuelClient.RunEffect(int id, int param1, int param2, int param3)`
Postfix receives `(int __0, int __1)` = ViewType, subtype param.

All ViewType IDs are from `Engine.ViewType` in the dump. Full list in `DuelEventPatch.cs`.

| ViewType | Name | param | Announcement |
|---|---|---|---|
| 1 | DuelStart | — | "Duel started!" (in `DuelStart_Postfix`) |
| 2 | DuelEnd | ResultType: 1=Win,2=Lose,3=Draw,4=Time | Victory / Defeat / Draw / Time *(critical)* |
| 5 | PhaseChange | phase int | Draw/Standby/Main1/Battle/Main2/End — delegated to `PhasePatch` |
| 6 | TurnChange | turn int | "Your turn / Opponent's turn, turn N" — delegated to `PhasePatch` |
| 12 | BattleAttack | — | Delegated to `DuelAttackPatch` |
| 19 | HandShow | — | "Hand revealed." |
| 26 | CardMove | moveType | Search(11), Discard(10), CostDrop(17); Draw(9) skipped (CutinDraw covers it) |
| 28 | CardFlipTurn | — | "Card flipped face-down." |
| 34 | CardExclude | — | "Card banished." |
| 36 | CardDisable | — | "Effect negated." |
| 37 | CardEquip | — | "Equip spell activated." |
| 45 | TributeRun | — | "Tribute Summon!" |
| 48 | MaterialRun | — | "Materials used." (fusion/synchro/xyz) |
| 51 | TuningRun | — | "Synchro Summon!" |
| 52 | ChainSet | — | "Chain started." |
| 53 | ChainRun | — | "Chain resolving." |
| 54 | RunSurrender | — | "Surrender." *(critical)* |
| 55 | RunDialog | — | Delegated to `DuelDialogPatch` |
| 56 | RunList | — | Delegated to `DuelDialogPatch` |
| 57 | RunSummon | — | "Monster summoned." |
| 58 | RunSpSummon | SpSummonType: 0=Fusion,1=SpFusion,2=Synchro,3=Ritual,4=Xyz,5=Pendulum,6=Link,7=Maximum | Type-specific summon name |
| 59 | RunFusion | — | "Fusion Summon!" |
| 60 | RunDetail | — | Delegated to `CardInfoPatch` |
| 61 | RunCoin | — | "Coin flip." *(critical)* |
| 62 | RunDice | — | "Dice roll." *(critical)* |
| 64 | RunSpecialWin | — | "Special win condition!" *(critical)* |
| 68 | CutinDraw | — | "Draw." |
| 69 | CutinSummon | — | "Summon!" |
| 70 | CutinFusion | — | "Fusion!" |
| 71 | CutinChain | — | "Chain response." |
| 72 | CutinActivate | — | "Effect activated!" |
| 73 | CutinSet | — | "Spell/Trap set." |
| 74 | CutinReverse | — | "Flip!" |
| 76 | CutinFlip | — | "Flip Summon!" |
| 77 | CutinTurnEnd | — | "Turn ended." |
| 78 | CutinDamage | — | "Battle damage." |
| 79 | CutinBreak | — | "Destroyed!" |
| 80 | CpuThinking | — | "Opponent is thinking." *(critical)* |
| 84 | OverlayRun | — | "Xyz Summon!" |
| 85 | CutinSuccess | — | "Effect resolved." |
| 86 | ChainEnd | — | "Chain end." |
| 89 | LinkRun | — | "Link Summon!" |
| 90 | RunJanken | — | "Rock-Paper-Scissors." *(critical)* |
| 92 | ChainStep | — | "Chain step." |

*(critical)* = `interrupt: true`; others use `interrupt: false` (queued).

`DuelEffectQueuePatch` deduplicates rapid events:
- `InstantMessage.ReqOpen` → 300ms dedup on identical text
- `RunEffectWorker.infoMessage` setter → exact-string dedup

### Dialogs — `DuelDialogPatch` + `DuelMiscPatch` + `DuelInfoDialogPatch`

| Class / Method | Applied | Announcement |
|---|---|---|
| `DuelConfirmDialog.Open` (6-param) | `Plugin.ApplyPatches` | Confirmation prompt text |
| `DuelConfirmDialog.Open` (4-param) | `Plugin.ApplyPatches` | Confirmation prompt text |
| `DuelSelectDialog.Open` | `DialogStatePatch.Initialize` | Selection dialog title |
| `ChoiceFirstPlayerDialog.ReqOpen` | `LatePatches` | "You go first." / "Opponent goes first." (`__1`=firstPlayer) |
| `DuelOkDialog.Open` (3-param) | `LatePatches` | Passes `__0` (pre-localised string) as interrupt |
| `DuelMulliganDialog.Open` | `LatePatches` | "Mulligan: N cards. Keep or replace?" |
| `DuelResultDialog.Open` | `LatePatches` | "Victory!" / "Defeat." / "Draw." |
| `DuelInfoDialog.ReqOpen` (8-param) | `LatePatches` | Passes `__0` (message) as interrupt; used for informational overlays during card effects |

### Attack Declaration — `DuelAttackPatch`

**Trigger:** `DuelClient.InvokeDecideAttackTarget(int attackerTeam, int attackerPos, int targetTeam, int targetPos)`

- Reads card names and ATK via `AccessToolsHelper.GetCardNameAndAtkAt(team, pos)`
- With ATK: `"{attacker} (ATK {a}) attacks {target} (ATK {t})!"`
- Direct attack (targetPos not on field): `"{attacker} (ATK {a}): direct attack!"`
- Fallback to name-only format if ATK returns -1

### Duel Action Menu

**Phase 1 — Menu opened:** `CardCommandPatch` on `CardCommand.Open` (6 params)
- Reads `CommandBit` bitmask from `__5` param
- Announces: "Actions: Attack, Activate Effect, …" (only set bits)
- Fires with `interrupt: false` to queue after card name

**Phase 2 — Navigation:** `CommandOperationPatch` on `CommandOperation.SetCursor(int index)`
- Reads `commandList` (private `List<Engine.CommandType>`) via reflection
- Announces: "{commandName}, {index+1} of {total}"
- `Engine.CommandType`: Attack=0, Look=1, SummonSp=2, Action=3, Summon=4, …, Surrender=11

### Cursor on Field — `DuelCursorPatch`

**Trigger:** `RunEffectWorker.OnCursorEnter(int team, int position, int viewIndex)` (200ms cooldown + dedup)

- Calls `GetCardNameAndAtkAt(team, position)` → if card present: `"{name} ATK {atk} — {your/opp} {zone}"`
- Empty zone: `"{your/opp} {zone} — empty"`

**Trigger:** `RunEffectWorker.OnSelectField(int team, int position, int viewIndex)` (no cooldown — deliberate confirm action)
- Announces: `"Target: {name} ATK {atk}"` or `"Zone selected: {zone}"`

Zone name resolution (CardRoot position → `zone_*` loc key):
- 0-4 → Monster Zone 1-5
- 5-6 → Extra Monster Zone 1-2
- 7-11 → Spell/Trap Zone 1-5
- 12 → Field Spell Zone
- 13 → Hand, 16 → Graveyard, 17 → Banished Zone

### Card Selection Lists — `CardSelectionListPatch`

**Trigger:** `CardSelectionList.SetList(…)` / `SetCursor(int index)`

- `SetList` → "Card selection — {type}: {count} card(s) available."
- `SetCursor` → "{cardName}, {index+1} of {total}"

Selection types (`Engine.CardSelectionListType`): Summon, SpSummon, MonsterEffect, MagicTrap, Flip, Attack, Chain, CheckTiming, Normal, Selection, Grave, Extra, Deck, OppHand, Generic.

### Special Summon Zone Placement — `SelectStandOperationPatch`

**Trigger:** `SelectStandOperation.BeginSpSummon(StandType, int, Action, Vector2, Status, ZoneMode)`
**Applied in:** `LatePatches`

Reads after call via reflection: `zoneMode` (public) and `standType` (private):

| ZoneMode | Announcement |
|---|---|
| SelectStand=0 | "Choose a summon zone." |
| DecidePosition=1 | Type-specific position prompt based on `StandType` |

StandType position prompts:
- `FaceAttackFaceDefense` → "Choose: Face-up Attack or Face-up Defense."
- `FaceAttackBackDefense` → "Choose: Face-up Attack or Face-down Defense."
- `FaceDefenseBackDefense` → "Choose: Face-up Defense or Face-down Defense."
- `All` → "Choose: Face-up Attack, Face-up Defense, or Face-down Defense."

### Monster Position Selection — `CardCommandExPatch`

**Trigger:** `CardCommandEx.Open(int cardID, int, Vector3)` — 3-param overload
**Applied in:** `LatePatches`

- `__0` = cardID → `AccessToolsHelper.GetCardName(cardId)`
- Reads `buttons` (NonPublic array) via reflection → checks `root.gameObject.activeInHierarchy`
- Maps `battlePosition` (int) to position label: 0=Face-Up Attack, 1=Face-Up Defense, 2=Face-Down Defense
- Announces: `"Position for {cardName}: {pos1}, {pos2}, …"`

### Pulldown Dialog — `DuelPullDownDialogPatch`

**Trigger:** `DuelPullDownDialog.Open(string message, List<string> selectionList, int selectNum, Action, Action)` — 5-param
**Applied in:** `LatePatches`

- `__0` = prompt message, `__1` = selectionList (via IEnumerable), `__2` = selectNum
- Iterates list via IEnumerable reflection to collect option strings
- Announces: `"{prompt} — Select {n}: {opt1}, {opt2}, …"`

### Ritual Summon Dialog — `DuelRitualDialogPatch`

**Trigger:** `DuelRitualDialog.Begin(string message, DialogRitualType type, int remainNum, int maxNum)` / `SetCount(int remainNum)`
**Applied in:** `LatePatches`

- `Begin` → full announcement: message + unit (levels/ATK/markers) + remaining/max
- `SetCount` → progress update: "Remaining: {n}." or "Ready to summon!" when remainNum ≤ 0
- `DialogRitualType` determines unit: Level, Atk, Link

### Timer — `DuelTimerPatch`

Turn timer alerts (announced once per threshold crossing):
- 60s remaining → "Warning: 60 seconds remaining."
- 30s remaining → "Warning: 30 seconds — turn ending soon."
- 10s remaining → "URGENT: 10 seconds!"

Duel clock alerts (total duel time):
- 2 minutes → "Warning: 2 minutes remaining in the duel."
- 1 minute → "Warning: 1 minute remaining in the duel."
- 30 seconds → "URGENT: 30 seconds in the duel!"

### Dice and Coin — `DuelMiscPatch`

**Trigger:** `DuelView.OnDiceResult(int player, int value)` / `OnCoinResult(int player, int side)`
**Applied in:** `LatePatches`

- `__0` = player (0=local, 1=opponent), `__1` = dice value or coin side (0=heads, 1=tails)
- Dice: "Dice: you/opponent — {value}"
- Coin: "Coin flip: you/opponent — heads/tails"

Note: `DuelEventPatch` also fires for `RunCoin=61` and `RunDice=62` with a generic "Coin flip." / "Dice roll." announcement. These fire at the start of the animation; `DuelMiscPatch` fires with the actual result.

---

## Keyboard Shortcuts Reference

All shortcuts registered in `KeyboardShortcuts.Awake()` via `ShortcutRegistry`.

| Key | Context | Action |
|---|---|---|
| F1 | Anywhere | Read active shortcuts (auto-generated from registry) |
| F2 | Anywhere | Repeat last announcement |
| F3 | Duel | Read all hand cards |
| Shift+F3 | Duel | Next hand card (cycle) |
| F4 | Duel | Read own field cards |
| Shift+F4 | Duel | Read opponent field cards |
| Ctrl+F4 | Duel | Next own field card (cycle) |
| Ctrl+Shift+F4 | Duel | Next opponent field card (cycle) |
| F5 | Anywhere | Silence TTS |
| F6 | Duel | Read own graveyard |
| F7 | Duel | Read own banished cards |
| Ctrl+F7 | Duel | Read opponent banished cards |
| F8 | Duel | Read own Extra Deck |
| Ctrl+F8 | Duel | Read opponent Extra Deck size |
| F9 | Duel | Read opponent graveyard |
| F10 | Duel | Read deck sizes (both) |
| F11 | Duel | Read opponent hand count |
| F12 | Anywhere | Browse announcement history (each press: one step back) |
| Space | Duel | Read LP (both players) |
| Shift+Space | Duel | Duel status (turn + phase + LP) |
| Alt | Anywhere | Read focused card info |
| Tab | Duel | Advance phase / pass priority (`PhaseSelect3D` via FindObjectsOfType) |

ShortcutRegistry processes in registration order. Modifier-specific shortcuts must be registered before catch-all (null modifier) shortcuts.

---

## Screen Detection Pattern

All patches detect their screen via the patched method itself — no polling required. Secondary screens use `ViewController.name` read via reflection in `ViewControllerPatch`.

For new screens that don't use `ViewController`:
```csharp
// Pattern: check active scene + active GameObject
var go = GameObject.Find("UI/ContentCanvas/ContentManager/TargetScreen");
if (go == null || !go.activeInHierarchy) return;
```

## Adding Support for a New Screen

1. Find the controller class in `decompiled/interop/Assembly-CSharp/` or `dump/dump.cs`
2. Identify the method that fires on open (typically `Open`, `Start`, `OnCreatedView`, `OnFocusChanged`)
3. Check if `ViewControllerPatch.Show_Postfix` already announces it:
   - If the screen uses `ViewController.ShowUI()`, it is already announced (PascalCase auto-cleaner)
   - If the name is not user-friendly, add it to `ScreenTitles` with a Loc key
4. If extra data (title, message, list) needs announcing:
   - Duel scene only → add `TryPatchPostfix` in `LatePatches.ApplyDuelScenePatches()`
   - All scenes → add `TryPatch` / `TryPatchByParamCount` in `Plugin.ApplyPatches()`
5. Add Loc keys: `Add("key", fr, en)` in `InitializeStrings()` and `_german["key"] = "…"` in `InitializeGermanStrings()`
6. Document the new screen in this file (VC name, method, param injection, field names used)

**Naming convention:** `ScreenTitles` key = class name minus `ViewController`/`Dialog`/`Widget` suffix.
For unknown names, `ResolveName` auto-cleans PascalCase (e.g., `FriendSearchViewController` → `"Friend Search"`).
