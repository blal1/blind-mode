# MasterDuelAccessibility — Mod Structure & Status

## Project Layout

```
mod/MasterDuelAccessibility/
  MasterDuelAccessibility.csproj    ← BepInEx 6 IL2CPP mod project (net6.0, x64)
  Plugin.cs                         ← BepInExPlugin entry point + PluginBehaviour MonoBehaviour
  TtsService.cs                     ← Tolk TTS wrapper (NVDA/JAWS/SAPI), circular history
  KeyboardShortcuts.cs              ← MonoBehaviour — F1–F12, Space, Alt, Tab
  ShortcutRegistry.cs               ← Central shortcut registry (register, process, help text)
  GameState.cs                      ← Shared state (CurrentMenu, CurrentTurn, MyLP, OppLP)
  AccessToolsHelper.cs              ← Reflection helpers (FindType, GetCardName, GetCardNameAndAtkAt)
  Loc.cs                            ← Localization (FR primary, EN fallback, DE partial)
  NullablePolyfill.cs               ← [NotNullWhen] shim for net6.0 + IL2CPP interop
  GeneralMenuNavigator.cs           ← Appends ", N of M" position suffix to every OnSelected

  Models/
    AnnouncementPriority.cs         ← Enum: Low, Normal, High, Immediate
    ShortcutDefinition.cs           ← Key + modifier + description + action + condition
    TargetInfo.cs                   ← YGO-adapted card target model (zone, team, type)

  Patches/                          ← All Harmony postfix patches
    — Always active (Plugin.ApplyPatches) —
    SelectionButtonPatch.cs         ← SelectionButton.OnSelected / OnDeselected / OnPointerClick
    ColorContainerPatch.cs          ← ColorContainerGraphic/Image.SetColor (icon buttons)
    ViewControllerPatch.cs          ← ViewController.OnFocusChanged / OnBack / ShowUI
    CardInfoPatch.cs                ← CardInfo.SetDescriptionArea (card detail panel, gated by Verbose)
    CardBrowserPatch.cs             ← CardBrowserViewController.Start / OnPageChanged
    DeckEditPatch.cs                ← DeckEditViewController2 (add/remove/save/rename/focus)
    DeckSelectPatch.cs              ← DeckSelectViewController2.OnFocusChanged (mode + deck name)
    MatchingPatch.cs                ← PvpMenuMatchingViewController.SetActiveView
    CardCraftPatch.cs               ← CardCraftDialog.Open (5-param, craft/dismantle)
    CardCraftResultPatch.cs         ← CardCraftResultDialog.GetResultMessage
    FilterSelectViewPatch.cs        ← FilterSelectViewController.OpenFilterSelect
    InputDigitViewPatch.cs          ← InputDigitViewController.OnCreatedView / OnValueAdded
    InputBlockPatch.cs              ← Input.GetKeyDown — blocks Ctrl/Esc/Space/Enter contextually
    EventSystemPatch.cs             ← StandaloneInputModule — blocks Tab in Unity EventSystem
    InputFieldPatch.cs              ← TMP_InputField.OnSelect / OnDeselect
    TogglePatch.cs                  ← UnityEngine.UI.Toggle.Set
    SliderPatch.cs                  ← UnityEngine.UI.Slider.Set (value + 150ms cooldown)
    DropdownPatch.cs                ← TMP_Dropdown.Show / set_value / Hide
    CardReportTelopPatch.cs         ← Post-effect stat banner ("+500 ATK")

    — Duel scene only (LatePatches.ApplyDuelScenePatches) —
    LatePatches.cs                  ← Dispatcher + DuelMiscPatch + MenuMiscPatch
    DuelEventPatch.cs               ← DuelClient.RunEffect (25+ ViewTypes) / Awake / OnDestroy
    DuelHudPatch.cs                 ← DuelLP.ChangeLP / SetLP (LP bar)
    DuelAttackPatch.cs              ← DuelClient.InvokeDecideAttackTarget
    DuelDialogPatch.cs              ← DuelConfirmDialog.Open (6-param + 4-param)
    PhasePatch.cs                   ← Delegated via DuelEventPatch ViewType 5/6
    CardCommandPatch.cs             ← CardCommand.Open (6-param) — action menu
    CommandOperationPatch.cs        ← CommandOperation.SetCursor — navigation in command menu
    DuelCursorPatch.cs              ← RunEffectWorker.OnCursorEnter / OnSelectField
    SelectStandOperationPatch.cs    ← SelectStandOperation.BeginSpSummon (zone/position)
    DuelRitualDialogPatch.cs        ← DuelRitualDialog.Begin / SetCount
    DuelEffectQueuePatch.cs         ← InstantMessage.ReqOpen / infoMessage dedup
    CardSelectionListPatch.cs       ← CardSelectionList.SetList / SetCursor
    DuelTimerPatch.cs               ← Turn + duel clock warnings (60/30/10s)
    DialogStatePatch.cs             ← DuelSelectDialog.Open
    — via LatePatches.cs inline —
    CardCommandExPatch              ← CardCommandEx.Open (3-param, position selection)
    DuelPullDownDialogPatch         ← DuelPullDownDialog.Open (5-param)
    DuelMiscPatch                   ← Dice / Coin / Mulligan / Result / FirstPlayer / OkDialog

  docs/
    SCREEN_REFERENCE.md            ← Per-screen reference (patches, announcements, navigation)
    GAME_ARCHITECTURE.md            ← Game internals (classes, namespaces, Unity setup)
    BEST_PRACTICES.md               ← Coding patterns for this mod
    EVENTS.md                       ← Duel event table (ViewType, SpSummonType, enums)
    MOD_STRUCTURE.md                ← This file
    KNOWN_ISSUES.md                 ← Bugs and planned work
    MENU_NAVIGATION.md              ← SelectionButton context processors (detailed)
    analysis/                       ← Auto-generated class stubs (tools/analyze_dump.py)

  tools/
    analyze_dump.py                 ← Generates docs/analysis/*.txt from decompiled interop stubs
```

