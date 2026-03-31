using System.Windows.Forms;
using Be.HexEditor.Theme;

namespace Be.HexEditor
{
    /// <summary>
    /// Summary description for FormAbout.
    /// </summary>
    public class FormAbout: Form
	{
		private Be.HexEditor.UCAbout ucAbout1;
		private System.Windows.Forms.Button btnOK;
        private UiManagerComponent uiManagerComponent;
        private System.ComponentModel.IContainer components;

        public FormAbout()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            btnOK = new Button();
            ucAbout1 = new UCAbout();
            uiManagerComponent = new UiManagerComponent(components);
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.ImeMode = ImeMode.NoControl;
            btnOK.Location = new System.Drawing.Point(390, 398);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(120, 34);
            btnOK.TabIndex = 0;
            btnOK.Text = "Ok";
            btnOK.Click += btnOK_Click;
            // 
            // ucAbout1
            // 
            ucAbout1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucAbout1.Location = new System.Drawing.Point(1, 11);
            ucAbout1.Margin = new Padding(2);
            ucAbout1.Name = "ucAbout1";
            ucAbout1.Size = new System.Drawing.Size(518, 382);
            ucAbout1.TabIndex = 1;
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormAbout
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(530, 450);
            Controls.Add(btnOK);
            Controls.Add(ucAbout1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void btnOK_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
