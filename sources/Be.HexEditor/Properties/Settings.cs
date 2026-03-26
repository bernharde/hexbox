using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be.HexEditor.Properties
{
    public class Settings
    {
        public static Settings Default = new();

        public int RecentFilesMax { get; set; } = 6;
        public bool UseSystemLanguage { get; set; } = true;
        public string SelectedLanguage { get; set; }
        public ThemeMode SelectedTheme { get; set; } = ThemeMode.Dark;

        public StringCollection RecentFiles { get; set; } = new StringCollection();

        public void Save() { }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
