using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Microsoft.EntityFrameworkCore;
using ShadowProperties.Data;
using ShadowProperties.Models;

namespace ShadowProperties.Classes
{
    public class BogusOperations
    {
        /// <summary>
        /// Create records
        /// </summary>
        /// <param name="count">Count of records to generate</param>
        /// <returns>List of Contact1</returns>
        public static List<Contact1> Contact1List(int count = 50)
        {

            var fakeContact = new Faker<Contact1>()
                .CustomInstantiator(f => new Contact1())
                .RuleFor(contact => contact.FirstName, f => f.Person.FirstName)
                .RuleFor(contact => contact.LastName, f => f.Person.LastName);

            return fakeContact.Generate(count);
        }

        /// <summary>
        /// Populate Contact1 table with n records
        /// </summary>
        /// <param name="count">Count of records to create</param>
        /// <returns></returns>
        public static async Task<int> PopulateContact1Table(int count)
        {
            await using var context = new ShadowContext();

            context.Contacts1.AddRange(Contact1List(count));

            int affected = await context.SaveChangesAsync();

            return affected;

        }

        /// <summary>
        /// Remove several records by setting is deleted in override of SaveChanges
        /// </summary>
        /// <param name="identifiers">keys to delete</param>
        /// <returns>Current filtered list</returns>
        public static async Task<List<Contact1>> RemoveSomeRecords(int[] identifiers)
        {
            await using var context = new ShadowContext();

            for (int index = 0; index < identifiers.Length; index++)
            {
                context.Remove(context.Contacts1
                    .FirstOrDefault(contact => contact.ContactId == identifiers[index])!);
            }
            
            await context.SaveChangesAsync();

            return context.Contacts1.ToList();

        }

        /// <summary>
        /// Get un-filter record count ignoring any filters
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Contact1>> WithNoFilter()
        {
            await using var context = new ShadowContext();
            return context.Contacts1.IgnoreQueryFilters().ToList();
        }
        public static async Task<List<Contact1>> WithFilter()
        {
            await using var context = new ShadowContext();
            return context.Contacts1.ToList();
        }
    }
}
