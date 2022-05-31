using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    public class CustomPanel : Panel
    {
        [Category("Behavior"), Description("Store a string")]
        public string Information { get; set; }
    }
}
