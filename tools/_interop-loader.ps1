# _interop-loader.ps1
# Dot-source this file to get Load-InteropAssembly and Get-AssemblyTypes.
#
# Usage in any analyze script:
#   . (Join-Path $PSScriptRoot "_interop-loader.ps1")
#   $assembly = Load-InteropAssembly $assemblyPath $interopDir
#   $types    = Get-AssemblyTypes $assembly
#
# Why ReflectionOnlyLoadFrom instead of LoadFrom:
#   - Assembly-CSharp.dll is a BepInEx IL2CPP interop stub; its dependencies
#     (Il2CppInterop.Runtime, UnityEngine modules, etc.) are not in the GAC
#     and cannot be JIT-compiled in a plain PowerShell process.
#   - ReflectionOnlyLoadFrom reads PE metadata only — no code execution, no JIT,
#     no dependency resolution failures for method bodies.
#   - All type names, base types, fields, properties, and method signatures
#     are available as metadata and work fine in reflection-only context.

function Load-InteropAssembly {
    param(
        [Parameter(Mandatory)][string]$AssemblyPath,
        [Parameter(Mandatory)][string]$InteropDir
    )

    # ── Step 1: Unblock all DLLs (strip Zone.Identifier ADS) ────────────────
    Get-ChildItem $InteropDir -Filter "*.dll" -ErrorAction SilentlyContinue |
        ForEach-Object { Unblock-File $_.FullName -ErrorAction SilentlyContinue }

    # ── Step 2: Pre-load all sibling interop DLLs in reflection-only context ─
    # This caches them so Assembly-CSharp.dll's dependency resolution succeeds.
    $resolved = Resolve-Path $AssemblyPath -ErrorAction SilentlyContinue
    $target   = if ($resolved) { $resolved.Path } else { $AssemblyPath }
    Get-ChildItem $InteropDir -Filter "*.dll" -ErrorAction SilentlyContinue |
        Where-Object { $_.FullName -ne $target } |
        ForEach-Object {
            try { [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($_.FullName) | Out-Null }
            catch { }  # ignore individual load failures (some stubs may have issues)
        }

    # ── Step 3: GAC fallback handler for remaining framework dependencies ────
    # Stays attached for the lifetime of this PS process (short-lived scripts).
    $handler = [System.ResolveEventHandler]{
        param($sender, $args)
        try   { return [System.Reflection.Assembly]::ReflectionOnlyLoad($args.Name) }
        catch { return $null }
    }
    [System.AppDomain]::CurrentDomain.add_ReflectionOnlyAssemblyResolve($handler)

    # ── Step 4: Load target assembly ─────────────────────────────────────────
    return [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($AssemblyPath)
}

function Get-AssemblyTypes {
    param([Parameter(Mandatory)][System.Reflection.Assembly]$Assembly)

    try {
        return $Assembly.GetTypes()
    }
    catch [System.Reflection.ReflectionTypeLoadException] {
        Write-Host "Partial load — processing available types" -ForegroundColor Yellow
        return $_.Exception.Types | Where-Object { $_ -ne $null }
    }
}
