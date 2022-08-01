namespace TinkeringConsoleApp.Interfaces
{
    public interface IEmployee
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}