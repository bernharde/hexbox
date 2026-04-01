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
    public partial class FormOptions: Form
    {
        int recentFilesMax;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RecentFilesMax
        {
            get { return recentFilesMax; }
            set 
            {
                if (recentFilesMax == value)
                    return;
                if (value < 0 || value > RecentFileHandler.MaxRecentFiles)
                    return;

                recentFilesMax = value; 
            }
        }


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
            var bgColor = Color.FromArgb(0, 120, 215);
            var theme = UiManagerComponent.CurrentTheme;
            btnThemeSystem.BackColor = theme == ThemeMode.System ? bgColor : Color.Transparent;
            btnThemeSystem.ForeColor = theme == ThemeMode.System ? Color.White : Color.White;
            btnThemeDark.BackColor = theme == ThemeMode.Dark ? bgColor : Color.Transparent;
            btnThemeDark.ForeColor = theme == ThemeMode.Dark ? Color.White : Color.White;
            btnThemeLight.BackColor = theme == ThemeMode.Light ? bgColor : Color.Transparent;
            btnThemeLight.ForeColor = theme == ThemeMode.Light ? Color.White : Color.White;
        }

		public FormOptions()
		{
			InitializeComponent();

			// Load localization based on current culture
			LocalizationManager.LoadCurrentCulture();

			// Apply localization to all UI elements
			this.ApplyLocalization();

			this.recentFilesMax = Settings.Default.RecentFilesMax;
			this.recentFilesMaxTextBox.DataBindings.Add("Text", this, "RecentFilesMax");
			this.useSystemLanguage = Settings.Default.UseSystemLanguage;
			this.useSystemLanguageCheckBox.DataBindings.Add("Checked", this, "UseSystemLanguage");

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

        void okButton_Click(object sender, EventArgs e)
        {
            bool changed = false;
            if (recentFilesMax != Settings.Default.RecentFilesMax)
            {
                Settings.Default.RecentFilesMax = recentFilesMax;
                changed = true;
            }

            //if ((ThemeMode)this.themeComboBox.SelectedValue != UiManagerComponent.CurrentTheme)
            //{
            //    UiManagerComponent.CurrentTheme = (ThemeMode)this.themeComboBox.SelectedValue;
            //    changed = true;
            //}

            if (Settings.Default.UseSystemLanguage != this.useSystemLanguage ||
                Settings.Default.SelectedLanguage != (string)this.languageListBox.SelectedValue)
            {
                Settings.Default.UseSystemLanguage = this.UseSystemLanguage;
                Settings.Default.SelectedLanguage = (string)this.languageListBox.SelectedValue;
                changed = true;
            }

            if(changed)
                Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
        }

        void useSystemLanguageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.languageListBox.Enabled = !useSystemLanguageCheckBox.Checked;
        }

        void LanguageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = (string)this.languageListBox.SelectedValue;
            if (selectedLanguage != Settings.Default.SelectedLanguage)
            {
                Settings.Default.SelectedLanguage = selectedLanguage;
                Settings.Default.Save();

                // Load new language and apply immediately
                var culture = new CultureInfo(selectedLanguage);
                LocalizationManager.LoadLocalization(culture);

                // Update all open forms immediately
                foreach (Form form in Application.OpenForms)
                {
                    if (form != null && !form.IsDisposed)
                    {
                        form.ApplyLocalization();
                    }
                }
            }
        }

        void BtnThemeSystem_Click(object sender, EventArgs e)
        {
            UiManagerComponent.CurrentTheme = ThemeMode.System;
            Settings.Default.SelectedTheme = ThemeMode.System;
            Settings.Default.Save();
            UpdateThemeButtons();
        }

        void BtnThemeDark_Click(object sender, EventArgs e)
        {
            UiManagerComponent.CurrentTheme = ThemeMode.Dark;
            Settings.Default.SelectedTheme = ThemeMode.Dark;
            Settings.Default.Save();
            UpdateThemeButtons();
        }

        void BtnThemeLight_Click(object sender, EventArgs e)
        {
            UiManagerComponent.CurrentTheme = ThemeMode.Light;
            Settings.Default.SelectedTheme = ThemeMode.Light;
            Settings.Default.Save();
            UpdateThemeButtons();
        }
    }
}





