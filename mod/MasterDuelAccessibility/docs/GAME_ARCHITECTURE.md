# Yu-Gi-Oh! Master Duel — Game Architecture

Reference documentation for the game's internal structure, useful for modding and accessibility development.

## Runtime

Engine: Unity 6 (6000.0.61f1)
IL2CPP backend: **yes** (no managed Mono, all C# compiled to native code)
Mod framework: **MelonLoader v0.7.1**
Install path (default): `C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh! Master Duel`

## Key Directories (game folder)

| Directory | Contents |
|-----------|----------|
| `MelonLoader/net6/` | MelonLoader runtime, `0Harmony.dll`, `Il2CppInterop.Runtime.dll` |
| `MelonLoader/Il2CppAssemblies/` | IL2CPP interop stubs — **the modding targets** |
| `Mods/` | Installed mod DLLs (e.g. `MasterDuelAccessibility.dll`) |
| `UserLibs/` | Shared managed DLLs (e.g. `TolkDotNet.dll`) |
| `Mods/MasterDuelAccessibility/lib/` | Tolk screen-reader bridge DLLs |

## Key Assemblies

**Assembly-CSharp (interop stub)**
Main game logic. All `YgomGame.*`, `YgomSystem.*`, and global classes live here.

- `YgomGame.Duel.*` — duel engine (DuelClient, DuelLP, CardRoot, Engine, PhaseSelectWindow…)
- `YgomGame.Card.*` — card data (Content resolver)
- `YgomGame.CardBrowser.*` — card browser (CardBrowserViewController)
- `YgomGame.Deck.*` — deck editor (DeckEditViewController2)
- `YgomSystem.UI.*` — UI framework (SelectionButton, ViewController, ColorContainer)
- `YgomSystem.Utility.*` — utilities (Locale)

## Card Identity

| Field | Type | Description |
|-------|------|-------------|
| `cardId` | `int` | Game card ID (matches Yu-Gi-Oh! database) |
| `position` | `int` | Field zone (see FieldPosition below) |
| `team` | `int` | `0` = local player, `1` = opponent |

### FieldPosition (BindingDuelFieldCards.FieldPostion)

| Value | Zone |
|-------|------|
| 0–4 | Monster main zones |
| 5–6 | Extra Monster Zones (EMZ) |
| 7–11 | Spell/Trap zones |
| 12 | Field Spell zone |
| 13 | Hand |
| 14 | Extra Deck |
| 15 | Main Deck |
| 16 | Graveyard |
| 17 | Banished (exclusion) |
| 18 | Special / temporary |

## Duel Scene Architecture

### Key MonoBehaviours

| Class | Namespace | Role |
|-------|-----------|------|
| `DuelClient` | `YgomGame.Duel` | Main duel controller — `RunEffect(id, p1, p2, p3)` fires all events |
| `DuelLP` | `YgomGame.Duel` | LP bar — `ChangeLP(afterLP, damage, …)` and `SetLP(lp)` |
| `CardRoot` | `YgomGame.Duel` | One instance per card on field/hand/grave; has `position`, `team`, `cardId`, `atk`, `def`, `isFace`, `isAttack` |
| `PhaseSelectWindow` | `YgomGame.Duel` | Phase buttons — `PhaseChange(int nextphase)`, `TurnChange(int team)` |
| `CardInfo` | `YgomGame.Duel` | Card detail panel — `SetDescriptionArea(…)` |
| `CardInfoDetail` | `YgomGame.Duel` | Extended card detail (browser / standalone) |
| `CardInfoBase` | `YgomGame.Duel` | Base class with TMP field references |
| `CardCommand` | `YgomGame.Duel` | Action menu (attack, summon, activate…) |
| `DuelConfirmDialog` | `YgomGame.Duel` | Yes/No dialog — `Open(…)` |
| `DuelSelectDialog` | `YgomGame.Duel` | List selection dialog — `Open(…)` |

### Content Singleton (card name resolver)

```csharp
var content = Content.Instance;          // YgomGame.Card.Content, sealed singleton
string name = content.GetName(cardId, false);   // human-readable card name
string desc = content.GetDesc(cardId, false);   // card description text
```

### Engine Enums (all nested in YgomGame.Duel.Engine)

| Enum | Key values |
|------|-----------|
| `ViewType` | DuelStart=1, DuelEnd=2, BattleAttack=12, HandShow=19, TributeRun=45, TuningRun=51, RunSummon=57, RunSpSummon=58, RunFusion=59, CutinDraw=68, CutinSummon=69, CutinActivate=72, CutinSet=73, CutinTurnEnd=77, CutinDamage=78, CutinBreak=79, CpuThinking=80, RunJanken=90 |
| `Phase` | Draw=0, Standby=1, Main1=2, Battle=3, Main2=4, End=5 |
| `SpSummonType` | Fusion=0, SpFusion=1, Synchro=2, Ritual=3, Xyz=4, Pendulum=5, Link=6, Maximum=7 |
| `ResultType` | None=0, Win=1, Lose=2, Draw=3, Time=4 |
| `CommandBit` | Attack=1, Look=2, SummonSp=4, Action=8, Summon=16, Surrender=2048 |
| `PlayerType` | Near=0, Far=1 (local vs. opponent in most contexts) |

## UI Navigation Architecture

The UI uses a hierarchy of `ViewController` / `SelectionButton` MonoBehaviours:

```
ViewController (e.g. "DUEL", "DECK", "SHOP")
  └─ SelectionButton (each interactive element)
       ├─ OnSelected  → fires when focused
       ├─ OnDeselected → fires when losing focus
       └─ OnPointerClick → fires on activation
```

`ColorContainerGraphic` / `ColorContainerImage` are used for icon-only buttons (no SelectionButton child). They fire `SetColor(Color)` when the button enters hover/focus state (`currentStatusMode == 2`).

## Screen Reader Integration

The mod uses **Tolk** (screen-reader bridge) via `TolkDotNet.dll`:

```
call Speak(text, interrupt: true)   → interrupts and reads immediately
call Speak(text, interrupt: false)  → queued, reads after current speech
call Silence()                      → stops all speech
```

Tolk detects: NVDA, JAWS, Windows SAPI (fallback).
DLL search path is set via `SetDllDirectory` to `Mods/MasterDuelAccessibility/lib/screen-reader-libs/windows/`.
