using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NumbersOnlyExample.Controls
{
    public class SpecialNumericUpDown : NumericUpDown
    {
        public SpecialNumericUpDown()
        {
            Controls[0].Hide();
            TextAlign = HorizontalAlignment.Right;
        }
        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }

        /// <summary>
        /// Provide access to value as an int from decimal
        /// </summary>
        [Browsable(false)] public int AsInteger => (int)Value;

        #region optional to stop beep on pressing enter

        public delegate void TriggerDelegate();

        public event TriggerDelegate TriggerEvent;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Return))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                TriggerEvent?.Invoke();

                return;
            }

            base.OnKeyDown(e);
        }

        #endregion

    }

}