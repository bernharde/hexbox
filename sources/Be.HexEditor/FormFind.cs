using Be.Windows.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Be.HexEditor.Theme;

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
            txtFind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFind.Location = new System.Drawing.Point(26, 81);
            txtFind.Name = "txtFind";
            txtFind.Size = new System.Drawing.Size(495, 23);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += txtString_TextChanged;
            // 
            // rbString
            // 
            rbString.AutoSize = true;
            rbString.Checked = true;
            rbString.ImeMode = ImeMode.NoControl;
            rbString.Location = new System.Drawing.Point(26, 59);
            rbString.Name = "rbString";
            rbString.Size = new System.Drawing.Size(46, 19);
            rbString.TabIndex = 0;
            rbString.TabStop = true;
            rbString.Text = "Text";
            // 
            // rbHex
            // 
            rbHex.AutoSize = true;
            rbHex.ImeMode = ImeMode.NoControl;
            rbHex.Location = new System.Drawing.Point(26, 131);
            rbHex.Name = "rbHex";
            rbHex.Size = new System.Drawing.Size(45, 19);
            rbHex.TabIndex = 3;
            rbHex.Text = "Hex";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "Find";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.AutoSize = true;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.ImeMode = ImeMode.NoControl;
            btnOK.Location = new System.Drawing.Point(266, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(120, 34);
            btnOK.TabIndex = 5;
            btnOK.Text = "&Find";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ImeMode = ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(392, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(120, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPercent
            // 
            lblPercent.ImeMode = ImeMode.NoControl;
            lblPercent.Location = new System.Drawing.Point(59, 0);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new System.Drawing.Size(96, 34);
            lblPercent.TabIndex = 14;
            lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinding
            // 
            lblFinding.ForeColor = System.Drawing.Color.Blue;
            lblFinding.ImeMode = ImeMode.NoControl;
            lblFinding.Location = new System.Drawing.Point(161, 0);
            lblFinding.Name = "lblFinding";
            lblFinding.Size = new System.Drawing.Size(99, 34);
            lblFinding.TabIndex = 13;
            // 
            // chkMatchCase
            // 
            chkMatchCase.AutoSize = true;
            chkMatchCase.ImeMode = ImeMode.NoControl;
            chkMatchCase.Location = new System.Drawing.Point(384, 57);
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.Size = new System.Drawing.Size(86, 19);
            chkMatchCase.TabIndex = 2;
            chkMatchCase.Text = "Match case";
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
            flowLayoutPanel1.Location = new System.Drawing.Point(17, 19);
            flowLayoutPanel1.Margin = new Padding(3, 1, 3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(515, 32);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // line
            // 
            line.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            line.BackColor = System.Drawing.Color.LightGray;
            line.Location = new System.Drawing.Point(39, 10);
            line.Margin = new Padding(3, 10, 3, 3);
            line.Name = "line";
            line.Size = new System.Drawing.Size(462, 1);
            line.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Controls.Add(btnOK);
            flowLayoutPanel2.Controls.Add(lblFinding);
            flowLayoutPanel2.Controls.Add(lblPercent);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new System.Drawing.Point(6, 322);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(515, 42);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // hexFind
            // 
            hexFind.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            hexFind.BuiltInContextMenu.CopyMenuItemImage = FluentUI.Copy16;
            hexFind.BuiltInContextMenu.CopyMenuItemScalingImageName = "Copy";
            hexFind.BuiltInContextMenu.CopyMenuItemText = "Copy";
            hexFind.BuiltInContextMenu.CutMenuItemImage = FluentUI.Cut16;
            hexFind.BuiltInContextMenu.CutMenuItemScalingImageName = "Cut";
            hexFind.BuiltInContextMenu.CutMenuItemText = "Cut";
            hexFind.BuiltInContextMenu.PasteMenuItemImage = FluentUI.ClipboardPaste16;
            hexFind.BuiltInContextMenu.PasteMenuItemScalingImageName = "Paste";
            hexFind.BuiltInContextMenu.PasteMenuItemText = "Paste";
            hexFind.BuiltInContextMenu.SelectAllMenuItemText = "Select All";
            hexFind.Enabled = false;
            hexFind.Font = new System.Drawing.Font("Consolas", 9F);
            hexFind.InfoForeColor = System.Drawing.Color.Empty;
            hexFind.Location = new System.Drawing.Point(26, 154);
            hexFind.Name = "hexFind";
            hexFind.Size = new System.Drawing.Size(495, 162);
            hexFind.TabIndex = 4;
            // 
            // uiManagerComponent
            // 
            uiManagerComponent.Form = this;
            // 
            // FormFind
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(533, 369);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(chkMatchCase);
            Controls.Add(rbHex);
            Controls.Add(rbString);
            Controls.Add(txtFind);
            Controls.Add(hexFind);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFind";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find";
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
