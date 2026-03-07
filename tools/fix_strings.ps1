# Audit Loc.cs for orphaned or missing localization keys.
#
# Scans all .cs files in the mod for Loc.Get("key") calls and cross-references
# them against the keys defined in Loc.cs. Reports:
#   - Keys used in code but not defined in Loc.cs
#   - Keys defined in Loc.cs but never referenced in code
#
# Usage: powershell -NoProfile -File tools\fix_strings.ps1

$ErrorActionPreference = "Stop"

$repoRoot = Split-Path -Parent $PSScriptRoot
$modDir   = Join-Path $repoRoot "mod\MasterDuelAccessibility"
$locFile  = Join-Path $modDir "Loc.cs"

if (-not (Test-Path $locFile)) {
    Write-Host "Loc.cs not found at $locFile" -ForegroundColor Red
    exit 1
}

Write-Host "Auditing localization keys in: $modDir" -ForegroundColor Cyan
Write-Host ""

# ── Collect defined keys from Loc.cs ────────────────────────────────────────
# Looks for: Add("key", ... or Add("key",
$defined = @{}
$locContent = Get-Content $locFile -Raw
$matches = [regex]::Matches($locContent, 'Add\(\s*"([^"]+)"')
foreach ($m in $matches) {
    $key = $m.Groups[1].Value
    $defined[$key] = $true
}

Write-Host "Defined keys in Loc.cs: $($defined.Count)"

# ── Collect used keys from all .cs files ─────────────────────────────────────
# Looks for: Loc.Get("key" or Loc.Get("key",
$used = @{}
$csFiles = Get-ChildItem $modDir -Recurse -Filter "*.cs"
foreach ($file in $csFiles) {
    if ($file.Name -eq "Loc.cs") { continue }
    # Strip single-line comments before scanning so commented-out Loc.Get() calls are ignored
    $content = (Get-Content $file.FullName) -notmatch '^\s*//' -join "`n"
    $fileMatches = [regex]::Matches($content, 'Loc\.Get\(\s*"([^"]+)"')
    foreach ($m in $fileMatches) {
        $key = $m.Groups[1].Value
        if (-not $used.ContainsKey($key)) {
            $used[$key] = @()
        }
        $used[$key] += $file.Name
    }
}

Write-Host "Used keys across mod: $($used.Count)"
Write-Host ""

# ── Missing keys (used but not defined) ──────────────────────────────────────
$missing = $used.Keys | Where-Object { -not $defined.ContainsKey($_) }
if ($missing) {
    Write-Host "MISSING keys (used in code but not in Loc.cs):" -ForegroundColor Red
    foreach ($key in ($missing | Sort-Object)) {
        Write-Host "  $key  ← in: $($used[$key] -join ', ')" -ForegroundColor Red
    }
} else {
    Write-Host "No missing keys — all Loc.Get() calls have definitions." -ForegroundColor Green
}

Write-Host ""

# ── Orphaned keys (defined but never used) ───────────────────────────────────
$orphaned = $defined.Keys | Where-Object { -not $used.ContainsKey($_) }
if ($orphaned) {
    Write-Host "ORPHANED keys (defined in Loc.cs but never referenced):" -ForegroundColor Yellow
    foreach ($key in ($orphaned | Sort-Object)) {
        Write-Host "  $key" -ForegroundColor Yellow
    }
} else {
    Write-Host "No orphaned keys — all Loc.cs entries are used." -ForegroundColor Green
}
