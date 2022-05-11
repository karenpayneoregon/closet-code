using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerSimpleConnect.Classes;


namespace SqlServerSimpleConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int _timeOut = 2;
        private CancellationTokenSource _cancellationTokenSource = new (TimeSpan.FromSeconds(_timeOut));

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
            }

            _cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(_timeOut));

            var (success, generalException, exception) = await Operations.Connect(_cancellationTokenSource.Token);

            if (success)
            {
                MessageBox.Show(@"Opened");
            }
            else
            {
                if (generalException)
                {
                    MessageBox.Show($@"Encountered: {exception.Message}");
                }
                else
                {
                    MessageBox.Show(@"Failed to open");
                }
                
            }
        }
    }
}
