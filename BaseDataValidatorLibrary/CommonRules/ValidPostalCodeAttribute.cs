using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Made up rules to validate a postal code
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ValidPostalCodeAttribute : ValidationAttribute
    {
        /// <summary>
        ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
        /// </summary>
        public override bool IsValid(object postalCode)
        {
            if (postalCode is null)
            {
                return false;
            }

            var value = postalCode.ToString();

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            List<string> list = new() { "97301", "97223", "97209", "97146", "97374", "97734" };
            var result = list.FirstOrDefault(item => item == value);
            return result is not null;
        }
    }
}