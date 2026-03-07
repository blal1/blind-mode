# Extract input/keybind-handling types from YGO Master Duel interop stubs.
#
# Analyses Assembly-CSharp.dll for YgomSystem input types, SelectionButton,
# PhaseSelect3D, and related classes with detailed field/method listings.
#
# Usage: powershell -NoProfile -File tools\extract_keybinds.ps1
# Output: analysis_keybinds.txt at repo root

$ErrorActionPreference = "Stop"

$repoRoot    = Split-Path -Parent $PSScriptRoot
$interopDir  = Join-Path $repoRoot "BepInEx\interop"
$outputPath  = Join-Path $repoRoot "analysis_keybinds.txt"

if (-not (Test-Path $interopDir)) {
    $interopDir = "C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\interop"
}

$dllPath = Join-Path $interopDir "Assembly-CSharp.dll"

Write-Host "Analyzing $dllPath for keybindings..." -ForegroundColor Cyan

if (-not (Test-Path $dllPath)) {
    Write-Host "Assembly not found at $dllPath" -ForegroundColor Red
    exit 1
}

$allFlags = [System.Reflection.BindingFlags]::Public -bor
            [System.Reflection.BindingFlags]::NonPublic -bor
            [System.Reflection.BindingFlags]::Instance -bor
            [System.Reflection.BindingFlags]::Static

try {
    . (Join-Path $PSScriptRoot "_interop-loader.ps1")
    $assembly = Load-InteropAssembly $dllPath $interopDir
    $types    = Get-AssemblyTypes $assembly

    $output = @()
    $output += "YGO Master Duel — Keybind / Input Analysis"
    $output += "Generated: $(Get-Date)"
    $output += "=" * 60

    # ── Helper to dump a single type ────────────────────────────────────────
    function Dump-Type($type) {
        $lines = @()
        $lines += "TYPE: $($type.FullName)"
        if ($type.BaseType) { $lines += "  Base: $($type.BaseType.Name)" }

        try {
            foreach ($field in $type.GetFields($allFlags)) {
                $lines += "  Field: $($field.FieldType.Name) $($field.Name)"
            }
        } catch {}

        try {
            foreach ($prop in $type.GetProperties($allFlags)) {
                $lines += "  Property: $($prop.PropertyType.Name) $($prop.Name)"
            }
        } catch {}

        try {
            foreach ($method in $type.GetMethods($allFlags)) {
                if (-not $method.IsSpecialName) {
                    $params = ($method.GetParameters() |
                        ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }) -join ", "
                    $lines += "  Method: $($method.ReturnType.Name) $($method.Name)($params)"
                }
            }
        } catch {}

        return $lines
    }

    # ── SelectionButton — primary selectable in all menus ───────────────────
    $selBtn = $types | Where-Object { $_.Name -eq 'SelectionButton' } | Select-Object -First 1
    if ($selBtn) {
        $output += "`nSELECTION BUTTON: $($selBtn.FullName)"
        $output += Dump-Type $selBtn
    } else {
        $output += "`n[SelectionButton not found — check dump\dump.cs]"
    }

    # ── PhaseSelect3D — 3D phase button in duel scene ────────────────────────
    $phaseBtn = $types | Where-Object { $_.Name -eq 'PhaseSelect3D' } | Select-Object -First 1
    if ($phaseBtn) {
        $output += "`n" + "=" * 60
        $output += "PHASE SELECT 3D: $($phaseBtn.FullName)"
        $output += Dump-Type $phaseBtn
    } else {
        $output += "`n[PhaseSelect3D not found — check dump\dump.cs]"
    }

    # ── YgomSystem input-related types ───────────────────────────────────────
    $output += "`n" + "=" * 60
    $output += "YgomSystem INPUT-RELATED TYPES:"

    $inputTypes = $types | Where-Object {
        ($_.FullName -match 'YgomSystem' -or $_.Namespace -eq $null) -and
        $_.Name -match 'Input|Key|Event|Action|Control|Handler'
    }

    foreach ($type in $inputTypes) {
        $output += "`n  TYPE: $($type.FullName)"
        $output += "    Base: $(if ($type.BaseType) { $type.BaseType.Name } else { 'None' })"
        $output += "    IsInterface: $($type.IsInterface)"

        try {
            foreach ($field in $type.GetFields($allFlags)) {
                $output += "    Field: $($field.FieldType.Name) $($field.Name)"
            }
        } catch {}
    }

    # ── All Keybind / Shortcut / InputAction named types ─────────────────────
    $output += "`n" + "=" * 60
    $output += "KEYBIND-NAMED TYPES:"

    $keybindTypes = $types | Where-Object {
        $_.Name -match 'Keybind|Hotkey|Shortcut|InputAction'
    }

    foreach ($type in $keybindTypes) {
        $output += "`n  TYPE: $($type.FullName)"
        $output += "    Base: $(if ($type.BaseType) { $type.BaseType.Name } else { 'None' })"
        $output += "    IsInterface: $($type.IsInterface)"

        try {
            foreach ($field in $type.GetFields($allFlags)) {
                $output += "    Field: $($field.FieldType.Name) $($field.Name)"
            }
        } catch {}
    }

    $output | Out-File -FilePath $outputPath -Encoding UTF8
    Write-Host "Results written to: $outputPath" -ForegroundColor Green
    Write-Host "Lines: $(($output | Measure-Object).Count)"
}
catch {
    Write-Host "Error: $_" -ForegroundColor Red
}
