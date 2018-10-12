using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class ToolStripMenuItemEx : ToolStripMenuItem, IScalingImage
    {
        [DefaultValue(null)]
        public string ScalingImageResourceName { get; set; }
                       
    }
}
