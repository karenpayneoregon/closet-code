using System.Collections.Generic;
using System.Threading.Tasks;
using MockingPeopleLibrary.Data;
using MockingPeopleLibrary.Models;

namespace MockingPeopleLibrary.Classes
{
    public class PopulateOperations
    {

        public static async Task People()
        {
            List<DeviceType> deviceTypes = new()
            {
                new() { Description = "Home phone" },
                new() { Description = "Work phone" },
                new() { Description = "Home email" },
                new() { Description = "Work email" }
            };

            List<Person> people = new List<Person>
            {
                new ()
                {
                    FirstName = "Karen", LastName = "Payne",
                    Addresses = new List<Address>()
                    {
                        new () {Street = "123 Maple Street", PostalCode = "00022"},
                        new () {Street = "222 Apple street", PostalCode = "00022"},
                    }, 
                    ContactDevices = new List<ContactDevice>()
                    {
                        new () {DeviceTypeId = 1, Value = "503 999-1111"},
                        new () {DeviceTypeId = 3, Value = "karenp@gmail.com"}

                    }
                },
                new ()
                {
                    FirstName = "Mary",
                    LastName = "Jones",
                    Addresses = new List<Address>()
                    {
                        new () {Street = "123 Cherry Street", PostalCode = "99999"},
                        new () {Street = "222 High Lane", PostalCode = "67654"},
                        new () {Street = "444 Birch Ave", PostalCode = "98234"},
                    },
                    ContactDevices = new List<ContactDevice>()
                    {
                        new () {DeviceTypeId = 1, Value = "503 555-5151"},
                        new () {DeviceTypeId = 3, Value = "mary@work.net"},
                        new () {DeviceTypeId = 2, Value = "971-987-9832"}

                    }
                }
            };

            await using var context = new PersonContext();

            context.AddRange(deviceTypes);
            context.AddRange(people);

            await context.SaveChangesAsync();

        }

    }
}
