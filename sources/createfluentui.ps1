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

# theme colors (soft, modern)
$themes = @{
    light = "#1E1E1E"
    dark  = "#E6E6E6"
}

# ensure output directory exists
New-Item -ItemType Directory -Force -Path $targetDir | Out-Null

# ===== SCRIPT =====

foreach ($icon in $icons) {

    $folderName   = $icon
    $fileNamePart = $icon.ToLower() -replace " ", "_"
    $cleanName    = $icon -replace " ", ""

    foreach ($size in $sizes) {

        $actualSize = $size

        # expected SVG path
        $svgFile = Join-Path $baseDir "$folderName\SVG\ic_fluent_${fileNamePart}_${size}_regular.svg"

        # ===== FALLBACK LOGIC =====

        if (!(Test-Path $svgFile)) {

            if ($size -eq 32) {
                # fallback 32 → 24
                $actualSize = 24
                $svgFile = Join-Path $baseDir "$folderName\SVG\ic_fluent_${fileNamePart}_24_regular.svg"
            }

            elseif ($size -eq 24) {
                # fallback 24 → 16 (rare)
                $actualSize = 16
                $svgFile = Join-Path $baseDir "$folderName\SVG\ic_fluent_${fileNamePart}_16_regular.svg"
            }
        }

        if (!(Test-Path $svgFile)) {
            Write-Warning "Missing SVG (even after fallback): $icon size $size"
            continue
        }

        foreach ($theme in $themes.Keys) {

            $color = $themes[$theme]
            $outputFile = Join-Path $targetDir "$cleanName`_${theme}_$size.png"

            Write-Host "Export [$theme][$size] $icon (src: $actualSize)"

            & $inkscape $svgFile `
                --export-type=png `
                --export-width=$size `
                --export-height=$size `
                --export-area-drawing `
                --export-background-opacity=0 `
                --export-filename=$outputFile `
                --export-overwrite `
                --actions="select-all;object-set-fill:$color;object-set-stroke:$color;export-do"
        }
    }
}