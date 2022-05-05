using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation.Results;

namespace FluentValidationLibrary.LanguageExensions
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
        public static bool IsSocialSecurityNumberValid(this string ssn)
        {
            return !string.IsNullOrWhiteSpace(ssn) && new Regex(
                    @"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$")
                .IsMatch(ssn);
        }

        public static bool HasValidPostcode(this string postcode)
        {
            List<string> list = new() { "97301", "97223", "97209", "97146", "97374", "97734" };
            var result = list.FirstOrDefault(item => item == postcode);
            return result is not null;
        }

        /// <summary>
        /// Simple example to show how to do a validation 
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static bool HaveValidPin(this string pin)
        {
            List<string> list = new() { "1111", "1234", "5555"};
            var result = list.FirstOrDefault(item => item == pin);
            return result is null;
        }

        /// <summary>
        /// Display any error messages to the console
        /// </summary>
        /// <param name="sender"></param>
        public static void ShowErrorMessage(this ValidationResult sender)
        {
            sender.Errors.ForEach(Console.WriteLine);
        }
    }
}