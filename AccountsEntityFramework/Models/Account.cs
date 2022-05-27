#nullable disable
using System;

namespace AccountsHasConversion.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string[] Roles { get; set; }
    }
}