using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        private static readonly string LocalesPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Locales"
        );

        /// <summary>
        /// Loads the localization for the specified culture.
        /// </summary>
        public static void LoadLocalization(CultureInfo culture)
        {
            var fileName = culture.Equals(CultureInfo.InvariantCulture) || culture.Equals(CultureInfo.CurrentCulture)
                ? "strings.json"
                : $"strings.{culture.Name}.json";

            var filePath = Path.Combine(LocalesPath, fileName);

            if (!File.Exists(filePath))
            {
                // Fallback to English if culture-specific file doesn't exist
                filePath = Path.Combine(LocalesPath, "strings.json");
            }

            try
            {
                var json = File.ReadAllText(filePath);
                _currentLocalization = JsonSerializer.Deserialize<Dictionary<string, string>>(json) 
                    ?? new Dictionary<string, string>();
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
        /// Applies localization to a control based on its name.
        /// For controls, the name is used as the key (e.g., "okButton" -> "OK" from JSON).
        /// </summary>
        public static void ApplyControlLocalization(Control control)
        {
            // Get the control name without the type suffix (e.g., "okButton" -> "OK")
            var controlName = control.Name;

            // Map common control names to localization keys
            var localizationKey = GetLocalizationKeyForControl(controlName);

            if (!string.IsNullOrEmpty(localizationKey))
            {
                var localizedText = GetString(localizationKey);
                if (localizedText != localizationKey) // Only set if we have a translation
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

        /// <summary>
        /// Maps control names and menu item names to localization keys.
        /// </summary>
        private static string GetLocalizationKeyForControl(string controlName)
        {
            return controlName switch
            {
                // Buttons
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

                // CheckBox and Labels
                "useSystemLanguageCheckBox" => "UseSystemLanguage",
                "recentFilesMaxlabel" => "ItemsShownInTheRecentFilesMenu",

                // Menu Items - File
                "fileToolStripMenuItem" => "File",
                "openToolStripMenuItem" => "Open",
                "saveToolStripMenuItem" => "Save",
                "recentFilesToolStripMenuItem" => "RecentFiles",
                "exitToolStripMenuItem" => "Exit",

                // Menu Items - Edit
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

                // Menu Items - Help
                "helpToolStripMenuItem" => "Help",
                "aboutToolStripMenuItem" => "About",
                "optionsToolStripMenuItem" => "Options",

                // Other items
                "copyToolStripMenuItem1" => "Copy",
                "copyHexToolStripMenuItem1" => "CopyHex",
                "pasteToolStripMenuItem1" => "Paste",
                "pasteHexToolStripMenuItem1" => "PasteHex",

                _ => null
            };
        }
    }
}
