using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    public class CustomButton : Button
    {
        [Category("Behavior"), Description("Store a string")]
        public string Information { get; set; }
    }
}