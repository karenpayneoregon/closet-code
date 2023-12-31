using System.Diagnostics;
using AsyncSimple.Classes;
using WindowsFormsLibrary.Classes;
//using WindowsFormsLibrary.Classes;
using static System.Threading.Thread;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).

namespace AsyncSimple
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource = new ();
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            var cancelled = false;
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
            cancellationTokenSource.Cancel();
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
            StatusLabel.Text = value.ToString();
            toolStripProgressBar1.Value = value;
        }

        private void NoviceButton_Click(object sender, EventArgs e)
        {
            static void BusyWait(int milliseconds)
            {
                var sw = Stopwatch.StartNew();

                while (sw.ElapsedMilliseconds < milliseconds)
                {
                    SpinWait(1000);
                }
            }

            if (WindowsFormsLibrary.Classes.Dialogs.Question(this,"Question", "Do you really, really want to wait?","Yep","Nope", DialogResult.No))
            {
                for (int index = 0; index < 10; index++)
                {
                    BusyWait(1000);
                }
            }


        }

        private async void FakeWorkButton_Click(object sender, EventArgs e)
        {
            var service = new SomeService();
            await Task.Run(() => service.Calculate());
            Dialogs.Information(this,"Done","Woohoo");
        }
    }


}
