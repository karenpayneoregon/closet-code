namespace ReturningInformation.Classes
{
    public class PersonEntity
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public override string ToString() => $"{FirstName} {LastName}";

        public void Deconstruct(out int id, out string firstName, out string lastName)
        {
            id = PersonID;
            firstName = FirstName;
            lastName = LastName;
        }
    }
}