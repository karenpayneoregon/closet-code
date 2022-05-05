using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsLibrary.LanguageExtensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Determines if a control needs to be invoked to prevent a cross thread violation. This is a generic
        /// extension method
        /// </summary>
        /// <typeparam name="T">Control</typeparam>
        /// <param name="control">Control</param>
        /// <param name="action">Predicate to run</param>
        /// <example>
        /// <code title="From Form1" >
        /// private void OnTimedEvent(object source, ElapsedEventArgs e)
        /// {
        ///     ElapsedTimerLabel.InvokeIfRequired(label =>
        ///     {
        ///         label.Text = $"{e.SignalTime}";
        ///     });
        /// 
        ///     FileOperations.CheckIfNewIncomingFileIsNeeded();
        /// }
        /// </code>
        /// </example>        
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
        /// <summary>
        /// Base method for obtaining controls on a form or within a container like a panel or group box
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <returns></returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        /// <summary>
        /// Get all TextBox controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of TextBoxes or an empty list if no TextBoxes on control</returns>
        public static List<TextBox> TextBoxList(this Control control) 
            => control.Descendants<TextBox>().ToList();

        /// <summary>
        /// Get all TextBox controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of TextBoxes or an empty list if no TextBoxes on control</returns>
        public static List<ListView> ListViewViewList(this Control control) 
            => control.Descendants<ListView>().ToList();

        /// <summary>
        /// Get all CheckBox controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of CheckBox or an empty list if no CheckBox on control</returns>
        public static List<CheckBox> CheckBoxList(this Control control) 
            => control.Descendants<CheckBox>().ToList();

        /// <summary>
        /// Get all ComboBox controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of ComboBox or an empty list if no ComboBox on control</returns>
        public static List<ComboBox> ComboBoxList(this Control control) 
            => control.Descendants<ComboBox>().ToList();

        /// <summary>
        /// Get all ListBox controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of ListBox or an empty list if no ListBox on control</returns>
        public static List<ListBox> ListBoxList(this Control control) 
            => control.Descendants<ListBox>().ToList();

        /// <summary>
        /// Get all Panel controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of Panel or an empty list if no Panel on control</returns>
        public static List<Panel> PanelList(this Control control) 
            => control.Descendants<Panel>().ToList();

        /// <summary>
        /// Get all GroupBox controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of GroupBox or an empty list if no GroupBox on control</returns>
        public static List<GroupBox> GroupBoxList(this Control control) 
            => control.Descendants<GroupBox>().ToList();

        /// <summary>
        /// Get all Button controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of Button or an empty list if no Button on control</returns>
        public static List<Button> ButtonList(this Control control) 
            => control.Descendants<Button>().ToList();

        /// <summary>
        /// Get all RadioButton controls from specified control
        /// </summary>
        /// <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
        /// <returns>List of RadioButton or an empty list if no RadioButton on control</returns>
        public static List<RadioButton> RadioButtonList(this Control control) 
            => control.Descendants<RadioButton>().ToList();

        /// <summary>
        /// Get selected/checked RadioButton for a control such as a panel, group box or form
        /// </summary>
        /// <param name="control">control, form, panel or group box</param>
        /// <param name="checked">True false, defaults to true</param>
        /// <returns>One checked Radio button or a empty value</returns>
        public static RadioButton RadioButtonChecked(this Control control, bool @checked = true) 
            => control.Descendants<RadioButton>().ToList().FirstOrDefault((radioButton) => radioButton.Checked == @checked);
    }
}