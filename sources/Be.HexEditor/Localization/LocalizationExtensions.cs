using System;
using System.Windows.Forms;

namespace Be.HexEditor.Localization
{
    /// <summary>
    /// Helper extension methods for applying localization to UI elements.
    /// </summary>
    internal static class LocalizationExtensions
    {
        /// <summary>
        /// Recursively applies localization to all controls and menu items in a form or container.
        /// </summary>
        public static void ApplyLocalization(this Control control)
        {
            // Apply localization to the control itself
            LocalizeControl(control);

            // Recursively apply to all child controls
            foreach (Control child in control.Controls)
            {
                ApplyLocalization(child);
            }

            // If it's a form with menu items, apply to them too
            if (control is Form form && form.MainMenuStrip != null)
            {
                ApplyLocalizationToMenuStrip(form.MainMenuStrip);
            }
        }

        /// <summary>
        /// Applies localization to a single control based on its name.
        /// </summary>
        private static void LocalizeControl(Control control)
        {
            var key = GetLocalizationKey(control.Name);
            if (!string.IsNullOrEmpty(key))
            {
                var localizedText = LocalizationManager.GetString(key);
                if (localizedText != key) // Only set if we have a translation
                {
                    control.Text = localizedText;
                }
            }
        }

        /// <summary>
        /// Recursively applies localization to menu strip items.
        /// </summary>
        private static void ApplyLocalizationToMenuStrip(MenuStrip menuStrip)
        {
            foreach (ToolStripItem item in menuStrip.Items)
            {
                LocalizeMenuItemRecursively(item);
            }
        }

        /// <summary>
        /// Recursively applies localization to a menu item and its child items.
        /// </summary>
        private static void LocalizeMenuItemRecursively(ToolStripItem item)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                var key = GetLocalizationKey(menuItem.Name);
                if (!string.IsNullOrEmpty(key))
                {
                    var localizedText = LocalizationManager.GetString(key);
                    if (localizedText != key)
                    {
                        menuItem.Text = localizedText;
                    }
                }

                // Recursively apply to child items
                foreach (ToolStripItem childItem in menuItem.DropDownItems)
                {
                    LocalizeMenuItemRecursively(childItem);
                }
            }
        }

        /// <summary>
        /// Gets the localization key for a control based on its name.
        /// </summary>
        private static string GetLocalizationKey(string controlName)
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
                "newToolStripMenuItem" => "New",

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

                // Menu Items - View
                "viewToolStripMenuItem" => "View",

                // Menu Items - Tools
                "toolsToolStripMenuItem" => "Tools",
                "optionsToolStripMenuItem" => "Options",

                // Menu Items - Help
                "helpToolStripMenuItem" => "Help",
                "aboutToolStripMenuItem" => "About",

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
