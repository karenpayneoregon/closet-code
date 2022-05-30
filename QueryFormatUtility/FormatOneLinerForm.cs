using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueryFormatUtility.Classes;

namespace QueryFormatUtility
{
    public partial class FormatOneLinerForm : Form
    {
        public FormatOneLinerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InputTextBox.Text = "SELECT LEN(FirstName) AS length " + 
                                "FROM Person WHERE LEN(FirstName) = (SELECT MAX(LEN(FirstName)) " + 
                                "FROM Person) SELECT LEN(LastName) AS length " + 
                                "FROM Person WHERE LEN(LastName) = (SELECT MAX(LEN(LastName)) FROM Person)" +
                                "SELECT ErrorID, RequestID, RequestGUID, ErrorCode, ErrorMessage, " + 
                                "SourceCode, CreateTimestamp, UpdateTimestamp, ErrorStatus " + 
                                "FROM RequestValidationError AS rve WHERE CreateTimestamp >= " + 
                                "CAST(GETDATE() AS DATE) AND CreateTimestamp < CAST(GETDATE() + 1 AS DATE);";

            ResultTextBox.Text = QueryParsers.Format(InputTextBox.Text);

            ActiveControl = CloseAppButton;
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
