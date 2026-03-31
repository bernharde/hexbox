using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Be.HexEditor;

[ToolboxItem(true)]
[DefaultEvent(nameof(SelectedValueChanged))]
[DefaultProperty(nameof(EnumType))]
public class EnumPanel : FlowLayoutPanel
{
    private Label _headerLabel;
    private object _selectedValue;

    public event EventHandler SelectedValueChanged;

    [Category("Data")]
    [Browsable(true)]
    //[TypeConverter(typeof(EnumValueConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public object SelectedValue
    {
        get => _selectedValue;
        set
        {
            if (_selectedValue == value)
                return;

            SelectValue(value);
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


    private Type _enumType;

    [Category("Data")]
    [Description("Enum type used to generate buttons")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    //[TypeConverter(typeof(EnumTypeConverter))]
    public Type EnumType
    {
        get => _enumType;
        set
        {
            if (_enumType != value)
            {
                _enumType = value;

                Rebuild();

                if (IsInDesignMode)
                    TypeDescriptor.Refresh(this); 
            }
        }
    }

    private string _headerText = "Header";

    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string HeaderText
    {
        get => _headerText;
        set
        {
            _headerText = value;
            if (_headerLabel != null)
                _headerLabel.Text = value;
        }
    }

    private void Rebuild()
    {
        Controls.Clear();

        if (_enumType == null || !_enumType.IsEnum)
            return;

        // Header
        _headerLabel = new Label
        {
            Text = HeaderText,
            AutoSize = true,
            ForeColor = TextColor,
            Margin = new Padding(0, 6, 10, 0)
        };

        Controls.Add(_headerLabel);

        var values = Enum.GetValues(_enumType);

        foreach (var val in values)
        {
            var btn = CreateButton(val);
            Controls.Add(btn);
        }

        if (values.Length > 0)
            SelectValue(values.GetValue(0));
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        if (IsInDesignMode)
            Rebuild();
    }

    private bool IsInDesignMode =>  LicenseManager.UsageMode == LicenseUsageMode.Designtime;

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