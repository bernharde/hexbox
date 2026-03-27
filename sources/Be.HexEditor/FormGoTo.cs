using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Be.HexEditor
{
	/// <summary>
	/// Summary description for FormGoTo.
	/// </summary>
    public class FormGoTo: Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nup;
		private System.Windows.Forms.Label label2;
        private Panel line;
        private FlowLayoutPanel flowLayoutPanel1;
        private UiManagerComponent uiManagerComponent;
        private IContainer components;

        public FormGoTo()
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormGoTo));
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            nup = new NumericUpDown();
            label2 = new Label();
            line = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            uiManagerComponent = new UiManagerComponent(components);
            ((ISupportInitialize)nup).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Name = "btnOK";
            btnOK.Click += btnOK_Click;
            // 
            // nup
            // 
            resources.ApplyResources(nup, "nup");
            nup.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup.Name = "nup";
            nup.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.ForeColor = Color.Blue;
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // line
            // 
            resources.ApplyResources(line, "line");
            line.BackColor = Color.LightGray;
            line.Name = "line";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOK);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormGoTo
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(line);
            Controls.Add(label2);
            Controls.Add(nup);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGoTo";
            ShowInTaskbar = false;
            Activated += FormGoTo_Activated;
            ((ISupportInitialize)nup).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);

        }
        #endregion

        public void SetDefaultValue(long byteIndex)
		{
			nup.Value = byteIndex + 1;
		}

		public void SetMaxByteIndex(long maxByteIndex)
		{
			nup.Maximum = maxByteIndex + 1;
		}

		public long GetByteIndex()
		{
			return Convert.ToInt64(nup.Value) - 1;
		}

		private void FormGoTo_Activated(object sender, System.EventArgs e)
		{
			nup.Focus();
			nup.Select(0, nup.Value.ToString().Length);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}
