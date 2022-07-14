using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToggleSwitchDemo.Classes;
using ToggleSwitchDemo.Models;

namespace ToggleSwitchDemo
{
    public partial class ChildForm : Form
    {
        private readonly List<Container> _container;


        public delegate void OnClicked(OperationType operationType, bool state);
        public event OnClicked ClickedEvent;
        public ChildForm()
        {
            InitializeComponent();
            SetProperties();
        }

        public ChildForm(List<Container> container)
        {
            InitializeComponent();
            _container = container;
            SetProperties();
            Console.WriteLine();
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

            ToggleSwitch1.Checked = _container[0].BPlusRelay;
            ToggleSwitch2.Checked = _container[0].BMinusRelay;
            ToggleSwitch3.Checked = _container[0].PreRelay;


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
