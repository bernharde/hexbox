using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Core
{
    public class ToolStripSplitButtonEx : ToolStripSplitButton, IScalingItem
    {
        [DefaultValue(null)]
        public string PngResourceName { get; set; }

    }
}
