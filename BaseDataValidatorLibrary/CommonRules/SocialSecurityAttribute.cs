using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Basic SSN validation, see also
    /// FluentValidationUnitTests.LanguageExtensions.IsSSNValid extension for more validation
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SocialSecurityAttribute : ValidationAttribute
    {
        public string SocialValue { get; set; }

        public override bool IsValid(object sender)
        {
            if (sender is null)
            {
                return false;
            }

            if (sender.ToString().Length == 9 && Regex.IsMatch(sender.ToString()!, @"^\d{9}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
