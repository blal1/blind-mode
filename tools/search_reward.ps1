# Search BepInEx logs for duel reward / scene / event names in YGO Master Duel.
#
# Replaces the old MelonLoader + MTGA StreamingAssets scan.
# BepInEx writes its log to LogOutput.log in the game folder.
#
# Usage: powershell -NoProfile -File tools\search_reward.ps1

$ErrorActionPreference = "Stop"

$gamePath = "C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel"
$logPath  = Join-Path $gamePath "BepInEx\LogOutput.log"

if (Test-Path $logPath) {
    Write-Host "=== BepInEx log — reward / scene / event mentions ===" -ForegroundColor Green
    Get-Content $logPath |
        Select-String -Pattern "reward|chest|DuelResult|scene|Solo|Event|Mission|DuelPass" |
        Select-Object -First 40 | ForEach-Object { Write-Host $_.Line }
} else {
    Write-Host "BepInEx log not found at: $logPath" -ForegroundColor Yellow
    Write-Host "Run the game at least once with BepInEx installed." -ForegroundColor Yellow
}

# List scene-related asset bundles (YGO keeps assets in StreamingAssets)
$streamingAssets = Join-Path $gamePath "Master Duel_Data\StreamingAssets"
if (Test-Path $streamingAssets) {
    Write-Host "`n=== Searching StreamingAssets for scene/reward asset bundles ===" -ForegroundColor Green
    Get-ChildItem $streamingAssets -Recurse -ErrorAction SilentlyContinue |
        Where-Object { $_.Name -match "scene|reward|duel|solo|event|mission" } |
        Select-Object -First 20 Name, FullName
} else {
    Write-Host "`nStreamingAssets not found at: $streamingAssets" -ForegroundColor Yellow
}

# Also dump.cs can reveal scene controller names
$repoRoot = Split-Path -Parent $PSScriptRoot
$dumpFile = Join-Path $repoRoot "dump\dump.cs"
if (Test-Path $dumpFile) {
    Write-Host "`n=== dump.cs — scene/reward controller types ===" -ForegroundColor Green
    Select-String -Path $dumpFile -Pattern "SceneController|RewardViewController|DuelResult|DuelPassReward|MissionReward" |
        Select-Object -First 20 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }
}
