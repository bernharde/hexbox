using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace Be.HexEditor.Localization
{
    /// <summary>
    /// Manages localization by loading JSON resource files and applying them to UI elements.
    /// </summary>
    internal static class LocalizationManager
    {
        private static Dictionary<string, string> _currentLocalization = new();

        /// <summary>
        /// Loads the localization for the specified culture from embedded resources.
        /// </summary>
        public static void LoadLocalization(CultureInfo culture)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Build fallback chain: specific culture → neutral language → en-US → en → default
            var fileNames = new List<string>();

            // 1. Exact culture match (e.g., de-DE)
            if (!culture.Equals(CultureInfo.InvariantCulture))
            {
                fileNames.Add($"strings-{culture.Name}.json");

                // 2. Neutral language (e.g., de from de-DE)
                if (!string.IsNullOrEmpty(culture.Name) && culture.Name.Contains("-"))
                {
                    var neutral = culture.Name.Split('-')[0];
                    fileNames.Add($"strings-{neutral}.json");
                }
            }

            // 3. Default invariant culture
            fileNames.Add("strings.json");
            
            try
            {
                foreach (var fileName in fileNames)
                {
                    var stream = assembly.GetManifestResourceStream($"Be.HexEditor.Locales.{fileName}");
                    if (stream != null)
                    {
                        using (stream)
                        using (var reader = new StreamReader(stream))
                        {
                            var json = reader.ReadToEnd();
                            _currentLocalization = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                                ?? new Dictionary<string, string>();
                            return;
                        }
                    }
                }
                
                // If we get here, no resource was found
                System.Diagnostics.Debug.WriteLine($"Error: Could not find any embedded localization resource");
                _currentLocalization = new Dictionary<string, string>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading localization: {ex.Message}");
                _currentLocalization = new Dictionary<string, string>();
            }
        }


        /// <summary>
        /// Gets the localized string for the specified key.
        /// </summary>
        public static string GetString(string key)
        {
            return _currentLocalization.TryGetValue(key, out var value) ? value : key;
        }

        /// <summary>
        /// Loads the current localization based on the current UI culture.
        /// </summary>
        public static void LoadCurrentCulture()
        {
            LoadLocalization(System.Threading.Thread.CurrentThread.CurrentUICulture);
        }

        /// <summary>
        /// Applies localization to a control based on its Tag property.
        /// The Tag property should contain the localization key (e.g., "okButton" -> Tag="OK").
        /// </summary>
        public static void ApplyControlLocalization(Control control)
        {
            // Check if control has a localization key in its Tag property
            if (control.Tag is string localizationKey && !string.IsNullOrEmpty(localizationKey))
            {
                var localizedText = GetString(localizationKey);
                if (localizedText != localizationKey)
                {
                    control.Text = localizedText;
                }
            }

            // Recursively apply to child controls
            foreach (Control child in control.Controls)
            {
                ApplyControlLocalization(child);
            }
        }
    }
}
