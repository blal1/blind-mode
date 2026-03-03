# Duel Events Reference

All duel events are fired by `DuelClient.RunEffect(int id, int param1, int param2, int param3)`.
The `id` maps to `Engine.ViewType`. The mod patches this method in `DuelEventPatch`.

---

## Engine.ViewType — Complete Event Table

| ViewType | Value | param1 meaning | Mod action | Priority |
|----------|-------|----------------|-----------|----------|
| `DuelStart` | 1 | — | "Duel started!" | Critical |
| `DuelEnd` | 2 | `Engine.ResultType` | Win/Lose/Draw/Time | Critical |
| `BattleAttack` | 12 | — | *handled by DuelAttackPatch* | — |
| `HandShow` | 19 | — | "Opponent shows their hand." | Queue |
| `TributeRun` | 45 | — | "Tribute Summon!" | Queue |
| `TuningRun` | 51 | — | "Synchro Summon!" | Queue |
| `ChainSet` | 52 | — | "Chain started." | Queue |
| `ChainRun` | 53 | — | "Chain resolving." | Queue |
| `RunSurrender` | 54 | — | "Surrender." | Critical |
| `RunDialog` | 55 | — | *handled by DuelDialogPatch* | — |
| `RunList` | 56 | — | *handled by DuelDialogPatch* | — |
| `RunSummon` | 57 | — | "Monster summoned." | Queue |
| `RunSpSummon` | 58 | `Engine.SpSummonType` | See SpSummonType table | Queue |
| `RunFusion` | 59 | — | "Fusion Summon!" | Queue |
| `RunDetail` | 60 | — | *handled by CardInfoPatch* | — |
| `RunCoin` | 61 | — | "Coin toss." | Critical |
| `RunDice` | 62 | — | "Dice roll." | Critical |
| `RunSpecialWin` | 64 | — | "Special condition win!" | Critical |
| `RunCommand` | 67 | `Engine.CommandBit` | *handled by CardCommandPatch* | — |
| `CutinDraw` | 68 | — | "Draw." | Queue |
| `CutinSummon` | 69 | — | "Summon!" | Queue |
| `CutinFusion` | 70 | — | "Fusion!" | Queue |
| `CutinChain` | 71 | — | "Chain response." | Queue |
| `CutinActivate` | 72 | — | "Effect activated!" | Queue |
| `CutinSet` | 73 | — | "Spell/Trap set." | Queue |
| `CutinReverse` | 74 | — | "Flip!" | Queue |
| `CutinTurnEnd` | 77 | — | "End of turn." | Queue |
| `CutinDamage` | 78 | — | "Battle damage." | Queue |
| `CutinBreak` | 79 | — | "Destroyed!" | Queue |
| `CpuThinking` | 80 | — | "Opponent is thinking." | Critical |
| `OverlayRun` | 84 | — | "Xyz Summon!" | Queue |
| `ChainEnd` | 86 | — | "Chain resolved." | Queue |
| `LinkRun` | 89 | — | "Link Summon!" | Queue |
| `RunJanken` | 90 | — | "Rock-Paper-Scissors." | Critical |
| `ChainStep` | 92 | — | "Chain step." | Queue |

---

## Engine.SpSummonType (param1 of RunSpSummon / ViewType=58)

| Value | Name | Mod action |
|-------|------|-----------|
| 0 | Fusion | "Fusion Summon!" (also fires RunFusion=59 / CutinFusion=70) |
| 1 | SpFusion | "Special Summon!" |
| 2 | Synchro | "Synchro Summon!" (also fires TuningRun=51) |
| 3 | **Ritual** | "Ritual Summon!" ← only via RunSpSummon |
| 4 | Xyz | "Xyz Summon!" (also fires OverlayRun=84) |
| 5 | **Pendulum** | "Pendulum Summon!" ← only via RunSpSummon |
| 6 | Link | "Link Summon!" (also fires LinkRun=89) |
| 7 | **Maximum** | "Maximum Summon!" ← only via RunSpSummon |

**Rule:** Ritual, Pendulum, and Maximum have NO dedicated ViewType — they must be detected via RunSpSummon(param1=3/5/7).

---

## Engine.ResultType (param1 of DuelEnd / ViewType=2)

| Value | Name | Announcement |
|-------|------|-------------|
| 0 | None | "Duel over." |
| 1 | Win | "You win!" |
| 2 | Lose | "You lose." |
| 3 | Draw | "Draw." |
| 4 | Time | "Duel over (time limit)." |

---

## Engine.Phase (PhaseSelectWindow.PhaseChange)

| Value | Phase | Announcement |
|-------|-------|-------------|
| 0 | Draw | "Draw Phase" |
| 1 | Standby | "Standby Phase" |
| 2 | Main1 | "Main Phase 1" |
| 3 | Battle | "Battle Phase" |
| 4 | Main2 | "Main Phase 2" |
| 5 | End | "End Phase" |

**Note:** Phase changes fire in rapid succession during auto-skip. The mod debounces them with 150 ms so only the final phase is announced.

---

## Attack Events (DuelAttackPatch)

Attack targeting is announced by patching `DuelClient.InvokeDecideAttackTarget`:

```
public static void InvokeDecideAttackTarget(
    int attackerPlayer, int attackerPosition, int attackerIndex,
    int targetPlayer,   int targetPosition,   int targetIndex)
```

Harmony: `__0=attackerPlayer`, `__1=attackerPosition`, `__3=targetPlayer`, `__4=targetPosition`

The patch calls `AccessToolsHelper.GetCardNameAndAtkAt(player, position)` for both cards.

| Scenario | Announcement |
|----------|-------------|
| vs target, ATK known | "{attacker} (ATK {n}) attacks {target} (ATK {m})!" |
| vs target, ATK unknown | "{attacker} attacks {target}!" |
| direct attack, ATK known | "{attacker} (ATK {n}): direct attack!" |
| direct attack, ATK unknown | "{attacker}: direct attack!" |

---

## LP Change Events (DuelHudPatch)

Patches `DuelLP.ChangeLP(int afterLP, int damage, Engine.DamageType type, int player, int position, Action onFinished)`.

Local player identified by `m_IsNear` (private bool, true = local player LP bar).

| Scenario | Announcement |
|----------|-------------|
| You take damage | "You: {afterLP} LP. -{damage} damage." |
| Opponent takes damage | "Opponent: {afterLP} LP. -{damage} damage." |
| You gain LP | "You: {afterLP} LP. +{gain} recovered." |
| Opponent gains LP | "Opponent: {afterLP} LP. +{gain} recovered." |

---

## Dialog Events (DuelDialogPatch)

`DuelConfirmDialog.Open(…)` — announces the dialog question and choice labels.
`DuelSelectDialog.Open(…)` — announces the list title.

---

## Duel Lifecycle

```
DuelClient.Awake()     → DuelStart_Postfix:  IsInDuel=true, LPs=8000, Turn=0
DuelClient.OnDestroy() → DuelEnd_Postfix:    IsInDuel=false
```
