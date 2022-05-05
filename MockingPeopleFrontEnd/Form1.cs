using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockingPeopleLibrary.Classes;
using WindowsFormsLibrary.Classes;


namespace MockingPeopleFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadOperations.Peek += ReadOperationsOnPeek;

        }

        private void ReadOperationsOnPeek(string sender)
        {
            textBox1.AppendText(sender + Environment.NewLine);
        }

        private async void CreateNewDatabaseButton_Click(object sender, EventArgs e)
        {
            var (success, exception) = await CreateOperations.NewPeopleDatabase();

            Dialogs.Information(this, success ? 
                "Finished" : 
                exception.Message);
        }

        private async void PopulateDatabaseButton_Click(object sender, EventArgs e)
        {
            var (success, exception) = await CreateOperations.CheckDatabaseExists();

            if (success)
            {
                await PopulateOperations.People();
                Dialogs.Information(this, "Finished populating");
            }
            else
            {
                Dialogs.Information(this, exception.Message);
            }

        }

        private async void ReadButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "";
            }

            await ReadOperations.ReadPeople();
        }

        private void GenerateBogusDataButton_Click(object sender, EventArgs e)
        {
            var results = BogusOperations.PeopleList(
                BogusNumericUpDown.AsInteger, 
                DumpJsonCheckBox.Checked);

        }

        private async void DatabaseExistCheckButton_Click(object sender, EventArgs e)
        {

            if (await VariousExamples.DatabaseExistsAsync())
            {
                Dialogs.Information("Database exists");
            }
            else
            {
                Dialogs.Information("Database does not exists");
            }

        }

        private void TablesArePopulatedButton_Click(object sender, EventArgs e)
        {
            Dialogs.Information(VariousExamples.TablesArePopulated() ? "Yes" : "No");
        }
    }
}
