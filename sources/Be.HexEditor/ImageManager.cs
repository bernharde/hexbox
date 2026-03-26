using System;
using System.Drawing;
using System.Windows.Forms;

namespace Be.HexEditor
{
    public static class ImageManager
    {
        public static Image Get(string name, float dpi, bool dark)
        {
            int size = dpi switch
            {
                >= 192 => 32,
                >= 144 => 24,
                _ => 16
            };

            string theme = dark ? "dark" : "light";
            string key = $"{name}_{theme}_{size}";

            var rm = FluentUI.ResourceManager;

            var img = (Image?)rm.GetObject(key);

            // fallback (important!)
            if (img == null && size == 32)
                img = (Image?)rm.GetObject($"{name}_{theme}_24");

            if (img == null && size == 24)
                img = (Image?)rm.GetObject($"{name}_{theme}_16");

            return img!;
        }
    }
}