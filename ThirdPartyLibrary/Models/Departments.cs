using ThirdPartyLibrary.Interfaces;

namespace ThirdPartyLibrary.Models
{
    public class Departments : IBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
        public Departments(int identifier, string name)
        {
            Id = identifier;
            Name = name;
        }
    }
}