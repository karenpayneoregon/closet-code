namespace MockingPeopleLibrary.Models
{
    public class ContactDevice
    {
        public int Id { get; set; }
        public DeviceType DeviceType { get; set; }
        public int DeviceTypeId { get; set; }
        public string Value { get; set; }
        public override string ToString() => $"{DeviceType.Description} : {Value}";

        public ContactDevice(int id)
        {
            Id = id;
        }

        public ContactDevice()
        {
            
        }
    }
}