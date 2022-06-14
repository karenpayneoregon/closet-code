using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RadioButtonApp
{
    public partial class Form1 : Form
    {
        private List<RadioButton> _radioButtonsGroupBox;
        private List<RadioButton> _radioButtonsPanel;

        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _radioButtonsGroupBox = OptionsGroupBox.Controls.OfType<RadioButton>().ToList();
            _radioButtonsGroupBox.ForEach(rb => rb.Checked = false);

            _radioButtonsPanel = OptionsPanel.Controls.OfType<RadioButton>().ToList();
            _radioButtonsPanel.ForEach(rb => rb.Checked = false);
        }

        private void CheckSelectionInGroupBoxButton_Click(object sender, EventArgs e)
        {
            var selection = _radioButtonsGroupBox.FirstOrDefault(x => x.Checked);
            if (selection == null)
            {
                MessageBox.Show("Make a selection");
            }
            else
            {
                MessageBox.Show($"You selected {selection.Text}");
            }
        }

        private void CheckSelectionInPanelButton_Click(object sender, EventArgs e)
        {
            var selection = _radioButtonsPanel.FirstOrDefault(x => x.Checked);
            if (selection == null)
            {
                MessageBox.Show("Make a selection");
            }
            else
            {
                MessageBox.Show($"You selected {selection.Text}");
            }
        }
    }
}
