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
            var path = @"C:\dev\hexbox\sources\IG\Images\";
            ProcessImage(path, "Open.svg");
            ProcessImage(path, "Save.svg");
            ProcessImage(path, "SaveStatusBar.svg");
            ProcessImage(path, "Cut.svg");
            ProcessImage(path, "Copy.svg");
            ProcessImage(path, "Paste.svg");
            ProcessImage(path, "QuickFind.svg");
            ProcessImage(path, "FindNext.svg");
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
