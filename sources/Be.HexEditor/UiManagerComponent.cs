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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ThemeMode Mode { get; set; } = ThemeMode.System;

        private Form? _form;

        public void BeginInit() { }

        public void EndInit()
        {
            // Called after designer initializes component
            _form = FindForm();

            if (_form != null)
            {
                _form.Load += (s, e) => Apply(_form);
            }
        }

        private Form? FindForm()
        {
            return this.Site?.Container?.Components
                .OfType<Form>()
                .FirstOrDefault();
        }

        private bool IsDark()
        {
            if (Mode == ThemeMode.Dark) return true;
            if (Mode == ThemeMode.Light) return false;

            var value = Microsoft.Win32.Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                "AppsUseLightTheme", 1);

            return (int)value == 0;
        }

        public void Apply(Form form)
        {
            bool dark = IsDark();
            var theme = dark ? Themes.Dark : Themes.Light;

            ThemeManager.Apply(form, theme, dark);
            ImageApplier.Apply(form, dark);
            ConfigureToolStrips(form);
        }

        private void ConfigureToolStrips(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ToolStrip ts)
                {
                    int size = parent.DeviceDpi >= 192 ? 32 :
                               parent.DeviceDpi >= 144 ? 24 : 16;

                    ts.ImageScalingSize = new Size(size, size);
                    ts.AutoSize = false;
                    ts.Height = size + 8;
                }

                ConfigureToolStrips(c);
            }
        }
    }
}
