# _interop-loader.ps1
# Dot-source this file to get Load-InteropAssembly and Get-AssemblyTypes.
#
# Usage in any analyze script:
#   . (Join-Path $PSScriptRoot "_interop-loader.ps1")
#   $assembly = Load-InteropAssembly $assemblyPath $interopDir
#   $types    = Get-AssemblyTypes $assembly
#
# Implementation note:
#   BepInEx 6 generates .NET 6 interop stubs. PowerShell 5.1 runs on .NET Framework 4.x.
#   These runtimes are incompatible for reflection loading (System.Private.CoreLib mismatch).
#   We therefore parse dump\dump.cs (IL2CppDumper text output) instead of loading the DLL.
#   $assemblyPath and $interopDir are accepted for API compatibility but ignored.

function Load-InteropAssembly {
    param(
        [Parameter(Mandatory)][string]$AssemblyPath,
        [Parameter(Mandatory)][string]$InteropDir
    )
    # Resolve dump.cs: go up from BepInEx\interop\ to find dump\dump.cs at repo root
    $bepInExDir = Split-Path -Parent $InteropDir          # ...\BepInEx
    $repoRoot   = Split-Path -Parent $bepInExDir          # repo root

    $candidates = @(
        (Join-Path $repoRoot  "dump\dump.cs"),
        (Join-Path (Split-Path -Parent $PSScriptRoot) "dump\dump.cs")
    )
    $dumpPath = $candidates | Where-Object { Test-Path $_ } | Select-Object -First 1
    if (-not $dumpPath) {
        Write-Host "dump\dump.cs not found. Tried:" -ForegroundColor Red
        $candidates | ForEach-Object { Write-Host "  $_" -ForegroundColor Red }
        exit 1
    }
    return [PSCustomObject]@{ _DumpPath = $dumpPath }
}

function Get-AssemblyTypes {
    param([Parameter(Mandatory)][object]$Assembly)
    Write-Host "Parsing: $($Assembly._DumpPath)" -ForegroundColor Cyan
    return _Parse-DumpCs $Assembly._DumpPath
}

# ── Internal parser ──────────────────────────────────────────────────────────
# Modifiers that can appear between access level and return type / field type
$script:_MOD = 'static|virtual|abstract|override|sealed|readonly|new|extern|unsafe|volatile'

