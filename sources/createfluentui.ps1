# ===== CONFIG =====
$inkscape = "C:\Program Files\WindowsApps\25415Inkscape.Inkscape_1.4.30.0_x64__9waqn51p1ttv2\VFS\ProgramFilesX64\Inkscape\bin\inkscape.exe"
$baseDir  = "C:\tools\fluentui\fluentui-system-icons-main\assets"
$targetDir = "C:\icons\png"

$sizes = @(16, 24, 32)

$icons = @(
    "Add",
    "Arrow Right",
    "Copy",
    "Cut",
    "Clipboard Paste",
    "Save",
    "Folder Open",
    "Search"
)

# Fluent blue (works in light & dark mode)
$color = "#0078D4"

# ensure output directory exists
New-Item -ItemType Directory -Force -Path $targetDir | Out-Null

# ===== SCRIPT =====

foreach ($icon in $icons) {

    $folderName   = $icon
    $fileNamePart = $icon.ToLower() -replace " ", "_"
    $cleanName    = $icon -replace " ", ""

    foreach ($size in $sizes) {

        $actualSize = $size

        # expected SVG
        $svgFile = Join-Path $baseDir "$folderName\SVG\ic_fluent_${fileNamePart}_${size}_regular.svg"

        # ===== FALLBACK =====
        if (!(Test-Path $svgFile)) {

            if ($size -eq 32) {
                $actualSize = 24
                $svgFile = Join-Path $baseDir "$folderName\SVG\ic_fluent_${fileNamePart}_24_regular.svg"
            }
            elseif ($size -eq 24) {
                $actualSize = 16
                $svgFile = Join-Path $baseDir "$folderName\SVG\ic_fluent_${fileNamePart}_16_regular.svg"
            }
        }

        if (!(Test-Path $svgFile)) {
            Write-Warning "Missing SVG: $icon size $size"
            continue
        }

        # ===== FORCE COLOR (reliable) =====

        $tempSvg = Join-Path $env:TEMP "icon_$cleanName.svg"

        (Get-Content $svgFile) `
            -replace 'stroke="[^"]*"', "stroke=""$color""" `
            -replace 'fill="[^"]*"', "fill=""$color""" `
            | Set-Content $tempSvg

        $outputFile = Join-Path $targetDir "$cleanName$size.png"

        Write-Host "Export [$size] $icon (src: $actualSize)"

        & $inkscape $tempSvg `
            --export-type=png `
            --export-width=$size `
            --export-height=$size `
            --export-area-drawing `
            --export-background-opacity=0 `
            --export-filename=$outputFile `
            --export-overwrite
    }
}