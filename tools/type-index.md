# YGO Master Duel — Decompile Type Index
#
# Used by tools\decompile-all.ps1 to batch-refresh decompiled reference sources.
# Run after a game update: powershell -NoProfile -File tools\decompile-all.ps1
#
# Dll values:
#   Asm       = Assembly-CSharp.dll        (main game types)
#   AsmFirst  = Assembly-CSharp-firstpass.dll (utility/early types)
#   Generated = __Generated.dll            (IL2CPP glue)
#   Auto      = tries Asm → AsmFirst → Generated

| Short Name | Full Type Name | Dll |
|---|---|---|
| DuelLP | YgomGame.Duel.DuelLP | Asm |
| DuelClient | YgomGame.Duel.DuelClient | Asm |
| DuelView | YgomGame.Duel.DuelView | Asm |
| DuelHUD | YgomGame.Duel.DuelHUD | Asm |
| DuelConfirmDialog | YgomGame.Duel.DuelConfirmDialog | Asm |
| DuelSelectDialog | YgomGame.Duel.DuelSelectDialog | Asm |
| DuelMulliganDialog | YgomGame.Duel.DuelMulliganDialog | Asm |
| DuelResultDialog | YgomGame.Duel.DuelResultDialog | Asm |
| DuelRitualDialog | DuelRitualDialog | Asm |
| PhaseSelectWindow | PhaseSelectWindow | Asm |
| PhaseSelect3D | PhaseSelect3D | Asm |
| CardInfo | CardInfo | Asm |
| CardInfoBase | CardInfoBase | Asm |
| CardInfoDetail | CardInfoDetail | Asm |
| SelectionButton | SelectionButton | Asm |
| ColorContainerGraphic | ColorContainerGraphic | Asm |
| ColorContainerImage | ColorContainerImage | Asm |
| ViewController | ViewController | Asm |
| CardBrowserViewController | YgomGame.CardBrowser.CardBrowserViewController | Asm |
| DeckEditViewController2 | DeckEditViewController2 | Asm |
| PvpMenuMatchingViewController | PvpMenuMatchingViewController | Asm |
| ShopViewController | YgomGame.Shop.ShopViewController | Asm |
| SoloModeViewController | YgomGame.Solo.SoloModeViewController | Asm |
| CardCommand | CardCommand | Asm |
| CardRoot | CardRoot | Asm |
| CardBaseData | CardBaseData | Asm |
| InstantMessage | InstantMessage | Asm |
| RunEffectWorker | RunEffectWorker | Asm |
| DuelTimerViewController | DuelTimerViewController | Asm |
| CardSelectionList | CardSelectionList | Asm |
| StandaloneInputModule | StandaloneInputModule | AsmFirst |
| Content | Content | Asm |
| Engine.CommandBit | Engine.CommandBit | Asm |
| Engine.ViewType | Engine.ViewType | Asm |
| Engine.Phase | Engine.Phase | Asm |
| Engine.DialogRitualType | Engine.DialogRitualType | Asm |
| SharedDefinition | SharedDefinition | Asm |
