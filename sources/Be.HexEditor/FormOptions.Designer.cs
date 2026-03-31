using Be.HexEditor.Theme;
using Be.HexEditor.Localization;

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
            useSystemLanguageCheckBox = new System.Windows.Forms.CheckBox();
            clearRecentFilesButton = new System.Windows.Forms.Button();
            recentFilesMaxlabel = new System.Windows.Forms.Label();
            recentFilesMaxTextBox = new System.Windows.Forms.TextBox();
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            uiManagerComponent = new UiManagerComponent(components);
            languageListBox = new System.Windows.Forms.ListBox();
            flowLayoutPanelTheme = new EnumPanel();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // useSystemLanguageCheckBox
            // 
            useSystemLanguageCheckBox.AutoSize = true;
            useSystemLanguageCheckBox.Location = new System.Drawing.Point(14, 14);
            useSystemLanguageCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            useSystemLanguageCheckBox.Name = "useSystemLanguageCheckBox";
            useSystemLanguageCheckBox.Size = new System.Drawing.Size(134, 17);
            useSystemLanguageCheckBox.TabIndex = 0;
            useSystemLanguageCheckBox.Text = "Use system language";
            useSystemLanguageCheckBox.UseVisualStyleBackColor = true;
            useSystemLanguageCheckBox.CheckedChanged += useSystemLanguageCheckBox_CheckedChanged;
            // 
            // clearRecentFilesButton
            // 
            clearRecentFilesButton.AutoSize = true;
            clearRecentFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clearRecentFilesButton.Location = new System.Drawing.Point(28, 243);
            clearRecentFilesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            clearRecentFilesButton.Name = "clearRecentFilesButton";
            clearRecentFilesButton.Size = new System.Drawing.Size(120, 34);
            clearRecentFilesButton.TabIndex = 2;
            clearRecentFilesButton.Text = LocalizationManager.GetString("ClearRecentFiles");
            clearRecentFilesButton.UseVisualStyleBackColor = true;
            clearRecentFilesButton.Click += clearRecentFilesButton_Click;
            // 
            // recentFilesMaxlabel
            // 
            recentFilesMaxlabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            recentFilesMaxlabel.AutoSize = true;
            recentFilesMaxlabel.Location = new System.Drawing.Point(14, 214);
            recentFilesMaxlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            recentFilesMaxlabel.Name = "recentFilesMaxlabel";
            recentFilesMaxlabel.Size = new System.Drawing.Size(196, 13);
            recentFilesMaxlabel.TabIndex = 1;
            recentFilesMaxlabel.Text = "Items shown in the recent files menu";
            // 
            // recentFilesMaxTextBox
            // 
            recentFilesMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            recentFilesMaxTextBox.Location = new System.Drawing.Point(218, 214);
            recentFilesMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            recentFilesMaxTextBox.Name = "recentFilesMaxTextBox";
            recentFilesMaxTextBox.Size = new System.Drawing.Size(66, 22);
            recentFilesMaxTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.AutoSize = true;
            okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            okButton.Location = new System.Drawing.Point(62, 5);
            okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(120, 34);
            okButton.TabIndex = 1;
            okButton.Text = LocalizationManager.GetString("OK");
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cancelButton.Location = new System.Drawing.Point(190, 5);
            cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(120, 34);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanel.Controls.Add(cancelButton);
            flowLayoutPanel.Controls.Add(okButton);
            flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel.Location = new System.Drawing.Point(8, 350);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new System.Drawing.Size(314, 50);
            flowLayoutPanel.TabIndex = 3;
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // languageListBox
            // 
            languageListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            languageListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            languageListBox.FormattingEnabled = true;
            languageListBox.Location = new System.Drawing.Point(28, 39);
            languageListBox.Name = "languageListBox";
            languageListBox.Size = new System.Drawing.Size(294, 156);
            languageListBox.TabIndex = 6;
            // 
            // flowLayoutPanelTheme
            // 
            flowLayoutPanelTheme.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanelTheme.AutoSize = true;
            flowLayoutPanelTheme.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            flowLayoutPanelTheme.EnumType = null;
            flowLayoutPanelTheme.HeaderText = "Theme";
            flowLayoutPanelTheme.Location = new System.Drawing.Point(8, 298);
            flowLayoutPanelTheme.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanelTheme.Name = "flowLayoutPanelTheme";
            flowLayoutPanelTheme.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelTheme.SelectedValue = null;
            flowLayoutPanelTheme.Size = new System.Drawing.Size(314, 46);
            flowLayoutPanelTheme.TabIndex = 7;
            flowLayoutPanelTheme.WrapContents = false;
            // 
            // FormOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = cancelButton;
            ClientSize = new System.Drawing.Size(331, 404);
            Controls.Add(flowLayoutPanelTheme);
            Controls.Add(languageListBox);
            Controls.Add(clearRecentFilesButton);
            Controls.Add(recentFilesMaxlabel);
            Controls.Add(recentFilesMaxTextBox);
            Controls.Add(flowLayoutPanel);
            Controls.Add(useSystemLanguageCheckBox);
            Font = new System.Drawing.Font("Segoe UI", 8.25F);
            Margin = new System.Windows.Forms.Padding(683, 129, 683, 129);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOptions";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Options";
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
        private System.Windows.Forms.CheckBox useSystemLanguageCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UiManagerComponent uiManagerComponent;
        private System.Windows.Forms.ListBox languageListBox;
        private Be.HexEditor.EnumPanel flowLayoutPanelTheme;
    }
}