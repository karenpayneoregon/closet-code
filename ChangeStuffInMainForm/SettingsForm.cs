using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChangeStuffInMainForm
{
    public partial class SettingsForm : Form
    {
        
        public delegate void OnChangeColors(Settings settings);
        public event OnChangeColors ColorsChanged;

        private readonly Settings _settings = new Settings();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ColorsChanged?.Invoke(_settings);
        }

        private void FormBackColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _settings.MainFormBackColor = colorDialog1.Color;
            }
        }

        private void PanelBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _settings.Panel1BackColor = colorDialog1.Color;
            }
        }

        private void BindingExampleButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormBackColor = colorDialog1.Color;
        }
    }

    public class Settings
    {
        public Color? MainFormBackColor { get; set; }
        public Color? Panel1BackColor { get; set; }
    }
}
