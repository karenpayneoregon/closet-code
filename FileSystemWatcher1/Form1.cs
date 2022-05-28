using System.ComponentModel;
using System.Windows.Forms;
using FileSystemWatcher1.Classes;

namespace FileSystemWatcher1
{
    public partial class Form1 : Form
    {
        private readonly FileOperations _fileOperations = new ("Path to watch", "file name to trigger on");
        public Form1()
        {
            InitializeComponent();

            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _fileOperations.Stop();
        }
    }
}
