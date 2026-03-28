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
            useSystemLanguageCheckBox = new System.Windows.Forms.CheckBox();
            clearRecentFilesButton = new System.Windows.Forms.Button();
            recentFilesMaxlabel = new System.Windows.Forms.Label();
            recentFilesMaxTextBox = new System.Windows.Forms.TextBox();
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            uiManagerComponent = new UiManagerComponent(components);
            label1 = new System.Windows.Forms.Label();
            languageListBox = new System.Windows.Forms.ListBox();
            buttonSystem = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonDark = new System.Windows.Forms.Button();
            buttonLight = new System.Windows.Forms.Button();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // languageListBox
            // 
            resources.ApplyResources(languageListBox, "languageListBox");
            languageListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            languageListBox.FormattingEnabled = true;
            languageListBox.Name = "languageListBox";
            // 
            // buttonSystem
            // 
            resources.ApplyResources(buttonSystem, "buttonSystem");
            buttonSystem.Name = "buttonSystem";
            buttonSystem.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(buttonSystem);
            flowLayoutPanel1.Controls.Add(buttonDark);
            flowLayoutPanel1.Controls.Add(buttonLight);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonDark
            // 
            resources.ApplyResources(buttonDark, "buttonDark");
            buttonDark.Name = "buttonDark";
            buttonDark.UseVisualStyleBackColor = true;
            // 
            // buttonLight
            // 
            resources.ApplyResources(buttonLight, "buttonLight");
            buttonLight.Name = "buttonLight";
            buttonLight.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = cancelButton;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(languageListBox);
            Controls.Add(clearRecentFilesButton);
            Controls.Add(recentFilesMaxlabel);
            Controls.Add(recentFilesMaxTextBox);
            Controls.Add(flowLayoutPanel);
            Controls.Add(useSystemLanguageCheckBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOptions";
            ShowIcon = false;
            ShowInTaskbar = false;
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox languageListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.Button buttonLight;
    }
}