using Be.HexEditor.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Theme
{
    public static class ThemeManager
    {
        public static void Apply(Control control, AppTheme theme, bool dark)
            {
                control.BackColor = theme.BackColor;
                control.ForeColor = theme.ForeColor;

                if (control is ToolStrip ts)
                {
                    ts.BackColor = theme.ToolStripBack;
                    ts.ForeColor = theme.ForeColor;

                    ts.Renderer = dark
                        ? new ToolStripDarkRenderer()
                        : new ToolStripProfessionalRenderer();
                }

                if(control is Be.Windows.Forms.HexBox hexBox)
                {
                    hexBox.BackColorDisabled = theme.DisabledBackColor;
                }

                if (control is LinkLabel linkLabel)
                {
                    linkLabel.LinkColor = theme.AccentColor;
                    linkLabel.VisitedLinkColor = theme.AccentColor;
                }

                if (control is MenuStrip or ContextMenuStrip)
                {
                    control.BackColor = theme.MenuBack;
                }

                foreach (Control child in control.Controls)
                {
                    Apply(child, theme, dark);
                }
            }
    }
}
