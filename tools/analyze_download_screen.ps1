# Analyze YGO Master Duel interop stubs for asset-download / loading-screen types.
#
# Usage: powershell -NoProfile -File tools\analyze_download_screen.ps1

$ErrorActionPreference = "Stop"

$repoRoot    = Split-Path -Parent $PSScriptRoot
$interopDir  = Join-Path $repoRoot "BepInEx\interop"

if (-not (Test-Path $interopDir)) {
    $interopDir = "C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel\BepInEx\interop"
}

$assemblyPath = Join-Path $interopDir "Assembly-CSharp.dll"

Write-Host "Analyzing download/loading-related types..." -ForegroundColor Cyan

if (-not (Test-Path $assemblyPath)) {
    Write-Host "Assembly not found at $assemblyPath" -ForegroundColor Red
    exit 1
}

# YGO types for download/loading screens — search dump.cs for alternatives
$targetTypes = @(
    'BootLoader',
    'DownloadViewController',
    'DownloadProgressViewController',
    'AssetBundleLoader',
    'LoadingViewController',
    'LoadingManager',
    'TitleSceneController',
    'TopScene',
    'ProgressBarController',
    'AssetLoadingPanel'
)

try {
    . (Join-Path $PSScriptRoot "_interop-loader.ps1")
    $assembly = Load-InteropAssembly $assemblyPath $interopDir
    $types    = Get-AssemblyTypes $assembly

    $found = 0
    foreach ($type in $types) {
        $name = $type.Name
        if ($targetTypes -contains $name) {
            $found++
            Write-Host "`n=========================================="
            Write-Host "CLASS: $($type.FullName)"
            Write-Host "=========================================="
            if ($type.BaseType) {
                Write-Host "  Base: $($type.BaseType.FullName)"
            }
            Write-Host "  IsInterface: $($type.IsInterface)"
            Write-Host "  IsAbstract: $($type.IsAbstract)"

            try {
                $fields = $type.GetFields(
                    [System.Reflection.BindingFlags]::Public -bor
                    [System.Reflection.BindingFlags]::NonPublic -bor
                    [System.Reflection.BindingFlags]::Instance -bor
                    [System.Reflection.BindingFlags]::Static)
                if ($fields.Count -gt 0) {
                    Write-Host "`n  Fields:"
                    foreach ($field in $fields) {
                        Write-Host "    $($field.FieldType.Name) $($field.Name)"
                    }
                }
            } catch {}

            try {
                $props = $type.GetProperties(
                    [System.Reflection.BindingFlags]::Public -bor
                    [System.Reflection.BindingFlags]::Instance -bor
                    [System.Reflection.BindingFlags]::Static)
                if ($props.Count -gt 0) {
                    Write-Host "`n  Properties:"
                    foreach ($prop in $props) {
                        Write-Host "    $($prop.PropertyType.Name) $($prop.Name)"
                    }
                }
            } catch {}

            try {
                $methods = $type.GetMethods(
                    [System.Reflection.BindingFlags]::Public -bor
                    [System.Reflection.BindingFlags]::NonPublic -bor
                    [System.Reflection.BindingFlags]::Instance -bor
                    [System.Reflection.BindingFlags]::DeclaredOnly) |
                    Where-Object { -not $_.IsSpecialName }
                if ($methods.Count -gt 0) {
                    Write-Host "`n  Methods:"
                    foreach ($method in $methods) {
                        $params = ($method.GetParameters() |
                            ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }) -join ", "
                        Write-Host "    $($method.ReturnType.Name) $($method.Name)($params)"
                    }
                }
            } catch {}
        }
    }

    if ($found -eq 0) {
        Write-Host "`nNo target types found. Search dump\dump.cs for alternatives:" -ForegroundColor Yellow
        Write-Host "  Select-String -Path '$(Join-Path $repoRoot 'dump\dump.cs')' -Pattern 'Download|Loading|Progress'" -ForegroundColor Yellow
    }
} catch {
    Write-Host "Error: $_" -ForegroundColor Red
}
