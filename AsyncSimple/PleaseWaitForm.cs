using System.Windows.Forms;
using WindowsFormsLibrary.Classes;

namespace AsyncSimple;
public partial class PleaseWaitForm : Form
{
    public delegate void OnCancel(bool cancel);
    public event OnCancel CancelEvent;
    public PleaseWaitForm()
    {
        InitializeComponent();
        FormClosing += PleaseWaitForm_FormClosing;
    }

    private void PleaseWaitForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason != CloseReason.UserClosing) return;
        if (Dialogs.Question(this, "Are you sure you want to really exit ?"))
        {
            e.Cancel = false;
            CancelEvent?.Invoke(true);
        }
        else
        {
            e.Cancel = true;
        }
    }
}
