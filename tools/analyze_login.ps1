# Analyze YGO Master Duel interop stubs for title-screen / startup types.
#
# Yu-Gi-Oh! Master Duel has no traditional login screen — it uses a Title scene
# ("Title") and a top-level menu after loading. This script finds those types.
#
# Usage: powershell -NoProfile -File tools\analyze_login.ps1
# Output: analysis_login.txt at repo root

$ErrorActionPreference = "Stop"

$repoRoot    = Split-Path -Parent $PSScriptRoot
$interopDir  = Join-Path $repoRoot "BepInEx\interop"

if (-not (Test-Path $interopDir)) {
    $interopDir = "C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\interop"
}

$assemblyPath = Join-Path $interopDir "Assembly-CSharp.dll"
$outputPath   = Join-Path $repoRoot "analysis_login.txt"

Write-Host "Analyzing: $assemblyPath" -ForegroundColor Cyan

if (-not (Test-Path $assemblyPath)) {
    Write-Host "Assembly not found at $assemblyPath" -ForegroundColor Red
    Write-Host "Run the game at least once with BepInEx installed to generate interop stubs." -ForegroundColor Yellow
    exit 1
}

try {
    . (Join-Path $PSScriptRoot "_interop-loader.ps1")
    $assembly = Load-InteropAssembly $assemblyPath $interopDir
    $types    = Get-AssemblyTypes $assembly

    Write-Host "Total types found: $($types.Count)"

    # YGO title/startup screen keywords (no traditional login — Steam/Konami auth is silent)
    $keywords = @(
        'Title', 'Top', 'Splash', 'Welcome', 'Startup', 'Boot',
        'Loading', 'Scene', 'Menu', 'Dialog', 'Modal',
        'Panel', 'Navigation', 'Button', 'Popup', 'Overlay',
        'Agreement', 'Terms', 'Privacy', 'Age'
    )

    $results = @()
    foreach ($type in $types) {
        $name = $type.FullName
        foreach ($kw in $keywords) {
            if ($name -match $kw) {
                $results += $type
                break
            }
        }
    }

    Write-Host "Matched types: $($results.Count)"

    $output = @()
    $output += "YGO Master Duel — Assembly-CSharp.dll Analysis — Title/Startup Types"
    $output += "Generated: $(Get-Date)"
    $output += "Total matched: $($results.Count)"
    $output += "=" * 60
    $output += ""

    foreach ($type in ($results | Sort-Object FullName)) {
        $output += "CLASS: $($type.FullName)"
        if ($type.BaseType) {
            $output += "  Base: $($type.BaseType.Name)"
        }
        $output += "  Public: $($type.IsPublic)"

        try {
            $props = $type.GetProperties(
                [System.Reflection.BindingFlags]::Public -bor
                [System.Reflection.BindingFlags]::Instance -bor
                [System.Reflection.BindingFlags]::Static)
            if ($props.Count -gt 0) {
                $output += "  Properties:"
                foreach ($prop in $props) {
                    $output += "    $($prop.PropertyType.Name) $($prop.Name)"
                }
            }
        } catch {}

        try {
            $methods = $type.GetMethods(
                [System.Reflection.BindingFlags]::Public -bor
                [System.Reflection.BindingFlags]::Instance -bor
                [System.Reflection.BindingFlags]::DeclaredOnly) |
                Where-Object { -not $_.IsSpecialName }
            if ($methods.Count -gt 0) {
                $output += "  Methods:"
                foreach ($method in $methods) {
                    $params = ($method.GetParameters() |
                        ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }) -join ", "
                    $output += "    $($method.ReturnType.Name) $($method.Name)($params)"
                }
            }
        } catch {}

        $output += "-" * 40
        $output += ""
    }

    $output | Out-File -FilePath $outputPath -Encoding UTF8
    Write-Host "Results written to: $outputPath" -ForegroundColor Green
}
catch {
    Write-Host "Error: $_" -ForegroundColor Red
}
