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
    public partial class GetQueryParamsForm : Form
    {
        public GetQueryParamsForm()
        {
            InitializeComponent();
        }

        private void GetQueryParamsForm_Load(object sender, EventArgs e)
        {
            var query = @"
SELECT        Cust.CustomerIdentifier, Cust.CompanyName, Cust.ContactId, Cust.City, Cust.PostalCode, CT.Name, C.FirstName, C.LastName
FROM            Customers AS Cust INNER JOIN
                         Contacts AS C ON Cust.ContactId = C.ContactId INNER JOIN
                         Countries AS CT ON Cust.CountryIdentifier = CT.CountryIdentifier
WHERE        (Cust.CountryIdentifier = @CountryIdentifier) AND (C.ContactTypeIdentifier = @ContactTypeIdentifier)";

            var (list, exceptions) = QueryParsers.GetVariables(query);

            StringBuilder builder = new();

            foreach (var parameter in list)
            {
                builder.AppendLine(parameter);
            }

            ResultTextBox.Text = builder.ToString();
            ActiveControl = CloseAppButton;
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
