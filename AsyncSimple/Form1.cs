using static WindowsFormsLibrary.Classes.Dialogs;


namespace AsyncSimple
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource; // = new();
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // check if we even started the async operation
            if (cancellationTokenSource is null) return;

            if (e.CloseReason == CloseReason.UserClosing && cancellationTokenSource.IsCancellationRequested == false)
            {
                if (Question(this, "Are you sure you want to really exit ?"))
                {
                    cancellationTokenSource.Cancel();
                }
                else
                {
                    e.Cancel = true;
                }
            }


        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            var cancelled = false;

            cancellationTokenSource ??= new CancellationTokenSource();

            if (cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Dispose();
                cancellationTokenSource = new CancellationTokenSource();
            }


            var progressIndicator = new Progress<int>(ReportProgress);

            try
            {
                await AsyncMethod(progressIndicator, cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                StatusLabel.Text = @"Cancelled";
                cancelled = true;
            }

            if (!cancelled) return;

            await Task.Delay(1000);
            StatusLabel.Text = @"Go again!";
        }

        private void CancelButton_Click(object sender, EventArgs egEventArgs)
        {
            if (Question(this, "Are you sure you want to really exit ?"))
            {
                cancellationTokenSource.Cancel();
            }
        }
        private static async Task AsyncMethod(IProgress<int> progress, CancellationToken ct)
        {

            for (int index = 1; index <= 100; index++)
            {
                //Simulate an async call that takes some time to complete
                await Task.Delay(500, ct);

                progress?.Report(index);

            }

        }

        private void ReportProgress(int value)
        {

            if (cancellationTokenSource.IsCancellationRequested)
                return;

            StatusLabel.Text = value.ToString();
            toolStripProgressBar1.Value = value;
        }

        private void PerformWorkButton_Click(object sender, EventArgs e)
        {
            var waitForm = new PleaseWaitForm();
            waitForm.CancelEvent += WaitForm_CancelEvent;
            waitForm.ShowDialog();
        }

        private void WaitForm_CancelEvent(bool cancel)
        {
            if (cancel)
            {
                // user decided to cancel
            }
            else
            {
                // user decided to continue
            }
        }
    }


}
