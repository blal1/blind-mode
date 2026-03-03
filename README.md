# Master Duel Accessibility

An accessibility mod for **Yu-Gi-Oh! Master Duel** that makes the game fully playable with a screen reader (NVDA, JAWS, or SAPI).

Built by a blind developer using AI assistance (Claude Code).

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
- **MelonLoader v0.7.1** — [melonwiki.xyz](https://melonwiki.xyz)
- A screen reader: **NVDA**, **JAWS**, or **Windows SAPI** (built-in)

---

## Installation

1. Install MelonLoader v0.7.1 into your Master Duel game folder (follow the MelonLoader guide)
2. Download the latest release from the [Releases](../../releases) page
3. Copy `MasterDuelAccessibility.dll` into the `Mods/` folder of your game
4. Copy the `MasterDuelAccessibility/` folder (containing the `lib/` subfolder) into `Mods/` as well
5. Copy `TolkDotNet.dll` into `UserLibs/`
6. Launch the game — your screen reader should announce events automatically

Your `Mods/` folder should look like this:

```
Mods/
├── MasterDuelAccessibility.dll
└── MasterDuelAccessibility/
    └── lib/
        └── screen-reader-libs/
            └── windows/
                ├── Tolk.dll
                ├── nvdaControllerClient64.dll
                └── SAAPI64.dll
UserLibs/
└── TolkDotNet.dll
```

---

## Build From Source

```bash
cd mod/MasterDuelAccessibility
dotnet build -c Release
```

**Output:** `bin/Release/net6.0/MasterDuelAccessibility.dll`

You will need the game installed so that MelonLoader has already generated the interop assemblies in `MelonLoader/Il2CppAssemblies/`.

---

## Project Structure

```
mod/MasterDuelAccessibility/   # The mod source code
├── Plugin.cs                  # Entry point (MelonMod)
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

## License

This project is licensed under the terms in [LICENSE](LICENSE).
