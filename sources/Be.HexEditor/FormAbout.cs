using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using Be.HexEditor.Theme;
using Be.HexEditor.Localization;

namespace Be.HexEditor
{
	/// <summary>
	/// About dialog showing application information and resources.
	/// </summary>
	public class FormAbout : Form
	{
		private TableLayoutPanel mainLayout;
		private Panel headerPanel;
		private FlowLayoutPanel headerContent;
		private Label lblTitle;
		private Label lblVersion;
		private Label lblAuthor;
		private LinkLabel lnkWebsite;
		
		// Custom tab buttons instead of TabControl
		private FlowLayoutPanel tabButtonsPanel;
		private Button btnTabAbout;
		private Button btnTabThanksTo;
		private Button btnTabLicense;
		private Button btnTabChanges;
		
		// Content panels for each tab
		private Panel contentPanel;
		private Panel pnlAbout;
		private Panel pnlThanksTo;
		private Panel pnlLicense;
		private Panel pnlChanges;
		
		private RichTextBox txtAbout;
		private RichTextBox txtThanksTo;
		private RichTextBox txtLicense;
		private RichTextBox txtChanges;
		private UiManagerComponent uiManagerComponent;
		private System.ComponentModel.IContainer components;

		public FormAbout()
		{
			InitializeComponent();
			if (!DesignMode)
			{
				LoadResources();
				LocalizationManager.LoadCurrentCulture();
				this.ApplyLocalization();
				lnkWebsite.LinkClicked += (s, e) => Process.Start(new ProcessStartInfo(lnkWebsite.Text) { UseShellExecute = true });
				btnOK.Click += (s, e) => Close();

				// Tab button event handlers
				btnTabAbout.Click += (s, e) => SelectTab(0);
				btnTabThanksTo.Click += (s, e) => SelectTab(1);
				btnTabLicense.Click += (s, e) => SelectTab(2);
				btnTabChanges.Click += (s, e) => SelectTab(3);

				// Apply theme BEFORE selecting the first tab
				uiManagerComponent.Form = this;

				// Select first tab AFTER theme is applied
				SelectTab(0);
			}
		}

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            mainLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            headerContent = new FlowLayoutPanel();
            lblTitle = new Label();
            lblVersion = new Label();
            lblAuthor = new Label();
            lnkWebsite = new LinkLabel();
            tabButtonsPanel = new FlowLayoutPanel();
            btnTabAbout = new Button();
            btnTabThanksTo = new Button();
            btnTabLicense = new Button();
            btnTabChanges = new Button();
            contentPanel = new Panel();
            pnlChanges = new Panel();
            txtChanges = new RichTextBox();
            pnlLicense = new Panel();
            txtLicense = new RichTextBox();
            pnlThanksTo = new Panel();
            txtThanksTo = new RichTextBox();
            pnlAbout = new Panel();
            txtAbout = new RichTextBox();
            uiManagerComponent = new UiManagerComponent(components);
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            headerContent.SuspendLayout();
            tabButtonsPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            pnlChanges.SuspendLayout();
            pnlLicense.SuspendLayout();
            pnlThanksTo.SuspendLayout();
            pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(tabButtonsPanel, 0, 1);
            mainLayout.Controls.Add(contentPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(5);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            mainLayout.Size = new Size(600, 500);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(headerContent);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(8, 8);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(5);
            headerPanel.Size = new Size(584, 134);
            headerPanel.TabIndex = 0;
            // 
            // headerContent
            // 
            headerContent.Controls.Add(lblTitle);
            headerContent.Controls.Add(lblVersion);
            headerContent.Controls.Add(lblAuthor);
            headerContent.Controls.Add(lnkWebsite);
            headerContent.Dock = DockStyle.Fill;
            headerContent.FlowDirection = FlowDirection.TopDown;
            headerContent.Location = new Point(5, 5);
            headerContent.Margin = new Padding(0);
            headerContent.Name = "headerContent";
            headerContent.Size = new Size(574, 124);
            headerContent.TabIndex = 0;
            headerContent.WrapContents = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.WindowText;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0, 0, 0, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Be.HexEditor";
            // 
            // lblVersion
            // 
            lblVersion.ForeColor = SystemColors.WindowText;
            lblVersion.Location = new Point(0, 40);
            lblVersion.Margin = new Padding(0, 0, 0, 3);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(300, 25);
            lblVersion.TabIndex = 1;
            lblVersion.Tag = "Version";
            lblVersion.Text = "Version: ";
            // 
            // lblAuthor
            // 
            lblAuthor.ForeColor = SystemColors.WindowText;
            lblAuthor.Location = new Point(0, 68);
            lblAuthor.Margin = new Padding(0, 0, 0, 3);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(300, 25);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author: Bernhard Elbl";
            // 
            // lnkWebsite
            // 
            lnkWebsite.AutoSize = true;
            lnkWebsite.LinkColor = SystemColors.HotTrack;
            lnkWebsite.Location = new Point(0, 96);
            lnkWebsite.Margin = new Padding(0);
            lnkWebsite.Name = "lnkWebsite";
            lnkWebsite.Size = new Size(204, 15);
            lnkWebsite.TabIndex = 3;
            lnkWebsite.TabStop = true;
            lnkWebsite.Text = "https://github.com/bemento/hexbox";
            lnkWebsite.VisitedLinkColor = SystemColors.HotTrack;
            // 
            // tabButtonsPanel
            // 
            tabButtonsPanel.Controls.Add(btnTabAbout);
            tabButtonsPanel.Controls.Add(btnTabThanksTo);
            tabButtonsPanel.Controls.Add(btnTabLicense);
            tabButtonsPanel.Controls.Add(btnTabChanges);
            tabButtonsPanel.Dock = DockStyle.Fill;
            tabButtonsPanel.Location = new Point(10, 150);
            tabButtonsPanel.Margin = new Padding(5, 5, 5, 0);
            tabButtonsPanel.Name = "tabButtonsPanel";
            tabButtonsPanel.Size = new Size(580, 35);
            tabButtonsPanel.TabIndex = 1;
            tabButtonsPanel.WrapContents = false;
            // 
            // btnTabAbout
            // 
            btnTabAbout.AutoSize = true;
            btnTabAbout.FlatAppearance.BorderSize = 0;
            btnTabAbout.FlatStyle = FlatStyle.Flat;
            btnTabAbout.ForeColor = SystemColors.ControlText;
            btnTabAbout.Location = new Point(0, 0);
            btnTabAbout.Margin = new Padding(0);
            btnTabAbout.Name = "btnTabAbout";
            btnTabAbout.Size = new Size(80, 32);
            btnTabAbout.TabIndex = 0;
            btnTabAbout.Tag = "About";
            btnTabAbout.Text = "About";
            // 
            // btnTabThanksTo
            // 
            btnTabThanksTo.AutoSize = true;
            btnTabThanksTo.FlatAppearance.BorderSize = 0;
            btnTabThanksTo.FlatStyle = FlatStyle.Flat;
            btnTabThanksTo.ForeColor = SystemColors.ControlText;
            btnTabThanksTo.Location = new Point(80, 0);
            btnTabThanksTo.Margin = new Padding(0);
            btnTabThanksTo.Name = "btnTabThanksTo";
            btnTabThanksTo.Size = new Size(80, 32);
            btnTabThanksTo.TabIndex = 1;
            btnTabThanksTo.Tag = "ThanksTo";
            btnTabThanksTo.Text = "Thanks To";
            // 
            // btnTabLicense
            // 
            btnTabLicense.AutoSize = true;
            btnTabLicense.FlatAppearance.BorderSize = 0;
            btnTabLicense.FlatStyle = FlatStyle.Flat;
            btnTabLicense.ForeColor = SystemColors.ControlText;
            btnTabLicense.Location = new Point(160, 0);
            btnTabLicense.Margin = new Padding(0);
            btnTabLicense.Name = "btnTabLicense";
            btnTabLicense.Size = new Size(80, 32);
            btnTabLicense.TabIndex = 2;
            btnTabLicense.Tag = "License";
            btnTabLicense.Text = "License";
            // 
            // btnTabChanges
            // 
            btnTabChanges.AutoSize = true;
            btnTabChanges.FlatAppearance.BorderSize = 0;
            btnTabChanges.FlatStyle = FlatStyle.Flat;
            btnTabChanges.ForeColor = SystemColors.ControlText;
            btnTabChanges.Location = new Point(240, 0);
            btnTabChanges.Margin = new Padding(0);
            btnTabChanges.Name = "btnTabChanges";
            btnTabChanges.Size = new Size(80, 32);
            btnTabChanges.TabIndex = 3;
            btnTabChanges.Tag = "Changes";
            btnTabChanges.Text = "Changes";
            // 
            // contentPanel
            // 
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Controls.Add(pnlChanges);
            contentPanel.Controls.Add(pnlLicense);
            contentPanel.Controls.Add(pnlThanksTo);
            contentPanel.Controls.Add(pnlAbout);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(5, 185);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(590, 302);
            contentPanel.TabIndex = 2;
            // 
            // pnlChanges
            // 
            pnlChanges.Controls.Add(txtChanges);
            pnlChanges.Dock = DockStyle.Fill;
            pnlChanges.Location = new Point(0, 0);
            pnlChanges.Name = "pnlChanges";
            pnlChanges.Padding = new Padding(5);
            pnlChanges.Size = new Size(588, 300);
            pnlChanges.TabIndex = 0;
            pnlChanges.Visible = false;
            // 
            // txtChanges
            // 
            txtChanges.BorderStyle = BorderStyle.None;
            txtChanges.Dock = DockStyle.Fill;
            txtChanges.Location = new Point(5, 5);
            txtChanges.Name = "txtChanges";
            txtChanges.ReadOnly = true;
            txtChanges.Size = new Size(578, 290);
            txtChanges.TabIndex = 0;
            txtChanges.Text = "";
            // 
            // pnlLicense
            // 
            pnlLicense.Controls.Add(txtLicense);
            pnlLicense.Dock = DockStyle.Fill;
            pnlLicense.Location = new Point(0, 0);
            pnlLicense.Name = "pnlLicense";
            pnlLicense.Padding = new Padding(5);
            pnlLicense.Size = new Size(588, 300);
            pnlLicense.TabIndex = 1;
            pnlLicense.Visible = false;
            // 
            // txtLicense
            // 
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Dock = DockStyle.Fill;
            txtLicense.Location = new Point(5, 5);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(578, 290);
            txtLicense.TabIndex = 0;
            txtLicense.Text = "";
            // 
            // pnlThanksTo
            // 
            pnlThanksTo.Controls.Add(txtThanksTo);
            pnlThanksTo.Dock = DockStyle.Fill;
            pnlThanksTo.Location = new Point(0, 0);
            pnlThanksTo.Name = "pnlThanksTo";
            pnlThanksTo.Padding = new Padding(5);
            pnlThanksTo.Size = new Size(588, 300);
            pnlThanksTo.TabIndex = 2;
            pnlThanksTo.Visible = false;
            // 
            // txtThanksTo
            // 
            txtThanksTo.BorderStyle = BorderStyle.None;
            txtThanksTo.Dock = DockStyle.Fill;
            txtThanksTo.Location = new Point(5, 5);
            txtThanksTo.Name = "txtThanksTo";
            txtThanksTo.ReadOnly = true;
            txtThanksTo.Size = new Size(578, 290);
            txtThanksTo.TabIndex = 0;
            txtThanksTo.Text = "";
            // 
            // pnlAbout
            // 
            pnlAbout.Controls.Add(txtAbout);
            pnlAbout.Dock = DockStyle.Fill;
            pnlAbout.Location = new Point(0, 0);
            pnlAbout.Name = "pnlAbout";
            pnlAbout.Padding = new Padding(5);
            pnlAbout.Size = new Size(588, 300);
            pnlAbout.TabIndex = 3;
            // 
            // txtAbout
            // 
            txtAbout.BorderStyle = BorderStyle.None;
            txtAbout.Dock = DockStyle.Fill;
            txtAbout.Location = new Point(5, 5);
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.Size = new Size(578, 290);
            txtAbout.TabIndex = 0;
            txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(600, 500);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(500, 400);
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "About";
            Text = "About";
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerContent.ResumeLayout(false);
            headerContent.PerformLayout();
            tabButtonsPanel.ResumeLayout(false);
            tabButtonsPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            pnlChanges.ResumeLayout(false);
            pnlLicense.ResumeLayout(false);
            pnlThanksTo.ResumeLayout(false);
            pnlAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);
        }

