<#
PowerShell script to extract all localizable strings from resx files
and create consolidated JSON files per language
#>

$ResxDir = "Be.HexEditor"
$OutDir = "Be.HexEditor\Locales"

if (-not (Test-Path $OutDir)) {
    New-Item -ItemType Directory -Path $OutDir -Force | Out-Null
}

$languageStrings = @{}

Get-ChildItem -Path $ResxDir -Filter *.resx -File | ForEach-Object {
    $fileName = $_.BaseName
    $parts = $fileName -split '\.'
    $formName = $parts[0]
    $language = if ($parts.Count -gt 1) { $parts[1] } else { "en" }
    
    [xml]$xml = Get-Content -Path $_.FullName
    
    if (-not $languageStrings.ContainsKey($language)) {
        $languageStrings[$language] = @{}
    }

    foreach ($node in $xml.root.data) {
        $name = $node.GetAttribute("name")
        if (-not $name -or $node.GetAttribute("type")) { continue }
        
        if (-not ($name.EndsWith(".Text") -or $name -eq "`$this.Text")) { continue }
        
        $valueNode = $node.SelectSingleNode("value")
        if ($valueNode) {
            $text = $valueNode.InnerText
            if ($text) {
                $decoded = [System.Net.WebUtility]::HtmlDecode($text) -replace "`r`n", "\n"
                $key = "$formName.$name"
                $languageStrings[$language][$key] = $decoded
            }
        }
    }
}

# Write JSON files
$languageStrings.GetEnumerator() | Sort-Object Name | ForEach-Object {
    $language = $_.Key
    $strings = $_.Value
    
    $jsonFileName = if ($language -eq "en") { "strings.json" } else { "strings.$language.json" }
    $outPath = Join-Path $OutDir $jsonFileName
    
    $sortedStrings = [ordered]@{}
    $strings.GetEnumerator() | Sort-Object Name | ForEach-Object {
        $sortedStrings[$_.Key] = $_.Value
    }
    
    $json = ConvertTo-Json -InputObject $sortedStrings -Depth 5
    Set-Content -Path $outPath -Value $json -Encoding UTF8
    Write-Host "✓ $jsonFileName ($($strings.Count) strings)"
}
