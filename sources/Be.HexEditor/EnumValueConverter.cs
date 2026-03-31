using System;
using System.Collections.Generic;
using System.Text;

namespace Be.HexEditor
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public class EnumValueConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            try
            {
                if (context?.Instance is EnumPanel panel &&
                    panel.EnumType != null &&
                    panel.EnumType.IsEnum)
                {
                    var values = Enum.GetValues(panel.EnumType)
                                     .Cast<object>()
                                     .ToList();

                    return new StandardValuesCollection(values);
                }
            }
            catch
            {
                // NEVER crash designer
            }

            return new StandardValuesCollection(Array.Empty<object>());
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            => sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            try
            {
                if (context?.Instance is EnumPanel panel &&
                    panel.EnumType != null &&
                    value is string s)
                {
                    return Enum.Parse(panel.EnumType, s);
                }
            }
            catch
            {
                // swallow errors
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            => destinationType == typeof(string) || base.CanConvertTo(context, destinationType);

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            try
            {
                if (destinationType == typeof(string) && value != null)
                    return value.ToString();
            }
            catch
            {
                // swallow
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
