using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Be.HexEditor
{
	/// <summary>
	/// Summary description for UCAbout.
	/// </summary>
	public class UCAbout : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.TabPage tabLicense;
		private System.Windows.Forms.RichTextBox txtLicense;
		private System.Windows.Forms.TabPage tabChanges;
		private System.Windows.Forms.RichTextBox txtChanges;
		private System.Windows.Forms.LinkLabel lnkWorkspace;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabThanksTo;
		private System.Windows.Forms.RichTextBox txtThanksTo;
        private Label lblIcon;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container? components = null;

		public UCAbout()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

            try
            {
                Assembly ca = Assembly.GetExecutingAssembly();

                string resThanksTo = "Be.HexEditor.Resources.ThanksTo.rtf";
                txtThanksTo.LoadFile(ca.GetManifestResourceStream(resThanksTo), RichTextBoxStreamType.RichText);

                string resLicense = "Be.HexEditor.Resources.license.txt";
                txtLicense.LoadFile(ca.GetManifestResourceStream(resLicense), RichTextBoxStreamType.PlainText);

                string resChanges = "Be.HexEditor.Resources.Changes.rtf";
                txtChanges.LoadFile(ca.GetManifestResourceStream(resChanges), RichTextBoxStreamType.RichText);

                lblVersion.Text = ca.GetName().Version.ToString();
            }
            catch (Exception)
            {
                return;
            }
		}

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            
            base.ScaleControl(factor, specified);
        }

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblAuthor = new Label();
            lnkWorkspace = new LinkLabel();
            label5 = new Label();
            lblVersion = new Label();
            label7 = new Label();
            tabControl = new TabControl();
            tabThanksTo = new TabPage();
            txtThanksTo = new RichTextBox();
            tabLicense = new TabPage();
            txtLicense = new RichTextBox();
            tabChanges = new TabPage();
            txtChanges = new RichTextBox();
            lblIcon = new Label();
            tabControl.SuspendLayout();
            tabThanksTo.SuspendLayout();
            tabLicense.SuspendLayout();
            tabChanges.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = Color.White;
            lblAuthor.BorderStyle = BorderStyle.FixedSingle;
            lblAuthor.Location = new Point(0, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(100, 23);
            lblAuthor.TabIndex = 6;
            // 
            // lnkWorkspace
            // 
            lnkWorkspace.BackColor = Color.White;
            lnkWorkspace.BorderStyle = BorderStyle.FixedSingle;
            lnkWorkspace.Location = new Point(0, 0);
            lnkWorkspace.Name = "lnkWorkspace";
            lnkWorkspace.Size = new Size(100, 23);
            lnkWorkspace.TabIndex = 5;
            lnkWorkspace.TabStop = true;
            lnkWorkspace.LinkClicked += lnkCompany_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.White;
            lblVersion.BorderStyle = BorderStyle.FixedSingle;
            lblVersion.Location = new Point(0, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(100, 23);
            lblVersion.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 3;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabThanksTo);
            tabControl.Controls.Add(tabLicense);
            tabControl.Controls.Add(tabChanges);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(200, 100);
            tabControl.TabIndex = 1;
            // 
            // tabThanksTo
            // 
            tabThanksTo.Controls.Add(txtThanksTo);
            tabThanksTo.Location = new Point(4, 24);
            tabThanksTo.Name = "tabThanksTo";
            tabThanksTo.Size = new Size(192, 72);
            tabThanksTo.TabIndex = 0;
            // 
            // txtThanksTo
            // 
            txtThanksTo.BackColor = Color.White;
            txtThanksTo.BorderStyle = BorderStyle.None;
            txtThanksTo.Location = new Point(0, 0);
            txtThanksTo.Name = "txtThanksTo";
            txtThanksTo.ReadOnly = true;
            txtThanksTo.Size = new Size(100, 96);
            txtThanksTo.TabIndex = 0;
            txtThanksTo.Text = "";
            // 
            // tabLicense
            // 
            tabLicense.Controls.Add(txtLicense);
            tabLicense.Location = new Point(4, 24);
            tabLicense.Name = "tabLicense";
            tabLicense.Size = new Size(192, 72);
            tabLicense.TabIndex = 1;
            // 
            // txtLicense
            // 
            txtLicense.BackColor = Color.White;
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Location = new Point(0, 0);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(100, 96);
            txtLicense.TabIndex = 0;
            txtLicense.Text = "";
            // 
            // tabChanges
            // 
            tabChanges.Controls.Add(txtChanges);
            tabChanges.Location = new Point(4, 24);
            tabChanges.Name = "tabChanges";
            tabChanges.Size = new Size(192, 72);
            tabChanges.TabIndex = 2;
            // 
            // txtChanges
            // 
            txtChanges.BorderStyle = BorderStyle.None;
            txtChanges.Location = new Point(0, 0);
            txtChanges.Name = "txtChanges";
            txtChanges.Size = new Size(100, 96);
            txtChanges.TabIndex = 0;
            txtChanges.Text = "";
            // 
            // lblIcon
            // 
            lblIcon.BackColor = Color.White;
            lblIcon.BorderStyle = BorderStyle.FixedSingle;
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(100, 23);
            lblIcon.TabIndex = 0;
            // 
            // UCAbout
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(lblIcon);
            Controls.Add(tabControl);
            Controls.Add(lblVersion);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lnkWorkspace);
            Controls.Add(lblAuthor);
            Controls.Add(label1);
            Name = "UCAbout";
            Size = new Size(393, 245);
            Load += UCAbout_Load;
            tabControl.ResumeLayout(false);
            tabThanksTo.ResumeLayout(false);
            tabLicense.ResumeLayout(false);
            tabChanges.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private void lnkCompany_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(this.lnkWorkspace.Text));
			}
			catch (Exception ex1)
			{
				MessageBox.Show(ex1.Message);
			}
		}

		private void UCAbout_Load(object sender, EventArgs e)
		{
			// Load localization based on current culture
			LocalizationManager.LoadCurrentCulture();

			// Apply localization to all UI elements
			this.ApplyLocalization();

			this.tabControl.Width = this.Width - 10;
            this.tabControl.Height = this.Height - this.tabControl.Top - 10;
            this.lblAuthor.Width = this.Width - this.lblAuthor.Left - 10;
            this.lnkWorkspace.Width = this.Width - this.lnkWorkspace.Left - 10;
            this.lblVersion.Width = this.Width - this.lblVersion.Left - 10;
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            // 36F

            var factor = DeviceDpi / 96F;
            lblIcon.Font = new Font(Font.FontFamily, 36F * factor, FontStyle.Regular);

        }
    }
}
