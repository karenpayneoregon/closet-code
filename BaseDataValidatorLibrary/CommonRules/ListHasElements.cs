using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Rule to assert there is at least one element in a list property
    /// </summary>
    public class ListHasElements : ValidationAttribute
    {
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