        private void SelectTab(int index)
		{
            var backColor = SystemColors.Control;
            var foreColor = SystemColors.ControlText;
            var accentBackColor = SystemColors.Highlight;
            var accentForeColor = SystemColors.HighlightText;

            // Hide all panels
            pnlAbout.Visible = false;
			pnlThanksTo.Visible = false;
			pnlLicense.Visible = false;
			pnlChanges.Visible = false;

			// Reset all button styles to unselected state
			btnTabAbout.BackColor = backColor;
			btnTabAbout.ForeColor = foreColor;
			btnTabThanksTo.BackColor = backColor;
			btnTabThanksTo.ForeColor = foreColor;
			btnTabLicense.BackColor = backColor;
			btnTabLicense.ForeColor = foreColor;
			btnTabChanges.BackColor = backColor;
			btnTabChanges.ForeColor = foreColor;

			// Show selected panel and highlight button with accent color
			// Use white text for good contrast on the accent background
			switch (index)
			{
				case 0:
					pnlAbout.Visible = true;
					btnTabAbout.BackColor = accentBackColor;
					btnTabAbout.ForeColor = accentForeColor;
					break;
				case 1:
					pnlThanksTo.Visible = true;
					btnTabThanksTo.BackColor = accentBackColor;
					btnTabThanksTo.ForeColor = accentForeColor;
					break;
				case 2:
					pnlLicense.Visible = true;
					btnTabLicense.BackColor = accentBackColor;
					btnTabLicense.ForeColor = accentForeColor;
					break;
				case 3:
					pnlChanges.Visible = true;
					btnTabChanges.BackColor = accentBackColor;
					btnTabChanges.ForeColor = accentForeColor;
					break;
			}
		}

