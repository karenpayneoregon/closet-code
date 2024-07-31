namespace SendToMainForm
{
    public partial class ChildForm : Form
    {
        public delegate void OnPassData(int[] items);
        public event OnPassData PassData;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void SendDataToMainFormButton_Click(object sender, EventArgs e)
        {
            const int min = 0;
            const int max = 20;
            
            Random randNum = new Random();

            int[] array = Enumerable
                .Repeat(0, 5)
                .Select(i => randNum.Next(min, max))
                .ToArray();

            PassData?.Invoke(array);

        }
    }
}
