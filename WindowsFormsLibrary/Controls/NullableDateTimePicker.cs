using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsLibrary.Controls
{
    /// <summary>
    /// For the age old question, how do I show an empty DateTimePicker
    /// </summary>
    public class NullableDateTimePicker : DateTimePicker
    {
        private DateTimePickerFormat originalFormat = DateTimePickerFormat.Short;
        private string originalCustomFormat;
        private bool isNull;

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new DateTime Value
        {
            get => isNull ? DateTime.MinValue : base.Value;
            set
            {
                // incoming value is set to min date
                if (value == DateTime.MinValue)
                {
                    // if set to min and not previously null, preserve original formatting
                    if (!isNull)
                    {
                        originalFormat = Format;
                        originalCustomFormat = CustomFormat;
                        isNull = true;
                    }

                    Format = DateTimePickerFormat.Custom;
                    CustomFormat = " ";
                }
                else // incoming value is real date
                {
                    // if set to real date and previously null, restore original formatting
                    if (isNull)
                    {
                        Format = originalFormat;
                        CustomFormat = originalCustomFormat;
                        isNull = false;
                    }

                    base.Value = value;
                }
            }
        }

        protected override void OnCloseUp(EventArgs eventArgs)
        {
            // on keyboard close, restore format
            if (MouseButtons == MouseButtons.None)
            {
                if (isNull)
                {
                    Format = originalFormat;
                    CustomFormat = originalCustomFormat;
                    isNull = false;
                }
            }

            base.OnCloseUp(eventArgs);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // on delete key press, set to min value (null)
            if (e.KeyCode == Keys.Delete)
            {
                Value = DateTime.MinValue;
            }
        }

        /// <summary>
        /// Indicates if Value has a date or not
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsNullValue => Value == DateTime.MinValue;
    }
}