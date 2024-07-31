using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedPatternMatching;

class Howdy
{
    public static string TimeOfDay() => DateTime.Now.Hour switch
    {
        <= 12 => "Good Morning",
        <= 16 => "Good Afternoon",
        <= 20 => "Good Evening",
        _ => "Good Night"
    };
}