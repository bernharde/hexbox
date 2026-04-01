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
                fileNames.Add($"strings.{culture.Name}.json");
                
                // 2. Neutral language (e.g., de from de-DE)
                if (!string.IsNullOrEmpty(culture.Name) && culture.Name.Contains("-"))
                {
                    var neutral = culture.Name.Split('-')[0];
                    fileNames.Add($"strings.{neutral}.json");
                }
            }
            
            // 3. Default invariant culture
            fileNames.Add("strings.json");
            
            try
            {
                foreach (var fileName in fileNames)
                {
                    var stream = FindEmbeddedResource(assembly, fileName);
                    
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
        /// Finds an embedded resource by searching common resource name patterns.
        /// </summary>
        private static Stream FindEmbeddedResource(Assembly assembly, string fileName)
        {
            // Try multiple possible resource name patterns
            var resourcePatterns = new[]
            {
                $"Be.HexEditor.Locales.{fileName}",
                fileName
            };

            foreach (var pattern in resourcePatterns)
            {
                var stream = assembly.GetManifestResourceStream(pattern);       
                if (stream != null)
                {
                    return stream;
                }
            }

            // Log available resources for debugging
            System.Diagnostics.Debug.WriteLine($"Available resources for '{fileName}':");
            var allResources = assembly.GetManifestResourceNames();
            var matchingResources = allResources.Where(r => r.Contains(fileName)).ToList();
            if (matchingResources.Count > 0)
            {
                foreach (var resource in matchingResources)
                {
                    System.Diagnostics.Debug.WriteLine($"  - {resource}");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"  No resources found containing '{fileName}'");
                System.Diagnostics.Debug.WriteLine($"  All embedded resources:");
                foreach (var resource in allResources.Where(r => r.Contains("Locales") || r.Contains("strings")).OrderBy(r => r))
                {
                    System.Diagnostics.Debug.WriteLine($"    - {resource}");
                }
            }

            return null;
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
        /// Applies localization to a control based on its name.
        /// For controls, the name is used as the key (e.g., "okButton" -> "OK" from JSON).
        /// </summary>
        public static void ApplyControlLocalization(Control control)
        {
            var controlName = control.Name;
            var localizationKey = GetLocalizationKeyForControl(controlName);

            if (!string.IsNullOrEmpty(localizationKey))
            {
                var localizedText = GetString(localizationKey);
                if (localizedText != localizationKey)
                {
                    control.Text = localizedText;
                }
            }

            foreach (Control child in control.Controls)
            {
                ApplyControlLocalization(child);
            }
        }

        /// <summary>
        /// Maps control names and menu item names to localization keys.
        /// </summary>
        private static string GetLocalizationKeyForControl(string controlName)
        {
            return controlName switch
            {
                "okButton" => "OK",
                "cancelButton" => "Cancel",
                "applyButton" => "Apply",
                "yesButton" => "Yes",
                "noButton" => "No",
                "closeButton" => "Close",
                "openButton" => "Open",
                "saveButton" => "Save",
                "findButton" => "Find",
                "findAllButton" => "FindAll",
                "findNextButton" => "FindNext",
                "clearRecentFilesButton" => "ClearRecentFiles",
                "useSystemLanguageCheckBox" => "UseSystemLanguage",
                "recentFilesMaxlabel" => "ItemsShownInTheRecentFilesMenu",
                "fileToolStripMenuItem" => "File",
                "openToolStripMenuItem" => "Open",
                "saveToolStripMenuItem" => "Save",
                "recentFilesToolStripMenuItem" => "RecentFiles",
                "exitToolStripMenuItem" => "Exit",
                "editToolStripMenuItem" => "Edit",
                "cutToolStripMenuItem" => "Cut",
                "copyToolStripMenuItem" => "Copy",
                "pasteToolStripMenuItem" => "Paste",
                "copyHexStringToolStripMenuItem" => "CopyHex",
                "pasteHexToolStripMenuItem" => "PasteHex",
                "findToolStripMenuItem" => "Find",
                "findNextToolStripMenuItem" => "FindNext",
                "goToToolStripMenuItem" => "GoTo",
                "selectAllToolStripMenuItem" => "SelectAll",
                "helpToolStripMenuItem" => "Help",
                "aboutToolStripMenuItem" => "About",
                "optionsToolStripMenuItem" => "Options",
                "copyToolStripMenuItem1" => "Copy",
                "copyHexToolStripMenuItem1" => "CopyHex",
                "pasteToolStripMenuItem1" => "Paste",
                "pasteHexToolStripMenuItem1" => "PasteHex",
                _ => null
            };
        }
    }
}
