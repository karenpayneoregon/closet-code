using System;
using System.Globalization;

namespace IFormatProviderExample.Classes
{
    public partial class SqlFormatProvider
    {
        public class SqlFormatter : ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (arg == null)
                {
                    return "NULL";
                }

                // pattern matching
                if (arg is string stringValue)
                {
                    return $"'{stringValue.Replace("'", "''")}'";
                }

                if (arg is DateTime dateTime)
                {
                    return $"'{dateTime:MM/dd/yyyy}'";
                }

                if (arg is IFormattable formattable)
                {
                    return formattable.ToString(format, CultureInfo.InvariantCulture);
                }

                return arg.ToString();
            }
        }
    }

    public partial class SqlFormatProvider : IFormatProvider
    {
        private readonly SqlFormatter _formatter = new();

        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) ? _formatter : null;
        }
    }
}