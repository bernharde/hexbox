using System;
using System.Collections.Generic;
using System.Text;

namespace Be.HexEditor
{
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public static class DarkTitleBar
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attr,
            ref int attrValue,
            int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public static void Apply(Form form, bool dark)
        {
            if (Environment.OSVersion.Version.Major >= 10)
            {
                int value = dark ? 1 : 0;
                DwmSetWindowAttribute(
                    form.Handle,
                    DWMWA_USE_IMMERSIVE_DARK_MODE,
                    ref value,
                    sizeof(int));
            }
        }
    }
}
