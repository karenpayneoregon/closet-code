using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    public class CustomButton : Button
    {
        [Category("Behavior"), Description("Constant identifier")]
        public string Information { get; set; }
    }
}