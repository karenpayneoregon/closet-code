using System;
using System.Collections.Generic;

namespace GetInformationForModel
{
    public static class Helpers
    {
        public static void IterateClassProperties<T>(this T sender)
        {
            foreach (var propertyInfo in sender.GetType().GetProperties())
            {
                Console.WriteLine(propertyInfo.PropertyType == typeof(DateTime)
                    ? $"{propertyInfo.Name,10}: {((DateTime)propertyInfo.GetValue(sender, null)):d}"
                    : $"{propertyInfo.Name,10}: {propertyInfo.GetValue(sender, null)} {propertyInfo.PropertyType.Name}");


                // not generic anymore
                if (propertyInfo.PropertyType == typeof(List<string>))
                {
                    Console.WriteLine($"{string.Join(",", ((List<string>)propertyInfo.GetValue(sender, null))!),25}");
                }
            }
        }
    }
}