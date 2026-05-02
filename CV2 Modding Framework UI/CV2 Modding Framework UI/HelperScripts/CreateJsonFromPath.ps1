param(
    [Parameter(Mandatory = $true)]
    [string]$Root,

    [Parameter(Mandatory = $true)]
    [string]$OutFile
)

function Get-DirTree {
    param([string]$Path)

    $children = Get-ChildItem -LiteralPath $Path -Directory | Sort-Object Name

    [pscustomobject]@{
        Name = Split-Path $Path -Leaf
        SubFolders = @($children | ForEach-Object {
            Get-DirTree -Path $_.FullName
        })
    }
}

$tree = Get-DirTree -Path (Resolve-Path $Root).Path
$tree | ConvertTo-Json -Depth 100 | Set-Content -LiteralPath $OutFile -Encoding UTF8