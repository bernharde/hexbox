using Svg;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGen
{
    class Program
    {

        static void Main(string[] args)
        {
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "Open.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "Save.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "SaveStatusBar.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "Cut.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "Copy.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "Paste.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "QuickFind.svg");
            ProcessImage(@"C:\Users\mextbe\Desktop\i\Open17\", "FindNext.svg");
        }

        static void ProcessImage(string path, string filename)
        {
            ProcessImageSize(path, filename, 16);
            ProcessImageSize(path, filename, 24);
            ProcessImageSize(path, filename, 32);
            ProcessImageSize(path, filename, 48);
            ProcessImageSize(path, filename, 64);
            ProcessImageSize(path, filename, 128);
        }

        static void ProcessImageSize(string path, string filename, int size)
        {
            var filenameWoExt = Path.GetFileNameWithoutExtension(filename);
            var newFilenameWithPath = path + filenameWoExt + size + ".png";
            var doc = SvgDocument.Open(path+filename);
            doc.Height = doc.Width = size;
            doc.Draw().Save(newFilenameWithPath, ImageFormat.Png);
        }
    }
}
