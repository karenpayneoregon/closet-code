using OpenFolderWinFormsApp.Classes;

namespace OpenFolderWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IsCoreButton_Click(object sender, EventArgs e)
        {
            IsCoreCheckBox.Checked = EnvironmentHelpers.IsNetCore();
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            EnvironmentHelpers.OpenFolderWithExplorer(@"C:\Users");
        }
    }
}