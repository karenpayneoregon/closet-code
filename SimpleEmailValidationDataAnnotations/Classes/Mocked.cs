using System.Collections.Generic;

namespace SimpleEmailValidationDataAnnotations.Classes
{
    public class Mocked
    {
        public static List<Human> Humans => new()
        {
            new () {Name = "Karen", Email = "karen@gmail"},
            new () {Name = "Bill", Email = "billgmail"},
            new () {Name = "Mike", Email = "mike@"},
            new () {Name = "Sue", Email = "sue@comcast.net"},
        };
    }
}