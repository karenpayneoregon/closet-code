using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class ContactDevice
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? PhoneTypeIdentifier { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual PhoneType PhoneTypeIdentifierNavigation { get; set; }
    }
}
