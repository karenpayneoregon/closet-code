using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FluentValidationLibrary.LanguageExtensions
{
    public static class ValidatingHelpers
    {
        /// <summary>
        /// Extreme validation for social security number
        /// </summary>
        /// <param name="ssn">value to validate</param>
        /// <returns></returns>
        /// <remarks>
        /// For simple validation see BaseDataValidatorLibrary.CommonRules.SocialSecurityAttribute
        /// </remarks>
        public static bool IsSSNValid(this string ssn)
        {
            return !string.IsNullOrWhiteSpace(ssn) && new Regex(
                    @"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$")
                .IsMatch(ssn);
        }
    }
}
