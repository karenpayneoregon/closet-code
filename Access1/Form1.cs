using System;
using System.ComponentModel;
using System.Windows.Forms;
using Access1.Classes;
using static Access1.Classes.Dialogs;

namespace Access1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            if (dataSet1.Tables[0].HasChanges())
            {
                if (Question("Save before exiting"))
                {
                    SaveChanges();
                }
                else
                {
                    e.Cancel = false;
                }
            }
           
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            Validate();
            personBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personTableAdapter.Fill(dataSet1.Person);
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            DataSet1.PersonRow current = dataSet1.Person[personBindingSource.Position];
            MessageBox.Show($"{current.FirstName} {current.LastName}\n{current.CreatedBy1:d}");
        }
    }
}
