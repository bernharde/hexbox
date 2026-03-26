using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor
{
    public enum ThemeMode
    {
        Light,
        Dark,
        System
    }



    public class UiManagerComponent : Component, ISupportInitialize
    {
        public UiManagerComponent() { }

        public UiManagerComponent(IContainer container)
        {
            container.Add(this);
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ThemeMode Mode { get; set; } = ThemeMode.System;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Form? Form { get; set; }

        public void BeginInit() { }

        public void EndInit()
        {
            if (Form != null)
            {
                Form.Load += (s, e) => Apply(Form);
            }
        }

        private bool IsDark()
        {
            if (Mode == ThemeMode.Dark) return true;
            if (Mode == ThemeMode.Light) return false;

            var value = Microsoft.Win32.Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                "AppsUseLightTheme", 1);

            return value is int i && i == 0;
        }

        public void Apply(Form form)
        {
            bool dark = IsDark();

            DarkTitleBar.Apply(form, dark);

            var theme = dark ? Themes.Dark : Themes.Light;

            ThemeManager.Apply(form, theme, dark);
            ImageApplier.Apply(form, dark);

            ConfigureToolStrips(form, dark);
            FixToolStripText(form, dark);
        }

        // =========================
        // TOOLSTRIP CONFIG
        // =========================

        private void ConfigureToolStrips(Control parent, bool dark)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ToolStrip ts)
                {
                    int size = parent.DeviceDpi >= 192 ? 32 :
                               parent.DeviceDpi >= 144 ? 24 : 16;

                    ts.ImageScalingSize = new Size(size, size);
                    ts.RenderMode = ToolStripRenderMode.Professional;
                    ts.Renderer = new ToolStripDarkRenderer();

                    ts.Padding = new Padding(2, 3, 2, 3);

                    foreach (ToolStripItem item in ts.Items)
                    {
                        item.Padding = new Padding(3);
                    }
                }

                ConfigureToolStrips(c, dark);
            }
        }

        // =========================
        // TEXT COLOR FIX
        // =========================

        private void FixToolStripText(Control parent, bool dark)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ToolStrip ts)
                {
                    var foreColor = dark
                        ? Color.FromArgb(230, 230, 230)
                        : Color.Black;

                    foreach (ToolStripItem item in ts.Items)
                    {
                        item.ForeColor = foreColor;
                        ApplyDropDown(item, foreColor);
                    }
                }

                FixToolStripText(c, dark);
            }
        }

        private void ApplyDropDown(ToolStripItem item, Color foreColor)
        {
            if (item is ToolStripDropDownItem dd)
            {
                foreach (ToolStripItem sub in dd.DropDownItems)
                {
                    sub.ForeColor = foreColor;
                    ApplyDropDown(sub, foreColor);
                }
            }
        }
    }

}