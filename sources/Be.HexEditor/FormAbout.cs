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
		private TabControl tabControl;
		private TabPage tabAbout;
		private TabPage tabThanksTo;
		private TabPage tabLicense;
		private TabPage tabChanges;
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
            tabControl = new TabControl();
            tabAbout = new TabPage();
            txtAbout = new RichTextBox();
            tabThanksTo = new TabPage();
            txtThanksTo = new RichTextBox();
            tabLicense = new TabPage();
            txtLicense = new RichTextBox();
            tabChanges = new TabPage();
            txtChanges = new RichTextBox();
            btnOK = new Button();
            uiManagerComponent = new UiManagerComponent(components);
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            headerContent.SuspendLayout();
            tabControl.SuspendLayout();
            tabAbout.SuspendLayout();
            tabThanksTo.SuspendLayout();
            tabLicense.SuspendLayout();
            tabChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(tabControl, 0, 1);
            mainLayout.Controls.Add(btnOK, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.Size = new Size(650, 550);
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
            headerPanel.Size = new Size(624, 134);
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
            headerContent.Size = new Size(612, 122);
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
            // tabControl
            // 
            tabControl.Controls.Add(tabAbout);
            tabControl.Controls.Add(tabThanksTo);
            tabControl.Controls.Add(tabLicense);
            tabControl.Controls.Add(tabChanges);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(10, 155);
            tabControl.Margin = new Padding(0, 5, 0, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(630, 330);
            tabControl.TabIndex = 1;
            // 
            // tabAbout
            // 
            tabAbout.Controls.Add(txtAbout);
            tabAbout.Location = new Point(4, 24);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(5);
            tabAbout.Size = new Size(622, 302);
            tabAbout.TabIndex = 0;
            tabAbout.Text = "About";
            // 
            // txtAbout
            // 
            txtAbout.BackColor = Color.White;
            txtAbout.BorderStyle = BorderStyle.None;
            txtAbout.Dock = DockStyle.Fill;
            txtAbout.Location = new Point(5, 5);
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.Size = new Size(612, 292);
            txtAbout.TabIndex = 0;
            txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // tabThanksTo
            // 
            tabThanksTo.Controls.Add(txtThanksTo);
            tabThanksTo.Location = new Point(4, 24);
            tabThanksTo.Name = "tabThanksTo";
            tabThanksTo.Padding = new Padding(5);
            tabThanksTo.Size = new Size(622, 302);
            tabThanksTo.TabIndex = 1;
            tabThanksTo.Text = "Thanks To";
            // 
            // txtThanksTo
            // 
            txtThanksTo.BackColor = Color.White;
            txtThanksTo.BorderStyle = BorderStyle.None;
            txtThanksTo.Dock = DockStyle.Fill;
            txtThanksTo.Location = new Point(5, 5);
            txtThanksTo.Name = "txtThanksTo";
            txtThanksTo.ReadOnly = true;
            txtThanksTo.Size = new Size(612, 292);
            txtThanksTo.TabIndex = 0;
            txtThanksTo.Text = "";
            // 
            // tabLicense
            // 
            tabLicense.Controls.Add(txtLicense);
            tabLicense.Location = new Point(4, 24);
            tabLicense.Name = "tabLicense";
            tabLicense.Padding = new Padding(5);
            tabLicense.Size = new Size(622, 302);
            tabLicense.TabIndex = 2;
            tabLicense.Text = "License";
            // 
            // txtLicense
            // 
            txtLicense.BackColor = Color.White;
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Dock = DockStyle.Fill;
            txtLicense.Location = new Point(5, 5);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(612, 292);
            txtLicense.TabIndex = 0;
            txtLicense.Text = "";
            // 
            // tabChanges
            // 
            tabChanges.Controls.Add(txtChanges);
            tabChanges.Location = new Point(4, 24);
            tabChanges.Name = "tabChanges";
            tabChanges.Padding = new Padding(5);
            tabChanges.Size = new Size(622, 302);
            tabChanges.TabIndex = 3;
            tabChanges.Text = "Changes";
            // 
            // txtChanges
            // 
            txtChanges.BackColor = Color.White;
            txtChanges.BorderStyle = BorderStyle.None;
            txtChanges.Dock = DockStyle.Fill;
            txtChanges.Location = new Point(5, 5);
            txtChanges.Name = "txtChanges";
            txtChanges.ReadOnly = true;
            txtChanges.Size = new Size(612, 292);
            txtChanges.TabIndex = 0;
            txtChanges.Text = "";
            // 
            // btnOK
            // 
            btnOK.AutoSize = true;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(10, 495);
            btnOK.Margin = new Padding(0, 5, 0, 0);
            btnOK.MinimumSize = new Size(100, 34);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 34);
            btnOK.TabIndex = 2;
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
            ClientSize = new Size(650, 550);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(550, 450);
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
            tabControl.ResumeLayout(false);
            tabAbout.ResumeLayout(false);
            tabThanksTo.ResumeLayout(false);
            tabLicense.ResumeLayout(false);
            tabChanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);
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

