using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EnumerationLibrary.Classes
{
    public class EnumHelper
    {
        public static List<KeyValuePair<string, Enum>> GetItemsAsDictionary<T>() =>
            Enum.GetValues(typeof(T)).Cast<T>()
                .Cast<Enum>()
                .Select(value => new KeyValuePair<string, Enum>(
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString())!,
                        typeof(DescriptionAttribute)) as DescriptionAttribute)!.Description, value))
                .ToList();
        public static List<KeyValuePair<string, Enum>> GetItemsAsDictionarySafe<T>()
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Must be an enum");
            }
            return Enum.GetValues(typeof(T)).Cast<T>()
                .Cast<Enum>()
                .Select(value => new KeyValuePair<string, Enum>(
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString())!, 
                        typeof(DescriptionAttribute)) as DescriptionAttribute)!.Description, value))
                .ToList();
        }
    }
}