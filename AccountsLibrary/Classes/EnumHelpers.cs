using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AccountsLibrary.Models;
using static System.Attribute;

namespace AccountsLibrary.Classes
{
    public class EnumHelpers
    {

        /// <summary>
        /// Generic method to get descriptions for enum members
        /// </summary>
        /// <typeparam name="T">enum</typeparam>
        /// <returns>list of ItemContainer</returns>
        public static List<EnumContainer> GetEnumDetails<T>() =>
            Enum.GetValues(typeof(T)).Cast<T>()
                .Cast<Enum>()
                .Select(value => new EnumContainer
                {
                    Description =
                        ((GetCustomAttribute(value.GetType().GetField(value.ToString())!,
                            typeof(DescriptionAttribute)) as DescriptionAttribute)!)
                        .Description,
                    Value = value
                }).ToList();

        
    }
}
