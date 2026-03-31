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
			LoadResources();
			LocalizationManager.LoadCurrentCulture();
			this.ApplyLocalization();
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();

			mainLayout = new TableLayoutPanel();
			headerPanel = new Panel();
			headerContent = new FlowLayoutPanel();
			lblTitle = new Label();
			lblVersion = new Label();
			lblAuthor = new Label();
			lnkWebsite = new LinkLabel();
			tabControl = new TabControl();
			tabAbout = new TabPage();
			tabThanksTo = new TabPage();
			tabLicense = new TabPage();
			tabChanges = new TabPage();
			txtAbout = new RichTextBox();
			txtThanksTo = new RichTextBox();
			txtLicense = new RichTextBox();
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

			// mainLayout setup
			mainLayout.ColumnCount = 1;
			mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			mainLayout.RowCount = 3;
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			mainLayout.Dock = DockStyle.Fill;
			mainLayout.Padding = new Padding(10);
			mainLayout.Margin = new Padding(0);
			mainLayout.Name = "mainLayout";

			// Add controls to mainLayout
			mainLayout.Controls.Add(headerPanel, 0, 0);
			mainLayout.Controls.Add(tabControl, 0, 1);
			mainLayout.Controls.Add(btnOK, 0, 2);

			// Set button alignment in table layout
			mainLayout.SetCellPosition(btnOK, new TableLayoutPanelCellPosition(0, 2));

			// headerPanel setup
			headerPanel.BorderStyle = BorderStyle.FixedSingle;
			headerPanel.Dock = DockStyle.Fill;
			headerPanel.Name = "headerPanel";
			headerPanel.Padding = new Padding(5);

			// headerContent (FlowLayoutPanel) setup to avoid docking conflicts
			headerContent.AutoSize = true;
			headerContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			headerContent.FlowDirection = FlowDirection.TopDown;
			headerContent.Dock = DockStyle.Fill;
			headerContent.WrapContents = false;
			headerContent.Margin = new Padding(0);
			headerContent.Padding = new Padding(5);
			headerContent.Name = "headerContent";

			// lblTitle
			lblTitle.AutoSize = false;
			lblTitle.Height = 35;
			lblTitle.Width = 300;
			lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblTitle.Name = "lblTitle";
			lblTitle.Text = "Be.HexEditor";
			lblTitle.Margin = new Padding(0, 0, 0, 5);

			// lblVersion
			lblVersion.AutoSize = false;
			lblVersion.Height = 25;
			lblVersion.Width = 300;
			lblVersion.Name = "lblVersion";
			lblVersion.Text = "Version: ";
			lblVersion.Margin = new Padding(0, 0, 0, 3);

			// lblAuthor
			lblAuthor.AutoSize = false;
			lblAuthor.Height = 25;
			lblAuthor.Width = 300;
			lblAuthor.Name = "lblAuthor";
			lblAuthor.Text = "Author: Bernhard Elbl";
			lblAuthor.Margin = new Padding(0, 0, 0, 3);

			// lnkWebsite
			lnkWebsite.AutoSize = true;
			lnkWebsite.Name = "lnkWebsite";
			lnkWebsite.Text = "https://github.com/bemento/hexbox";
			lnkWebsite.Margin = new Padding(0);
			lnkWebsite.LinkClicked += (s, e) => Process.Start(new ProcessStartInfo(lnkWebsite.Text) { UseShellExecute = true });

			// Add header controls to flow layout
			headerContent.Controls.Add(lblTitle);
			headerContent.Controls.Add(lblVersion);
			headerContent.Controls.Add(lblAuthor);
			headerContent.Controls.Add(lnkWebsite);
			headerPanel.Controls.Add(headerContent);

			// tabControl setup
			tabControl.Controls.Add(tabAbout);
			tabControl.Controls.Add(tabThanksTo);
			tabControl.Controls.Add(tabLicense);
			tabControl.Controls.Add(tabChanges);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Name = "tabControl";
			tabControl.Margin = new Padding(0, 5, 0, 5);

			// tabAbout
			tabAbout.Controls.Add(txtAbout);
			tabAbout.Name = "tabAbout";
			tabAbout.Padding = new Padding(5);
			tabAbout.Text = "About";

			// txtAbout
			txtAbout.BackColor = Color.White;
			txtAbout.BorderStyle = BorderStyle.None;
			txtAbout.Dock = DockStyle.Fill;
			txtAbout.Name = "txtAbout";
			txtAbout.ReadOnly = true;
			txtAbout.Text = "Be.HexEditor\n\nA simple and modern hex editor built with .NET 10.\n\nFeatures:\n- View and edit binary files\n- Multiple encoding support\n- Find and replace functionality\n- Recent files list\n- Dark/Light theme support\n- Multi-language support";

			// tabThanksTo
			tabThanksTo.Controls.Add(txtThanksTo);
			tabThanksTo.Name = "tabThanksTo";
			tabThanksTo.Padding = new Padding(5);
			tabThanksTo.Text = "Thanks To";

			// txtThanksTo
			txtThanksTo.BackColor = Color.White;
			txtThanksTo.BorderStyle = BorderStyle.None;
			txtThanksTo.Dock = DockStyle.Fill;
			txtThanksTo.Name = "txtThanksTo";
			txtThanksTo.ReadOnly = true;

			// tabLicense
			tabLicense.Controls.Add(txtLicense);
			tabLicense.Name = "tabLicense";
			tabLicense.Padding = new Padding(5);
			tabLicense.Text = "License";

			// txtLicense
			txtLicense.BackColor = Color.White;
			txtLicense.BorderStyle = BorderStyle.None;
			txtLicense.Dock = DockStyle.Fill;
			txtLicense.Name = "txtLicense";
			txtLicense.ReadOnly = true;

			// tabChanges
			tabChanges.Controls.Add(txtChanges);
			tabChanges.Name = "tabChanges";
			tabChanges.Padding = new Padding(5);
			tabChanges.Text = "Changes";

			// txtChanges
			txtChanges.BackColor = Color.White;
			txtChanges.BorderStyle = BorderStyle.None;
			txtChanges.Dock = DockStyle.Fill;
			txtChanges.Name = "txtChanges";
			txtChanges.ReadOnly = true;

			// btnOK button setup
			btnOK.AutoSize = true;
			btnOK.DialogResult = DialogResult.OK;
			btnOK.FlatStyle = FlatStyle.Flat;
			btnOK.MinimumSize = new Size(100, 34);
			btnOK.Name = "btnOK";
			btnOK.Text = "OK";
			btnOK.Margin = new Padding(0, 5, 0, 0);
			btnOK.Click += (s, e) => Close();

			// uiManagerComponent
			uiManagerComponent.Form = this;

			// FormAbout
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			CancelButton = btnOK;
			ClientSize = new Size(650, 550);
			Controls.Add(mainLayout);
			MinimumSize = new Size(550, 450);
			Name = "FormAbout";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "About";
			Font = new Font("Segoe UI", 9F);

			mainLayout.ResumeLayout(false);
			mainLayout.PerformLayout();
			headerPanel.ResumeLayout(false);
			headerContent.ResumeLayout(false);
			headerPanel.PerformLayout();
			tabControl.ResumeLayout(false);
			tabAbout.ResumeLayout(false);
			tabThanksTo.ResumeLayout(false);
			tabLicense.ResumeLayout(false);
			tabChanges.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
			ResumeLayout(false);
			PerformLayout();
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

