using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryHelpersLibrary.Models
{
    public class FileLines
    {
        public string Name { get; set; }
        public List<string> Lines { get; set; }

        public void Deconstruct(out string name, out List<string> lines)
        {
            name = Name;
            lines = Lines;
        }

        public override string ToString() => Name;
    }
}
