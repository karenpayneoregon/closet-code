using System;
using System.Windows.Forms;
using EventsGetInvocationListFormsApp.Extensions;

namespace EventsGetInvocationListFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            button1.Click += Button1OnClick;
            button1.Click += Button1OnClick;
            button1.Click += Button1OnClick;

            UpdateCount();
        }

        private void Button1OnClick(object sender, EventArgs e)
        {
            listBox1.Items.Add(nameof(Button1OnClick));
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            button1.DisableEvents("Click");
            UpdateCount();
        }

        private void EventCountButton_Click(object sender, EventArgs e)
        {
            UpdateCount();
        }

        private void UpdateCount()
        {
            listBox1.Items.Add(button1.EventCount("Click").ToString());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
