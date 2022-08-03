namespace CustomerDatabaseLibrary.Models
{
    public class Genders
    {
        public int id { get; set; }
        public string GenderType { get; set; }
        public override string ToString() => GenderType;
    }
}
