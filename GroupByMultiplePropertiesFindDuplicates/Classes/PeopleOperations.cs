using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupByMultiplePropertiesFindDuplicates.Models;

namespace GroupByMultiplePropertiesFindDuplicates.Classes
{
    public class PeopleOperations
    {
        public static void Example1()
        {
            List<Person> people = new()
            {
                new() { FirstName = "Karen", LastName = "Payne", BirthDate = new DateTime(1960, 12, 1) },
                new() { FirstName = "Mary", LastName = "Payne", BirthDate = new DateTime(1960, 12, 1) },
                new() { FirstName = "Karen", LastName = "Payne", BirthDate = new DateTime(1960, 1, 1) },
                new() { FirstName = "Karen", LastName = "Payne", BirthDate = new DateTime(1960, 12, 1) },
            };

            List<Person> distinctItems = people
                .GroupBy(person => new
                {
                    person.FirstName,
                    person.LastName,
                    person.BirthDate
                })
                .Select(groupItem => groupItem.First())
                .ToList();

            List<Person> distinctPeople = new(distinctItems);
            foreach (var person in distinctPeople)
            {
                Console.WriteLine($"{person.FirstName,-10}{person.BirthDate:d}");
            }
        }
    }
}
