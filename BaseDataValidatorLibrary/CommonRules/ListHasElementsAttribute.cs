using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Rule to assert there is at least one element in a list property
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ListHasElementsAttribute : ValidationAttribute
    {
        /// <summary>
        ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
        /// </summary>
        public override bool IsValid(object sender)
        {
            if (sender == null)
            {
                return false;
            }

            if (sender.IsList())
            {
                var result = ((IEnumerable)sender).Cast<object>().ToList();
                return result.Any();
            }
            else
            {
                return false;
            }
        }
    }
}
