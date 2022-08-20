using System.Windows.Forms;

namespace CreateDynamicControls.Classes.Controls
{
    /// <summary>
    /// Adds a property for storing category primary key
    /// </summary>
    public class DataButton : Button
    {
        public int Identifier { get; set; }
    }
}
