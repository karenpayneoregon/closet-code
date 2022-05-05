using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    public class CustomLabel : Label
    {
        [Category("Behavior"), Description("Constant identifier")]
        public string Information { get; set; }
    }
}
