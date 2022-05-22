using System;
using System.Collections.Generic;
using Bogus;
using DataGridViewExport.Models;

namespace DataGridViewExport.Classes
{
    public class CreateOperations
    {
        /// <summary>
        /// Generate a list of <see cref="Contacts"/>
        /// </summary>
        /// <param name="rowCount"></param>
        /// <returns>list of contacts using <see cref="rowCount"/></returns>
        public static List<Contact> Contacts(int rowCount = 10)
        {
            int contactIdentifier = 1;

            return new Faker<Contact>()
                .CustomInstantiator(f => new(contactIdentifier++))
                .RuleFor(contact => contact.FirstName, f => f.Name.FirstName())
                .RuleFor(contact => contact.LastName, f => f.Name.LastName())
                .RuleFor(contact => contact.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(contact => contact.Email, f => f.Person.Email)
                .RuleFor(item => item.BirthDate, f => f.Date.Between(
                    new DateTime(1980, 1, 1), 
                    new DateTime(2022, 12, 1)))
                .Generate(rowCount);
        }
    }
}