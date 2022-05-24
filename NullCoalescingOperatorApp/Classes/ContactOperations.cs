using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullCoalescingOperatorApp.Models;

namespace NullCoalescingOperatorApp.Classes
{
    public class ContactOperations
    {
        public static List<Contact> Contacts => new()
        {
            new Contact() { FirstName = "Karen", LastName = "Payne", Email = "payne@provider.net" },
            new Contact() { LastName = "Adams", Email = "adams@comcast.net" },
            new Contact() { FirstName = "John", Email = "smith@comcast.net" },
            new Contact() ,
            new Contact() { FirstName = "Harry", LastName = "White", Email = "white@gmail.com" },
        };

        public static void Show()
        {
            var list = Contacts;
            foreach (var contact in Contacts)
            {
                Console.WriteLine(contact.DisplayCoalescing);
            }
        }
    }
}
