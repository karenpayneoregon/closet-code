// ReSharper disable once CheckNamespace
namespace ReturningInformation.Models
{
    public partial class Person
    {
        public void Deconstruct(out int id, out string firstName, out string lastName)
        {
            id = PersonID;
            firstName = FirstName;
            lastName = LastName;
        }

    }
}
