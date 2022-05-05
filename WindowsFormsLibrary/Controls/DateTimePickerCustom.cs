using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsLibrary.Controls
{
    public class DateTimePickerCustom : DateTimePicker
    {
        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > -1;

        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }

        public DateTimePickerCustom()
        {
            Format = DateTimePickerFormat.Short;
            Size = new System.Drawing.Size(100, 23);
        }

    }
}