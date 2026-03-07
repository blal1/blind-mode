# Find keybind / input-action strings in dump\dump.cs for YGO Master Duel.
#
# Replaces binary byte scanning of the native GameAssembly.dll with plain-text
# searching of the Il2CppDumper output (dump\dump.cs).
#
# Usage: powershell -NoProfile -File tools\find_keybinds.ps1

$ErrorActionPreference = "Stop"

$repoRoot = Split-Path -Parent $PSScriptRoot
$dumpFile = Join-Path $repoRoot "dump\dump.cs"

if (-not (Test-Path $dumpFile)) {
    Write-Host "dump\dump.cs not found at $dumpFile" -ForegroundColor Red
    exit 1
}

Write-Host "Searching dump.cs for keybind / input action strings..." -ForegroundColor Cyan

Write-Host "`nINPUT / SELECTOR CLASS DEFINITIONS:" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "^public class.*(Input|Selector|KeyHandler|Shortcut)" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host "`nYgomSystem TYPES (any):" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "^public (class|enum|interface) YgomSystem\." |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host "`nSELECTION BUTTON INTERFACE:" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "SelectionButton|ISelectable|OnSelected|OnDeselected|OnPointerClick" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }

Write-Host "`nDUEL INPUT / ACTION NAMES:" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "DuelInput|DuelAction|DuelCommand|CommandBit" |
    Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }
