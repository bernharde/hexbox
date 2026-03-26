using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor
{
    class ToolStripDarkRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(45, 45, 48));
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var color = e.Item.Selected
                ? Color.FromArgb(70, 70, 74)
                : Color.FromArgb(37, 37, 38);

            e.Graphics.FillRectangle(new SolidBrush(color), e.Item.ContentRectangle);
        }
    }
}
