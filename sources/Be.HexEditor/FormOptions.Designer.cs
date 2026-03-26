namespace Be.HexEditor
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            selectLanguageLabel = new System.Windows.Forms.Label();
            languageComboBox = new System.Windows.Forms.ComboBox();
            useSystemLanguageCheckBox = new System.Windows.Forms.CheckBox();
            clearRecentFilesButton = new System.Windows.Forms.Button();
            recentFilesMaxlabel = new System.Windows.Forms.Label();
            recentFilesMaxTextBox = new System.Windows.Forms.TextBox();
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            uiManagerComponent = new UiManagerComponent(components);
            label1 = new System.Windows.Forms.Label();
            themeComboBox = new System.Windows.Forms.ComboBox();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // selectLanguageLabel
            // 
            resources.ApplyResources(selectLanguageLabel, "selectLanguageLabel");
            selectLanguageLabel.Name = "selectLanguageLabel";
            // 
            // languageComboBox
            // 
            languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            languageComboBox.FormattingEnabled = true;
            resources.ApplyResources(languageComboBox, "languageComboBox");
            languageComboBox.Name = "languageComboBox";
            // 
            // useSystemLanguageCheckBox
            // 
            resources.ApplyResources(useSystemLanguageCheckBox, "useSystemLanguageCheckBox");
            useSystemLanguageCheckBox.Name = "useSystemLanguageCheckBox";
            useSystemLanguageCheckBox.UseVisualStyleBackColor = true;
            useSystemLanguageCheckBox.CheckedChanged += useSystemLanguageCheckBox_CheckedChanged;
            // 
            // clearRecentFilesButton
            // 
            resources.ApplyResources(clearRecentFilesButton, "clearRecentFilesButton");
            clearRecentFilesButton.Name = "clearRecentFilesButton";
            clearRecentFilesButton.UseVisualStyleBackColor = true;
            clearRecentFilesButton.Click += clearRecentFilesButton_Click;
            // 
            // recentFilesMaxlabel
            // 
            resources.ApplyResources(recentFilesMaxlabel, "recentFilesMaxlabel");
            recentFilesMaxlabel.Name = "recentFilesMaxlabel";
            // 
            // recentFilesMaxTextBox
            // 
            resources.ApplyResources(recentFilesMaxTextBox, "recentFilesMaxTextBox");
            recentFilesMaxTextBox.Name = "recentFilesMaxTextBox";
            // 
            // okButton
            // 
            resources.ApplyResources(okButton, "okButton");
            okButton.Name = "okButton";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            resources.ApplyResources(cancelButton, "cancelButton");
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(flowLayoutPanel, "flowLayoutPanel");
            flowLayoutPanel.Controls.Add(cancelButton);
            flowLayoutPanel.Controls.Add(okButton);
            flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            uiManagerComponent.Mode = ThemeMode.Dark;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // themeComboBox
            // 
            themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            themeComboBox.FormattingEnabled = true;
            resources.ApplyResources(themeComboBox, "themeComboBox");
            themeComboBox.Name = "themeComboBox";
            // 
            // FormOptions
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = cancelButton;
            Controls.Add(themeComboBox);
            Controls.Add(label1);
            Controls.Add(clearRecentFilesButton);
            Controls.Add(recentFilesMaxlabel);
            Controls.Add(selectLanguageLabel);
            Controls.Add(recentFilesMaxTextBox);
            Controls.Add(flowLayoutPanel);
            Controls.Add(languageComboBox);
            Controls.Add(useSystemLanguageCheckBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOptions";
            ShowIcon = false;
            ShowInTaskbar = false;
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox recentFilesGroupBox;
        private System.Windows.Forms.Button clearRecentFilesButton;
        private System.Windows.Forms.Label recentFilesMaxlabel;
        private System.Windows.Forms.TextBox recentFilesMaxTextBox;
        private System.Windows.Forms.GroupBox languageSettingsGroupBox;
        private System.Windows.Forms.Label selectLanguageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.CheckBox useSystemLanguageCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UiManagerComponent uiManagerComponent;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.Label label1;
    }
}