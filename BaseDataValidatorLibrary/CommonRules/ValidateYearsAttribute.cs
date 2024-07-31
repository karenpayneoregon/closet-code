using System;
using System.ComponentModel.DataAnnotations;


namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Validate year only of a DateTime
    /// </summary>
    public class ValidateYearsAttribute : ValidationAttribute
    {
        /*
         * These are public to show how to get details in Models class.
         */
        public readonly DateTime MinValue = DateTime.UtcNow.AddYears(-90);
        public readonly DateTime MaxValue = DateTime.UtcNow;

        public override bool IsValid(object sender)
        {
            var value = (DateTime)sender;
            return value.Year >= MinValue.Year && value.Year <= MaxValue.Year;
        }

        public override string FormatErrorMessage(string name) 
            => string.Format(ErrorMessage!, 
                MinValue.ToString("yyyy"), 
                MaxValue.ToString("yyyy"));
    }
}
