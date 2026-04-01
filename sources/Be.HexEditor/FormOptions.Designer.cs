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
            uiManagerComponent = new UiManagerComponent(components);
            languageListBox = new System.Windows.Forms.ListBox();
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
            clearRecentFilesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            clearRecentFilesButton.AutoSize = true;
            clearRecentFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clearRecentFilesButton.Location = new System.Drawing.Point(28, 257);
            clearRecentFilesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            clearRecentFilesButton.Name = "clearRecentFilesButton";
            clearRecentFilesButton.Size = new System.Drawing.Size(103, 25);
            clearRecentFilesButton.TabIndex = 2;
            clearRecentFilesButton.Text = "ClearRecentFiles";
            clearRecentFilesButton.UseVisualStyleBackColor = true;
            clearRecentFilesButton.Click += clearRecentFilesButton_Click;
            // 
            // recentFilesMaxlabel
            // 
            recentFilesMaxlabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            recentFilesMaxlabel.AutoSize = true;
            recentFilesMaxlabel.Location = new System.Drawing.Point(14, 207);
            recentFilesMaxlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            recentFilesMaxlabel.Name = "recentFilesMaxlabel";
            recentFilesMaxlabel.Size = new System.Drawing.Size(196, 13);
            recentFilesMaxlabel.TabIndex = 1;
            recentFilesMaxlabel.Text = "Items shown in the recent files menu";
            // 
            // recentFilesMaxTextBox
            // 
            recentFilesMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            recentFilesMaxTextBox.Location = new System.Drawing.Point(28, 225);
            recentFilesMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            recentFilesMaxTextBox.Name = "recentFilesMaxTextBox";
            recentFilesMaxTextBox.Size = new System.Drawing.Size(66, 22);
            recentFilesMaxTextBox.TabIndex = 0;
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
            languageListBox.Size = new System.Drawing.Size(452, 143);
            languageListBox.TabIndex = 6;
            // 
            // FormOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(506, 400);
            Controls.Add(languageListBox);
            Controls.Add(clearRecentFilesButton);
            Controls.Add(recentFilesMaxlabel);
            Controls.Add(recentFilesMaxTextBox);
            Controls.Add(useSystemLanguageCheckBox);
            Font = new System.Drawing.Font("Segoe UI", 8.25F);
            ForeColor = System.Drawing.Color.White;
            Margin = new System.Windows.Forms.Padding(683, 129, 683, 129);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOptions";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Options";
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.GroupBox recentFilesGroupBox;
        private System.Windows.Forms.Button clearRecentFilesButton;
        private System.Windows.Forms.Label recentFilesMaxlabel;
        private System.Windows.Forms.TextBox recentFilesMaxTextBox;
        private System.Windows.Forms.GroupBox languageSettingsGroupBox;
        private System.Windows.Forms.CheckBox useSystemLanguageCheckBox;
        private UiManagerComponent uiManagerComponent;
        private System.Windows.Forms.ListBox languageListBox;
    }
}