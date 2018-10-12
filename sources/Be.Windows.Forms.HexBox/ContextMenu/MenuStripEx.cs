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
            ScalingStripExtension = new ScalingStripExtension(this);
        }
    }
}
