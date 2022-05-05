using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsLibrary.Classes
{

    public class Dialogs
    {

      
        /// <summary>
        /// Dialog to ask a question
        /// </summary>
        /// <param name="caption">text for dialog caption</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesText">text for yes button</param>
        /// <param name="noText">text for no button</param>
        /// <param name="defaultButton">specifies the default button for this dialog</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(string caption, string heading, string yesText, string noText, DialogResult defaultButton)
        {

            TaskDialogButton yesButton = new (yesText) { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new (noText) { Tag = DialogResult.No };
            
            TaskDialogButtonCollection buttons = new ();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new ()
            {
                Caption = caption,
                SizeToContent = true,
                Heading = heading,
                Icon = TaskDialogIcon.Information,
                Buttons = buttons
            };


            TaskDialogButton result = TaskDialog.ShowDialog(page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }

        /// <summary>
        /// Dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="caption">text for dialog caption</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesText">text for yes button</param>
        /// <param name="noText">text for no button</param>
        /// <param name="defaultButton">specifies the default button for this dialog</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(Form owner, string caption, string heading, string yesText, string noText, DialogResult defaultButton)
        {

            TaskDialogButton yesButton = new (yesText) { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new (noText) { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }


            TaskDialogPage page = new ()
            {
                Caption = caption,
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.visualstudio32),
                Buttons = buttons,
                Footnote = new TaskDialogFootnote() { Text = "Code sample" }
            };

            var result = TaskDialog.ShowDialog(owner, page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }

        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="icon">Icon to display</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(Control owner, string heading, Icon icon, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(icon),
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(owner, page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }
        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(Control owner, string heading, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };
            
            TaskDialogButtonCollection buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.QuestionBlue),
                Buttons = buttons, 
                AllowCancel = true
            };

            var result = TaskDialog.ShowDialog(owner, page);
            return result.Tag is not null && (DialogResult)result.Tag == DialogResult.Yes;
        }

        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesAction"></param>
        /// <returns>true for yes button, false for no button</returns>
        /// <remarks>
        /// Dialogs.Question(this, "Ask something", YesMethod, NoMethod);
        ///
        /// Last two parameters are the actions to perform
        /// </remarks>
        public static void Question(Control owner, string heading, Action yesAction, Action noAction)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection
            {
                yesButton,
                noButton
            };
            

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.QuestionBlue),
                Buttons = buttons
            };
            
            var result = TaskDialog.ShowDialog(owner, page);

            if ((DialogResult)result.Tag == DialogResult.Yes)
            {
                yesAction?.Invoke();
            }
            else
            {
                noAction?.Invoke();
            }
            
        }
        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="icon">Icon to display</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(string heading, Icon icon, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(icon),
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }

        /// <summary>
        /// displays a message with option to assign button text
        /// </summary>
        /// <param name="heading">head for dialog</param>
        /// <param name="buttonText">button text</param>
        public static void Information(string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new (buttonText);

            TaskDialogPage page = new ()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.blueInformation_32),
                Footnote = new TaskDialogFootnote() { Text = "Karen Payne code sample" },
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };
            
            TaskDialog.ShowDialog(page);

        }

        /// <summary>
        /// displays a message with option to assign button text
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading"></param>
        /// <param name="buttonText"></param>
        public static void Information(Control owner, string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new (buttonText);

            TaskDialogPage page = new ()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.exclamation24),
                Footnote = new TaskDialogFootnote() { Text = "Karen Payne code sample" },
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };
            
            TaskDialog.ShowDialog(owner, page);

        }


        /// <summary>
        /// Auto close dialog by specified seconds, if timed out
        /// invoke continue button.
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="text">text to display</param>
        /// <param name="Icon">icon to present</param>
        /// <param name="seconds">seconds to timeout</param>
        /// <param name="okText">text for continue button</param>
        public static void AutoCloseDialog(Control owner, string text, Icon Icon, int seconds, string okText = "OK")
        {

            var remaining = seconds * 10;

            TaskDialogButton continueButton = new(okText);

            TaskDialogPage page = new()
            {
                Heading = "",
                Text = text,
                Icon = new TaskDialogIcon(Icon),
                Buttons = new TaskDialogButtonCollection() { continueButton},
                Caption = "Information"
            };

            using Timer timer = new()
            {
                Enabled = true,
                Interval = 100
            };

            timer.Tick += (_, _) =>
            {
                remaining -= 1;

                if (remaining != 0) return;
                timer.Enabled = false;
                if (continueButton.BoundPage is not null)
                {
                    continueButton.PerformClick();
                }
            };

            TaskDialogButton result = TaskDialog.ShowDialog(owner, page);

            ContinueOperation?.Invoke(result == continueButton);

        }
        /// <summary>
        /// Used for development to display exception information
        /// </summary>
        /// <param name="exception">Exception thrown</param>
        /// <param name="buttonText">optional text for button</param>
        public static void ErrorBox(Exception exception, string buttonText = "Silly programmer")
        {

            TaskDialogButton singleButton = new (buttonText);

            var text = $"Encountered the following\n{exception.Message}";


            TaskDialogPage page = new ()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = text,
                Icon = TaskDialogIcon.Error,
                Buttons = new TaskDialogButtonCollection() { singleButton }
            };

            TaskDialog.ShowDialog(page);

        }


        public delegate void OnContinue(bool sender);
        public static event OnContinue ContinueOperation;

        [ModuleInitializer]
        public static void Init()
        {
            Application.EnableVisualStyles();
        }
    }
}
