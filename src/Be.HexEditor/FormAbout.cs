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
		
		private TabControl aboutTabControl;
		private TabPage tabPageAbout;
		private TabPage tabPageThanksTo;
		private TabPage tabPageLicense;
		private TabPage tabPageChanges;
		
		private Panel pnlAbout;
		private Panel pnlThanksTo;
		private Panel pnlLicense;
		private Panel pnlChanges;
		
		private RichTextBox txtAbout;
		private RichTextBox txtThanksTo;
		private RichTextBox txtLicense;
		private RichTextBox txtChanges;
		private UiManagerComponent uiManagerComponent;
        private Button cancelButton;
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

				// Apply theme BEFORE selecting the first tab
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
            aboutTabControl = new TabControl();
            tabPageAbout = new TabPage();
            tabPageThanksTo = new TabPage();
            tabPageLicense = new TabPage();
            tabPageChanges = new TabPage();
            cancelButton = new Button();
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
            aboutTabControl.SuspendLayout();
            tabPageAbout.SuspendLayout();
            tabPageThanksTo.SuspendLayout();
            tabPageLicense.SuspendLayout();
            tabPageChanges.SuspendLayout();
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
            mainLayout.Controls.Add(aboutTabControl, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(5);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
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
            // aboutTabControl
            // 
            aboutTabControl.Controls.Add(tabPageAbout);
            aboutTabControl.Controls.Add(tabPageThanksTo);
            aboutTabControl.Controls.Add(tabPageLicense);
            aboutTabControl.Controls.Add(tabPageChanges);
            aboutTabControl.Dock = DockStyle.Fill;
            aboutTabControl.Location = new Point(5, 145);
            aboutTabControl.Margin = new Padding(0);
            aboutTabControl.Name = "aboutTabControl";
            aboutTabControl.SelectedIndex = 0;
            aboutTabControl.Size = new Size(590, 342);
            aboutTabControl.TabIndex = 1;
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(pnlAbout);
            tabPageAbout.Location = new Point(4, 24);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(0);
            tabPageAbout.Size = new Size(582, 314);
            tabPageAbout.TabIndex = 0;
            tabPageAbout.Tag = "About";
            tabPageAbout.Text = "About";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tabPageThanksTo
            // 
            tabPageThanksTo.Controls.Add(pnlThanksTo);
            tabPageThanksTo.Location = new Point(4, 24);
            tabPageThanksTo.Name = "tabPageThanksTo";
            tabPageThanksTo.Padding = new Padding(0);
            tabPageThanksTo.Size = new Size(582, 314);
            tabPageThanksTo.TabIndex = 1;
            tabPageThanksTo.Tag = "ThanksTo";
            tabPageThanksTo.Text = "Thanks To";
            tabPageThanksTo.UseVisualStyleBackColor = true;
            // 
            // tabPageLicense
            // 
            tabPageLicense.Controls.Add(pnlLicense);
            tabPageLicense.Location = new Point(4, 24);
            tabPageLicense.Name = "tabPageLicense";
            tabPageLicense.Padding = new Padding(0);
            tabPageLicense.Size = new Size(582, 314);
            tabPageLicense.TabIndex = 2;
            tabPageLicense.Tag = "License";
            tabPageLicense.Text = "License";
            tabPageLicense.UseVisualStyleBackColor = true;
            // 
            // tabPageChanges
            // 
            tabPageChanges.Controls.Add(pnlChanges);
            tabPageChanges.Location = new Point(4, 24);
            tabPageChanges.Name = "tabPageChanges";
            tabPageChanges.Padding = new Padding(0);
            tabPageChanges.Size = new Size(582, 314);
            tabPageChanges.TabIndex = 3;
            tabPageChanges.Tag = "Changes";
            tabPageChanges.Text = "Changes";
            tabPageChanges.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(0, 0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(0, 0);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "btnCancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // pnlChanges
            // 
            pnlChanges.Controls.Add(txtChanges);
            pnlChanges.Dock = DockStyle.Fill;
            pnlChanges.Location = new Point(0, 0);
            pnlChanges.Name = "pnlChanges";
            pnlChanges.Padding = new Padding(5);
            pnlChanges.Size = new Size(582, 314);
            pnlChanges.TabIndex = 0;
            // 
            // txtChanges
            // 
            txtChanges.BackColor = SystemColors.ControlLightLight;
            txtChanges.BorderStyle = BorderStyle.None;
            txtChanges.Dock = DockStyle.Fill;
            txtChanges.Location = new Point(5, 5);
            txtChanges.Name = "txtChanges";
            txtChanges.ReadOnly = true;
            txtChanges.Size = new Size(572, 304);
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
            pnlLicense.Size = new Size(582, 314);
            pnlLicense.TabIndex = 1;
            // 
            // txtLicense
            // 
            txtLicense.BackColor = SystemColors.ControlLightLight;
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Dock = DockStyle.Fill;
            txtLicense.Location = new Point(5, 5);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(572, 304);
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
            pnlThanksTo.Size = new Size(582, 314);
            pnlThanksTo.TabIndex = 2;
            // 
            // txtThanksTo
            // 
            txtThanksTo.BackColor = SystemColors.ControlLightLight;
            txtThanksTo.BorderStyle = BorderStyle.None;
            txtThanksTo.Dock = DockStyle.Fill;
            txtThanksTo.Location = new Point(5, 5);
            txtThanksTo.Name = "txtThanksTo";
            txtThanksTo.ReadOnly = true;
            txtThanksTo.Size = new Size(572, 304);
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
            pnlAbout.Size = new Size(582, 314);
            pnlAbout.TabIndex = 3;
            // 
            // txtAbout
            // 
            txtAbout.BackColor = SystemColors.ControlLightLight;
            txtAbout.BorderStyle = BorderStyle.None;
            txtAbout.Dock = DockStyle.Fill;
            txtAbout.Location = new Point(5, 5);
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.Size = new Size(572, 304);
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
            CancelButton = cancelButton;
            ClientSize = new Size(600, 500);
            Controls.Add(cancelButton);
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
            aboutTabControl.ResumeLayout(false);
            tabPageAbout.ResumeLayout(false);
            tabPageThanksTo.ResumeLayout(false);
            tabPageLicense.ResumeLayout(false);
            tabPageChanges.ResumeLayout(false);
            pnlChanges.ResumeLayout(false);
            pnlLicense.ResumeLayout(false);
            pnlThanksTo.ResumeLayout(false);
            pnlAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);
        }

		private void LoadResources()
		{
			try
			{
				Assembly assembly = Assembly.GetExecutingAssembly();

				// Load version
                var fileInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                var version = fileInfo.ProductVersion;
                if (string.IsNullOrWhiteSpace(version))
                    version = fileInfo.FileVersion;
                if (string.IsNullOrWhiteSpace(version))
                    version = assembly.GetName().Version?.ToString() ?? "unknown";

                int metadataSeparator = version.IndexOf('+');
                if (metadataSeparator > 0)
                    version = version.Substring(0, metadataSeparator);

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




