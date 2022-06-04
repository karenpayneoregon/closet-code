using System;
using System.ComponentModel.DataAnnotations;

namespace ValidatingFormProject.Rules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ValidCountryNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is null)
            {
                return false;
            }

            return value.ToString() != "Select";

        }
    }
}