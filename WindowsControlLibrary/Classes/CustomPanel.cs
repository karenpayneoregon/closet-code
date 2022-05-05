using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    public class CustomPanel : Panel
    {
        [Category("Behavior"), Description("Constant identifier")]
        public string Information { get; set; }
    }
}
