using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryHelpersLibrary.Models
{
    public class FolderItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string[] ItemArray => new[] { Name, Count.ToString() };
        public override string ToString() => Name;

    }
}
