using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Be.HexEditor.Theme;

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
            label1.Location = new Point(13, 47);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 0;
            label1.Text = "Byte number:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(170, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Tag = "Cancel";
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.AutoSize = true;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(73, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(91, 34);
            btnOK.TabIndex = 2;
            btnOK.Tag = "Ok";
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // nup
            // 
            nup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nup.Location = new Point(153, 47);
            nup.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup.Name = "nup";
            nup.Size = new Size(120, 20);
            nup.TabIndex = 3;
            nup.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 10;
            label2.Tag = "GoTo";
            label2.Text = "Go to";
            // 
            // line
            // 
            line.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            line.BackColor = Color.LightGray;
            line.Location = new Point(78, 22);
            line.Margin = new Padding(3, 10, 3, 3);
            line.Name = "line";
            line.Size = new Size(195, 1);
            line.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOK);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(5, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(268, 40);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormGoTo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(279, 139);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(line);
            Controls.Add(label2);
            Controls.Add(nup);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGoTo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Goto byte";
            Tag = "GotoByte";
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
