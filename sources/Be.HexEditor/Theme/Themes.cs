using System.Drawing;

namespace Be.HexEditor.Theme
{
    public static class Themes
    {
        public static readonly AppTheme Light = new()
        {
            BackColor = Color.White,
            ForeColor = Color.Black,
            ToolStripBack = Color.WhiteSmoke,
            DisabledBackColor = Color.WhiteSmoke,
            MenuBack = Color.White,

            AccentColor = Color.FromArgb(0, 120, 215),
            HoverColor = Color.FromArgb(230, 230, 230),
            BorderColor = Color.FromArgb(200, 200, 200)
        };

        public static readonly AppTheme Dark = new()
        {
            BackColor = Color.FromArgb(30, 30, 30),
            ForeColor = Color.White,
            ToolStripBack = Color.FromArgb(45, 45, 48),
            DisabledBackColor = Color.FromArgb(30, 30, 30),
            MenuBack = Color.FromArgb(37, 37, 38),

            AccentColor = Color.FromArgb(0, 120, 215),
            HoverColor = Color.FromArgb(60, 60, 65),
            BorderColor = Color.FromArgb(70, 70, 70)
        };
    }
}
