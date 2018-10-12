using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    sealed class ScalingStripExtension : Component
    {
        ToolStrip ToolStrip { get; set; }

        ResourceManager ResourceManager { get; set; }

        public ScalingStripExtension(ToolStrip toolStrip)
        {
            if (!Util.IsPerMonitorV2)
                return;

            ToolStrip = toolStrip;
            toolStrip.HandleCreated += Scale;
            toolStrip.ParentChanged += Scale;
            toolStrip.DpiChangedAfterParent += ToolStrip_DpiChangedAfterParent;

            var resourceManagerTypeName = ConfigurationManager.AppSettings["ImageResourceManagerType"];
            if (!string.IsNullOrEmpty(resourceManagerTypeName))
            {
                var resourceManagerType = Type.GetType(resourceManagerTypeName);
                if (resourceManagerType != null)
                {
                    ResourceManager = new ResourceManager(resourceManagerType);
                }
                else
                {
                    Debug.WriteLine($"ScalingStripExtension ImageResourceManagerType with the name '{resourceManagerTypeName}' not found");
                }
            }
        }

        private void Scale(object sender, EventArgs e)
        {
            AdjustImages();
        }

        private void ToolStrip_DpiChangedAfterParent(object sender, EventArgs e)
        {
            AdjustImages();
            AdjustFonts();
        }

        public void AdjustFonts()
        {
            var control = GetControl();
            var form = Util.GetRoot<Control>(control);
            Debug.WriteLine($"Toolstrip.OnDpiChangedAfterParent deviceDpi: {ToolStrip.DeviceDpi} formFontSize: {form.Font.Size}, fontSize: {form.Font.Size}");
            foreach (ToolStripItem item in ToolStrip.Items)
            {
                item.Font = form.Font;
            }
        }

        public void AdjustImages()
        {
            if (Util.DesignMode)
                return;

            if (ResourceManager == null)
                return;

            Control control = GetControl();
            var factor = control.DeviceDpi / 96F;

            ToolStrip.ImageScalingSize = new Size((int)(16F * factor), (int)(16F * factor));

            Debug.WriteLine($"AdjustImages factor: {factor}, scalingSize: {ToolStrip.ImageScalingSize}");

            var width = ToolStrip.ImageScalingSize.Width;

            var size = 16;
            if (width < 17)
                size = 16;
            else if (width < 25)
                size = 24;
            else if (width < 33)
                size = 32;
            else if (width < 49)
                size = 48;
            else if (width < 65)
                size = 64;
            else if (width < 129)
                size = 128;

            foreach (ToolStripItem item in ToolStrip.Items)
            {
                var scalingItem = item as IScalingImage;
                if (scalingItem == null)
                    continue;

                if (!string.IsNullOrEmpty(scalingItem.ScalingImageResourceName))
                {
                    var png = scalingItem.ScalingImageResourceName + size;
                    var bitmap = (Bitmap)ResourceManager.GetObject(png);
                    item.Image = bitmap;
                }
            }
        }

        private Control GetControl()
        {
            Control control;
            var cx = ToolStrip as ContextMenuStrip;
            if (cx != null)
            {
                control = cx.SourceControl;
            }
            else
            {
                control = ToolStrip;
            }

            return control;
        }
    }
}
