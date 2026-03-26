using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            btnOK = new Button();
            ucAbout1 = new UCAbout();
            uiManagerComponent = new UiManagerComponent(components);
            ((System.ComponentModel.ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.Click += btnOK_Click;
            // 
            // ucAbout1
            // 
            resources.ApplyResources(ucAbout1, "ucAbout1");
            ucAbout1.Name = "ucAbout1";
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            uiManagerComponent.Mode = ThemeMode.Dark;
            // 
            // FormAbout
            // 
            AcceptButton = btnOK;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(btnOK);
            Controls.Add(ucAbout1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
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
