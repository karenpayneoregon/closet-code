using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    public class DataButton : Button
    {
        [Category("Behavior"), Description("Identifier")]
        public int Identifier { get; set; }
        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }
    }
}
