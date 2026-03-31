using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.ComponentModel.TypeConverter;

namespace Be.HexEditor
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;

    public class EnumTypeConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var enums = typeof(EnumPanel).Assembly
                .GetTypes()
                .Where(t => t.IsEnum)
                .OrderBy(t => t.Name)
                .ToList();

            return new StandardValuesCollection(enums);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string s)
            {
                // Try full name first
                var type = Type.GetType(s);

                if (type != null && type.IsEnum)
                    return type;

                // fallback: search loaded assemblies
                type = AppDomain.CurrentDomain
                    .GetAssemblies()
                    .SelectMany(a =>
                    {
                        try { return a.GetTypes(); }
                        catch { return Array.Empty<Type>(); }
                    })
                    .FirstOrDefault(t => t.FullName == s && t.IsEnum);

                if (type != null)
                    return type;
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is Type t)
            {
                return t.FullName; // important!
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
