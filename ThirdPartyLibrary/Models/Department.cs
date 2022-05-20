namespace ThirdPartyLibrary.Models
{
    public class Department
    {

        public int Id { get;  }
        public string Name { get;  }
        public override string ToString() => Name;

        public Department(int identifier, string name)
        {
            Id = identifier;
            Name = name;
        }
    }
}
