$OutDir = "c:\Repos\hexbox\src\Be.HexEditor\Package\Assets"
New-Item -ItemType Directory -Force -Path $OutDir | Out-Null
Add-Type -AssemblyName System.Drawing

$bgDark    = [System.Drawing.Color]::FromArgb(255, 11,  22,  38)
$bgLight   = [System.Drawing.Color]::FromArgb(255, 24,  48,  80)
$textColor = [System.Drawing.Color]::FromArgb(255, 69, 112, 170)

function New-Asset([string]$FileName, [int]$W, [int]$H) {
    $bmp = New-Object System.Drawing.Bitmap($W, $H)
    $g   = [System.Drawing.Graphics]::FromImage($bmp)
    $g.SmoothingMode     = [System.Drawing.Drawing2D.SmoothingMode]::AntiAlias
    $g.TextRenderingHint = [System.Drawing.Text.TextRenderingHint]::AntiAliasGridFit

    $rect = [System.Drawing.Rectangle]::new(0, 0, $W, $H)
    $path = New-Object System.Drawing.Drawing2D.GraphicsPath
    $path.AddEllipse($rect)
    $pgb = New-Object System.Drawing.Drawing2D.PathGradientBrush($path)
    $pgb.CenterColor    = $bgLight
    $pgb.SurroundColors = @($bgDark)
    $g.FillRectangle((New-Object System.Drawing.SolidBrush($bgDark)), $rect)
    $g.FillEllipse($pgb, $rect)

    $fontSize = [int]([Math]::Min($W, $H) * 0.52)
    if ($fontSize -lt 6) { $fontSize = 6 }
    $font  = New-Object System.Drawing.Font("Segoe UI", $fontSize, [System.Drawing.FontStyle]::Bold, [System.Drawing.GraphicsUnit]::Pixel)
    $brush = New-Object System.Drawing.SolidBrush($textColor)
    $sf    = [System.Drawing.StringFormat]::GenericTypographic
    $sf.Alignment     = [System.Drawing.StringAlignment]::Center
    $sf.LineAlignment = [System.Drawing.StringAlignment]::Center
    $sf.FormatFlags   = [System.Drawing.StringFormatFlags]::NoClip

    $g.DrawString("0F", $font, $brush, [System.Drawing.RectangleF]::new(0, 0, $W, $H), $sf)

    $g.Dispose(); $pgb.Dispose(); $path.Dispose(); $font.Dispose(); $brush.Dispose()
    $outPath = Join-Path $OutDir $FileName
    $bmp.Save($outPath, [System.Drawing.Imaging.ImageFormat]::Png)
    $bmp.Dispose()
    Write-Host "Generated $FileName (${W}x${H})"
}

New-Asset "Square44x44Logo.png"   44  44
New-Asset "Square71x71Logo.png"   71  71
New-Asset "Square150x150Logo.png" 150 150
New-Asset "Square310x310Logo.png" 310 310
New-Asset "Wide310x150Logo.png"   310 150
New-Asset "StoreLogo.png"         50  50
New-Asset "SplashScreen.png"      620 300

Write-Host "Done."
