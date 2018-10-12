using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class MenuStripEx : MenuStrip
    {     
        ScalingStripExtension ScalingStripExtension { get; set; }
        public MenuStripEx()
        {
            if (!Util.IsPerMonitorV2)
                return;

            ScalingStripExtension = new ScalingStripExtension(this);
        }
    }
}
