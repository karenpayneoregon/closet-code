using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AddSelectToComboBox.Classes;
using AddSelectToComboBox.Models;

namespace AddSelectToComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MonthsComboBox.DataSource = Operations.Months();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {

            var month = ((MonthItem)MonthsComboBox.SelectedItem);
            if (month.Index == -1)
            {
                MessageBox.Show("Make a selection");
            }
            else
            {
                MessageBox.Show($"{month.Index,-3}{month.Name}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["SqlServerConnection"]))
            {
                conn.Open();
                Console.WriteLine("Opened");
            }
            //var settings = ConfigurationManager
            //    .ConnectionStrings
            //    .OfType<ConnectionStringSettings>().ToList();

            //StringBuilder builder = new StringBuilder();
            //for (int index = 0; index < settings.Count(); index++)
            //{
            //    Console.WriteLine($"{index,-3}{settings[index].Name,-10}{settings[index].ConnectionString}");
            //    builder.AppendLine(settings[index].Name);
            //}

            //MessageBox.Show(builder.ToString());
        }
    }
}
