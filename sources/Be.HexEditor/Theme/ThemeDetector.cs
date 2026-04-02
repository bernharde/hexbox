using System;
using System.Collections.Generic;
using System.Text;

namespace Be.HexEditor.Theme
{
    using Microsoft.Win32;
    using System;

    public static class ThemeDetector
    {
        /// <summary>
        /// Returns true if Windows is in Dark Mode (for Apps)
        /// </summary>
        public static bool IsDarkTheme()
        {
            try
            {
                using var key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");

                if (key != null)
                {
                    var value = key.GetValue("AppsUseLightTheme");

                    // 0 = Dark Theme, 1 = Light Theme
                    if (value is int intValue)
                    {
                        return intValue == 0;   // Dark mode
                    }
                }
            }
            catch (Exception ex)
            {
                // Fallback in case of error (e.g. permission issues)
                Console.WriteLine($"Error reading theme: {ex.Message}");
            }

            return false; // Default to light if we can't read
        }

        /// <summary>
        /// Returns true if Windows system mode (taskbar/start menu) is Dark
        /// </summary>
        public static bool IsSystemDarkTheme()
        {
            try
            {
                using var key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");

                var value = key?.GetValue("SystemUsesLightTheme");
                if (value is int intValue)
                {
                    return intValue == 0;
                }
            }
            catch { }

            return false;
        }
    }
}
