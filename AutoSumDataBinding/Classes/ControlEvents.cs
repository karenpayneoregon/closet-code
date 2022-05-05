using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSumDataBinding.Classes
{
    public class ControlEvents
    {
        /// <summary>
        /// Only allow double or decimal values
        /// </summary>
        public static void TextBoxOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        /// <summary>
        ///  Format value as currency
        /// </summary>
        public static void Binding_Format(object sender, ConvertEventArgs e)
        {
            e.Value = ((double)e.Value).ToString("C");

        }
    }
}
