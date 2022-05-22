using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NumbersOnlyTextBox
{
    /// <summary>
    /// Custom <see cref="NumericUpDown"/> without spinner and a property to obtain value as an int
    /// and suppresses a bell dinging if the enter key is depressed.
    /// </summary>
    public class SpecialNumericUpDown : NumericUpDown
    {

        public SpecialNumericUpDown()
        {
            Controls[0].Hide();
            TextAlign = HorizontalAlignment.Right;
            Width = 100;
        }
        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }

        /// <summary>
        /// Return Value as an int
        /// </summary>
        [Browsable(false)] public int AsInteger => (int)Value;
        [Browsable(false)] public string AsString => Value.ToString();

        /// <summary>
        /// Redundant 
        /// </summary>
        [Browsable(false)] public decimal AsDecimal => Value;

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

    }

}