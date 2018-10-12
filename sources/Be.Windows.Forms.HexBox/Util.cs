using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    static class Util
    {
        /// <summary>
        /// Initializes an instance of Util class
        /// </summary>
        static Util()
        {
            // design mode is true if host process is: Visual Studio, Visual Studio Express Versions (C#, VB, C++) or SharpDevelop
            var designerHosts = new List<string>() { "devenv", "vcsexpress", "vbexpress", "vcexpress", "sharpdevelop" };
            using (var process = System.Diagnostics.Process.GetCurrentProcess())
            {
                var processName = process.ProcessName.ToLower();
                DesignMode = designerHosts.Contains(processName);
            }
            var section = (NameValueCollection)ConfigurationManager.GetSection("System.Windows.Forms.ApplicationConfigurationSection");
            if(section != null)
            {
                DpiAwareness = section["DpiAwareness"];
                IsPerMonitorV2 = DpiAwareness == "PerMonitorV2";
            }
        }

        /// <summary>
        /// Gets true, if we are in design mode of Visual Studio
        /// </summary>
        /// <remarks>
        /// In Visual Studio 2008 SP1 the designer is crashing sometimes on windows forms. 
        /// The DesignMode property of Control class is buggy and cannot be used, so use our own implementation instead.
        /// </remarks>
        public static bool DesignMode { get; private set; }

        public static string DpiAwareness { get; set; }

        public static bool IsPerMonitorV2 { get; set; }

        public static T GetRoot<T>(Control c) where T : Control
        {
            if (c == null)
                return default(T);

            var parent = c.Parent;

            var found = parent as T;
            if (found != null && found.Parent == null)
                return found;

            return GetRoot<T>(parent);
        }

    }
}