## Patch Registration

Patches in `Plugin.ApplyPatches()`:
- `TryPatch(typeName, methodName, postfix: method)` — single overload
- `TryPatchByParamCount(typeName, methodName, paramCount, postfix: method)` — overload disambiguation

Patches in `LatePatches.ApplyDuelScenePatches()`:
- `TryPatchPostfix(typeName, methodName, patchClass, patchMethod)` — same pattern, called on `sceneLoaded`

If a type is not found at runtime, `TryPatch` logs a BepInEx warning and continues — the mod degrades gracefully per patch.

## Build & Deploy

```bash
# Build (from mod directory)
dotnet build -c Release

# Output
bin/Release/net6.0/MasterDuelAccessibility.dll

# Auto-deploy: csproj CopyToGame target runs on Windows only
# Copies DLL to: C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh! Master Duel\BepInEx\plugins\
```

## Dependencies (csproj references)

- `BepInEx.Core.dll` + `BepInEx.Unity.IL2CPP.dll` — BepInEx 6 IL2CPP framework
- `0Harmony.dll` — HarmonyX (bundled with BepInEx)
- `Il2CppInterop.Runtime.dll` — IL2CPP interop layer
- `Il2Cppmscorlib.dll` — IL2CPP mscorlib stubs
- `UnityEngine.CoreModule.dll` / `InputLegacyModule` / `UIModule` / `UI` / `TextMeshPro` — Unity stubs
- `TolkDotNet.dll` — Tolk .NET wrapper (NVDA/JAWS/SAPI bridge)

All references are `<Private>false</Private>` — not bundled in output DLL.

## Reference Files for Development

When implementing new patches, check in this order:

1. `docs/SCREEN_REFERENCE.md` — screen-by-screen patch map and announcement formats
2. `docs/analysis/analysis_duel.txt` — DuelClient, DuelLP, CardRoot signatures
3. `docs/analysis/analysis_enums.txt` — all Engine.* enums with values
4. `docs/analysis/analysis_card.txt` — CardRoot fields with IL2CPP offsets
5. `decompiled/interop/Assembly-CSharp/YgomGame.Duel/` — full decompiled stubs (authoritative)
6. `dump/dump.cs` — IL2CppDumper output (alternative view with RVA addresses)
