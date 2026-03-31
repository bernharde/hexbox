using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Theme
{
    class VsColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30);
        public override Color ImageMarginGradientBegin => Color.FromArgb(30, 30, 30);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(30, 30, 30);
        public override Color ImageMarginGradientEnd => Color.FromArgb(30, 30, 30);

        public override Color MenuItemSelected => Color.FromArgb(45, 45, 48);
        public override Color MenuItemBorder => Color.FromArgb(45, 45, 48);

        public override Color ButtonSelectedHighlight => Color.FromArgb(45, 45, 48);
        public override Color ButtonPressedHighlight => Color.FromArgb(0, 122, 204);
    }

    // =========================
    // DARK RENDERER
    // =========================

    public class ToolStripDarkRenderer : ToolStripProfessionalRenderer
    {
        public ToolStripDarkRenderer() : base(new VsColorTable())
        {
        }


        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(45, 45, 48));
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var color = e.Item.Selected
                ? Color.FromArgb(70, 70, 74)
                : Color.FromArgb(37, 37, 38);

            using var brush = new SolidBrush(color);
            e.Graphics.FillRectangle(brush, e.Item.ContentRectangle);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            var color = Color.FromArgb(70, 70, 70);
            int y = e.Item.Height / 2;

            using var pen = new Pen(color);
            e.Graphics.DrawLine(pen, 4, y, e.Item.Width - 4, y);
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            // remove white strip completely
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //using var pen = new Pen(Color.FromArgb(60, 60, 60));
            //e.Graphics.DrawRectangle(
            //    pen,
            //    0, 0,
            //    e.ToolStrip.Width - 1,
            //    e.ToolStrip.Height - 1);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            if(e.Item?.Enabled == true)
                e.ArrowColor = Color.WhiteSmoke;
            base.OnRenderArrow(e);
        }
    }
}
