using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            ContactDevices = new HashSet<ContactDevice>();
        }

        public int PhoneTypeIdenitfier { get; set; }
        public string PhoneTypeDescription { get; set; }

        public virtual ICollection<ContactDevice> ContactDevices { get; set; }
    }
}
