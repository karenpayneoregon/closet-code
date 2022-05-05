using System.ComponentModel.DataAnnotations;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.CommonRules
{
    public class CharacterAttribute : ValidationAttribute
    {
        public override bool IsValid(object sender)
        {

            char value = sender.ToString()[0];

            return value.IsLetter();
        }
    }
}