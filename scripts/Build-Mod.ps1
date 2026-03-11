<#
.SYNOPSIS
    Build the MasterDuelAccessibility mod (Release configuration).
.DESCRIPTION
    Wrapper around dotnet build that builds the mod DLL.
    The .csproj auto-copies the output to BepInEx/plugins/ on Windows.
#>
param(
    [switch]$Debug
)

$ErrorActionPreference = 'Stop'
$modDir = Join-Path $PSScriptRoot '..\mod\MasterDuelAccessibility'

$config = if ($Debug) { 'Debug' } else { 'Release' }

Write-Host "Building MasterDuelAccessibility ($config)..." -ForegroundColor Cyan
dotnet build $modDir -c $config

if ($LASTEXITCODE -eq 0) {
    $dll = Join-Path $modDir "bin\$config\net6.0\MasterDuelAccessibility.dll"
    if (Test-Path $dll) {
        Write-Host "Build OK: $dll" -ForegroundColor Green
    }
} else {
    Write-Host "Build FAILED (exit code $LASTEXITCODE)." -ForegroundColor Red
    exit $LASTEXITCODE
}
