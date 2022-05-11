using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.CommonRules;

namespace RulesUnitTestProject.Models
{
    public class FileAttachment
    {
        [ExistingFileName]
        public string FileName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
