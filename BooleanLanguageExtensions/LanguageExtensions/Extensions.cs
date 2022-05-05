using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooleanLanguageExtensions.Models;

namespace BooleanLanguageExtensions.LanguageExtensions
{
    public static class Extensions
    {
        public static string ToYesNoStringIs(this bool value, LanguageCode code) =>
            code is LanguageCode.English ? value ? "Yes" : "No" :
            code is LanguageCode.Spanish ? value ? "sí" : "No" :
            code is LanguageCode.Russian ? value ? "da" : "Net" :
            code is LanguageCode.Vietnamese ? value ? "Đúng" : "Không" :
            throw new ArgumentOutOfRangeException("Unknown language code");
    }
}
