using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Be.HexEditor.Properties;

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
            var textColor = Color.White;
            var theme = UiManagerComponent.CurrentTheme;
            buttonSystem.BackColor = theme == ThemeMode.System ? ;
            buttonDark.Checked = theme == ThemeMode.Dark;
            buttonLight.Checked = theme == ThemeMode.Light;
        }

        public FormOptions()
        {
            InitializeComponent();

            this.recentFilesMax = Settings.Default.RecentFilesMax;
            this.recentFilesMaxTextBox.DataBindings.Add("Text", this, "RecentFilesMax");
            this.useSystemLanguage = Settings.Default.UseSystemLanguage;
            this.useSystemLanguageCheckBox.DataBindings.Add("Checked", this, "UseSystemLanguage");

            var theme = UiManagerComponent.CurrentTheme;
            Button button;
            if (theme == ThemeMode.System)
                button = buttonSystem;
            this.themeComboBox.DataSource = Enum.GetValues(typeof(ThemeMode));
            this.themeComboBox.SelectedItem = UiManagerComponent.CurrentTheme;

            if (string.IsNullOrEmpty(Settings.Default.SelectedLanguage))
                Settings.Default.SelectedLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName; 

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Rows.Add(strings.English, "en");
            dt.Rows.Add(strings.German, "de");
			dt.Rows.Add(strings.Italian, "it");
            dt.Rows.Add(strings.Japanese, "ja");
            dt.Rows.Add(strings.Russian, "ru");
            dt.Rows.Add(strings.SimplifiedChinese, "zh-CN");
            dt.DefaultView.Sort = "Name";

            this.languageListBox.DataSource = dt.DefaultView;
            this.languageListBox.DisplayMember = "Name";
            this.languageListBox.ValueMember = "Value";
            this.languageListBox.SelectedValue = Settings.Default.SelectedLanguage;
            if (this.languageListBox.SelectedIndex == -1)
                this.languageListBox.SelectedIndex = 0;
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

            if ((ThemeMode)this.themeComboBox.SelectedValue != UiManagerComponent.CurrentTheme)
            {
                UiManagerComponent.CurrentTheme = (ThemeMode)this.themeComboBox.SelectedValue;
                changed = true;
            }

            if (Settings.Default.UseSystemLanguage != this.useSystemLanguage ||
                Settings.Default.SelectedLanguage != (string)this.languageListBox.SelectedValue)
            {
                Settings.Default.UseSystemLanguage = this.UseSystemLanguage;
                Settings.Default.SelectedLanguage = (string)this.languageListBox.SelectedValue;

                Program.ShowMessage(strings.ProgramRestartSettings);

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
    }
}
