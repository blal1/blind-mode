# Menu Navigation

How the mod navigates and announces menus in Yu-Gi-Oh! Master Duel.

---

## Navigation Framework

The game uses a two-level UI system:

```
ViewController (screen-level)
  └─ SelectionButton (one per interactive element)
```

The mod patches both levels:

| Patch | Trigger | Action |
|-------|---------|--------|
| `ViewControllerPatch.OnFocusChanged` | Screen gains/loses focus | Announce menu name + set `GameState.CurrentMenu` |
| `ViewControllerPatch.OnBack` | Back button / Escape | Announce "Back" |
| `SelectionButtonPatch.OnSelected` | Element focused | Context-aware announcement (see below) |
| `SelectionButtonPatch.OnDeselected` | Element loses focus | (reserved, currently unused) |
| `SelectionButtonPatch.OnPointerClick` | Element clicked | Update `CurrentMenu` state, schedule delayed card read |

---

## Position Tracking (GeneralMenuNavigator)

Every `OnSelected` announcement is automatically appended with ", N of M" (e.g., ", 3 of 7").

**How it works:**
1. Walk the transform hierarchy from the button to its parent
2. Count all **active** siblings that have a `SelectionButton` component
3. Return the 1-based `(index, total)` — omit if `total <= 1`

Uses `GetInstanceID()` for IL2CPP-safe identity comparison.

---

## Context-Aware SelectionButton Announcements

The dispatcher in `SelectionButtonPatch.OnSelected_Postfix` checks `GameState.CurrentMenu` and routes to the appropriate processor:

### Menu.None (main lobby and unrecognized screens)

Processors tried in order:
1. `ProcessNotificationsPopup` — notification bell popup
2. `ProcessFriendsMenu` — add friend button
3. `ProcessProfile` — "{name}, level {n}"
4. `ProcessEventBanner` — "Event banner"
5. `ProcessTopicsBanner` — "News, page {n}" (reads `ScrollRectPageSnap.hpage`)
6. Default — reads all text children of the button

### Menu.Notifications

- Reads notification title + optional status label

### Menu.Missions

- Walks 9 levels up to find mission name
- Reads reward text and time remaining
- Format: "{name}\nReward: {reward}\nTime left: {time}"

### Menu.Shop

- `ProcessPacks` — reads pack name, category, expiry, price
- `ProcessCardPack` (name="CardPict") — reads rarity + new/owned counts

### Menu.Settings

- Detects sliders (`Slider.value / maxValue`) and mode steppers (`ModeText` child)
- Format: "{label}\nValue: {n} of {max}" or "{label}: {mode}"

### Menu.DuelPass

- Reads pass type (Normal/Gold) + grade + quantity

### Menu.Deck

- `ProcessNewDeck` — "New deck" when the icon-add-deck button is active
- `ProcessDecksMenu` — deck name from hierarchy

### Menu.Duel / Menu.Solo

- `ProcessDuelGame` — detects `Anchor_` (terrain card) vs `HandCard`
- `ProcessDuelMenu` — duel action menu (6-ancestor depth check or "Main" child)

---

## ColorContainerPatch (Icon Buttons)

Some buttons in Master Duel use `ColorContainerGraphic` or `ColorContainerImage` instead of `SelectionButton` — typically icon-only buttons with no text label.

**Trigger:** `SetColor(Color)` is called with `currentStatusMode == 2` (hover/focus state).

**Actions by button type:**
- `DuelListCard` — click its SelectionButton via reflection → `CardInfoPatch` announces the card
- `Button0` / `Button1` — direction buttons; reads parent label + "ascending/descending"
- `ChapterDuel(Clone)` — chapter duel star count from child[4]
- `DismantleButton` / `CreateButton` — reads CP cost from child[6]
- Default — reads all text children of the button hierarchy

---

## Card Browser Navigation

Patched via `CardBrowserPatch`:

| Event | Action |
|-------|--------|
| `Start` | Capture `SnapContentManager` reference; schedule first-card read in 0.8s |
| `OnPageChanged` | Schedule card read in 0.3s (debounce scroll) |
| Alt key | `ReadCurrentCard` → finds `CardInfoDetail_Browser(Clone)` at page slot and calls `CardInfoPatch.BuildAnnouncement` |

---

## Deck Editor Navigation

Patched via `DeckEditPatch`:

| Method | Announcement |
|--------|-------------|
| `StartCardAddEffect` | "{card name} added to deck." |
| `RemoveFromDeck` (4-param) | "{card name} removed from deck." |
| `OnSubmitDeckName` | "Deck renamed: {name}." |
| `OnClickSaveButton` | "Deck "{name}" saved." |
| `OnFocusChanged(setfocus=true)` | "Editing deck: {name}." |

---

## Matchmaking Screen

Patched via `MatchingPatch` on `PvpMenuMatchingViewController.SetActiveView(View state)`:

| State | Announcement |
|-------|-------------|
| SEARCHING=0 | "Searching for an opponent…" |
| MATCHING=1 | "Opponent found! Preparing duel." |
| TIMEOUT=2 | "Search timed out." |

---

## Duel Action Menu (CardCommandPatch)

Announces available actions when `RunCommand` fires (ViewType=67, param1=`Engine.CommandBit` bitmask):

- Attack, Activate Effect, Special Summon, Normal Summon, Flip, Set Monster, Set Spell/Trap, Pendulum, Attack Position, Defense Position, View, Surrender

Format: "Actions: Attack, Activate Effect" (only set bits announced).
