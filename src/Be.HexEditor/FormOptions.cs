using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Be.HexEditor.Properties;
using Be.HexEditor.Localization;
using Be.HexEditor.Theme;

namespace Be.HexEditor
{
    public partial class FormOptions : Form
    {

        bool useSystemLanguage;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UseSystemLanguage
        {
            get { return useSystemLanguage; }
            set { useSystemLanguage = value; }
        }

        void UpdateThemeButtons()
        {
            var currentTheme = UiManagerComponent.CurrentSystemColorMode;
            var accentColor = Color.FromArgb(0, 120, 215); // Blue accent
            var inactiveColor = Color.Transparent;

            // Determine text color based on theme
            var activeForeColor = Color.White; // White text on blue accent
            var inactiveForeColor = currentTheme == SystemColorMode.Classic ? Color.Black : Color.White;

            // Update System button
            btnThemeSystem.BackColor = currentTheme == SystemColorMode.System ? accentColor : inactiveColor;
            btnThemeSystem.ForeColor = currentTheme == SystemColorMode.System ? activeForeColor : inactiveForeColor;

            // Update Dark button
            btnThemeDark.BackColor = currentTheme == SystemColorMode.Dark ? accentColor : inactiveColor;
            btnThemeDark.ForeColor = currentTheme == SystemColorMode.Dark ? activeForeColor : inactiveForeColor;

            // Update Light button
            btnThemeLight.BackColor = currentTheme == SystemColorMode.Classic ? accentColor : inactiveColor;
            btnThemeLight.ForeColor = currentTheme == SystemColorMode.Classic ? activeForeColor : inactiveForeColor;

            // Force refresh
            btnThemeSystem.Refresh();
            btnThemeDark.Refresh();
            btnThemeLight.Refresh();
        }

        public FormOptions()
        {
            InitializeComponent();

            // Load localization based on current culture
            LocalizationManager.LoadCurrentCulture();

            // Apply localization to all UI elements
            this.ApplyLocalization();

            this.recentFilesMaxTextBox.Text = Settings.Default.RecentFilesMax.ToString();
            this.useSystemLanguageCheckBox.Checked = Settings.Default.UseSystemLanguage;

            if (string.IsNullOrEmpty(Settings.Default.SelectedLanguage))
                Settings.Default.SelectedLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Rows.Add("English", "en");
            dt.Rows.Add("Deutsch", "de");
            dt.Rows.Add("Italiano", "it");
            dt.Rows.Add("日本語", "ja");
            dt.Rows.Add("Русский", "ru");
            dt.Rows.Add("中文", "zh-CN");
            dt.DefaultView.Sort = "Name";

            this.languageListBox.DataSource = dt.DefaultView;
            this.languageListBox.DisplayMember = "Name";
            this.languageListBox.ValueMember = "Value";
            this.languageListBox.SelectedValue = Settings.Default.SelectedLanguage;
            if (this.languageListBox.SelectedIndex == -1)
                this.languageListBox.SelectedIndex = 0;

            // Add event handler for immediate language switching
            this.languageListBox.SelectedIndexChanged += LanguageListBox_SelectedIndexChanged;

            // Initialize theme buttons
            UpdateThemeButtons();
        }

        void clearRecentFilesButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.recentFileHandler.Clear();
        }

        void useSystemLanguageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.languageListBox.Enabled = !useSystemLanguageCheckBox.Checked;

            CheckLanguageChange();
        }

        private void CheckLanguageChange()
        {
            var hasChanges = false;
            if (Settings.Default.UseSystemLanguage != useSystemLanguageCheckBox.Checked)
            {
                Settings.Default.UseSystemLanguage = useSystemLanguageCheckBox.Checked;
                hasChanges = true;
            }

            string selectedLanguage = (string)this.languageListBox.SelectedValue;
            if (selectedLanguage != Settings.Default.SelectedLanguage)
            {
                Settings.Default.SelectedLanguage = selectedLanguage;
                hasChanges = true;
            }

            if (hasChanges)
            {
                Settings.Default.Save();
                Program.SetCulture();
                LocalizationManager.LoadCurrentCulture();
                foreach (Form form in Application.OpenForms)
                {
                    if (form != null && !form.IsDisposed)
                    {
                        form.ApplyLocalization();
                    }
                }
            }
        }

        void LanguageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckLanguageChange();
        }

        private void SetTheme(SystemColorMode mode)
        {
            if (UiManagerComponent.CurrentSystemColorMode != mode)
            {
                Settings.Default.SelectedSystemColorMode = mode;
                Settings.Default.Save();
                UpdateThemeButtons();

                MessageBox.Show(LocalizationManager.GetString("ProgramRestartSettings"), LocalizationManager.GetString("Information"), MessageBoxButtons.OK);
            }
        }

        void BtnThemeSystem_Click(object sender, EventArgs e)
        {
            SetTheme(SystemColorMode.System);
        }

        void BtnThemeDark_Click(object sender, EventArgs e)
        {
            SetTheme(SystemColorMode.Dark);
        }

        void BtnThemeLight_Click(object sender, EventArgs e)
        {
            SetTheme(SystemColorMode.Classic);
        }

        private void recentFilesMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            var ok = int.TryParse(recentFilesMaxTextBox.Text, out int count);
            if (ok)
            {
                if (Settings.Default.RecentFilesMax != count)
                {
                    Settings.Default.RecentFilesMax = count;
                    Settings.Default.Save();
                }
            }

        }
    }
}