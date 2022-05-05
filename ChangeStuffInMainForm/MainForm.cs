using System;
using System.Windows.Forms;

namespace ChangeStuffInMainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ColorsChanged += SettingsFormOnColorsChanged;
            settingsForm.ShowDialog();
            settingsForm.Dispose();
        }

        private void SettingsFormOnColorsChanged(Settings settings)
        {
            if (settings.Panel1BackColor.HasValue)
            {
                panel1.BackColor = settings.Panel1BackColor.Value;
            }

            if (settings.MainFormBackColor.HasValue)
            {
                BackColor = settings.MainFormBackColor.Value;
            }
        }
    }
}
