using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Be.HexEditor
{
    public static class Themes
    {
        public static readonly AppTheme Light = new()
        {
            BackColor = Color.White,
            ForeColor = Color.Black,
            ToolStripBack = Color.WhiteSmoke,
            DisabledBackColor = Color.WhiteSmoke,
            MenuBack = Color.White
        };

        public static readonly AppTheme Dark = new()
        {
            BackColor = Color.FromArgb(30, 30, 30),
            ForeColor = Color.White,
            ToolStripBack = Color.FromArgb(45, 45, 48),
            DisabledBackColor = Color.FromArgb(30, 30, 30),
            MenuBack = Color.FromArgb(37, 37, 38)
        };
    }
}
