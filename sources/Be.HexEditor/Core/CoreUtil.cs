using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Core
{
    public static class CoreUtil
    {
        public static void AdjustImages(ToolStrip toolStrip)
        {
            if (Util.DesignMode) return;

            //var newDpi = _form.DpiNew;
            var factor = (float)toolStrip.DeviceDpi / 96F;

            //MessageBox.Show(factor.ToString());

            //if ((dpiNew == 0) || (dpiOld == dpiNew)) return; // Abort.

            //float factor = _form.DpiNew / _dpiOld;

            //dpiOld = dpiNew;

            //MessageBox.Show(factor.ToString());

            toolStrip.ImageScalingSize = new System.Drawing.Size((int)(16F * factor), (int)(16F * factor));

            Debug.WriteLine($"AdjustImages factor: {factor}, scalingSize: {toolStrip.ImageScalingSize}");

            //MessageBox.Show(toolStrip.ImageScalingSize.Width.ToString());

            var width = toolStrip.ImageScalingSize.Width;

            foreach (ToolStripItem item in toolStrip.Items)
            {
                var scalingItem = item as IScalingItem;
                if (scalingItem == null)
                    continue;

                
                if (width < 17 && scalingItem.Image16 != null)
                    item.Image = scalingItem.Image16;
                else if (width < 25 && scalingItem.Image24 != null)
                    item.Image = scalingItem.Image24;
                else if (width < 33 && scalingItem.Image32 != null)
                    item.Image = scalingItem.Image32;

                if (!string.IsNullOrEmpty(scalingItem.PngResourceName))
                {
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

                    var png = scalingItem.PngResourceName + size;
                    var bitmap = (System.Drawing.Bitmap)Pngs.ResourceManager.GetObject(png);
                    item.Image = bitmap;
                }
            }
        }

        public static void ScaleFont(Control control)
        {
            var factor = control.DeviceDpi / 96F;
            control.Font = new Font(control.Font.FontFamily, SystemFonts.MessageBoxFont.Size * factor, control.Font.Style);
        }

        public static T GetParent<T>(Control c) where T : Control
        {
            if (c == null)
                return default(T);

            var parent = c.Parent;

            var found = parent as T;
            if (found != null)
                return found;

            return GetParent<T>(parent);
        }
    }
}
