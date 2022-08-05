using System.Collections.Generic;
using Bogus;
using CheckedListBoxExtensionsApp1.Models;

namespace CheckedListBoxExtensionsApp1.Classes
{
    public class BogusOperations 
    {
        public static List<Company> Companies(int count = 10)
        {
            int identifier = 1;
            Faker<Company> fakePerson = new Faker<Company>()
                .CustomInstantiator(f => new Company(identifier++))
                .RuleFor(p => p.Name, f => f.Company.CompanyName());

            return fakePerson.Generate(count);

        }
    }
}