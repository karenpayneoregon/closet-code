
using System.Windows.Forms;

namespace WindowsControlLibrary.Classes
{
    /// <summary>
    /// VS2019 there is no BindingNavigator, here you go :-)
    /// </summary>
    public class CoreBindingNavigator : BindingNavigator
    {
        public CoreBindingNavigator()
        {
            AddStandardItems();
        }
    }
}
