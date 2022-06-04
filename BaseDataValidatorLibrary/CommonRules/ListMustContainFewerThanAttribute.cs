using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.CommonRules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ListMustContainFewerThanAttribute : ValidationAttribute
    {
        public ListMustContainFewerThanAttribute(int maximum)
        {
            Maximum = maximum;
        }

        public int Maximum { get; set; }

        public override string FormatErrorMessage(string name)
        {
            if (ErrorMessage == null && ErrorMessageResourceName == null)
            {
                ErrorMessage = "is unacceptable";
            }

            return $"{name.SplitCamelCase()} count must be less than {Maximum}";

        }
        /// <summary>
        ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
        /// </summary>
        public override bool IsValid(object sender)
        {
            if (sender is null)
            {
                return false;
            }

            if (sender.IsList())
            {
                var result = ((IEnumerable)sender).Cast<object>().ToList();
                return result.Count < 5;
            }
            else
            {
                return false;
            }

        }
    }
}