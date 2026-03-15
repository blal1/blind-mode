# MasterDuelAccessibility

An accessibility mod for **Yu-Gi-Oh! Master Duel** that makes the game fully playable with a screen reader (NVDA, JAWS, or SAPI). Every menu, dialog, duel event, and game action is announced automatically.

Built by a blind developer using AI assistance.

Based on [**BlindMode**](https://github.com/radsi/Master-Duels-BlindMode) by **Radsi** — the original BepInEx accessibility mod for Master Duel. This project extends that work with a significantly larger feature set (~175 screens covered, 100+ keyboard shortcuts).

---

## 1. About

Yu-Gi-Oh! Master Duel is a free-to-play digital card game. Players build decks and duel against opponents in real time.

- **Engine:** Unity (IL2CPP, 64-bit)
- **Platform:** Steam (Windows PC)
- **Mod Loader:** BepInEx 6.0 IL2CPP
- **Languages:** French (primary), English (auto-detected from game)

---

## 2. Prerequisites

1. **Yu-Gi-Oh! Master Duel** (Steam version)
2. **BepInEx 6.0.0 IL2CPP** — [github.com/BepInEx/BepInEx/releases](https://github.com/BepInEx/BepInEx/releases)
   - Download the IL2CPP build for Windows x64
3. A **screen reader** (any of the following):
   - NVDA (free, recommended): [nvaccess.org](https://www.nvaccess.org/download/)
   - JAWS
   - Windows SAPI (built-in, no install needed)

---

## 3. Installation

**Step 1 — Install BepInEx**

1. Download BepInEx 6.0 IL2CPP (Windows x64)
2. Extract the archive into the game root directory:
   ```
   Default path: C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\
   ```
3. Launch the game once and close it — BepInEx will generate its folder structure

**Step 2 — Install the mod**

Download the latest release and place files as follows:

```
Yu-Gi-Oh!  Master Duel\          (game root)
  BepInEx\
    plugins\
      MasterDuelAccessibility.dll     <- mod main file
      MasterDuelAccessibility\
        lib\
          Tolk.dll                    <- screen reader bridge
          nvdaControllerClient64.dll  <- NVDA bridge
          SAAPI64.dll                 <- JAWS bridge
```

**Step 3 — Launch the game**

1. Make sure your screen reader is running
2. Launch the game through Steam
3. The mod initializes automatically — you will hear announcements as soon as the title screen loads

---

## 4. Game Keyboard Controls (Native)

These are the game's built-in controls. The mod does not change them.

- **Arrow keys** — Move cursor / navigate menus
- **Enter** — Confirm / select
- **Escape** — Cancel / go back
- **Tab** — Advance phase / pass priority (also used by the mod for the same action)

---

## 5. Mod Keyboard Shortcuts

### Global — All Screens

- **F1** — Context-sensitive help: reads all active shortcuts for the current screen
- **F2** — Repeat last announcement
- **F3** — Read current screen name (outside duel) / read all cards in hand (in duel)
- **F5** — Silence the screen reader immediately
- **F12** — Browse announcement history (press repeatedly to step back through recent messages; up to 10 entries)
- **Alt+Left** — Read info for the currently focused card (card info panel)

---

### Duel — Status and Life Points

- **Space** — Read your life points
- **L** — Your life points only
- **Shift+Space** — Full duel state: turn number, current phase, both players' LP
- **T** — Same as Shift+Space (alternative key)
- **S** — Re-read the current game instruction or pending effect text

---

### Duel — Hand

- **C** — Read all cards in your hand (name + ATK/DEF or type)
- **Shift+C** — Announce opponent's hand count
- **F3** — Same as C (alternative key)
- **Shift+F3** — Step through your hand one card at a time (resets when any other key is pressed)
- **1 through 5** — Read the Nth card in your hand (1 = first card, 5 = fifth card)

---

### Duel — Field

- **M** — Read your side of the field (all monster zones + spell/trap zones)
- **Shift+M** — Read opponent's field
- **F4** — Read your field (same as M)
- **Shift+F4** — Read opponent's field (same as Shift+M)
- **Ctrl+F4** — Step through your field one card at a time (sequential navigation)
- **Ctrl+Shift+F4** — Step through opponent's field one card at a time
- **Shift+1 through Shift+5** — Read opponent's monster zone 1–5 directly
- **6 through 9** — Read your spell/trap zones 1–4 (positions 7–10)
- **Shift+6 through Shift+9** — Read opponent's spell/trap zones 1–4
- **0** — Read your field spell zone (position 12)
- **Shift+0** — Read opponent's field spell zone
- **F** — Read the card in your field spell zone

---

### Duel — Graveyard and Banished

- **G** — Read your graveyard
- **Shift+G** — Read opponent's graveyard
- **F6** — Read your graveyard (same as G)
- **F9** — Read opponent's graveyard (same as Shift+G)
- **X** — Read your banished cards
- **Shift+X** — Read opponent's banished cards
- **F7** — Read your banished cards (same as X)
- **Ctrl+F7** — Read opponent's banished cards (same as Shift+X)

---

### Duel — Deck and Extra Deck

- **D** — Read both deck sizes (yours and opponent's)
- **F10** — Read deck sizes (same as D)
- **E** — Read your Extra Deck (count and breakdown by type)
- **Shift+E** — Read opponent's Extra Deck size
- **F8** — Read your Extra Deck (same as E)
- **Ctrl+F8** — Read opponent's Extra Deck size (same as Shift+E)
- **F11** — Read opponent's hand count

---

### Duel — Card Info and Actions

- **I** — Read detailed info for the card currently under the game cursor
- **O** — Read opponent overview: LP, hand count, deck size, graveyard size
- **P** — Announce current phase only

---

### Duel — Target Selection (when selecting targets for spells/effects)

- **Left/Right arrows** — Move between valid targets (announced automatically)
- **Enter** — Confirm selected target
- **Escape** — Cancel

---

### Duel — Zone Placement (when placing a monster on the field)

- **Arrow keys** — Move between valid zones (announced automatically)
- **Enter** — Confirm placement
- **Escape** — Cancel card play

---

## 6. Automatic Announcements

The following are announced automatically without pressing any key.

### Menus and Navigation

- Every button and menu item is read when it receives focus
- Menus announce their context: Shop packs (name, price, availability), Deck editor (card added/removed), Settings (slider value, current option), Duel Pass rewards, Mission details, Notifications, Profile info, etc.
- Every dialog and popup is announced when it opens
- Every button lists its position: "Button 3 of 7"
- Tab switches (shop categories, settings pages, etc.) are announced

### Duel Events

All of the following are announced the moment they happen:

- **Life points** — "Your LP: 8000 → 5500 (−2500)"
- **Phases and turns** — Draw Phase, Standby Phase, Main Phase 1, Battle Phase, Main Phase 2, End Phase; turn number; whose turn it is
- **Normal summon** — card name
- **Special summon** — card name + type (Fusion, Synchro, Xyz, Ritual, Pendulum, Link, Maximum, etc.)
- **Flip summon / set** — card name
- **Attack declared** — "Dark Magician (2500 ATK) attacks Blue-Eyes White Dragon (3000 ATK)"
- **Card destroyed** — card name
- **Card sent to graveyard** — card name and how (effect, battle, cost, etc.)
- **Card banished** — card name
- **Card searched** — card name
- **Card drawn** — at the start of each turn
- **Spell/trap activated** — card name and activation zone
- **Effect resolved** — card name
- **Chain opened / resolved** — chain link number
- **Counter added/removed** — card name
- **ATK/DEF boost** — "+500 ATK" (via the card report banner)
- **Ritual summon** — tribute requirement announced when dialog opens, updates as you select tributes
- **Duel start** — "Duel begin!"
- **Duel result** — "Victory!", "Defeat", or "Draw"
- **CPU thinking** — "Opponent is thinking..."
- **Rock-paper-scissors / coin toss** — result announced

### Duel Dialogs

- Yes/No confirmation dialogs — content + which option is selected
- Card selection lists — options listed, updates as you navigate
- Command menus (Attack, Summon, Set, etc.) — available actions listed
- "Choose a target" instruction — re-announced with each cursor move
- Zone selection during placement — zone number and position type (face-up attack, face-up defense, face-down defense)

### Shop and Rewards

- Shop screen opening — category name announced
- Pack details — pack name, price, availability, "new" status
- Purchase confirmation — product name, quantity, price
- Login bonus — day number, reward type and quantity
- Gift box — number of waiting gifts
- Duel Pass — current tier, next tier
- Lottery / pack opening — all cards obtained listed
- Card crafting result — cards crafted and CP cost

### Deck Editor

- Card added to deck — card name
- Card removed from deck — card name
- Deck renamed — new name
- Deck saved
- Card browser — current card name, ATK/DEF, type read automatically when you scroll to it

### System Screens

- Title screen — "Title screen ready"
- Matchmaking — "Searching...", "Opponent found!", "Timeout"
- Download progress
- Fatal errors and maintenance messages

---

## 7. Covered Screens

The mod covers **~175 screens** across all areas of the game:

- Title screen, loading, registration, tutorial
- Home screen, header (gems, notifications, gifts)
- All duel screens (PvP, Solo, Room, WCS, Team Tag, Auto-Duel)
- Deck editor, card browser, card crafting, structure decks
- Shop, gem shop, ticket exchange, pack opening, Duel Pass
- Missions, notifications, profile, friends, replays
- Season/ranked, Colosseum, WCS, Team, Tag Duel (TDY), DiceRally, TurnOverPrize
- Settings, language select, privacy
- Card file (collection stats), certification, survey, help, account link

---

## 8. Frequently Asked Questions

**Q: The screen reader does not speak at all.**

Check:
1. Your screen reader (NVDA, JAWS, or SAPI) is running before the game starts
2. `Tolk.dll` and `nvdaControllerClient64.dll` are in the correct `lib\` folder
3. BepInEx is installed correctly (a console window appears when the game starts)
4. `MasterDuelAccessibility.dll` is in `BepInEx\plugins\`

**Q: Announcements suddenly stopped during play.**

Press **F2** to repeat the last announcement. If still silent, try pressing **F1** — if help text is spoken, the mod is running fine. Some game animations suppress speech briefly.

**Q: The mod reads the wrong screen or seems out of sync.**

This can happen after fast transitions. Press **F2** to re-read the last announcement. The mod detects scenes automatically and will resync on the next navigation action.

**Q: Can I use this without NVDA?**

Yes. JAWS and Windows SAPI (built-in) are supported automatically via Tolk. No configuration is needed — the mod will use whichever screen reader is running.

**Q: What languages are supported?**

French and English. The mod detects the game's language setting automatically on startup. French is the primary/default language.

**Q: How do I change card description verbosity?**

In BepInEx configuration (BepInEx\config\MasterDuelAccessibility.cfg), the `Verbose` setting controls whether full card descriptions are read. Set to `true` for full descriptions, `false` for name + stats only. Default is `false`.

**Q: Does the mod affect gameplay?**

No. The mod only reads existing game information aloud and intercepts keyboard shortcuts that don't conflict with any game controls. It does not modify game logic, card rules, or outcomes.

**Q: How do I uninstall?**

Delete `BepInEx\plugins\MasterDuelAccessibility.dll` and the `MasterDuelAccessibility\` subfolder. To remove BepInEx entirely, delete the `BepInEx\` folder and the `winhttp.dll` file from the game root.

---

## 9. Quick Reference

### Global Shortcuts

- **F1** — Shortcut help (contextual)
- **F2** — Repeat last announcement
- **F3** — Screen name / hand (in duel)
- **F5** — Silence
- **F12** — Browse announcement history
- **Alt+Left** — Read focused card info

### Duel — Status

- **Space / L** — Your LP
- **Shift+Space / T** — Full state (turn + phase + both LP)
- **S** — Re-read current instruction
- **O** — Opponent overview
- **P** — Current phase only

### Duel — Hand

- **C / F3** — Read full hand
- **Shift+C / F11** — Opponent hand count
- **Shift+F3** — Step through hand one card at a time
- **1–5** — Read card N in hand

### Duel — Field

- **M / F4** — Your field
- **Shift+M / Shift+F4** — Opponent's field
- **Ctrl+F4** — Step through your field
- **Ctrl+Shift+F4** — Step through opponent's field
- **F** — Your field spell zone
- **Shift+1–5** — Opponent monster zones 1–5
- **6–9 / Shift+6–9** — Spell/trap zones
- **0 / Shift+0** — Field spell zone

### Duel — Graveyard and Banished

- **G / F6** — Your graveyard
- **Shift+G / F9** — Opponent graveyard
- **X / F7** — Your banished
- **Shift+X / Ctrl+F7** — Opponent banished

### Duel — Deck and Extra Deck

- **D / F10** — Deck sizes
- **E / F8** — Your Extra Deck
- **Shift+E / Ctrl+F8** — Opponent Extra Deck size

---

## 10. Build From Source

```bash
cd mod/MasterDuelAccessibility
dotnet build -c Release
```

Output: `bin/Release/net6.0/MasterDuelAccessibility.dll`

You need BepInEx installed and the game launched at least once so that BepInEx has generated the interop assemblies in `BepInEx/interop/`.

### Project Structure

```
mod/MasterDuelAccessibility/   # Mod source code
├── Plugin.cs                  # BepInEx entry point
├── TtsService.cs              # Tolk TTS wrapper
├── KeyboardShortcuts.cs       # Keyboard handler (MonoBehaviour)
├── ShortcutRegistry.cs        # Central shortcut registry
├── Loc.cs                     # Localization (fr/en, 100+ keys)
├── GameState.cs               # Shared game state
├── AccessToolsHelper.cs       # Reflection utilities
├── GeneralMenuNavigator.cs    # "N of M" position announcer
└── Patches/                   # ~60 Harmony patch files
docs/                          # Development documentation
dump/                          # IL2CppDumper output (game stubs)
scripts/                       # Build and deploy PowerShell scripts
```

---

## Credits

- **Radsi** — [BlindMode](https://github.com/radsi/Master-Duels-BlindMode), the original BepInEx accessibility mod this project builds on
- **Davey Kager** — [Tolk](https://github.com/dkager/tolk), the screen reader bridge library
- **HappyStarfish** — [Accessibility Mod Template](https://github.com/HappyStarfish/Accessibility-mod-template), used as reference framework
- **Claude (Anthropic)** — AI pair programmer

---

## License

This project is licensed under the terms in [LICENSE](LICENSE).
