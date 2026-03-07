# Find duel-phase / priority / action key functions in dump\dump.cs.
#
# dump.cs is the Il2CppDumper output — search it as plain text instead of
# doing binary byte scanning on the native GameAssembly.dll.
#
# Usage: powershell -NoProfile -File tools\find_key_functions.ps1

$ErrorActionPreference = "Stop"

$repoRoot = Split-Path -Parent $PSScriptRoot
$dumpFile = Join-Path $repoRoot "dump\dump.cs"

if (-not (Test-Path $dumpFile)) {
    Write-Host "dump\dump.cs not found at $dumpFile" -ForegroundColor Red
    exit 1
}

Write-Host "=== PHASE / PRIORITY FUNCTIONS ===" -ForegroundColor Green
Write-Host ""

Write-Host "PHASE CHANGE METHODS:" -ForegroundColor Cyan
Select-String -Path $dumpFile -Pattern "PhaseChange|OnClickButtonPhase|SetPhase|ChangePhase" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host ""
Write-Host "DUEL CONFIRM / OK BUTTONS:" -ForegroundColor Cyan
Select-String -Path $dumpFile -Pattern "DuelConfirm|OnOk|OnYes|OnAccept|OnClickOk" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host ""
Write-Host "PASS PRIORITY / CHAIN RESOLUTION:" -ForegroundColor Cyan
Select-String -Path $dumpFile -Pattern "PassPriority|ChainEnd|SelectYesNo|SkipChain" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host ""
Write-Host "DUEL SCENE HOTKEY / BUTTON LABELS:" -ForegroundColor Cyan
Select-String -Path $dumpFile -Pattern "DuelButton|PhaseButton|DuelHotkey|DuelKey" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host ""
Write-Host "UNDO / CANCEL:" -ForegroundColor Cyan
Select-String -Path $dumpFile -Pattern "OnUndo|OnCancel|Undo|CancelSelect" |
    Where-Object { $_.Line -match "void|bool" } |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }
