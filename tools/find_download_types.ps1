# Find asset-download / loading related types in YGO Master Duel interop stubs.
#
# Searches both Assembly-CSharp.dll and Assembly-CSharp-firstpass.dll.
# Falls back to dump\dump.cs grep if stubs are not available.
#
# Usage: powershell -NoProfile -File tools\find_download_types.ps1

$ErrorActionPreference = "Stop"

$repoRoot   = Split-Path -Parent $PSScriptRoot
$interopDir = Join-Path $repoRoot "BepInEx\interop"

if (-not (Test-Path $interopDir)) {
    $interopDir = "C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\interop"
}

$assemblies = @(
    (Join-Path $interopDir "Assembly-CSharp.dll"),
    (Join-Path $interopDir "Assembly-CSharp-firstpass.dll")
)

$keywords = @('Download', 'Progress', 'Loading', 'Asset', 'Bundle', 'Patch', 'Update', 'Boot')

$foundAny = $false

foreach ($assemblyPath in $assemblies) {
    if (-not (Test-Path $assemblyPath)) {
        Write-Host "Skipping (not found): $assemblyPath" -ForegroundColor DarkGray
        continue
    }

    Write-Host "`n=== Analyzing: $(Split-Path $assemblyPath -Leaf) ===" -ForegroundColor Cyan

    try {
        . (Join-Path $PSScriptRoot "_interop-loader.ps1")
        $assembly = Load-InteropAssembly $assemblyPath $interopDir
        $types    = Get-AssemblyTypes $assembly

        foreach ($type in $types) {
            $name = $type.FullName
            foreach ($kw in $keywords) {
                if ($name -match $kw) {
                    Write-Host $name
                    $foundAny = $true
                    break
                }
            }
        }
    } catch {
        Write-Host "Error loading $assemblyPath : $_" -ForegroundColor Red
    }
}

# Fallback: grep dump.cs
if (-not $foundAny) {
    $dumpFile = Join-Path $repoRoot "dump\dump.cs"
    if (Test-Path $dumpFile) {
        Write-Host "`n=== Fallback: dump.cs grep for Download/Loading/Asset ===" -ForegroundColor Yellow
        Select-String -Path $dumpFile -Pattern "Download|AssetBundle|LoadingView|ProgressView" |
            Select-Object -First 30 | ForEach-Object { Write-Host "  $($_.Line.Trim())" }
    }
}
