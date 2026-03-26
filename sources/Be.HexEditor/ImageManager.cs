using System;
using System.Drawing;
using System.Windows.Forms;

namespace Be.HexEditor
{
    public static class ImageManager
    {
        public static Image Get(string name, float dpi)
        {
            int size = dpi switch
            {
                >= 192 => 32,
                >= 144 => 24,
                _ => 16
            };

            string key = $"{name}{size}";

            var rm = FluentUI.ResourceManager;

            var img = (Image?)rm.GetObject(key);

            // fallback (important!)
            if (img == null && size == 32)
                img = (Image?)rm.GetObject($"{name}24");

            if (img == null && size == 24)
                img = (Image?)rm.GetObject($"{name}16");

            return img!;
        }
    }
}