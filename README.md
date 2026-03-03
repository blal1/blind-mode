# Master Duel Accessibility

An accessibility mod for **Yu-Gi-Oh! Master Duel** that makes the game fully playable with a screen reader (NVDA, JAWS, or SAPI).

Built by a blind developer using AI assistance (Claude Code).

Based on [**BlindMode**](https://github.com/radsi/Master-Duels-BlindMode) by **Radsi** — the original BepInEx accessibility mod for Master Duel. This project extends that work with a significantly larger feature set.

---

## Features

- **Text-to-speech** for all game events via Tolk (NVDA, JAWS, SAPI)
- **Duel announcements** — LP changes, phase/turn changes, card summons, attacks, spell/trap activations, draw, and 20+ other events
- **Menu navigation** — button focus, contextual announcements for shop, missions, settings, deck editor, matchmaking, solo mode, and more
- **Card info** — reads card name, ATK/DEF, level/rank/link, and description
- **Card browser** — auto-reads current card when scrolling
- **Deck editor** — announces cards added/removed, deck renamed/saved
- **Card crafting** — announces create/dismantle dialog and result
- **Keyboard shortcuts** — quick access to all game info without leaving the keyboard
- **Bilingual** — French and English (auto-detected from game language)

---

## Keyboard Shortcuts

| Key | Context | Action |
|-----|---------|--------|
| Space | Duel | Read LP (both players) |
| Alt | Anywhere | Read current card info |
| F1 | Anywhere | Read shortcut help |
| F2 | Anywhere | Repeat last spoken text |
| F3 | Duel | Read hand cards |
| F4 | Duel | Read field cards |
| F5 | Anywhere | Silence / stop speech |
| F12 | Anywhere | Browse announcement history |

---

## Requirements

- **Yu-Gi-Oh! Master Duel** (Steam)
- **BepInEx 6.0.0-be.xxx (IL2CPP)** — [github.com/BepInEx/BepInEx](https://github.com/BepInEx/BepInEx/releases)
- A screen reader: **NVDA**, **JAWS**, or **Windows SAPI** (built-in)

---

## Installation

1. Install BepInEx 6 (IL2CPP) into your Master Duel game folder (follow the BepInEx guide)
2. Launch the game once so BepInEx generates its folder structure, then close it
3. Download the latest release from the [Releases](../../releases) page
4. Extract the zip — copy the `BepInEx/` folder into your Master Duel game folder
5. Launch the game — your screen reader should announce events automatically

Your `BepInEx/plugins/` folder should look like this:

```
BepInEx/
└── plugins/
    ├── MasterDuelAccessibility.dll
    ├── TolkDotNet.dll
    └── MasterDuelAccessibility/
        └── lib/
            └── screen-reader-libs/
                └── windows/
                    ├── Tolk.dll
                    ├── nvdaControllerClient64.dll
                    └── SAAPI64.dll
```

---

## Build From Source

```bash
cd mod/MasterDuelAccessibility
dotnet build -c Release
```

**Output:** `bin/Release/net6.0/MasterDuelAccessibility.dll`

You will need BepInEx installed and the game launched at least once so that BepInEx has generated the interop assemblies in `BepInEx/interop/`.

---

## Project Structure

```
mod/MasterDuelAccessibility/   # The mod source code
├── Plugin.cs                  # Entry point (BepInEx BasePlugin)
├── TtsService.cs              # Tolk TTS wrapper
├── KeyboardShortcuts.cs       # F1–F12, Space, Alt handlers
├── ShortcutRegistry.cs        # Central shortcut registry
├── Loc.cs                     # Localization (fr/en)
├── GameState.cs               # Shared state
├── AccessToolsHelper.cs       # Reflection utilities
└── Patches/                   # All Harmony patches
Accessibility-Mod-Template/    # Reference docs and templates
dump/                          # IL2CppDumper output (game stubs)
BepInEx/                       # Reference DLLs
```

---

## Contributing

See [CONTRIBUTING](CONTRIBUTING).

---

## Credits

- **Radsi** — [BlindMode](https://github.com/radsi/Master-Duels-BlindMode), the original BepInEx accessibility mod this project is based on
- **Davey Kager** — [Tolk](https://github.com/dkager/tolk) screen reader bridge library
- **HappyStarfish** — [Accessibility Mod Template](https://github.com/HappyStarfish/Accessibility-mod-template) used as reference framework

---

## License

This project is licensed under the terms in [LICENSE](LICENSE).
