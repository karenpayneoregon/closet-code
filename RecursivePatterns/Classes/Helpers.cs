using System;
using System.Collections.Generic;
using System.Text;

namespace RecursivePatterns.Classes
{
    public class Helpers
    {
        public static IEnumerable<List<Employee>> GetEmployeesWhereManagerHasThreeYearsAsManager(List<Person> people)
        {
            const int years = 3;

            foreach (var person in people)
            {
                /*
                 * If Manager and has been for three years
                 *
                 * YearsAsManager equates to if YearsAsManager = 3
                 * Employees: { } employees means to return list of employees under this manager
                 */
                if (person is Manager { YearsAsManager: years, Employees: { } employees })
                {
                    yield return employees;
                }
            }
        }

    }
}
