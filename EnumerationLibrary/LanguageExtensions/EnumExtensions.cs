using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationLibrary.LanguageExtensions
{

    public static class EnumExtensions
    {
        /// <summary>
        /// Convert string to enum member
        /// </summary>
        /// <typeparam name="T">Enum to work with</typeparam>
        /// <param name="value">Value to convert</param>
        /// <returns>Enum member or <see cref="ArgumentException"/> </returns>
        public static T GetValueFromEnumMember<T>(this string value) where T : Enum
        {
            var type = typeof(T);

            foreach (var field in type.GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute)
                {
                    if (attribute.Value == value)
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == value)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            throw new ArgumentException($"unknown value: {value}");
        }
    }
}
