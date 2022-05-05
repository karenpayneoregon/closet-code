using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class GenericExtensions
    {
        public static bool Between<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T>
            => Comparer<T>.Default.Compare(value, lowerValue) >= 0 &&
               Comparer<T>.Default.Compare(value, upperValue) <= 0;

        public static bool BetweenExclusive<T>(this IComparable<T> sender, T minimumValue, T maximumValue)
            => sender.CompareTo(minimumValue) > 0 && sender.CompareTo(maximumValue) < 0;

        public static bool IsGreaterThan<T>(this T sender, T value) where T : IComparable
            => sender.CompareTo(value) > 0;

        public static bool IsLessThan<T>(this T sender, T value) where T : IComparable
            => sender.CompareTo(value) < 0;

        /// <summary>
        /// Get ErrorMessage for specific Attribute
        /// </summary>
        /// <typeparam name="T">Attribute</typeparam>
        /// <param name="instance">instance of a class</param>
        /// <param name="propertyName">Property name in instance to get error message</param>
        /// <returns>error message</returns>
        public static T GetAttribute<T>(this object instance, string propertyName) where T : Attribute
        {
            var attrType = typeof(T);
            var property = instance.GetType().GetProperty(propertyName);
            return (T)property!.GetCustomAttributes(attrType, false).First();
        }
    }
}
