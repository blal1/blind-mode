# Known Issues

Active bugs, limitations, and planned work for MasterDuelAccessibility.

---

## Active Bugs

### ATK/DEF reads wrong value after card effect

When a monster's ATK/DEF changes mid-duel (e.g., Limiter Removal, Honest), the `atk`/`def` properties on `CardRoot` may not immediately reflect the new value for the frame the patch fires. The F4 field read shows the updated value correctly (called later), but attack announcements via `DuelAttackPatch` might occasionally show the pre-effect ATK.

---

### Face-down opponent cards may show ATK=0 instead of hidden

If an opponent's face-down card is in a monster zone and `isFace=false`, the ATK is read as 0 (not hidden). The mod currently only hides the **name** for face-down opponent cards; the ATK entry is skipped when `atk < 0`. Confirmed safe for most cases but edge cases with 0-ATK monsters (e.g., Maji-Gire Panda) may produce false readouts.

---

### F12 history resets on mouse click

`Input.anyKeyDown` captures mouse buttons, so clicking with the mouse resets `_historyPos` to -1 (navigation position) even if the user intended to keep browsing history. This is a Unity Legacy Input limitation.

**Workaround:** Press F12 again after any mouse click to restart history navigation from the latest entry.

---

### Deck editor "Remove from deck" announces wrong card name occasionally

The `RemoveFromDeck` 4-parameter overload patches `DeckCard` (a MonoBehaviour). On fast double-clicks, the instance may be recycled by the game's object pool before the postfix reads `m_BaseData.CardID`, causing the name to resolve to null → falls back to silent skip instead of announcement.

---

## Limitations

### Opponent hand names hidden in all modes

F11 reads only the **count** of cards in the opponent's hand, even in Solo/AI mode where the game may show opponent cards face-up internally. This is intentional (prevents unfair advantage in online play), but may be relaxed for solo mode in a future update.

### No announcement for chain details beyond "Chain started/resolving/resolved"

The mod announces the chain lifecycle but does not read out which cards are on the chain or their order. Reading chain participants requires iterating `DuelClient`'s internal chain list, which is not yet implemented.

### Phase auto-skip: only final phase announced

When the player has auto-skip enabled, multiple phases fire within a single frame. The 150 ms debounce means only the last phase in the burst is announced. If the player needs to know intermediate phases (e.g., Standby phase effects), they must disable auto-skip in game settings.

### Solo duel opponent field reading may have permission issues

In online ranked duels, reading the opponent field via Shift+F4 only shows face-up cards (face-down cards announce "face-down card" without the name). This is correct and intended. In Solo/AI duels, the AI's set cards are also treated as hidden — the same privacy-safe behavior applies for consistency.

---

## Planned Features

### Duel status summary (Shift+Space)

A combined announcement: "Turn {n}, your turn. Main Phase 1. You: 4200 LP, Opponent: 6300 LP."
Tracks current phase via `GameState.CurrentPhaseLabel` and whose turn via `GameState.CurrentPlayer`.

### Opponent field reading (Shift+F4)

Reads the opponent's visible field cards: name + ATK/DEF for face-up monsters; "face-down card" for hidden cards. Uses `CollectCardNames(hand: false, team: 1)`.

### Card effect chain announcement

Read the name of each card added to the chain: "Chain 1: Dark Hole. Chain 2: Ash Blossom."
Requires patching `ChainSet` / `ChainRun` with card ID resolution.

### Graveyard navigation (Up/Down in grave)

After pressing F6/F9, allow Up/Down arrows to step through individual cards one by one instead of reading all at once.

### Field zone awareness for F4

Currently F4 lists all field cards in array order. A future improvement would organize by zone: "Monster zones: … | Spell/Trap zones: … | Field zone: …"

### Solo mode opponent hand reveal

In Solo/AI duels, reading opponent hand names (F11 with names, not just count) could be made available as an opt-in setting for practice/learning purposes.

### Extra Deck type breakdown for F8

Currently lists all Extra Deck cards. Future: announce by type: "Fusion monsters: …; Synchro monsters: …; Link monsters: …"

### Localization: Japanese support

Currently supports French (primary) and English. Japanese (`ja-JP`) is the game's native language and a priority for the next localization pass.
