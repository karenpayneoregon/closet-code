using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetControlFormProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
        public Company(int id) { Id = id; }

        public Company() { }
    }
}