function _Parse-DumpCs {
    param([string]$Path)

    $types = [System.Collections.Generic.List[object]]::new()
    $lines = [System.IO.File]::ReadAllLines($Path)
    $ns    = ""
    $cur   = $null
    $depth = 0

    foreach ($line in $lines) {

        # ── Namespace comment ────────────────────────────────────────────────
        if ($line -match '^// Namespace:\s*(.*)$') {
            $ns = $matches[1].Trim()
            continue
        }

        # ── Type declaration at top level (depth == 0) ───────────────────────
        if ($depth -eq 0 -and
            $line -match '^\s*(public|private|internal|protected)\s+(?:(?:sealed|abstract|static|readonly|partial)\s+)*(class|struct|interface|enum)\s+([^\s:{/[<]+)') {

            if ($cur -ne $null) { $types.Add($cur) }

            $access   = $matches[1]
            $kind     = $matches[2]
            $rawName  = $matches[3].Trim()

            # Base type: first token after ':' before '{' or '//'
            $baseName = ""
            if ($line -match ':\s*([^{/,<\[]+)') {
                $baseName = $matches[1].Trim() -replace '\s+.*', ''
            }

            $simpleName = $rawName
            $fullName   = if ($ns) { "$ns.$simpleName" } else { $simpleName }

            $cur = [PSCustomObject]@{
                FullName    = $fullName
                Name        = $simpleName
                BaseType    = if ($baseName) { [PSCustomObject]@{ Name = $baseName } } else { $null }
                IsInterface = ($kind -eq 'interface')
                IsPublic    = ($access -eq 'public')
                _Props      = [System.Collections.Generic.List[object]]::new()
                _Methods    = [System.Collections.Generic.List[object]]::new()
                _Fields     = [System.Collections.Generic.List[object]]::new()
            }
            $cur | Add-Member -MemberType ScriptMethod -Name 'GetProperties' -Value { return $this._Props.ToArray() }
            $cur | Add-Member -MemberType ScriptMethod -Name 'GetMethods'    -Value { return $this._Methods.ToArray() }
            $cur | Add-Member -MemberType ScriptMethod -Name 'GetFields'     -Value { return $this._Fields.ToArray() }
        }

        # ── Brace tracking ───────────────────────────────────────────────────
        foreach ($ch in $line.ToCharArray()) {
            if ($ch -eq '{') { $depth++ }
            elseif ($ch -eq '}') {
                $depth--
                if ($depth -eq 0 -and $cur -ne $null) {
                    $types.Add($cur)
                    $cur = $null
                }
            }
        }

        # Only parse members at depth exactly 1 (direct members of the type)
        if ($cur -eq $null -or $depth -ne 1) { continue }

        $trimmed = $line.Trim()

        # Skip blanks, comments, attributes
        if ($trimmed -eq '' -or $trimmed -match '^//' -or $trimmed -match '^\[') { continue }

        # ── Properties — line contains { get or { set (and no parentheses) ───
        if ($trimmed -notmatch '\(' -and $trimmed -match '\{\s*(?:get|set)') {
            # Pattern: <access> [modifiers] <type> <name> { ... }
            # Use explicit modifier list to avoid ambiguity
            if ($trimmed -match "^(?:public|private|internal|protected)(?:\s+(?:$($script:_MOD)))*\s+(\S+)\s+(\w+)\s*\{") {
                $cur._Props.Add([PSCustomObject]@{
                    Name         = $matches[2]
                    PropertyType = [PSCustomObject]@{ Name = (_Short $matches[1]) }
                })
            }
            continue
        }

        # ── Methods — line contains '(' ───────────────────────────────────────
        if ($trimmed -match '\(') {
            if ($trimmed -match "^(?:public|private|internal|protected)(?:\s+(?:$($script:_MOD)))*\s+(\S+)\s+(\w+)\s*\(([^)]*)\)") {
                $retType    = _Short $matches[1]
                $methodName = $matches[2]
                $paramStr   = $matches[3].Trim()

                $params = [System.Collections.Generic.List[object]]::new()
                if ($paramStr -ne '') {
                    foreach ($p in ($paramStr -split ',')) {
                        $p = $p.Trim() -replace '\[.*?\]', '' -replace '^\s*(?:ref|out|in|params|this)\s+', ''
                        $parts = ($p.Trim() -split '\s+') | Where-Object { $_ -ne '' }
                        if ($parts.Count -ge 2) {
                            $params.Add([PSCustomObject]@{
                                Name          = $parts[-1]
                                ParameterType = [PSCustomObject]@{ Name = (_Short $parts[-2]) }
                            })
                        }
                    }
                }

                $m = [PSCustomObject]@{
                    Name          = $methodName
                    ReturnType    = [PSCustomObject]@{ Name = $retType }
                    IsSpecialName = ($methodName -match '^(get_|set_|add_|remove_|op_|\.)' )
                    _Params       = $params
                }
                $m | Add-Member -MemberType ScriptMethod -Name 'GetParameters' -Value { return $this._Params.ToArray() }
                $cur._Methods.Add($m)
            }
            continue
        }

        # ── Fields — line ends with ; (no parens, no braces) ─────────────────
        if ($trimmed -match ';') {
            if ($trimmed -match "^(?:public|private|internal|protected)(?:\s+(?:$($script:_MOD)))*\s+(\S+)\s+(\w+)\s*(?:=.*)?;") {
                $cur._Fields.Add([PSCustomObject]@{
                    Name      = $matches[2]
                    FieldType = [PSCustomObject]@{ Name = (_Short $matches[1]) }
                })
            }
        }
    }

    if ($cur -ne $null) { $types.Add($cur) }
    return $types.ToArray()
}

function _Short ([string]$t) {
    return ($t -replace '<.*', '' -replace '\[\]$', '').Trim()
}
