param(
    [Parameter(Mandatory = $true)]
    [string]$PublishDir,

    [Parameter(Mandatory = $true)]
    [string]$OutputPath
)

$publishRoot = (Resolve-Path $PublishDir).Path
if (-not (Test-Path $publishRoot)) {
    throw "Publish directory '$PublishDir' does not exist."
}

$files = Get-ChildItem -Path $publishRoot -File -Recurse | Sort-Object FullName
if (-not $files) {
    throw "Publish directory '$publishRoot' does not contain any files."
}

function Get-HashSuffix {
    param([string]$Value)

    $sha256 = [System.Security.Cryptography.SHA256]::Create()
    try {
        $bytes = [System.Text.Encoding]::UTF8.GetBytes($Value)
        $hashBytes = $sha256.ComputeHash($bytes)
        return ([System.BitConverter]::ToString($hashBytes)).Replace('-', '').Substring(0, 16)
    }
    finally {
        $sha256.Dispose()
    }
}

function New-Id {
    param(
        [string]$Prefix,
        [string]$Value
    )

    return "$Prefix$(Get-HashSuffix $Value)"
}

function Escape-Xml {
    param([string]$Value)

    return [System.Security.SecurityElement]::Escape($Value)
}

function Get-RelativePath {
    param(
        [string]$BasePath,
        [string]$Path
    )

    $baseUri = New-Object System.Uri(($BasePath.TrimEnd('\') + '\'))
    $pathUri = New-Object System.Uri($Path)
    $relativeUri = $baseUri.MakeRelativeUri($pathUri)
    return [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
}

$root = [ordered]@{
    Name = ''
    RelativePath = ''
    Dirs = [ordered]@{}
    Files = New-Object System.Collections.Generic.List[object]
}

foreach ($file in $files) {
    $relativePath = Get-RelativePath -BasePath $publishRoot -Path $file.FullName
    $relativeDirectory = [System.IO.Path]::GetDirectoryName($relativePath)
    $segments = @()

    if (-not [string]::IsNullOrWhiteSpace($relativeDirectory)) {
        $segments = $relativeDirectory -split '[\\/]'
    }

    $node = $root
    $currentRelativePath = ''
    foreach ($segment in $segments) {
        $currentRelativePath = if ([string]::IsNullOrEmpty($currentRelativePath)) { $segment } else { Join-Path $currentRelativePath $segment }
        if (-not $node.Dirs.Contains($segment)) {
            $node.Dirs[$segment] = [ordered]@{
                Name = $segment
                RelativePath = $currentRelativePath
                Dirs = [ordered]@{}
                Files = New-Object System.Collections.Generic.List[object]
            }
        }

        $node = $node.Dirs[$segment]
    }

    $node.Files.Add([ordered]@{
        FullPath = $file.FullName
        RelativePath = $relativePath
        Name = $file.Name
    })
}

$componentIds = New-Object System.Collections.Generic.List[string]
$builder = New-Object System.Text.StringBuilder

[void]$builder.AppendLine('<Wix xmlns="http://wixtoolset.org/schemas/v4/wxs">')
[void]$builder.AppendLine('  <Fragment>')

function Add-FileNodes {
    param(
        [System.Text.StringBuilder]$Xml,
        $DirectoryNode,
        [int]$IndentLevel
    )

    $indent = '  ' * $IndentLevel

    foreach ($fileNode in $DirectoryNode.Files) {
        $componentId = New-Id -Prefix 'cmp' -Value $fileNode.RelativePath
        $fileId = New-Id -Prefix 'fil' -Value $fileNode.RelativePath
        $escapedSource = Escape-Xml $fileNode.FullPath
        [void]$componentIds.Add($componentId)
        [void]$Xml.AppendLine(('{0}<Component Id="{1}" Guid="*">' -f $indent, $componentId))
        [void]$Xml.AppendLine(('{0}  <File Id="{1}" Source="{2}" KeyPath="yes">' -f $indent, $fileId, $escapedSource))
        [void]$Xml.AppendLine(('{0}  </File>' -f $indent))
        [void]$Xml.AppendLine(('{0}</Component>' -f $indent))
    }

    foreach ($child in $DirectoryNode.Dirs.Values) {
        $directoryId = New-Id -Prefix 'dir' -Value $child.RelativePath
        $escapedName = Escape-Xml $child.Name
        [void]$Xml.AppendLine(('{0}<Directory Id="{1}" Name="{2}">' -f $indent, $directoryId, $escapedName))
        Add-FileNodes -Xml $Xml -DirectoryNode $child -IndentLevel ($IndentLevel + 1)
        [void]$Xml.AppendLine(('{0}</Directory>' -f $indent))
    }
}

[void]$builder.AppendLine('    <DirectoryRef Id="INSTALLFOLDER">')
Add-FileNodes -Xml $builder -DirectoryNode $root -IndentLevel 3
[void]$builder.AppendLine('    </DirectoryRef>')
[void]$builder.AppendLine('  </Fragment>')
[void]$builder.AppendLine('  <Fragment>')
[void]$builder.AppendLine('    <ComponentGroup Id="GeneratedFileComponents">')
foreach ($componentId in $componentIds) {
    [void]$builder.AppendLine(('      <ComponentRef Id="{0}" />' -f $componentId))
}
[void]$builder.AppendLine('    </ComponentGroup>')
[void]$builder.AppendLine('  </Fragment>')
[void]$builder.AppendLine('</Wix>')

$outputDirectory = Split-Path -Path $OutputPath -Parent
if (-not [string]::IsNullOrEmpty($outputDirectory)) {
    New-Item -ItemType Directory -Path $outputDirectory -Force | Out-Null
}

[System.IO.File]::WriteAllText($OutputPath, $builder.ToString(), [System.Text.UTF8Encoding]::new($false))