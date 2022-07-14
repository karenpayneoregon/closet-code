using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToggleSwitchDemo.Classes;
using ToggleSwitchDemo.Models;

namespace ToggleSwitchDemo
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly List<Container> _container = new List<Container>() {new Container()};
        public MainForm()
        {
            InitializeComponent();

            Move += OnTheMove;

            _bindingSource.DataSource = _container;

            PlusRelayCheckBox.DataBindings.Add("Checked", _bindingSource, nameof(Models.Container.BPlusRelay));
            MinusRelayCheckBox.DataBindings.Add("Checked", _bindingSource, nameof(Models.Container.BMinusRelay));
            PreRelayCheckBox.DataBindings.Add("Checked", _bindingSource, nameof(Models.Container.PreRelay));

        }

        private void ShowChildFormButton_Click(object sender, EventArgs e)
        {
            var test = _container;
            var childForm = new ChildForm(_container) { Top = Top, Left = (Left + Width), Tag = "Right" };
            childForm.ClickedEvent += ClickedEvent;
            childForm.Show();
            MoveChildForm();

        }
        private void OnTheMove(object sender, EventArgs e)
        {
            MoveChildForm();
        }

        private void MoveChildForm()
        {
            var childForms = Application.OpenForms.Cast<Form>()
                .Where(form => form.Name == nameof(ChildForm));

            if (childForms.Any())
            {
                foreach (var currentChildForm in childForms)
                {
                    currentChildForm.Top = Top;
                    currentChildForm.Left = currentChildForm.Tag.ToString() == "Left" ? (Left - Width) + 120 : (Left + Width);
                }
            }
        }

        private void ClickedEvent(OperationType operationType, bool state)
        {
            switch (operationType)
            {
                case OperationType.BPlusRelay:
                    _container[0].BPlusRelay = state;
                    DoSomethingForPlus(state);
                    break;
                case OperationType.BMinusRelay:
                    _container[0].BMinusRelay = state;
                    break;
                case OperationType.PreRelay:
                    _container[0].PreRelay = state;
                    break;
                case OperationType.CycleCount:
                    // TODO
                    break;
                case OperationType.PairDown:
                    // TODO
                    break;
                case OperationType.TestMode:
                    // TODO
                    break;
                case OperationType.StandbyMode:
                    // TODO
                    break;
                // no need for default here
            }


        }

        private void DoSomethingForPlus(bool state)
        {
            // TODO
        }
    }
}
