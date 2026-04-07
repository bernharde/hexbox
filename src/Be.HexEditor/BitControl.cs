using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Be.HexEditor
{
	public partial class BitControl : UserControl
	{
		const int BitCount = 8;

		readonly List<TextBox> _bitEditors = new List<TextBox>(BitCount);
		readonly TableLayoutPanel _headerPanel;
		readonly TableLayoutPanel _editorPanel;

		public event EventHandler BitChanged;

		BitInfo _bitInfo;

		protected virtual void OnBitChanged(EventArgs e)
		{
			if (BitChanged != null)
				BitChanged(this, e);
		}

		public BitControl()
		{
			InitializeComponent();

			_headerPanel = CreateBitPanel();
			_editorPanel = CreateBitPanel();

			ConfigureLayout();
			CreateBitEditors();
			UpdateView();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public BitInfo BitInfo
		{
			get { return _bitInfo; }
			set
			{
				_bitInfo = value;
				UpdateView();
			}
		}

		TableLayoutPanel CreateBitPanel()
		{
			var panel = new TableLayoutPanel();
			panel.ColumnCount = BitCount;
			panel.RowCount = 1;
			panel.Dock = DockStyle.Fill;
			panel.Margin = Padding.Empty;
			panel.Padding = Padding.Empty;
			panel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;

			for (int i = 0; i < BitCount; i++)
			{
				panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / BitCount));
			}

			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			return panel;
		}

		void ConfigureLayout()
		{
			pnBitsHeader.SuspendLayout();
			pnBitsEditor.SuspendLayout();

			pnBitsHeader.Controls.Clear();
			pnBitsHeader.BackColor = SystemColors.Control;
			pnBitsHeader.Padding = new Padding(4, 2, 4, 0);
			pnBitsHeader.Controls.Add(_headerPanel);

			pnBitsEditor.Controls.Clear();
			pnBitsEditor.BackColor = SystemColors.Control;
			pnBitsEditor.Padding = new Padding(4, 0, 4, 2);
			pnBitsEditor.Controls.Add(_editorPanel);

			pnBitsHeader.ResumeLayout(false);
			pnBitsEditor.ResumeLayout(false);
		}

		void CreateBitEditors()
		{
			for (int bit = BitCount - 1, column = 0; bit >= 0; bit--, column++)
			{
				_headerPanel.Controls.Add(CreateHeaderLabel(bit), column, 0);

				var editor = CreateBitEditor(bit);
				_editorPanel.Controls.Add(editor, column, 0);
				_bitEditors.Add(editor);
			}
		}

		Label CreateHeaderLabel(int bit)
		{
			var label = new Label();
			label.AutoSize = false;
			label.Dock = DockStyle.Fill;
			label.Margin = Padding.Empty;
			label.Name = "lbl" + bit.ToString();
			label.Text = bit.ToString();
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Font = new Font("Consolas", SystemFonts.MessageBoxFont.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			return label;
		}

		TextBox CreateBitEditor(int bit)
		{
			var editor = new TextBox();
			editor.BorderStyle = BorderStyle.FixedSingle;
			editor.Dock = DockStyle.Fill;
			editor.Font = new Font("Consolas", SystemFonts.MessageBoxFont.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			editor.Margin = new Padding(1, 0, 1, 0);
			editor.MaxLength = 1;
			editor.Name = "txt" + bit.ToString();
			editor.ShortcutsEnabled = false;
			editor.TabIndex = BitCount - bit;
			editor.Tag = bit;
			editor.Text = "0";
			editor.TextAlign = HorizontalAlignment.Center;
			editor.Enter += editor_Enter;
			editor.KeyDown += editor_KeyDown;
			editor.MouseUp += editor_MouseUp;
			return editor;
		}

		private void UpdateView()
		{
			if (_bitInfo == null)
			{
				foreach (var editor in _bitEditors)
				{
					editor.Text = string.Empty;
				}
				lblBit.Visible = false;
				lblValue.Visible = false;
				pnBitsHeader.Visible = false;
				pnBitsEditor.Visible = false;

				return;
			}

			lblBit.Visible = true;
			lblValue.Visible = true;
			pnBitsHeader.Visible = true;
			pnBitsEditor.Visible = true;

			foreach (var editor in _bitEditors)
			{
				int bit = (int)editor.Tag;
				editor.Text = _bitInfo.GetBitAsString(bit);
			}
		}

		void editor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Tab)
				return;

			if (e.Modifiers != Keys.None)
				return;

			var editor = (TextBox)sender;
			e.Handled = true;
			e.SuppressKeyPress = true;

			switch (e.KeyCode)
			{
				case Keys.D0:
				case Keys.NumPad0:
					UpdateBit(editor, false);
					break;
				case Keys.D1:
				case Keys.NumPad1:
					UpdateBit(editor, true);
					break;
				case Keys.Left:
					NavigateRelative(editor, -1);
					break;
				case Keys.Right:
					NavigateRelative(editor, 1);
					break;
				case Keys.Home:
					FocusEditor(0);
					break;
				case Keys.End:
					FocusEditor(_bitEditors.Count - 1);
					break;
			}
		}

		void UpdateBit(TextBox editor, bool value)
		{
			if (_bitInfo == null)
				return;

			var bitIndex = (int)editor.Tag;
			var text = value ? "1" : "0";

			if (editor.Text == text && _bitInfo[bitIndex] == value)
			{
				NavigateRelative(editor, 1);
				return;
			}

			editor.Text = text;
			_bitInfo[bitIndex] = value;
			OnBitChanged(EventArgs.Empty);
			NavigateRelative(editor, 1);
		}

		void NavigateRelative(TextBox editor, int offset)
		{
			var index = _bitEditors.IndexOf(editor);
			FocusEditor(index + offset);
		}

		void FocusEditor(int index)
		{
			if (index < 0 || index >= _bitEditors.Count)
				return;

			var editor = _bitEditors[index];
			editor.Focus();
			SelectEditorText(editor);
		}

		void editor_Enter(object sender, EventArgs e)
		{
			SelectEditorText((TextBox)sender);
		}

		void editor_MouseUp(object sender, MouseEventArgs e)
		{
			SelectEditorText((TextBox)sender);
		}

		void SelectEditorText(TextBox editor)
		{
			editor.SelectionStart = 0;
			editor.SelectionLength = editor.TextLength;
		}
   }
}
