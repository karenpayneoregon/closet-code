namespace MockingPeopleLibrary.Models
{
    public class DeviceType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public override string ToString() => Description;

    }
}