using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EnumerationLibrary.Models;
using static System.Attribute;

namespace EnumerationLibrary.Classes
{
    public class Operations
    {
        /// <summary>
        /// Generic method to get descriptions for enum members
        /// </summary>
        /// <typeparam name="T">enum</typeparam>
        /// <returns>list of <see cref="ItemContainer"/> </returns>
        /// <remarks>If T is not an enum an exception is thrown</remarks>
        public static List<ItemContainer> GetItems<T>()
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Must be an enum");
            }
  
            return Enum.GetValues(typeof(T)).Cast<T>()
                .Cast<Enum>()
                .Select(value => new ItemContainer
                {
                    Description =
                        ((GetCustomAttribute(value.GetType().GetField(value.ToString())!,
                            typeof(DescriptionAttribute)) as DescriptionAttribute)!)
                        .Description,
                    Value = value
                }).ToList();
        }

        /// <summary>
        /// Generic method to get descriptions for enum members
        /// </summary>
        /// <typeparam name="T">enum</typeparam>
        /// <returns>list of ItemContainer</returns>
        /// <remarks>does not perform checks for proper type</remarks>
        public static List<ItemContainer> GetItemsNoTypeCheck<T>() =>
            Enum.GetValues(typeof(T)).Cast<T>()
                .Cast<Enum>()
                .Select(value => new ItemContainer
                {
                    Description =
                        ((GetCustomAttribute(value.GetType().GetField(value.ToString())!,
                            typeof(DescriptionAttribute)) as DescriptionAttribute)!)
                        .Description,
                    Value = value
                }).ToList();

        /// <summary>
        /// Hard-wired method to get enum members descriptions
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// See generic version in EnumerationLibrary.Classes.GetItems
        /// </remarks>
        public static List<ItemContainer> CategoryItems() =>
            Enum.GetValues(typeof(Categories))
                .Cast<Enum>()
                .Select(value => new ItemContainer
                {
                    Description =
                        ((DescriptionAttribute)Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                            typeof(DescriptionAttribute))).Description,
                    Value = value
                }).ToList();
    }
}
