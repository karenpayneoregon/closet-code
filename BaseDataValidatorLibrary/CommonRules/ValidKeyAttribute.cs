using System;
using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Custom rule for third digit for a forum question
    /// </summary>
    public class ValidKeyAttribute : ValidationAttribute
    {
        public override bool IsValid(object sender)
        {
            string value = Convert.ToString(sender);

            if (value!.Length < 9)
            {
                return false;
            }

            return value[2] == '0' || value[2] == '3';
        }
    }
}