using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class ToolStripEx : ToolStrip
    {
        ScalingStripExtension ScalingStripExtension { get; set; }
        public ToolStripEx()
        {
            if (!Util.IsPerMonitorV2)
                return;

            ScalingStripExtension = new ScalingStripExtension(this);
        }
    }
}
