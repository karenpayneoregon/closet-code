using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Example to allow/disallow specific values
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ValidPinAttribute : ValidationAttribute
    {
        /// <summary>
        ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
        /// </summary>
        public override bool IsValid(object pin)
        {
            if (pin is null)
            {
                return false;
            }

            var value = pin.ToString();

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (value.Length < 4)
            {
                return false;
            }

            List<string> list = new() { "1111", "1234", "5555" };
            var result = list.FirstOrDefault(item => item == value);

            return result is null;
        }
    }
}