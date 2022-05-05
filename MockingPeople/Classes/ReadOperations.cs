using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MockingPeopleLibrary.Data;
using MockingPeopleLibrary.Models;

namespace MockingPeopleLibrary.Classes
{

    public class ReadOperations
    {
        public delegate void DisplayMessage(string sender);
        public static event DisplayMessage Peek;
        public static async Task ReadPeople()
        {

            await using var context = new PersonContext();

            List<Person> people = await context
                .People
                .Include(person => person.Addresses)
                .Include(person => person.ContactDevices)
                .ThenInclude(contactDevice => contactDevice.DeviceType)
                .ToListAsync();

            foreach (var person in people)
            {
                Peek?.Invoke($"{person.Id} {person.FirstName} {person.LastName}");
                Peek?.Invoke("Addresses");
                foreach (var address in person.Addresses)
                {
                    Peek?.Invoke($"\t{address.Id} {address.Street} {address.PostalCode}");
                }

                Peek?.Invoke("Devices");
                foreach (var device in person.ContactDevices)
                {
                    Peek?.Invoke($"\t{device.DeviceTypeId}  {device.DeviceType} {device.Value}");
                }

                var homePhone = person.ContactDevices.FirstOrDefault(x => x.DeviceTypeId == 1);
                Peek?.Invoke(homePhone is not null ? "\tHas home phone" : "\tHas no home phone");

                var workPhone = person.ContactDevices.FirstOrDefault(x => x.DeviceTypeId == 2);
                Peek?.Invoke(workPhone is not null ? "\tHas work phone" : "\tHas no work phone");

                Peek?.Invoke("----------------------");
            }

            Peek?.Invoke("");


        }

    }
}
