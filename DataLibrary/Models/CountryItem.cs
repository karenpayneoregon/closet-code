namespace DataLibrary.Models
{
    public class CountryItem
    {
        public int Id { get;  }
        public string Name { get;  }
        public override string ToString() => Name;

        public CountryItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}