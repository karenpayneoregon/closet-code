using Setters.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Setters
{
    partial class Program
    {
        static void Main(string[] args)
        {
            (int id, string firstName, string middleName, string lastName, List<string> list) = 
                new PersonRecord(1,"Karen", "", "Payne", ["(999) 999-2222", "(333) 888-9999"]);


            foreach (var number in list)
            {
                Console.WriteLine(number);
            }


            var props = typeof(PersonRecord).GetPropertyWithAttribute<DescriptionAttribute>();

            foreach ((PropertyInfo Info, DescriptionAttribute Attribute) in props)
            {
                Console.WriteLine($"{Info.Name}: {Attribute.Description}");
            }

            Console.ReadLine();
        }
    }
}
