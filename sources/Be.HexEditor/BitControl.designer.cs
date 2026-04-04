using Be.HexEditor.Localization;

namespace Be.HexEditor
{
	partial class BitControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBit = new System.Windows.Forms.Label();
            lblValue = new System.Windows.Forms.Label();
            pnBitsEditor = new System.Windows.Forms.Panel();
            pnBitsHeader = new System.Windows.Forms.Panel();
            layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblBit
            // 
            lblBit.AutoSize = true;
            lblBit.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBit.Location = new System.Drawing.Point(0, 0);
            lblBit.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            lblBit.Name = "lblBit";
            lblBit.Size = new System.Drawing.Size(44, 30);
            lblBit.TabIndex = 0;
            lblBit.Text = "Bit";
            lblBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            lblValue.Location = new System.Drawing.Point(0, 30);
            lblValue.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new System.Drawing.Size(44, 30);
            lblValue.TabIndex = 1;
            lblValue.Text = "Value";
            lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBitsEditor
            // 
            pnBitsEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            pnBitsEditor.Location = new System.Drawing.Point(52, 30);
            pnBitsEditor.Margin = new System.Windows.Forms.Padding(0);
            pnBitsEditor.Name = "pnBitsEditor";
            pnBitsEditor.Size = new System.Drawing.Size(370, 30);
            pnBitsEditor.TabIndex = 3;
            // 
            // pnBitsHeader
            // 
            pnBitsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            pnBitsHeader.Location = new System.Drawing.Point(52, 0);
            pnBitsHeader.Margin = new System.Windows.Forms.Padding(0);
            pnBitsHeader.Name = "pnBitsHeader";
            pnBitsHeader.Size = new System.Drawing.Size(370, 30);
            pnBitsHeader.TabIndex = 2;
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 2;
            layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            layoutPanel.Controls.Add(lblBit, 0, 0);
            layoutPanel.Controls.Add(lblValue, 0, 1);
            layoutPanel.Controls.Add(pnBitsHeader, 1, 0);
            layoutPanel.Controls.Add(pnBitsEditor, 1, 1);
            layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutPanel.Location = new System.Drawing.Point(0, 0);
            layoutPanel.Margin = new System.Windows.Forms.Padding(0);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 2;
            layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            layoutPanel.Size = new System.Drawing.Size(422, 60);
            layoutPanel.TabIndex = 0;
            // 
            // BitControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(layoutPanel);
            Name = "BitControl";
            Size = new System.Drawing.Size(422, 60);
            layoutPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Panel pnBitsEditor;
        private System.Windows.Forms.Panel pnBitsHeader;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
	}
}
