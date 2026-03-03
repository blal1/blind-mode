# MasterDuelAccessibility — Best Practices

Coding patterns and conventions for the accessibility mod.
For game structure, see [GAME_ARCHITECTURE.md](GAME_ARCHITECTURE.md).

---

## Patching Strategy

### Always use Harmony postfix patches

```csharp
// In Plugin.ApplyPatches():
TryPatch("YgomGame.Duel.DuelLP", "ChangeLP",
    postfix: typeof(DuelHudPatch), nameof(DuelHudPatch.ChangeLP_Postfix));
```

- Prefix = only when you must prevent the original from running (rarely needed)
- Postfix = normal case — reads state after the game updates it

### Positional parameter injection for static methods

For static methods like `DuelClient.RunEffect(int id, int p1, int p2, int p3)`:

```csharp
// Harmony positional params: __0, __1, __2, __3
public static void RunEffect_Postfix(int __0, int __1) { ... }
```

Use `__0`/`__1` for static methods where argument names are IL2CPP-mangled.

### Use `TryPatchByParamCount` for overloaded methods

When multiple overloads exist (e.g., `DuelConfirmDialog.Open` has 4-param and 6-param versions):

```csharp
TryPatchByParamCount("YgomGame.Duel.DuelConfirmDialog", "Open", 6,
    postfix: typeof(DuelDialogPatch), nameof(DuelDialogPatch.ConfirmDialog_Open_Postfix));
```

---

## Reflection Patterns

### Finding game types at runtime

```csharp
// Always use AccessToolsHelper, never AccessTools.TypeByName directly
var type = AccessToolsHelper.FindType("YgomGame.Duel.DuelLP");  // full name
var type = AccessToolsHelper.FindType("CardRoot");              // short name also works
```

### Reading fields with unknown offset

```csharp
var pubInst = BindingFlags.Public | BindingFlags.Instance;
var prop = type.GetProperty("atk", pubInst);
int atk = prop?.GetValue(instance) is int a ? a : -1;
```

### Reading private fields (walk base type chain)

```csharp
static int? GetStatusMode(object instance) {
    var t = instance.GetType();
    while (t != null && t != typeof(object)) {
        var prop = t.GetProperty("currentStatusMode",
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        if (prop != null) return Convert.ToInt32(prop.GetValue(instance));
        t = t.BaseType;
    }
    return null;
}
```

### Resolving card name from ID

```csharp
// Use the helper — handles null-safety and exceptions
string? name = AccessToolsHelper.GetCardName(cardId);

// Or the combined helper (name + ATK in one call):
var (name, atk) = AccessToolsHelper.GetCardNameAndAtkAt(team, position);
```

### Finding GameObjects by path

```csharp
var go = AccessToolsHelper.FindGameObjectByPath(
    "UI/OverlayCanvas/DialogManager/CardBrowser/...");
```

---

## Announcement Priorities

Inspired by AccessibleArena BEST_PRACTICES:

| Priority | `interrupt` | When to use |
|----------|------------|-------------|
| **Critical** | `true` | Duel start/end, LP change, surrender, coin/dice, janken, opponent thinking |
| **Informational** | `false` | Summons, activations, chain steps, draw, set — queued in order |
| **User-triggered** | `true` | All keyboard shortcut reads (user expects immediate response) |

```csharp
// Critical — interrupts current speech:
tts.Speak("You win!", interrupt: true);

// Informational — queued after current speech:
tts.Speak("Synchro Summon!", interrupt: false);
```

---

## Debounce for Rapid-Fire Events

Phase changes fire in bursts (Draw → Standby → Main1 in ~60 ms during auto-skip).
Without debounce, only the last one is heard, randomly.

```csharp
private static CancellationTokenSource? _phaseCts;
private static readonly TimeSpan PhaseDebounce = TimeSpan.FromMilliseconds(150);

private static void SpeakDebounced(TtsService tts, string text)
{
    _phaseCts?.Cancel();
    _phaseCts = new CancellationTokenSource();
    var token = _phaseCts.Token;
    Task.Run(async () =>
    {
        try
        {
            await Task.Delay(PhaseDebounce, token);
            tts.Speak(text, interrupt: false);
        }
        catch (OperationCanceledException) { }
    });
}
```

Turn changes are announced immediately (they never fire in bursts and are always critical).

---

## Announcement History

`TtsService` maintains a circular buffer of the last 10 spoken messages.

- `tts.Speak(text, addToHistory: false)` — use for meta-announcements (repeat, history readback) to avoid polluting history
- `tts.GetHistoryEntry(offset)` — offset 0 = most recent
- `tts.HistoryCount` — number of stored messages

F12 in `KeyboardShortcuts` navigates backward through history.

---

## IL2CPP Component Injection

Adding a custom `MonoBehaviour`:

```csharp
// In Plugin.OnInitializeMelon():
var go = new GameObject("KeyboardShortcuts");
Object.DontDestroyOnLoad(go);
go.AddComponent(Il2CppInterop.Runtime.Il2CppType.Of<KeyboardShortcuts>());
```

The class must inherit from `MonoBehaviour` AND declare the `(IntPtr pointer)` constructor:

```csharp
public class KeyboardShortcuts : MonoBehaviour
{
    public KeyboardShortcuts(IntPtr pointer) : base(pointer) { }
    public void Update() { ... }
}
```

---

## Keyboard Shortcuts — Design Rules

1. **F1–F12**: Global/duel shortcuts — always defined in the header comment of `KeyboardShortcuts.cs`
2. **Shift + key**: Opponent equivalent of a player shortcut (e.g., Shift+F4 = opponent field vs F4 = own field)
3. **Duel-only**: All F3–F12 shortcuts check `IsInDuel` before acting
4. **F12 (history)**: Must be checked FIRST, before the `anyKeyDown` reset that clears `_historyPos`
5. **No Alt+F keys**: Alt+F4 closes the window on Windows — avoid all Alt+F combinations

---

## Localization

All user-visible strings go through `Loc.Get(key)` — never hardcode strings in patches.

```csharp
// Simple key
tts.Speak(Loc.Get("duel_attack"), interrupt: false);

// Key with placeholders
tts.Speak(Loc.Get("duel_attack_vs_stats", attackerName, atk, targetName, targetAtk));
```

Add new strings via `Loc.Add("key", "French text", "English text")` in `Loc.InitializeStrings()`.

Language is auto-detected from `YgomSystem.Utility.Locale.GetLanguage()`:
- `"fr-FR"` → French
- Any other value → English (default)

---

## State Tracking

Shared cross-patch state lives in `GameState` and `KeyboardShortcuts`:

| Field | Where | Updated by |
|-------|-------|-----------|
| `IsInDuel` | `KeyboardShortcuts` | `DuelEventPatch` |
| `MyLP` / `OppLP` | `KeyboardShortcuts` | `DuelHudPatch` |
| `CurrentTurn` | `GameState` | `PhasePatch.TurnChange_Postfix` |
| `CurrentPhaseLabel` | `GameState` | `PhasePatch.PhaseChange_Postfix` |
| `CurrentPlayer` | `GameState` | `PhasePatch.TurnChange_Postfix` |
| `CurrentMenu` | `GameState` | `ViewControllerPatch`, `DuelEventPatch` |
| `PendingCardReadAt` | `KeyboardShortcuts` | `SelectionButtonPatch` (delayed card read after click) |
