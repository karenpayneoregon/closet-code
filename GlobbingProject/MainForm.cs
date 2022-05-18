using System;
using System.IO;
using System.Windows.Forms;
using DirectoryHelpersLibrary.Classes;
using DirectoryHelpersLibrary.Models;
using WindowsFormsLibrary.Classes;
using WindowsFormsLibrary.LanguageExtensions;

namespace GlobbingProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            GlobbingOperations.TraverseFileMatch += TraverseFileMatch;
            GlobbingOperations.Done += Done;
        }

        private void Done(string message)
        {
            Dialogs.AutoCloseDialog(this, message, Properties.Resources.blueInformation_32, 1);
        }

        private void TraverseFileMatch(FileMatchItem sender)
        {
            ResultListBox.InvokeIfRequired(listBox =>
            {
                listBox.Items.Add(Path.Combine(sender.Folder, sender.FileName));
                listBox.SelectedIndex = listBox.Items.Count - 1;
            });
        }

        /// <summary>
        /// Provides what to find via include array and what to exclude
        /// using the exclude array
        /// </summary>
        private async void ExecuteButton_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear();
            string path = Folders.SolutionFolder();

            string[] include = { "**/*.cs" };
            string[] exclude = { "**/*Assembly*.cs", "**/*Designer*.cs" };

            await GlobbingOperations.GetFiles(path, include, exclude);
        }
    }
}
