using Be.Windows.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Be.HexEditor
{
    /// <summary>
    /// Summary description for FormFind.
    /// </summary>
    public class FormFind: Form
	{
		private Be.Windows.Forms.HexBox hexFind;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.RadioButton rbString;
		private System.Windows.Forms.RadioButton rbHex;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
		private Label lblPercent;
		private Label lblFinding;
		private CheckBox chkMatchCase;
		private Timer timerPercent;
		private Timer timer;
		private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel line;
        private UiManagerComponent uiManagerComponent;
        private IContainer components;

		public FormFind()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			rbString.CheckedChanged += new EventHandler(rb_CheckedChanged);
			rbHex.CheckedChanged += new EventHandler(rb_CheckedChanged);

		}

		void ByteProvider_Changed(object sender, EventArgs e)
		{
			ValidateFind();
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormFind));
            txtFind = new TextBox();
            rbString = new RadioButton();
            rbHex = new RadioButton();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            lblPercent = new Label();
            lblFinding = new Label();
            chkMatchCase = new CheckBox();
            timerPercent = new Timer(components);
            timer = new Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            line = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            hexFind = new HexBox();
            uiManagerComponent = new UiManagerComponent(components);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((ISupportInitialize)uiManagerComponent).BeginInit();
            SuspendLayout();
            // 
            // txtFind
            // 
            resources.ApplyResources(txtFind, "txtFind");
            txtFind.Name = "txtFind";
            txtFind.TextChanged += txtString_TextChanged;
            // 
            // rbString
            // 
            resources.ApplyResources(rbString, "rbString");
            rbString.Checked = true;
            rbString.Name = "rbString";
            rbString.TabStop = true;
            // 
            // rbHex
            // 
            resources.ApplyResources(rbHex, "rbHex");
            rbHex.Name = "rbHex";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Name = "label1";
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPercent
            // 
            resources.ApplyResources(lblPercent, "lblPercent");
            lblPercent.Name = "lblPercent";
            // 
            // lblFinding
            // 
            lblFinding.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(lblFinding, "lblFinding");
            lblFinding.Name = "lblFinding";
            // 
            // chkMatchCase
            // 
            resources.ApplyResources(chkMatchCase, "chkMatchCase");
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // timerPercent
            // 
            timerPercent.Tick += timerPercent_Tick;
            // 
            // timer
            // 
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(line);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // line
            // 
            resources.ApplyResources(line, "line");
            line.BackColor = System.Drawing.Color.LightGray;
            line.Name = "line";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Controls.Add(btnOK);
            flowLayoutPanel2.Controls.Add(lblFinding);
            flowLayoutPanel2.Controls.Add(lblPercent);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // hexFind
            // 
            resources.ApplyResources(hexFind, "hexFind");
            // 
            // 
            // 
            hexFind.BuiltInContextMenu.CopyMenuItemImage = Pngs.Copy16;
            hexFind.BuiltInContextMenu.CopyMenuItemScalingImageName = "Copy";
            hexFind.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.CopyMenuItemText");
            hexFind.BuiltInContextMenu.CutMenuItemImage = Pngs.Cut16;
            hexFind.BuiltInContextMenu.CutMenuItemScalingImageName = "Cut";
            hexFind.BuiltInContextMenu.CutMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.CutMenuItemText");
            hexFind.BuiltInContextMenu.PasteMenuItemImage = Pngs.Paste16;
            hexFind.BuiltInContextMenu.PasteMenuItemScalingImageName = "Paste";
            hexFind.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.PasteMenuItemText");
            hexFind.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.SelectAllMenuItemText");
            hexFind.InfoForeColor = System.Drawing.Color.Empty;
            hexFind.Name = "hexFind";
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            uiManagerComponent.Mode = ThemeMode.Dark;
            // 
            // FormFind
            // 
            AcceptButton = btnOK;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            CancelButton = btnCancel;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(chkMatchCase);
            Controls.Add(rbHex);
            Controls.Add(rbString);
            Controls.Add(txtFind);
            Controls.Add(hexFind);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFind";
            ShowIcon = false;
            ShowInTaskbar = false;
            Activated += FormFind_Activated;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((ISupportInitialize)uiManagerComponent).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private FindOptions _findOptions;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FindOptions FindOptions
		{
			get 
			{ 
				return _findOptions; 
			}
			set
			{
				_findOptions = value;
				Reinitialize();
			}
		}

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public HexBox HexBox { get; set; }

		private void Reinitialize()
		{
			rbString.Checked = _findOptions.Type == FindType.Text;
			txtFind.Text = _findOptions.Text;
			chkMatchCase.Checked = _findOptions.MatchCase;

			rbHex.Checked = _findOptions.Type == FindType.Hex;

			if (hexFind.ByteProvider != null)
				hexFind.ByteProvider.Changed -= new EventHandler(ByteProvider_Changed);

			var hex = this._findOptions.Hex != null ? _findOptions.Hex : new byte[0];
			hexFind.ByteProvider = new DynamicByteProvider(hex);
			hexFind.ByteProvider.Changed += new EventHandler(ByteProvider_Changed);
		}

		private void rb_CheckedChanged(object sender, System.EventArgs e)
		{
			txtFind.Enabled = rbString.Checked;
			hexFind.Enabled = !txtFind.Enabled;

			if(txtFind.Enabled)
				txtFind.Focus();
			else
				hexFind.Focus();
		}

		private void rbString_Enter(object sender, EventArgs e)
		{
			txtFind.Focus();
		}

		private void rbHex_Enter(object sender, EventArgs e)
		{
			hexFind.Focus();
		}

		private void FormFind_Activated(object sender, System.EventArgs e)
		{
			if(rbString.Checked)
				txtFind.Focus();
			else
				hexFind.Focus();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			_findOptions.MatchCase = chkMatchCase.Checked;

			var provider = this.hexFind.ByteProvider as DynamicByteProvider;
			_findOptions.Hex = provider.Bytes.ToArray();
			_findOptions.Text = txtFind.Text;
			_findOptions.Type = rbHex.Checked ? FindType.Hex : FindType.Text;
			_findOptions.MatchCase = chkMatchCase.Checked;
			_findOptions.IsValid = true;

			FindNext();
		}

		bool _finding;

		public void FindNext()
		{
			if (!_findOptions.IsValid)
				return;

			UpdateUIToFindingState();

			// start find process
			long res = HexBox.Find(_findOptions);

			UpdateUIToNormalState();

			Application.DoEvents();

			if (res == -1) // -1 = no match
			{
				MessageBox.Show(strings.FindOperationEndOfFile, Program.SoftwareName,
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (res == -2) // -2 = find was aborted
			{
				return;
			}
			else // something was found
			{
				this.Close();

				Application.DoEvents();

				if (!HexBox.Focused)
					HexBox.Focus();
			}
		}

		private void UpdateUIToNormalState()
		{
			timer.Stop();
			timerPercent.Stop();
			_finding = false;
			txtFind.Enabled = chkMatchCase.Enabled = rbHex.Enabled = rbString.Enabled
				= hexFind.Enabled = btnOK.Enabled = true;
		}

		private void UpdateUIToFindingState()
		{
			_finding = true;
			timer.Start();
			timerPercent.Start();
			txtFind.Enabled = chkMatchCase.Enabled = rbHex.Enabled = rbString.Enabled
				= hexFind.Enabled = btnOK.Enabled = false;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			if (_finding)
				this.HexBox.AbortFind();
			else
				this.Close();
		}

		private void txtString_TextChanged(object sender, EventArgs e)
		{
			ValidateFind();
		}

		private void ValidateFind()
		{
			var isValid = false;
			if (rbString.Checked && txtFind.Text.Length > 0)
				isValid = true;
			if (rbHex.Checked && hexFind.ByteProvider.Length > 0)
				isValid = true;
			this.btnOK.Enabled = isValid;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (lblFinding.Text.Length == 13)
				lblFinding.Text = "";

			lblFinding.Text += ".";
		}

		private void timerPercent_Tick(object sender, EventArgs e)
		{
			long pos = this.HexBox.CurrentFindingPosition;
			long length = HexBox.ByteProvider.Length;
			double percent = (double)pos / (double)length * (double)100;

			System.Globalization.NumberFormatInfo nfi =
				new System.Globalization.CultureInfo("en-US").NumberFormat;

			string text = percent.ToString("0.00", nfi) + " %";
			lblPercent.Text = text;
		}

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

	}
}
