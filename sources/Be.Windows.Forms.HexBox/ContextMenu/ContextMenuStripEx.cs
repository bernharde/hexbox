using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class ContextMenuStripEx : ContextMenuStrip
    {
        ScalingStripExtension ScalingStripExtension { get; set; }
        public ContextMenuStripEx()
        {
            ScalingStripExtension = new ScalingStripExtension(this);

            this.Opened += ContextMenuStripEx_Opened;
        }

        private void ContextMenuStripEx_Opened(object sender, EventArgs e)
        {
            ScalingStripExtension.AdjustImages();
            ScalingStripExtension.AdjustFonts();
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);

            foreach(ToolStripItem item in this.Items)
            {
                Debug.WriteLine($"ContextMenuStripEx.OnDpiChangedAfterParent {DeviceDpi}, fontsize {item.Font.Size}");
            }
        }
    }
}
