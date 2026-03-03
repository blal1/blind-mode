# MasterDuelAccessibility — Mod Structure & Status

## Project Layout

```
mod/MasterDuelAccessibility/
  MasterDuelAccessibility.csproj    ← MelonLoader mod project (net6.0, x64)
  Plugin.cs                         ← MelonMod entry point
  TtsService.cs                     ← Tolk TTS wrapper (NVDA/JAWS/SAPI)
  KeyboardShortcuts.cs              ← MonoBehaviour for F1–F12, Space, Alt
  GameState.cs                      ← Shared state (menu, turn, phase, player)
  AccessToolsHelper.cs              ← Reflection helpers (FindType, GetCardName…)
  Loc.cs                            ← Localization (FR + EN)
  NullablePolyfill.cs               ← [NotNullWhen] shim for net6.0/IL2CPP
  GeneralMenuNavigator.cs           ← Appends ", N of M" position to menu items

  Patches/
    DuelEventPatch.cs               ← DuelClient.RunEffect (all duel events)
    DuelHudPatch.cs                 ← DuelLP.ChangeLP / SetLP (LP bar)
    DuelAttackPatch.cs              ← DuelClient.InvokeDecideAttackTarget
    DuelDialogPatch.cs              ← DuelConfirmDialog.Open / DuelSelectDialog.Open
    PhasePatch.cs                   ← PhaseSelectWindow.PhaseChange / TurnChange
    CardInfoPatch.cs                ← CardInfo.SetDescriptionArea (card detail panel)
    CardCommandPatch.cs             ← RunCommand — action menu (attack, summon…)
    SelectionButtonPatch.cs         ← SelectionButton.OnSelected / OnDeselected / OnPointerClick
    ColorContainerPatch.cs          ← ColorContainerGraphic/Image.SetColor (icon buttons)
    ViewControllerPatch.cs          ← ViewController.OnFocusChanged / OnBack
    CardBrowserPatch.cs             ← CardBrowserViewController.Start / OnPageChanged
    DeckEditPatch.cs                ← DeckEditViewController2 (add/remove/save/rename)
    MatchingPatch.cs                ← PvpMenuMatchingViewController.SetActiveView

  docs/
    GAME_ARCHITECTURE.md            ← Game internals reference
    BEST_PRACTICES.md               ← Coding patterns for this mod
    EVENTS.md                       ← Duel event table (ViewType, SpSummonType…)
    MOD_STRUCTURE.md                ← This file
    KNOWN_ISSUES.md                 ← Bugs and planned work
    MENU_NAVIGATION.md              ← Menu navigation documentation
    analysis/                       ← Auto-generated class stubs (run tools/analyze_dump.py)

  tools/
    analyze_dump.py                 ← Generates docs/analysis/*.txt from decompiled interop stubs
```

## Keyboard Shortcut Reference

| Key | KeyCode | Context | Action |
|-----|---------|---------|--------|
| Space | 32 | Duel | Read LP (both players) |
| Shift+Space | 32 + shift | Duel | Duel status (turn + phase + LP) |
| Alt | 308 | Anywhere | Read current card info |
| F1 | 282 | Anywhere | Read shortcut help |
| F2 | 283 | Anywhere | Repeat last spoken |
| F3 | 284 | Duel | Read hand cards |
| F4 | 285 | Duel | Read own field cards (ATK/DEF/position/counters) |
| Shift+F4 | 285 + shift | Duel | Read opponent field cards |
| F5 | 286 | Anywhere | Silence |
| F6 | 287 | Duel | Read own graveyard |
| F7 | 288 | Duel | Read own banished cards |
| F8 | 289 | Duel | Read own Extra Deck |
| F9 | 290 | Duel | Read opponent graveyard |
| F10 | 291 | Duel | Read deck sizes (both) |
| F11 | 292 | Duel | Read opponent hand count (count only) |
| F12 | 293 | Anywhere | Browse announcement history (each press goes one step back) |

## Patch Registration (Plugin.ApplyPatches)

All patches are registered with `TryPatch(typeName, methodName, postfix: ...)` or
`TryPatchByParamCount(typeName, methodName, paramCount, postfix: ...)` for overloaded methods.

If a type is not found at runtime (e.g., removed in a game update), `TryPatch` logs a warning and continues — the mod degrades gracefully.

## Build & Deploy

```bash
# Build (from mod directory)
dotnet build -c Release

# Output
bin/Release/net6.0/MasterDuelAccessibility.dll

# Deploy to game (WSL path)
/mnt/c/Program Files (x86)/Steam/steamapps/common/Yu-Gi-Oh! Master Duel/Mods/
```

The `.csproj` includes a post-build step that auto-copies the DLL to `Mods/` on Windows.

## NuGet Sources

`mod/NuGet.config` adds the BepInEx dev feed for MelonLoader-compatible packages.
Main dependency: `MelonLoader.Il2CppAssemblyGenerator`, `HarmonyLib`, `Il2CppInterop.Runtime`.

## Reference Files for Development

When implementing new patches, always check these first:

1. `docs/analysis/analysis_duel.txt` — DuelClient, DuelLP, CardRoot full signatures
2. `docs/analysis/analysis_enums.txt` — All Engine.* enums with values
3. `docs/analysis/analysis_card.txt` — CardRoot fields with offsets
4. `decompiled/interop/Assembly-CSharp/YgomGame.Duel/` — Full decompiled stubs
5. `dump/dump.cs` — IL2CppDumper output (alternative view with RVA addresses)
