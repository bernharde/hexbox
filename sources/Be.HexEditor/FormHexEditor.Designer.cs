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
            recentFileHandler = new RecentFileHandler(components);
            uiManagerComponent = new UiManagerComponent(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.SystemColors.Control;
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(652, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator2, recentFilesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = FluentUI.FolderOpen16;
            openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += open_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = FluentUI.Save16;
            saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += save_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            recentFilesToolStripMenuItem.Enabled = false;
            recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            recentFilesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            recentFilesToolStripMenuItem.Text = "Recent Files";
            recentFilesToolStripMenuItem.DropDownItemClicked += recentFiles_DropDownItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator3, copyHexStringToolStripMenuItem, pasteHexToolStripMenuItem, toolStripSeparator4, findToolStripMenuItem, findNextToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator5, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = FluentUI.Cut16;
            cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            cutToolStripMenuItem.Click += cut_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = FluentUI.Copy16;
            copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copy_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = FluentUI.ClipboardPaste16;
            pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += paste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // copyHexStringToolStripMenuItem
            // 
            copyHexStringToolStripMenuItem.Name = "copyHexStringToolStripMenuItem";
            copyHexStringToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.C;
            copyHexStringToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            copyHexStringToolStripMenuItem.Text = "Copy Hex";
            copyHexStringToolStripMenuItem.Click += copyHex_Click;
            // 
            // pasteHexToolStripMenuItem
            // 
            pasteHexToolStripMenuItem.Name = "pasteHexToolStripMenuItem";
            pasteHexToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.V;
            pasteHexToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            pasteHexToolStripMenuItem.Text = "Paste Hex";
            pasteHexToolStripMenuItem.Click += pasteHex_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Image = FluentUI.Search16;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F;
            findToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += find_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Image = FluentUI.ArrowRight16;
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            findNextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            findNextToolStripMenuItem.Text = "Find Next";
            findNextToolStripMenuItem.Click += findNext_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G;
            goToToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            goToToolStripMenuItem.Text = "Go To";
            goToToolStripMenuItem.Click += goTo_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(196, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { encodingToolStripMenuItem, bitsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // encodingToolStripMenuItem
            // 
            encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            encodingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            encodingToolStripMenuItem.Text = "&Encoding";
            // 
            // bitsToolStripMenuItem
            // 
            bitsToolStripMenuItem.CheckOnClick = true;
            bitsToolStripMenuItem.Name = "bitsToolStripMenuItem";
            bitsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            bitsToolStripMenuItem.Text = "&Bits";
            bitsToolStripMenuItem.CheckedChanged += bitsToolStripMenuItem_CheckedChanged;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            optionsToolStripMenuItem.Text = "&Options";
            optionsToolStripMenuItem.Click += options_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += about_Click;
            // 
            // toolStrip
            // 
            toolStrip.BackColor = System.Drawing.SystemColors.Control;
            toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripButton, saveToolStripButton, toolStripSeparator6, cutToolStripButton, copyToolStripSplitButton, pasteToolStripSplitButton, encodingToolStripComboBox });
            toolStrip.Location = new System.Drawing.Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new System.Windows.Forms.Padding(4);
            toolStrip.Size = new System.Drawing.Size(652, 35);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = FluentUI.FolderOpen16;
            openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Padding = new System.Windows.Forms.Padding(2);
            openToolStripButton.Size = new System.Drawing.Size(24, 24);
            openToolStripButton.Text = "&Open";
            openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            openToolStripButton.Click += open_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = FluentUI.Save16;
            saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Padding = new System.Windows.Forms.Padding(2);
            saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += save_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = FluentUI.Cut16;
            cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Padding = new System.Windows.Forms.Padding(2);
            cutToolStripButton.Size = new System.Drawing.Size(24, 24);
            cutToolStripButton.Text = "Cut";
            cutToolStripButton.Click += cut_Click;
            // 
            // copyToolStripSplitButton
            // 
            copyToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            copyToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyToolStripMenuItem1, copyHexToolStripMenuItem1 });
            copyToolStripSplitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            copyToolStripSplitButton.Image = FluentUI.Copy16;
            copyToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            copyToolStripSplitButton.Name = "copyToolStripSplitButton";
            copyToolStripSplitButton.Padding = new System.Windows.Forms.Padding(2);
            copyToolStripSplitButton.Size = new System.Drawing.Size(36, 24);
            copyToolStripSplitButton.Text = "Copy";
            copyToolStripSplitButton.ButtonClick += copy_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copy_Click;
            // 
            // copyHexToolStripMenuItem1
            // 
            copyHexToolStripMenuItem1.Name = "copyHexToolStripMenuItem1";
            copyHexToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            copyHexToolStripMenuItem1.Text = "Copy Hex";
            copyHexToolStripMenuItem1.Click += copyHex_Click;
            // 
            // pasteToolStripSplitButton
            // 
            pasteToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            pasteToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pasteToolStripMenuItem1, pasteHexToolStripMenuItem1 });
            pasteToolStripSplitButton.Image = FluentUI.ClipboardPaste16;
            pasteToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            pasteToolStripSplitButton.Name = "pasteToolStripSplitButton";
            pasteToolStripSplitButton.Padding = new System.Windows.Forms.Padding(2);
            pasteToolStripSplitButton.Size = new System.Drawing.Size(36, 24);
            pasteToolStripSplitButton.Text = "Paste";
            pasteToolStripSplitButton.ButtonClick += paste_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += paste_Click;
            // 
            // pasteHexToolStripMenuItem1
            // 
            pasteHexToolStripMenuItem1.Name = "pasteHexToolStripMenuItem1";
            pasteHexToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            pasteHexToolStripMenuItem1.Text = "Paste Hex";
            pasteHexToolStripMenuItem1.Click += pasteHex_Click;
            // 
            // encodingToolStripComboBox
            // 
            encodingToolStripComboBox.BackColor = System.Drawing.SystemColors.Control;
            encodingToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            encodingToolStripComboBox.DropDownWidth = 180;
            encodingToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            encodingToolStripComboBox.Name = "encodingToolStripComboBox";
            encodingToolStripComboBox.Padding = new System.Windows.Forms.Padding(2);
            encodingToolStripComboBox.Size = new System.Drawing.Size(192, 27);
            encodingToolStripComboBox.SelectedIndexChanged += toolStripEncoding_SelectedIndexChanged;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.SystemColors.Control;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel, fileSizeToolStripStatusLabel, bitToolStripStatusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 453);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            statusStrip.Size = new System.Drawing.Size(652, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            toolStripStatusLabel.Size = new System.Drawing.Size(7, 17);
            // 
            // fileSizeToolStripStatusLabel
            // 
            fileSizeToolStripStatusLabel.Name = "fileSizeToolStripStatusLabel";
            fileSizeToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fileSizeToolStripStatusLabel.Size = new System.Drawing.Size(8, 17);
            // 
            // bitToolStripStatusLabel
            // 
            bitToolStripStatusLabel.Name = "bitToolStripStatusLabel";
            bitToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // bodyPanel
            // 
            bodyPanel.Controls.Add(hexBox);
            bodyPanel.Controls.Add(bitControl1);
            bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            bodyPanel.Location = new System.Drawing.Point(0, 59);
            bodyPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new System.Drawing.Size(652, 394);
            bodyPanel.TabIndex = 11;
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
            hexBox.BuiltInContextMenu.CopyMenuItemText = "Copy ";
            hexBox.BuiltInContextMenu.CutMenuItemImage = FluentUI.Cut16;
            hexBox.BuiltInContextMenu.CutMenuItemScalingImageName = "Cut";
            hexBox.BuiltInContextMenu.CutMenuItemText = "Cut ";
            hexBox.BuiltInContextMenu.PasteMenuItemImage = FluentUI.ClipboardPaste16;
            hexBox.BuiltInContextMenu.PasteMenuItemScalingImageName = "Paste";
            hexBox.BuiltInContextMenu.PasteMenuItemText = "Paste ";
            hexBox.BuiltInContextMenu.SelectAllMenuItemText = "Select All ";
            hexBox.ColumnInfoVisible = true;
            hexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            hexBox.Font = new System.Drawing.Font("Consolas", 9F);
            hexBox.HexCasing = Windows.Forms.HexCasing.Lower;
            hexBox.LineInfoVisible = true;
            hexBox.Location = new System.Drawing.Point(0, 0);
            hexBox.Margin = new System.Windows.Forms.Padding(0);
            hexBox.Name = "hexBox";
            hexBox.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(38, 79, 120, 255);
            hexBox.Size = new System.Drawing.Size(652, 334);
            hexBox.StringViewVisible = true;
            hexBox.TabIndex = 8;
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
            bitControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            bitControl1.Location = new System.Drawing.Point(0, 334);
            bitControl1.Margin = new System.Windows.Forms.Padding(0);
            bitControl1.Name = "bitControl1";
            bitControl1.Size = new System.Drawing.Size(652, 60);
            bitControl1.TabIndex = 10;
            bitControl1.BitChanged += bitControl1_BitChanged;
            // 
            // recentFileHandler
            // 
            recentFileHandler.RecentFileToolStripItem = recentFilesToolStripMenuItem;
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormHexEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(652, 475);
            Controls.Add(bodyPanel);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(44, 29, 44, 29);
            Name = "FormHexEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Be.HexEditor";
            FormClosing += FormHexEditor_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
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
        public RecentFileHandler recentFileHandler;
		private System.Windows.Forms.ToolStripStatusLabel bitToolStripStatusLabel;
		private System.Windows.Forms.ToolStripComboBox encodingToolStripComboBox;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem;
		private BitControl bitControl1;
		private System.Windows.Forms.Panel bodyPanel;
        private UiManagerComponent uiManagerComponent;
    }
}