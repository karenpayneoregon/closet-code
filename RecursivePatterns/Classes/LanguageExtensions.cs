using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace RecursivePatterns.Classes
{
    /// <summary>
    /// C#9
    /// </summary>
    public static class LanguageExtensions
    {
        public static List<Employee> GetEmployeesWhereManagerHasYearsAsManager(this Person person) => person switch
        {
            Manager { YearsAsManager: >=4 } manager => manager.Employees,
            Manager { YearsAsManager: 3 } manager => manager.Employees,
            _ => null
        };
    }


    public class Validates
    {
        public static bool ValidateBirthYear(string birthYear) =>
            birthYear.Length == 4 && birthYear.All(char.IsDigit)
                                  && int.TryParse(birthYear, out var year)
                                  && year is >= 1920 and <= 2002;
    }


}