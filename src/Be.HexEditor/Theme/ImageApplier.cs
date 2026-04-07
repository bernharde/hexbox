using System.Windows.Forms;

namespace Be.HexEditor.Theme
{
    public static class ImageApplier
    {
        public static void Apply(Control parent, bool dark)
        {
            foreach (Control c in parent.Controls)
            {
                // Buttons etc.
                if (c.Tag is string key)
                {
                    var img = ImageManager.Get(key, parent.DeviceDpi);

                    switch (c)
                    {
                        case Button btn:
                            btn.Image = img;
                            break;
                    }
                }

                // ToolStrips
                if (c is ToolStrip ts)
                {
                    ApplyToolStrip(ts, parent.DeviceDpi, dark);
                }

                Apply(c, dark);
            }
        }

        private static void ApplyToolStrip(ToolStrip ts, float dpi, bool dark)
        {
            foreach (ToolStripItem item in ts.Items)
            {
                if (item.Tag is string key)
                {
                    item.Image = ImageManager.Get(key, dpi);
                    item.ImageScaling = ToolStripItemImageScaling.None;
                }
            }
        }
    }
}
