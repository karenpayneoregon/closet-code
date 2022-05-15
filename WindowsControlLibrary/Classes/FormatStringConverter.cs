using System.ComponentModel;
using CommonLibrary.Classes;

namespace WindowsControlLibrary.Classes
{
    public partial class TimeComboBox
    {
        public class FormatStringConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                var hours = new Hours();
                return new StandardValuesCollection(hours.Range(TimeIncrement.Quarterly));
            }
        }
    }
}
