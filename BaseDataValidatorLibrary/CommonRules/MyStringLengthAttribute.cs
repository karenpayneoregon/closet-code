using System;
using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Example for custom rule on string length of a class property
    /// [MyStringLength(6, MinimumLength = 3)]
    /// </summary>
    public class MyStringLengthAttribute : StringLengthAttribute
    {
        public MyStringLengthAttribute(int maximumLength) : base(maximumLength)
        {
        }

        public override bool IsValid(object value)
        {
            string val = Convert.ToString(value);

            if (val!.Length < MinimumLength)
            {
                ErrorMessage = "Minimum length should be 3";
            }

            if (val.Length > MaximumLength)
            {
                ErrorMessage = "Maximum length should be 6";
            }

            return base.IsValid(value);
        }
    }
}
