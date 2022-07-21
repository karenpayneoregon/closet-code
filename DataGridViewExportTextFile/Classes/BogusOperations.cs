using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using Person = DataGridViewExportTextFile.Models.Person;

namespace DataGridViewExportTextFile.Classes
{
    public class BogusOperations
    {
        [SuppressMessage("ReSharper", "All")]
        public static List<Person> People(int count = 10)
        {
            int identifier = 1;
            
            Faker<Person> fakePerson = new Faker<Person>()
                    .CustomInstantiator(f => new Person(identifier++))
                    .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                    .RuleFor(p => p.LastName, f => f.Person.LastName)
                    .RuleFor(p => p.BirthDate, f => f.Date.Past(10))
                ;

           
            return fakePerson.Generate(count);

        }
    }
}
