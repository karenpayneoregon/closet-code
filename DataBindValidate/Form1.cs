using System;
using System.Collections.Generic;
using System.Configuration;
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
            NumberTextBox.DataBindings.Add("Text", _bindingSource, nameof(Usuarios.NumberValue));
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

        /// <summary>
        /// https://docs.microsoft.com/en-us/answers/questions/876927/problem-writing-self-closing-null-value-to-setting.html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetSettingToNullButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Testsetting = "";
            //Properties.Settings.Default.Save();
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.AppSettings.Settings.Remove("Testsetting");
            //config.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumberTextBox.DataBindings.Count >0)
            {
                NumberTextBox.DataBindings.Clear();
                NumberTextBox.DataBindings.Add("Text", _bindingSource, nameof(Usuarios.NumberValue));
            }
        }
    }
}
