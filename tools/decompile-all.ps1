# Batch-decompile all types listed in tools\type-index.md
# Run after game updates to refresh the pre-decompiled reference files.
#
# Usage: powershell -NoProfile -File tools\decompile-all.ps1
#
# type-index.md format (Markdown table):
#   | Short Name | Full Type Name | Dll |
#   |------------|---------------|-----|
#   | DuelLP | YgomGame.Duel.DuelLP | Asm |
#
# Dll values: Asm, AsmFirst, Generated, Spine, Auto

$ErrorActionPreference = "Stop"

$repoRoot     = Split-Path -Parent $PSScriptRoot
$indexFile    = Join-Path $repoRoot "tools\type-index.md"
$decompileScript = Join-Path $repoRoot "tools\decompile.ps1"

if (-not (Test-Path $indexFile)) {
    Write-Host "Type index not found at $indexFile" -ForegroundColor Red
    Write-Host "Create tools\type-index.md with a Markdown table:" -ForegroundColor Yellow
    Write-Host "  | Short Name | Full Type Name | Dll |" -ForegroundColor Yellow
    Write-Host "  |------------|---------------|-----|" -ForegroundColor Yellow
    Write-Host "  | DuelLP | YgomGame.Duel.DuelLP | Asm |" -ForegroundColor Yellow
    exit 1
}

# Parse type-index.md: lines like "| ShortName | full.namespace.TypeName | Asm |"
$lines    = Get-Content $indexFile
$total    = 0
$succeeded = 0
$failed   = 0

foreach ($line in $lines) {
    # Match table rows: | ShortName | FullNamespace | DLL |
    if ($line -match '^\|\s*`?([^`|]+)`?\s*\|\s*`?([^`|]+)`?\s*\|\s*`?([^`|]+)`?\s*\|') {
        $shortName = $matches[1].Trim()
        $fullName  = $matches[2].Trim()
        $dll       = $matches[3].Trim()

        # Skip header / separator rows
        if ($shortName -eq "Short Name" -or $shortName -match "^-+$") { continue }

        $total++
        Write-Host "`n[$total] Decompiling $shortName ($dll)..." -ForegroundColor White

        try {
            & $decompileScript -TypeName $fullName -Dll $dll
            if ($LASTEXITCODE -eq 0) { $succeeded++ } else { $failed++ }
        } catch {
            Write-Host "  Error: $_" -ForegroundColor Red
            $failed++
        }
    }
}

Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "Decompile complete: $succeeded/$total succeeded, $failed failed" -ForegroundColor Cyan
