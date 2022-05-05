using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus;
using MockingPeopleLibrary.Extensions;
using MockingPeopleLibrary.Models;
using Person = MockingPeopleLibrary.Models.Person;

namespace MockingPeopleLibrary.Classes
{
    public class BogusOperations
    {
        /// <summary>
        /// Pre-defined <see cref="DeviceType"/> list for generating fake data
        /// </summary>
        public static List<DeviceType> DeviceTypeList => new()
        {
            new() {Id = 1, Description = "Home phone" },
            new() {Id = 2, Description = "Work phone" },
            new() {Id = 3, Description = "Home email" },
            new() {Id = 4, Description = "Work email" }
        };

        /// <summary>
        /// Generate a list of <see cref="Person"/> excluding 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="dump"></param>
        /// <returns></returns>
        public static List<Person> PeopleList(int count,bool dump = false)
        {

            /*
             * Setup for creating Address type
             */
            int addressIdentifier = 1;
            var fakeAddress = new Faker<Address>()
                    .CustomInstantiator(f => new Address(addressIdentifier++))
                    .RuleFor(a => a.Street, f => f.Address.StreetAddress())
                    .RuleFor(a => a.PostalCode, f => f.Address.ZipCode());

            /*
              * Setup for creating ContactDevices type
              */
            int contactDeviceIdentifier = 1;
            var fakeContactDevices = new Faker<ContactDevice>()
                .CustomInstantiator(f => new ContactDevice(contactDeviceIdentifier++))
                .RuleFor(c => c.DeviceTypeId, f => f.Random.Int(1, 4))
                .RuleFor(c => c.DeviceType, f => f.PickRandom(DeviceTypeList))
                .RuleFor(c => c.Value, f => f.Phone.PhoneNumber());

            /*
             * Setup for generating people excluding Residents which are left
             * out as Residents are inferred because of no configuration and this
             * means EF Core decides for us.
             */
            int personIdentifier = 1;
            Faker<Person> fakePerson = new Faker<Person>()
                .CustomInstantiator(f => new Person(personIdentifier++))
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Addresses, f =>  fakeAddress.Generate(4))
                .RuleFor(p => p.ContactDevices, f => fakeContactDevices.Generate(1));


            List<Person> list = fakePerson.Generate(count);
            
            if (dump)
            {
                list.DumpJson();
            }

            return list;
        }

    }
}
