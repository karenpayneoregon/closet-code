using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Setters.Classes
{
    /// <summary>
    ///  Intent is to show differences between a class and record which are immutable such as
    ///  shown in the last two week's classes.
    ///
    ///  PersonClass is generally used for a container of data with read/write capabilities
    ///  PersonRecord is a quick upgrade from a class as in PersonClass
    ///  PersonRecordReadOnly is a record with possibilities for providing descriptions for members of the record
    ///  Person1 is shorthand for a creating a record
    /// 
    /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
    /// </summary>
    class Examples
    {
        public static void CreatePersonRecord()
        {
            /*
             * Before C# 9
             */
            PersonClass personClass = new()
            {
                Id = 1,
                FirstName = "Karen",
                MiddleName = "",
                LastName = "Payne",
                Gender = Gender.Female,
                Modified = DateTime.Now
            };



            /*
             * Convert to record
             */
            PersonRecord personRecord = new ()
            {
                Id = 1, 
                FirstName = "Karen", 
                MiddleName = "", 
                LastName = "Payne", 
                Gender = Gender.Female, 
                Modified = DateTime.Now
            };

            personRecord.Id = 0;


            /*
             * True record deconstructed 
             */
            (string firstName, string middleName, string lastName) = new PersonRecordReadOnly("Karen", "","Payne");

            Person1 person1 = new("Karen", "","Payne");
            Person1 person2 = new("Karen", "","Payne");
            Person1 person3 = new("Mary", "","Payne");
            
            Debug.WriteLine(person1);
            Debug.WriteLine($"{person1.FirstName} {person1.LastName}");

            Debug.WriteLine($"Person1 = Person2 {person1.Equals(person2).ToYesNo()}");
            Debug.WriteLine($"Person1 = Person3 {person1.Equals(person3).ToYesNo()}");

            /*
             * Create and immutable instance of Person2
             */
            var person4 = new Person2
            {
                FirstName = "Lisa",
                MiddleName = "A",
                LastName = "Smith-Burham"
            };

            /*
             * Create a new instance of person4 and change a property value
             */
            var newPerson = person4 with { LastName = "Smith" };

            Debug.WriteLine($"new person {newPerson}");

        }

        
    }



    public record Person2
    {
        public string FirstName { get; init; }
        public string MiddleName { get; init; }
        public string LastName { get; init; }
    }

    public record PersonRecordReadOnly(
        [property: Description("First Name")] string FirstName,
        [property: Description("Middle Name")] string MiddleName,
        [property: Description("Last Name")] string LastName
    );

    public record Person1(string FirstName, string MiddleName, string LastName);

    public record PersonRecord 
    {
        public int Id { get; set; }
        public string FirstName { get; init; }
        public string MiddleName { get; init; }
        public string LastName { get; init; }
        public Gender Gender { get; init; }
        public DateTime? Modified { get; init; }
    }

    public class PersonClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; init; }
        public DateTime? Modified { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
    }
}
