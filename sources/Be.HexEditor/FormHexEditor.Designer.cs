namespace Be.HexEditor
{
    partial class FormHexEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHexEditor));
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            copyHexStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip = new System.Windows.Forms.ToolStrip();
            openToolStripButton = new System.Windows.Forms.ToolStripButton();
            saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            copyToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            copyHexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            pasteHexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            encodingToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            fileSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            bitToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            bodyPanel = new System.Windows.Forms.Panel();
            hexBox = new Be.Windows.Forms.HexBox();
            bitControl1 = new BitControl();
            RecentFileHandler = new RecentFileHandler(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.SystemColors.Control;
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            resources.ApplyResources(menuStrip, "menuStrip");
            menuStrip.Name = "menuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator2, recentFilesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = FluentUI.FolderOpen16;
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Click += open_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = FluentUI.Save16;
            resources.ApplyResources(saveToolStripMenuItem, "saveToolStripMenuItem");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Click += save_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // recentFilesToolStripMenuItem
            // 
            resources.ApplyResources(recentFilesToolStripMenuItem, "recentFilesToolStripMenuItem");
            recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            recentFilesToolStripMenuItem.DropDownItemClicked += recentFiles_DropDownItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Click += exit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator3, copyHexStringToolStripMenuItem, pasteHexToolStripMenuItem, toolStripSeparator4, findToolStripMenuItem, findNextToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator5, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = FluentUI.Cut16;
            resources.ApplyResources(cutToolStripMenuItem, "cutToolStripMenuItem");
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Click += cut_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = FluentUI.Copy16;
            resources.ApplyResources(copyToolStripMenuItem, "copyToolStripMenuItem");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Click += copy_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = FluentUI.ClipboardPaste16;
            resources.ApplyResources(pasteToolStripMenuItem, "pasteToolStripMenuItem");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Click += paste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // copyHexStringToolStripMenuItem
            // 
            copyHexStringToolStripMenuItem.Name = "copyHexStringToolStripMenuItem";
            resources.ApplyResources(copyHexStringToolStripMenuItem, "copyHexStringToolStripMenuItem");
            copyHexStringToolStripMenuItem.Click += copyHex_Click;
            // 
            // pasteHexToolStripMenuItem
            // 
            pasteHexToolStripMenuItem.Name = "pasteHexToolStripMenuItem";
            resources.ApplyResources(pasteHexToolStripMenuItem, "pasteHexToolStripMenuItem");
            pasteHexToolStripMenuItem.Click += pasteHex_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Image = FluentUI.Search16;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            resources.ApplyResources(findToolStripMenuItem, "findToolStripMenuItem");
            findToolStripMenuItem.Click += find_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Image = FluentUI.ArrowRight16;
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            resources.ApplyResources(findNextToolStripMenuItem, "findNextToolStripMenuItem");
            findNextToolStripMenuItem.Click += findNext_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            resources.ApplyResources(goToToolStripMenuItem, "goToToolStripMenuItem");
            goToToolStripMenuItem.Click += goTo_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encodingToolStripMenuItem, bitsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // encodingToolStripMenuItem
            // 
            encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            resources.ApplyResources(encodingToolStripMenuItem, "encodingToolStripMenuItem");
            // 
            // bitsToolStripMenuItem
            // 
            bitsToolStripMenuItem.CheckOnClick = true;
            bitsToolStripMenuItem.Name = "bitsToolStripMenuItem";
            resources.ApplyResources(bitsToolStripMenuItem, "bitsToolStripMenuItem");
            bitsToolStripMenuItem.CheckedChanged += bitsToolStripMenuItem_CheckedChanged;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(optionsToolStripMenuItem, "optionsToolStripMenuItem");
            optionsToolStripMenuItem.Click += options_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Click += about_Click;
            // 
            // toolStrip
            // 
            toolStrip.BackColor = System.Drawing.SystemColors.Control;
            toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripButton, saveToolStripButton, toolStripSeparator6, cutToolStripButton, copyToolStripSplitButton, pasteToolStripSplitButton, encodingToolStripComboBox });
            resources.ApplyResources(toolStrip, "toolStrip");
            toolStrip.Name = "toolStrip";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = FluentUI.FolderOpen24;
            resources.ApplyResources(openToolStripButton, "openToolStripButton");
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Click += open_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = FluentUI.Save24;
            resources.ApplyResources(saveToolStripButton, "saveToolStripButton");
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Click += save_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = FluentUI.Cut24;
            resources.ApplyResources(cutToolStripButton, "cutToolStripButton");
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Click += cut_Click;
            // 
            // copyToolStripSplitButton
            // 
            copyToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            copyToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyToolStripMenuItem1, copyHexToolStripMenuItem1 });
            copyToolStripSplitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            copyToolStripSplitButton.Image = FluentUI.Copy24;
            resources.ApplyResources(copyToolStripSplitButton, "copyToolStripSplitButton");
            copyToolStripSplitButton.Name = "copyToolStripSplitButton";
            copyToolStripSplitButton.ButtonClick += copy_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            resources.ApplyResources(copyToolStripMenuItem1, "copyToolStripMenuItem1");
            copyToolStripMenuItem1.Click += copy_Click;
            // 
            // copyHexToolStripMenuItem1
            // 
            copyHexToolStripMenuItem1.Name = "copyHexToolStripMenuItem1";
            resources.ApplyResources(copyHexToolStripMenuItem1, "copyHexToolStripMenuItem1");
            copyHexToolStripMenuItem1.Click += copyHex_Click;
            // 
            // pasteToolStripSplitButton
            // 
            pasteToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            pasteToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pasteToolStripMenuItem1, pasteHexToolStripMenuItem1 });
            pasteToolStripSplitButton.Image = FluentUI.ClipboardPaste24;
            resources.ApplyResources(pasteToolStripSplitButton, "pasteToolStripSplitButton");
            pasteToolStripSplitButton.Name = "pasteToolStripSplitButton";
            pasteToolStripSplitButton.ButtonClick += paste_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            resources.ApplyResources(pasteToolStripMenuItem1, "pasteToolStripMenuItem1");
            pasteToolStripMenuItem1.Click += paste_Click;
            // 
            // pasteHexToolStripMenuItem1
            // 
            pasteHexToolStripMenuItem1.Name = "pasteHexToolStripMenuItem1";
            resources.ApplyResources(pasteHexToolStripMenuItem1, "pasteHexToolStripMenuItem1");
            pasteHexToolStripMenuItem1.Click += pasteHex_Click;
            // 
            // encodingToolStripComboBox
            // 
            encodingToolStripComboBox.BackColor = System.Drawing.SystemColors.Control;
            encodingToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            encodingToolStripComboBox.DropDownWidth = 180;
            resources.ApplyResources(encodingToolStripComboBox, "encodingToolStripComboBox");
            encodingToolStripComboBox.Name = "encodingToolStripComboBox";
            encodingToolStripComboBox.SelectedIndexChanged += toolStripEncoding_SelectedIndexChanged;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.SystemColors.Control;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel, fileSizeToolStripStatusLabel, bitToolStripStatusLabel });
            resources.ApplyResources(statusStrip, "statusStrip");
            statusStrip.Name = "statusStrip";
            statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            statusStrip.SizingGrip = false;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            resources.ApplyResources(toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // fileSizeToolStripStatusLabel
            // 
            fileSizeToolStripStatusLabel.Name = "fileSizeToolStripStatusLabel";
            fileSizeToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resources.ApplyResources(fileSizeToolStripStatusLabel, "fileSizeToolStripStatusLabel");
            // 
            // bitToolStripStatusLabel
            // 
            bitToolStripStatusLabel.Name = "bitToolStripStatusLabel";
            resources.ApplyResources(bitToolStripStatusLabel, "bitToolStripStatusLabel");
            // 
            // bodyPanel
            // 
            bodyPanel.Controls.Add(hexBox);
            bodyPanel.Controls.Add(bitControl1);
            resources.ApplyResources(bodyPanel, "bodyPanel");
            bodyPanel.Name = "bodyPanel";
            // 
            // hexBox
            // 
            hexBox.AllowDrop = true;
            hexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            hexBox.BuiltInContextMenu.CopyMenuItemImage = FluentUI.Copy16;
            hexBox.BuiltInContextMenu.CopyMenuItemScalingImageName = "Copy";
            hexBox.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.CopyMenuItemText");
            hexBox.BuiltInContextMenu.CutMenuItemImage = FluentUI.Cut16;
            hexBox.BuiltInContextMenu.CutMenuItemScalingImageName = "Cut";
            hexBox.BuiltInContextMenu.CutMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.CutMenuItemText");
            hexBox.BuiltInContextMenu.PasteMenuItemImage = FluentUI.ClipboardPaste16;
            hexBox.BuiltInContextMenu.PasteMenuItemScalingImageName = "Paste";
            hexBox.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.PasteMenuItemText");
            hexBox.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.SelectAllMenuItemText");
            hexBox.ColumnInfoVisible = true;
            resources.ApplyResources(hexBox, "hexBox");
            hexBox.HexCasing = Windows.Forms.HexCasing.Lower;
            hexBox.LineInfoVisible = true;
            hexBox.Name = "hexBox";
            hexBox.StringViewVisible = true;
            hexBox.UseFixedBytesPerLine = true;
            hexBox.VScrollBarVisible = true;
            hexBox.SelectionStartChanged += hexBox_SelectionStartChanged;
            hexBox.SelectionLengthChanged += hexBox_SelectionLengthChanged;
            hexBox.CurrentLineChanged += Position_Changed;
            hexBox.CurrentPositionInLineChanged += Position_Changed;
            hexBox.Copied += hexBox_Copied;
            hexBox.CopiedHex += hexBox_CopiedHex;
            hexBox.RequiredWidthChanged += hexBox_RequiredWidthChanged;
            hexBox.DragDrop += hexBox_DragDrop;
            hexBox.DragEnter += hexBox_DragEnter;
            // 
            // bitControl1
            // 
            resources.ApplyResources(bitControl1, "bitControl1");
            bitControl1.Name = "bitControl1";
            bitControl1.BitChanged += bitControl1_BitChanged;
            // 
            // RecentFileHandler
            // 
            RecentFileHandler.RecentFileToolStripItem = recentFilesToolStripMenuItem;
            // 
            // FormHexEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(bodyPanel);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormHexEditor";
            FormClosing += FormHexEditor_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private Be.Windows.Forms.HexBox hexBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel fileSizeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyHexStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton copyToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyHexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton pasteToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteHexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        public RecentFileHandler RecentFileHandler;
		private System.Windows.Forms.ToolStripStatusLabel bitToolStripStatusLabel;
		private System.Windows.Forms.ToolStripComboBox encodingToolStripComboBox;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem;
		private BitControl bitControl1;
		private System.Windows.Forms.Panel bodyPanel;
    }
}