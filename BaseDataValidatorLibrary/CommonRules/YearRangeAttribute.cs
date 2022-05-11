using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.CommonRules
{

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class YearRangeAttribute : ValidationAttribute
    {
        public YearRangeAttribute(int maximumYear)
        {
            MaximumYear = maximumYear;
        }
        /// <summary>
        /// Maximum permitted year
        /// </summary>
        public int MaximumYear { get; }
        /// <summary>
        /// Minimum permitted year
        /// </summary>
        public int MinimumYear { get; set; }
        public override string FormatErrorMessage(string name)
        {
            if (ErrorMessage is null && ErrorMessageResourceName is null)
            {
                ErrorMessage = "'Year {0}' and/or year '{1}' are invalid";
            }

            return $"{name} year must be between {MinimumYear} and {MaximumYear}";

        }

        public override bool IsValid(object sender)
            => ((DateTime)sender).Year.Between(MinimumYear, MaximumYear);
    }
}