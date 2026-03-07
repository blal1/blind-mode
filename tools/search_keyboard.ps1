# Search dump\dump.cs for input / keyboard / selection-related types in YGO Master Duel.
#
# dump.cs is the Il2CppDumper output — a text file with all type and method signatures.
# It is the authoritative reference for YGO type names (replaces binary scanning).
#
# Usage: powershell -NoProfile -File tools\search_keyboard.ps1

$ErrorActionPreference = "Stop"

$repoRoot = Split-Path -Parent $PSScriptRoot
$dumpFile = Join-Path $repoRoot "dump\dump.cs"

if (-not (Test-Path $dumpFile)) {
    Write-Host "dump\dump.cs not found at $dumpFile" -ForegroundColor Red
    Write-Host "Run Il2CppDumper against the game to generate it." -ForegroundColor Yellow
    exit 1
}

Write-Host "=== Searching dump.cs for SelectionButton / Accept / Input ===" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "SelectionButton|IAccept|OnSelected|OnClick" |
    Select-Object -First 30 | ForEach-Object { Write-Host $_.Line }

Write-Host "`n=== YgomSystem input types ===" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "YgomSystem\.(Input|Key|Event)" |
    Select-Object -First 30 | ForEach-Object { Write-Host $_.Line }

Write-Host "`n=== Phase / Priority buttons ===" -ForegroundColor Green
Select-String -Path $dumpFile -Pattern "PhaseSelect|ButtonPhase|Priority" |
    Select-Object -First 20 | ForEach-Object { Write-Host $_.Line }