		private void LoadResources()
		{
			try
			{
				Assembly assembly = Assembly.GetExecutingAssembly();

				// Load version
				var version = assembly.GetName().Version;
				lblVersion.Text = $"Version: {version}";

				// Load ThanksTo
				string resThanksTo = "Be.HexEditor.Resources.ThanksTo.rtf";
				using (var stream = assembly.GetManifestResourceStream(resThanksTo))
				{
					if (stream != null)
						txtThanksTo.LoadFile(stream, RichTextBoxStreamType.RichText);
                    txtThanksTo.SelectAll();
                    txtThanksTo.SelectionColor = SystemColors.ControlText;
                }

				// Load License
				string resLicense = "Be.HexEditor.Resources.license.txt";
				using (var stream = assembly.GetManifestResourceStream(resLicense))
				{
					if (stream != null)
						txtLicense.LoadFile(stream, RichTextBoxStreamType.PlainText);
				}

				// Load Changes
				string resChanges = "Be.HexEditor.Resources.Changes.rtf";
				using (var stream = assembly.GetManifestResourceStream(resChanges))
				{
					if (stream != null)
						txtChanges.LoadFile(stream, RichTextBoxStreamType.RichText);
                    txtChanges.SelectAll();
                    txtChanges.SelectionColor = SystemColors.ControlText;
                }
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine($"Error loading resources: {ex.Message}");
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}




