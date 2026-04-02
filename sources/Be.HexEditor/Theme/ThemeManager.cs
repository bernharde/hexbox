using Be.HexEditor.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Theme
{
    public static class ThemeManager
    {
        private static AppTheme _currentTheme;
        private static bool _isDarkTheme;

        public static void Apply(Control control, AppTheme theme, bool dark)
        {
            _currentTheme = theme;
            _isDarkTheme = dark;

            

            //control.BackColor = theme.BackColor;
            //control.ForeColor = theme.ForeColor;

            if (control is ToolStrip ts)
            {
                //ts.BackColor = theme.ToolStripBack;
                //ts.ForeColor = theme.ForeColor;

                ts.Renderer = dark
                    ? new ToolStripDark2Renderer()
                    : new ToolStripProfessionalRenderer();
            }

            //if (control is Be.Windows.Forms.HexBox hexBox)
            //{
            //    hexBox.BackColorDisabled = theme.DisabledBackColor;
            //}

            if (control is LinkLabel linkLabel)
            {
                linkLabel.LinkColor = theme.AccentColor;
                linkLabel.VisitedLinkColor = theme.AccentColor;
            }

            //if (control is Button button && button.FlatStyle == FlatStyle.Flat)
            //{
            //    button.BackColor = theme.BackColor;
            //    button.ForeColor = theme.ForeColor;
            //}

            //if (control is MenuStrip or ContextMenuStrip)
            //{
            //    control.BackColor = theme.MenuBack;
            //}

            foreach (Control child in control.Controls)
            {
                Apply(child, theme, dark);
            }
        }

        public static AppTheme GetCurrentTheme()
        {
            return _currentTheme;
        }

        public static bool IsDarkTheme()
        {
            return _isDarkTheme;
        }
    }
}

