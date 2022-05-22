using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewExport.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Contact(int id)
        {
            Id = id;
        }

        public Contact()
        {
            
        }
    }
}
