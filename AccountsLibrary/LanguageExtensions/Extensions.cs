using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountsLibrary.LanguageExtensions
{
    public static class Extensions
    {
        public static T ToEnum<T>(this int value) where T : struct => (T)(object)value;
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}
