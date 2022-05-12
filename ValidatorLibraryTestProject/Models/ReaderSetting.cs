using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ValidatorLibraryTestProject.Models
{
    public class ReaderSetting
    {
        [JsonPropertyName("RfidAddress")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "RFID Address is required.")]
        [StringLength(3, ErrorMessage = "Max Length is 3")]
        public string RfidAddress { get; set; }
    }
}
