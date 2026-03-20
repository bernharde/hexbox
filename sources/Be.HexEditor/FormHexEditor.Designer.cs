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
            menuStrip = new Be.Windows.Forms.MenuStripEx();
            fileToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            openToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            recentFilesToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            editToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            cutToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            copyToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            pasteToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            copyHexStringToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            pasteHexToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            findToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            findNextToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            goToToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            viewToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            encodingToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            bitsToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolsToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            optionsToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            helpToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            aboutToolStripMenuItem = new Be.Windows.Forms.ToolStripMenuItemEx();
            toolStrip = new Be.Windows.Forms.ToolStripEx();
            openToolStripButton = new Be.Windows.Forms.ToolStripButtonEx();
            saveToolStripButton = new Be.Windows.Forms.ToolStripButtonEx();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripButton = new Be.Windows.Forms.ToolStripButtonEx();
            copyToolStripSplitButton = new Be.Windows.Forms.ToolStripSplitButtonEx();
            copyToolStripMenuItem1 = new Be.Windows.Forms.ToolStripMenuItemEx();
            copyHexToolStripMenuItem1 = new Be.Windows.Forms.ToolStripMenuItemEx();
            pasteToolStripSplitButton = new Be.Windows.Forms.ToolStripSplitButtonEx();
            pasteToolStripMenuItem1 = new Be.Windows.Forms.ToolStripMenuItemEx();
            pasteHexToolStripMenuItem1 = new Be.Windows.Forms.ToolStripMenuItemEx();
            encodingToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            statusStrip = new Be.Windows.Forms.StatusStripEx();
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
            openToolStripMenuItem.Image = Pngs.Open16;
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ScalingImageResourceName = "Open";
            openToolStripMenuItem.Click += open_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Pngs.SaveStatusBar16;
            resources.ApplyResources(saveToolStripMenuItem, "saveToolStripMenuItem");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ScalingImageResourceName = "SaveStatusBar";
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
            cutToolStripMenuItem.Image = Pngs.Cut16;
            resources.ApplyResources(cutToolStripMenuItem, "cutToolStripMenuItem");
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ScalingImageResourceName = "Cut";
            cutToolStripMenuItem.Click += cut_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = Pngs.Copy16;
            resources.ApplyResources(copyToolStripMenuItem, "copyToolStripMenuItem");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ScalingImageResourceName = "Copy";
            copyToolStripMenuItem.Click += copy_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = Pngs.Paste16;
            resources.ApplyResources(pasteToolStripMenuItem, "pasteToolStripMenuItem");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ScalingImageResourceName = "Paste";
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
            findToolStripMenuItem.Image = Pngs.QuickFind16;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ScalingImageResourceName = "QuickFind";
            resources.ApplyResources(findToolStripMenuItem, "findToolStripMenuItem");
            findToolStripMenuItem.Click += find_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Image = Pngs.FindNext16;
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.ScalingImageResourceName = "FindNext";
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
            resources.ApplyResources(toolStrip, "toolStrip");
            toolStrip.BackColor = System.Drawing.SystemColors.Control;
            toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripButton, saveToolStripButton, toolStripSeparator6, cutToolStripButton, copyToolStripSplitButton, pasteToolStripSplitButton, encodingToolStripComboBox });
            toolStrip.Name = "toolStrip";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = Pngs.Open16;
            resources.ApplyResources(openToolStripButton, "openToolStripButton");
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.ScalingImageResourceName = "Open";
            openToolStripButton.Click += open_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = Pngs.SaveStatusBar16;
            resources.ApplyResources(saveToolStripButton, "saveToolStripButton");
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.ScalingImageResourceName = "SaveStatusBar";
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
            cutToolStripButton.Image = Pngs.Cut16;
            resources.ApplyResources(cutToolStripButton, "cutToolStripButton");
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.ScalingImageResourceName = "Cut";
            cutToolStripButton.Click += cut_Click;
            // 
            // copyToolStripSplitButton
            // 
            copyToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            copyToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyToolStripMenuItem1, copyHexToolStripMenuItem1 });
            copyToolStripSplitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            copyToolStripSplitButton.Image = Pngs.Copy16;
            resources.ApplyResources(copyToolStripSplitButton, "copyToolStripSplitButton");
            copyToolStripSplitButton.Name = "copyToolStripSplitButton";
            copyToolStripSplitButton.ScalingImageResourceName = "Copy";
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
            pasteToolStripSplitButton.Image = Pngs.Paste16;
            resources.ApplyResources(pasteToolStripSplitButton, "pasteToolStripSplitButton");
            pasteToolStripSplitButton.Name = "pasteToolStripSplitButton";
            pasteToolStripSplitButton.ScalingImageResourceName = "Paste";
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
            resources.ApplyResources(bodyPanel, "bodyPanel");
            bodyPanel.Controls.Add(hexBox);
            bodyPanel.Controls.Add(bitControl1);
            bodyPanel.Name = "bodyPanel";
            // 
            // hexBox
            // 
            hexBox.AllowDrop = true;
            hexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            hexBox.BuiltInContextMenu.CopyMenuItemImage = Pngs.Copy16;
            hexBox.BuiltInContextMenu.CopyMenuItemScalingImageName = "Copy";
            hexBox.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.CopyMenuItemText");
            hexBox.BuiltInContextMenu.CutMenuItemImage = Pngs.Cut16;
            hexBox.BuiltInContextMenu.CutMenuItemScalingImageName = "Cut";
            hexBox.BuiltInContextMenu.CutMenuItemText = resources.GetString("hexBox.BuiltInContextMenu.CutMenuItemText");
            hexBox.BuiltInContextMenu.PasteMenuItemImage = Pngs.Paste16;
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

        private Be.Windows.Forms.MenuStripEx menuStrip;
        private Be.Windows.Forms.ToolStripMenuItemEx fileToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private Be.Windows.Forms.ToolStripMenuItemEx saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Be.Windows.Forms.ToolStripMenuItemEx exitToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx editToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx cutToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx copyToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Be.Windows.Forms.ToolStripMenuItemEx findToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx toolsToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx optionsToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx helpToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx aboutToolStripMenuItem;
        private Be.Windows.Forms.ToolStripEx toolStrip;
        private Be.Windows.Forms.ToolStripButtonEx openToolStripButton;
        private Be.Windows.Forms.ToolStripButtonEx saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private Be.Windows.Forms.ToolStripButtonEx cutToolStripButton;
        private Be.Windows.Forms.HexBox hexBox;
        private Be.Windows.Forms.StatusStripEx statusStrip;
        private Be.Windows.Forms.ToolStripMenuItemEx findNextToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx goToToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private Be.Windows.Forms.ToolStripMenuItemEx recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel fileSizeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Be.Windows.Forms.ToolStripMenuItemEx copyHexStringToolStripMenuItem;
        private Be.Windows.Forms.ToolStripMenuItemEx pasteHexToolStripMenuItem;
        private Be.Windows.Forms.ToolStripSplitButtonEx copyToolStripSplitButton;
        private Be.Windows.Forms.ToolStripMenuItemEx copyToolStripMenuItem1;
        private Be.Windows.Forms.ToolStripMenuItemEx copyHexToolStripMenuItem1;
        private Be.Windows.Forms.ToolStripSplitButtonEx pasteToolStripSplitButton;
        private Be.Windows.Forms.ToolStripMenuItemEx pasteToolStripMenuItem1;
        private Be.Windows.Forms.ToolStripMenuItemEx pasteHexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Be.Windows.Forms.ToolStripMenuItemEx selectAllToolStripMenuItem;
        public RecentFileHandler RecentFileHandler;
		private System.Windows.Forms.ToolStripStatusLabel bitToolStripStatusLabel;
		private System.Windows.Forms.ToolStripComboBox encodingToolStripComboBox;
		private Be.Windows.Forms.ToolStripMenuItemEx viewToolStripMenuItem;
		private Be.Windows.Forms.ToolStripMenuItemEx encodingToolStripMenuItem;
		private Be.Windows.Forms.ToolStripMenuItemEx bitsToolStripMenuItem;
		private BitControl bitControl1;
		private System.Windows.Forms.Panel bodyPanel;
    }
}