using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTaskProgress2
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            var cancelled = false;
            if (_cts.IsCancellationRequested == true)
            {
                _cts.Dispose();
                _cts = new CancellationTokenSource();
            }


            var progressIndicator = new Progress<int>(ReportProgress);
            
            try
            {
                await AsyncMethod(progressIndicator, _cts.Token);
            }
            catch (OperationCanceledException)
            {
                StatusLabel.Text = "Cancelled";
                cancelled = true;
            }

            if (!cancelled) return;
            
            await Task.Delay(1000);
            StatusLabel.Text = "Go again!";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }
        private static async Task AsyncMethod(IProgress<int> progress, CancellationToken ct)
        {

            for (int index = 100; index <= 120; index++)
            {
                //Simulate an async call that takes some time to complete
                await Task.Delay(500, ct);

                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }

                progress?.Report(index);

            }

        }
        private void ReportProgress(int value)
        {
            StatusLabel.Text = value.ToString();
            TextBox1.Text = value.ToString();
        }

    }
}
