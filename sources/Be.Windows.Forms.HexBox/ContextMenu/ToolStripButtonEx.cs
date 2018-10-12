using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class ToolStripButtonEx : ToolStripButton, IScalingImage
    {
        [DefaultValue(null)]
        public string ScalingImageResourceName { get; set; }

        public ToolStripButtonEx()
        {
            
        }
    }
}
