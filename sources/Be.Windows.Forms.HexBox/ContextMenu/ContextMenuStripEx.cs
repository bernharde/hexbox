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
            if (!Util.IsPerMonitorV2)
                return;

            ScalingStripExtension = new ScalingStripExtension(this);
            Opened += ContextMenuStripEx_Opened;
        }

        private void ContextMenuStripEx_Opened(object sender, EventArgs e)
        {
            ScalingStripExtension.AdjustImages();
            ScalingStripExtension.AdjustFonts();
        }
    }
}
