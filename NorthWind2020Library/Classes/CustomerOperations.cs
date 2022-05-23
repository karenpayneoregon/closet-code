using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NorthWind2020ConsoleApp.Data;
using NorthWind2020Library.Models;

namespace NorthWind2020Library.Classes
{
    public class CustomerOperations
    {
        public static List<CustomersForExcel> ToExcel()
        {
            using var context = new Context();

            return context.Customers
                .Include(customer => customer.Contact)
                .Include(customer => customer.ContactTypeIdentifierNavigation)
                .Include(customer => customer.CountryIdentifierNavigation)
                .Include(customer => customer.Contact.ContactDevices)
                .Select(current => new CustomersForExcel(
                    current.CompanyName, 
                    current.CountryIdentifierNavigation.Name, 
                    current.Contact.ContactTypeIdentifierNavigation.ContactTitle, 
                    $"{current.Contact.FirstName} {current.Contact.LastName}", 
                    current.Phone, current.ModifiedDate))
                .ToList();

        }
    }
}