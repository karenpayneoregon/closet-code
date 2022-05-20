using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataBindValidate.Classes;
using DataBindValidate.Models;

namespace DataBindValidate
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            _bindingSource.DataSource = new List<Usuarios>() { new Usuarios() };
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            NombreTextBox.DataBindings.Add("Text", _bindingSource, nameof(Usuarios.Nombre));
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            Usuarios current = (Usuarios)_bindingSource.Current;
            var modelEntity = ValidationHelper.ValidateEntity(current);

            if (modelEntity.IsValid)
            {
                JsonOperation.Serialize(current);
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                modelEntity.Errors.ToList().ForEach(item => builder.AppendLine(item.ErrorMessage));
                Console.WriteLine(builder.ToString());
            }
        }
    }
}
