using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DependencyInjectionForms1.Interfaces;
using DependencyInjectionForms1.Views;

namespace DependencyInjectionForms1
{
    public partial class Form1 : Form
    {
        private  IDataConnection dataConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void UserViewButton_Click(object sender, EventArgs e)
        {
            new UserView().ShowDialog();
        }

        private void GetDataConnectionButton_Click(object sender, EventArgs e)
        {
            dataConnection = Program.GetService<IDataConnection>();
            Debug.WriteLine(dataConnection.GetConnection());
        }
    }
}
