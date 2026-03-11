<#
.SYNOPSIS
    Deploy the MasterDuelAccessibility mod to the game directory.
.DESCRIPTION
    Copies the built DLL to BepInEx/plugins/ in the game directory.
    Run Build-Mod.ps1 first, or use -Build to build before deploying.
#>
param(
    [switch]$Build
)

$ErrorActionPreference = 'Stop'

$gameDir = 'C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel'
$pluginsDir = Join-Path $gameDir 'BepInEx\plugins'
$modDir = Join-Path $PSScriptRoot '..\mod\MasterDuelAccessibility'
$srcDll = Join-Path $modDir 'bin\Release\net6.0\MasterDuelAccessibility.dll'

if ($Build) {
    Write-Host 'Building first...' -ForegroundColor Cyan
    & (Join-Path $PSScriptRoot 'Build-Mod.ps1')
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

if (-not (Test-Path $srcDll)) {
    Write-Host "DLL not found: $srcDll" -ForegroundColor Red
    Write-Host 'Run Build-Mod.ps1 first or use -Build flag.' -ForegroundColor Yellow
    exit 1
}

if (-not (Test-Path $gameDir)) {
    Write-Host "Game directory not found: $gameDir" -ForegroundColor Red
    exit 1
}

if (-not (Test-Path $pluginsDir)) {
    New-Item -ItemType Directory -Path $pluginsDir -Force | Out-Null
}

Copy-Item $srcDll -Destination $pluginsDir -Force
Write-Host "Deployed to: $pluginsDir\MasterDuelAccessibility.dll" -ForegroundColor Green
