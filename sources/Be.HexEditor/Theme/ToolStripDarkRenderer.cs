using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Theme
{
    public class ToolStripDarkRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            if(!UiManagerComponent.IsDark())
            {
                base.OnRenderItemImage(e);
                return;
            }

            if (!e.Item.Enabled && e.Image != null)
            {
                // Pick a visible disabled color
                Color tint = Color.FromArgb(100, 100, 100);

                using var ia = new System.Drawing.Imaging.ImageAttributes();

                float r = tint.R / 255f;
                float g = tint.G / 255f;
                float b = tint.B / 255f;

                var matrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
                {
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {r, g, b, 0, 1}
                });

                ia.SetColorMatrix(matrix);

                e.Graphics.DrawImage(
                    e.Image,
                    e.ImageRectangle,
                    0, 0, e.Image.Width, e.Image.Height,
                    GraphicsUnit.Pixel,
                    ia);

                return;
            }

            base.OnRenderItemImage(e);
        }
    }
}
