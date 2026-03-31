<#
PowerShell script to convert all .resx files to consolidated JSON files organized by language.
Creates one JSON file per language (e.g., strings.json, strings.de.json, strings.ru.json)
containing all localizable strings from all forms in the solution.

Usage:
  .\resx-to-json-consolidated.ps1 -ResxDir "Be.HexEditor" -OutDir "Be.HexEditor\Locales"
#>
param(
    [string]$ResxDir = "Be.HexEditor",
    [string]$OutDir = "Be.HexEditor\Locales"
)

if (-not (Test-Path $ResxDir)) {
    Write-Error "Resx directory '$ResxDir' not found."
    exit 1
}

if (-not (Test-Path $OutDir)) {
    New-Item -ItemType Directory -Path $OutDir -Force | Out-Null
    Write-Host "Created output directory: $OutDir"
}

# Dictionary to store strings by language
$languageStrings = @{}

Get-ChildItem -Path $ResxDir -Filter *.resx -File | ForEach-Object {
    $resx = $_.FullName
    $fileName = $_.BaseName
    
    # Parse language/culture from filename
    # FormOptions.de.resx -> language is "de"
    # FormOptions.resx -> language is "en"
    $parts = $fileName -split '\.'
    $formName = $parts[0]
    $language = if ($parts.Count -gt 1) { $parts[1] } else { "en" }
    
    try {
        [xml]$xml = Get-Content -Path $resx -Raw
    }
    catch {
        Write-Warning "Failed to parse XML: $resx"
        return
    }

    $dataNodes = $xml.root.data
    if (-not $dataNodes) {
        Write-Host "No data in $fileName.resx"
        return
    }

    # Initialize language dictionary if not exists
    if (-not $languageStrings.ContainsKey($language)) {
        $languageStrings[$language] = @{}
    }

    $stringCount = 0
    foreach ($node in $dataNodes) {
        $name = $node.GetAttribute("name")
        if ([string]::IsNullOrEmpty($name)) { continue }

        # Filter: only include .Text properties
        $hasType = $node.GetAttribute("type")
        if (-not [string]::IsNullOrEmpty($hasType)) {
            continue
        }
        
        if (-not ($name.EndsWith(".Text") -or $name -eq "`$this.Text")) {
            continue
        }

        # Extract value
        $valueNode = $node.SelectSingleNode("value")
        if ($valueNode -ne $null) {
            $text = $valueNode.InnerText
            if (-not [string]::IsNullOrEmpty($text)) {
                # Decode HTML entities
                $decoded = [System.Net.WebUtility]::HtmlDecode($text)
                # Normalize line endings
                $decoded = $decoded -replace "`r`n", "\n"
                
                # Create key: FormName.KeyName
                $key = "$formName.$name"
                $languageStrings[$language][$key] = $decoded
                $stringCount++
            }
        }
    }
    
    if ($stringCount -gt 0) {
        Write-Host "✓ Parsed $fileName.resx ($stringCount strings for language: $language)"
    }
}

# Write consolidated JSON files per language
$languageStrings.GetEnumerator() | Sort-Object Name | ForEach-Object {
    $language = $_.Key
    $strings = $_.Value
    
    # Create language code filename
    $jsonFileName = if ($language -eq "en") { "strings.json" } else { "strings.$language.json" }
    $outPath = Join-Path $OutDir $jsonFileName
    
    # Sort keys for readability and create ordered hashtable
    $sortedStrings = [ordered]@{}
    $strings.GetEnumerator() | Sort-Object Name | ForEach-Object {
        $sortedStrings[$_.Key] = $_.Value
    }
    
    # Convert to JSON with proper formatting
    $json = ConvertTo-Json -InputObject $sortedStrings -Depth 5
    Set-Content -Path $outPath -Value $json -Encoding UTF8
    
    Write-Host "✓ Wrote $jsonFileName ($($strings.Count) total strings)"
}

Write-Host ""
Write-Host "Localization files created in: $OutDir"
Write-Host "Languages found: $($languageStrings.Keys | Sort-Object)"
