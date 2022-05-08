using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CheckedListBoxExtensionsApp.Models;
using Bogus;

namespace CheckedListBoxExtensionsApp.Classes
{
    public class BogusOperations 
    {
        public static List<Company> Companies(int count = 10)
        {
            int identifier = 1;
            Faker<Company> fakePerson = new Faker<Company>()
                .CustomInstantiator(f => new Company(identifier++))
                .RuleFor(p => p.Name, f => f.Company.CompanyName())
;


            return fakePerson.Generate(count);

        }
    }
}