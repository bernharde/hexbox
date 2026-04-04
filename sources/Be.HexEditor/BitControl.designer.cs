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
            pnBitsEditor = new System.Windows.Forms.Panel();
            pnBitsHeader = new System.Windows.Forms.Panel();
            layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnBitsEditor
            // 
            pnBitsEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            pnBitsEditor.Location = new System.Drawing.Point(0, 30);
            pnBitsEditor.Margin = new System.Windows.Forms.Padding(0);
            pnBitsEditor.Name = "pnBitsEditor";
            pnBitsEditor.Size = new System.Drawing.Size(422, 30);
            pnBitsEditor.TabIndex = 1;
            // 
            // pnBitsHeader
            // 
            pnBitsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            pnBitsHeader.Location = new System.Drawing.Point(0, 0);
            pnBitsHeader.Margin = new System.Windows.Forms.Padding(0);
            pnBitsHeader.Name = "pnBitsHeader";
            pnBitsHeader.Size = new System.Drawing.Size(422, 30);
            pnBitsHeader.TabIndex = 0;
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 1;
            layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            layoutPanel.Controls.Add(pnBitsHeader, 0, 0);
            layoutPanel.Controls.Add(pnBitsEditor, 0, 1);
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

        private System.Windows.Forms.Panel pnBitsEditor;
        private System.Windows.Forms.Panel pnBitsHeader;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
	}
}
