using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class ToolStripEx : ToolStrip
    {
        ScalingStripExtension ScalingStripExtension { get; set; }
        public ToolStripEx()
        {
            ScalingStripExtension = new ScalingStripExtension(this);
        }
    }
}
