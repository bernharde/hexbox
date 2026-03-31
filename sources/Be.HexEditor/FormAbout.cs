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
		private Button btnOK;
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
				uiManagerComponent.Form = this;

				// Tab button event handlers
				btnTabAbout.Click += (s, e) => SelectTab(0);
				btnTabThanksTo.Click += (s, e) => SelectTab(1);
				btnTabLicense.Click += (s, e) => SelectTab(2);
				btnTabChanges.Click += (s, e) => SelectTab(3);

				SelectTab(0); // Show first tab
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
            btnOK = new Button();
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
            mainLayout.Controls.Add(btnOK, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.Size = new Size(600, 500);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(headerContent);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(13, 13);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(5);
            headerPanel.Size = new Size(574, 134);
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
            headerContent.Padding = new Padding(5);
            headerContent.Size = new Size(562, 122);
            headerContent.TabIndex = 0;
            headerContent.WrapContents = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(5, 5);
            lblTitle.Margin = new Padding(0, 0, 0, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Be.HexEditor";
            // 
            // lblVersion
            // 
            lblVersion.Location = new Point(5, 45);
            lblVersion.Margin = new Padding(0, 0, 0, 3);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(300, 25);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version: ";
            // 
            // lblAuthor
            // 
            lblAuthor.Location = new Point(5, 73);
            lblAuthor.Margin = new Padding(0, 0, 0, 3);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(300, 25);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author: Bernhard Elbl";
            // 
            // lnkWebsite
            // 
            lnkWebsite.AutoSize = true;
            lnkWebsite.Location = new Point(5, 101);
            lnkWebsite.Margin = new Padding(0);
            lnkWebsite.Name = "lnkWebsite";
            lnkWebsite.Size = new Size(204, 15);
            lnkWebsite.TabIndex = 3;
            lnkWebsite.TabStop = true;
            lnkWebsite.Text = "https://github.com/bemento/hexbox";
            // 
            // tabButtonsPanel
            // 
            tabButtonsPanel.Controls.Add(btnTabAbout);
            tabButtonsPanel.Controls.Add(btnTabThanksTo);
            tabButtonsPanel.Controls.Add(btnTabLicense);
            tabButtonsPanel.Controls.Add(btnTabChanges);
            tabButtonsPanel.Dock = DockStyle.Fill;
            tabButtonsPanel.Location = new Point(10, 155);
            tabButtonsPanel.Margin = new Padding(0, 5, 0, 5);
            tabButtonsPanel.Name = "tabButtonsPanel";
            tabButtonsPanel.Size = new Size(580, 30);
            tabButtonsPanel.TabIndex = 1;
            tabButtonsPanel.WrapContents = false;
            // 
            // btnTabAbout
            // 
            btnTabAbout.FlatAppearance.BorderSize = 0;
            btnTabAbout.FlatStyle = FlatStyle.Flat;
            btnTabAbout.Location = new Point(0, 0);
            btnTabAbout.Margin = new Padding(0);
            btnTabAbout.Name = "btnTabAbout";
            btnTabAbout.Size = new Size(80, 32);
            btnTabAbout.TabIndex = 0;
            btnTabAbout.Text = "About";
            // 
            // btnTabThanksTo
            // 
            btnTabThanksTo.FlatAppearance.BorderSize = 0;
            btnTabThanksTo.FlatStyle = FlatStyle.Flat;
            btnTabThanksTo.Location = new Point(80, 0);
            btnTabThanksTo.Margin = new Padding(0);
            btnTabThanksTo.Name = "btnTabThanksTo";
            btnTabThanksTo.Size = new Size(80, 32);
            btnTabThanksTo.TabIndex = 1;
            btnTabThanksTo.Text = "Thanks To";
            // 
            // btnTabLicense
            // 
            btnTabLicense.FlatAppearance.BorderSize = 0;
            btnTabLicense.FlatStyle = FlatStyle.Flat;
            btnTabLicense.Location = new Point(160, 0);
            btnTabLicense.Margin = new Padding(0);
            btnTabLicense.Name = "btnTabLicense";
            btnTabLicense.Size = new Size(80, 32);
            btnTabLicense.TabIndex = 2;
            btnTabLicense.Text = "License";
            // 
            // btnTabChanges
            // 
            btnTabChanges.FlatAppearance.BorderSize = 0;
            btnTabChanges.FlatStyle = FlatStyle.Flat;
            btnTabChanges.Location = new Point(240, 0);
            btnTabChanges.Margin = new Padding(0);
            btnTabChanges.Name = "btnTabChanges";
            btnTabChanges.Size = new Size(80, 32);
            btnTabChanges.TabIndex = 3;
            btnTabChanges.Text = "Changes";
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(pnlChanges);
            contentPanel.Controls.Add(pnlLicense);
            contentPanel.Controls.Add(pnlThanksTo);
            contentPanel.Controls.Add(pnlAbout);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(10, 190);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(580, 250);
            contentPanel.TabIndex = 2;
            // 
            // pnlChanges
            // 
            pnlChanges.Controls.Add(txtChanges);
            pnlChanges.Dock = DockStyle.Fill;
            pnlChanges.Location = new Point(0, 0);
            pnlChanges.Name = "pnlChanges";
            pnlChanges.Padding = new Padding(5);
            pnlChanges.Size = new Size(580, 250);
            pnlChanges.TabIndex = 0;
            pnlChanges.Visible = false;
            // 
            // txtChanges
            // 
            txtChanges.BackColor = Color.White;
            txtChanges.BorderStyle = BorderStyle.None;
            txtChanges.Dock = DockStyle.Fill;
            txtChanges.Location = new Point(5, 5);
            txtChanges.Name = "txtChanges";
            txtChanges.ReadOnly = true;
            txtChanges.Size = new Size(570, 240);
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
            pnlLicense.Size = new Size(580, 250);
            pnlLicense.TabIndex = 1;
            pnlLicense.Visible = false;
            // 
            // txtLicense
            // 
            txtLicense.BackColor = Color.White;
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Dock = DockStyle.Fill;
            txtLicense.Location = new Point(5, 5);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(570, 240);
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
            pnlThanksTo.Size = new Size(580, 250);
            pnlThanksTo.TabIndex = 2;
            pnlThanksTo.Visible = false;
            // 
            // txtThanksTo
            // 
            txtThanksTo.BackColor = Color.White;
            txtThanksTo.BorderStyle = BorderStyle.None;
            txtThanksTo.Dock = DockStyle.Fill;
            txtThanksTo.Location = new Point(5, 5);
            txtThanksTo.Name = "txtThanksTo";
            txtThanksTo.ReadOnly = true;
            txtThanksTo.Size = new Size(570, 240);
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
            pnlAbout.Size = new Size(580, 250);
            pnlAbout.TabIndex = 3;
            // 
            // txtAbout
            // 
            txtAbout.BackColor = Color.White;
            txtAbout.BorderStyle = BorderStyle.None;
            txtAbout.Dock = DockStyle.Fill;
            txtAbout.Location = new Point(5, 5);
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.Size = new Size(570, 240);
            txtAbout.TabIndex = 0;
            txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.AutoSize = true;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(480, 456);
            btnOK.Margin = new Padding(0, 10, 10, 0);
            btnOK.MinimumSize = new Size(100, 34);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 34);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormAbout
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = btnOK;
            ClientSize = new Size(600, 500);
            Controls.Add(mainLayout);
            MinimumSize = new Size(500, 400);
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerContent.ResumeLayout(false);
            headerContent.PerformLayout();
            tabButtonsPanel.ResumeLayout(false);
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
			// Hide all panels
			pnlAbout.Visible = false;
			pnlThanksTo.Visible = false;
			pnlLicense.Visible = false;
			pnlChanges.Visible = false;

			// Reset all button styles
			btnTabAbout.BackColor = Color.Transparent;
			btnTabAbout.ForeColor = SystemColors.ControlText;
			btnTabThanksTo.BackColor = Color.Transparent;
			btnTabThanksTo.ForeColor = SystemColors.ControlText;
			btnTabLicense.BackColor = Color.Transparent;
			btnTabLicense.ForeColor = SystemColors.ControlText;
			btnTabChanges.BackColor = Color.Transparent;
			btnTabChanges.ForeColor = SystemColors.ControlText;

			// Show selected panel and highlight button
			switch (index)
			{
				case 0:
					pnlAbout.Visible = true;
					btnTabAbout.BackColor = SystemColors.Highlight;
					btnTabAbout.ForeColor = SystemColors.HighlightText;
					break;
				case 1:
					pnlThanksTo.Visible = true;
					btnTabThanksTo.BackColor = SystemColors.Highlight;
					btnTabThanksTo.ForeColor = SystemColors.HighlightText;
					break;
				case 2:
					pnlLicense.Visible = true;
					btnTabLicense.BackColor = SystemColors.Highlight;
					btnTabLicense.ForeColor = SystemColors.HighlightText;
					break;
				case 3:
					pnlChanges.Visible = true;
					btnTabChanges.BackColor = SystemColors.Highlight;
					btnTabChanges.ForeColor = SystemColors.HighlightText;
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
