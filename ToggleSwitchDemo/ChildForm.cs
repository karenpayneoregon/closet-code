using System;
using System.Linq;
using System.Windows.Forms;
using ToggleSwitchDemo.Classes;

namespace ToggleSwitchDemo
{
    public partial class ChildForm : Form
    {
        public delegate void OnClicked(OperationType operationType, bool state);
        public event OnClicked ClickedEvent;
        public ChildForm()
        {
            InitializeComponent();
            SetProperties();
        }

        public void SetProperties()
        {

            ToggleSwitch1.Tag = OperationType.BPlusRelay;
            ToggleSwitch2.Tag = OperationType.BMinusRelay;
            ToggleSwitch3.Tag = OperationType.PreRelay;
            ToggleSwitch4.Tag = OperationType.CycleCount;
            ToggleSwitch5.Tag = OperationType.PairDown;
            ToggleSwitch6.Tag = OperationType.TestMode;
            ToggleSwitch7.Tag = OperationType.StandbyMode;

            var list = Controls.OfType<JCS.ToggleSwitch>().ToList();

            foreach (var toggleSwitch in list)
            {
                toggleSwitch.CheckedChanged += ToggleSwitchOnCheckedChanged;
            }
        }

        private void ToggleSwitchOnCheckedChanged(object sender, EventArgs e)
        {
            var current = (JCS.ToggleSwitch)sender;
            ClickedEvent?.Invoke((OperationType)current.Tag, current.Checked);
        }
    }
}
