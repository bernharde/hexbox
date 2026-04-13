Add-Type -AssemblyName System.Drawing

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$outputSquare = Join-Path $scriptDir 'Store-1080x1080.png'
$outputPortrait = Join-Path $scriptDir 'Store-720x1080.png'

function New-Brush([string] $color) {
    return New-Object System.Drawing.SolidBrush ([System.Drawing.ColorTranslator]::FromHtml($color))
}

function New-Pen([string] $color, [float] $width) {
    return New-Object System.Drawing.Pen ([System.Drawing.ColorTranslator]::FromHtml($color)), $width
}

function Draw-RoundedRectangle {
    param(
        [System.Drawing.Graphics] $Graphics,
        [System.Drawing.Pen] $Pen,
        [System.Drawing.Brush] $Brush,
        [float] $X,
        [float] $Y,
        [float] $Width,
        [float] $Height,
        [float] $Radius
    )

    $diameter = $Radius * 2
    $path = New-Object System.Drawing.Drawing2D.GraphicsPath
    $path.AddArc($X, $Y, $diameter, $diameter, 180, 90)
    $path.AddArc($X + $Width - $diameter, $Y, $diameter, $diameter, 270, 90)
    $path.AddArc($X + $Width - $diameter, $Y + $Height - $diameter, $diameter, $diameter, 0, 90)
    $path.AddArc($X, $Y + $Height - $diameter, $diameter, $diameter, 90, 90)
    $path.CloseFigure()
    if ($Brush) { $Graphics.FillPath($Brush, $path) }
    if ($Pen) { $Graphics.DrawPath($Pen, $path) }
    $path.Dispose()
}

function Draw-Poster {
    param(
        [int] $Width,
        [int] $Height,
        [string] $OutputPath
    )

    $bitmap = New-Object System.Drawing.Bitmap $Width, $Height
    $graphics = [System.Drawing.Graphics]::FromImage($bitmap)
    $graphics.SmoothingMode = [System.Drawing.Drawing2D.SmoothingMode]::AntiAlias
    $graphics.InterpolationMode = [System.Drawing.Drawing2D.InterpolationMode]::HighQualityBicubic
    $graphics.TextRenderingHint = [System.Drawing.Text.TextRenderingHint]::ClearTypeGridFit

    $background = New-Object System.Drawing.Drawing2D.LinearGradientBrush (
        ([System.Drawing.Rectangle]::new(0, 0, $Width, $Height)),
        ([System.Drawing.ColorTranslator]::FromHtml('#0F1115')),
        ([System.Drawing.ColorTranslator]::FromHtml('#1B2230')),
        60
    )
    $graphics.FillRectangle($background, 0, 0, $Width, $Height)

    $markShadowBrush = New-Brush '#162238'
    $markBrush = New-Brush '#3E68A3'
    $markFont = [System.Drawing.Font]::new('Segoe UI Semibold', ($Width * 0.44), [System.Drawing.FontStyle]::Bold, [System.Drawing.GraphicsUnit]::Pixel)
    $markText = 'OF'
    $markSize = $graphics.MeasureString($markText, $markFont)
    $markX = ($Width - $markSize.Width) / 2
    $markY = ($Height - $markSize.Height) / 2 - ($Height * 0.03)
    $graphics.DrawString($markText, $markFont, $markShadowBrush, ($markX + 12), ($markY + 14))
    $graphics.DrawString($markText, $markFont, $markBrush, $markX, $markY)

    $bitmap.Save($OutputPath, [System.Drawing.Imaging.ImageFormat]::Png)

    $markFont.Dispose()
    $markShadowBrush.Dispose()
    $markBrush.Dispose()
    $background.Dispose()
    $graphics.Dispose()
    $bitmap.Dispose()
}

Draw-Poster -Width 1080 -Height 1080 -OutputPath $outputSquare
Draw-Poster -Width 720 -Height 1080 -OutputPath $outputPortrait
