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
            var section = (NameValueCollection)ConfigurationManager.GetSection("System.Windows.Forms.ApplicationConfigurationSection");
            if(section != null)
            {
                DpiAwareness = section["DpiAwareness"];
                IsPerMonitorV2 = DpiAwareness == "PerMonitorV2";
            }
        }

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
