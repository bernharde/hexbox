using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Be.HexEditor;

public class EnumPanel : FlowLayoutPanel
{
    private Label _headerLabel;
    private object _selectedValue;

    public event EventHandler SelectedValueChanged;

    public object SelectedValue
    {
        get => _selectedValue;
        private set
        {
            _selectedValue = value;
            SelectedValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    // Styling (can be customized)
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BackgroundColor { get; set; } = Color.FromArgb(30, 30, 30);
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color ButtonColor { get; set; } = Color.FromArgb(45, 45, 48);
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color HoverColor { get; set; } = Color.FromArgb(60, 60, 65);
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color SelectedColor { get; set; } = Color.FromArgb(0, 120, 215);
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color TextColor { get; set; } = Color.White;

    public EnumPanel()
    {
        AutoSize = true;
        FlowDirection = FlowDirection.LeftToRight;
        WrapContents = false;
        Padding = new Padding(5);
        BackColor = BackgroundColor;
    }

    public void SetEnum<T>(string header) where T : Enum
    {
        Controls.Clear();

        // Header
        _headerLabel = new Label
        {
            Text = header,
            AutoSize = true,
            ForeColor = TextColor,
            Margin = new Padding(0, 6, 10, 0)
        };

        Controls.Add(_headerLabel);

        var values = Enum.GetValues(typeof(T)).Cast<T>().ToList();

        foreach (var val in values)
        {
            var btn = CreateButton(val);
            Controls.Add(btn);
        }

        // select first by default
        if (values.Count > 0)
            SelectValue(values[0]);
    }

    private Button CreateButton(object value)
    {
        var btn = new Button
        {
            Text = value.ToString(),
            Tag = value,
            AutoSize = true,
            FlatStyle = FlatStyle.Flat,
            BackColor = ButtonColor,
            ForeColor = TextColor,
            Margin = new Padding(2),
            Padding = new Padding(8, 4, 8, 4)
        };

        btn.FlatAppearance.BorderSize = 0;

        btn.Click += (s, e) =>
        {
            SelectValue(value);
        };

        btn.MouseEnter += (s, e) =>
        {
            if (!Equals(value, SelectedValue))
                btn.BackColor = HoverColor;
        };

        btn.MouseLeave += (s, e) =>
        {
            if (!Equals(value, SelectedValue))
                btn.BackColor = ButtonColor;
        };

        return btn;
    }

    private void SelectValue(object value)
    {
        SelectedValue = value;

        foreach (var btn in Controls.OfType<Button>())
        {
            if (Equals(btn.Tag, value))
            {
                btn.BackColor = SelectedColor;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = ButtonColor;
                btn.ForeColor = TextColor;
            }
        }
    }
}