using System;
using System.Windows.Forms;
using DependencyInjectionForms1.Interfaces;
using DependencyInjectionForms1.Presenters;

namespace DependencyInjectionForms1.Views
{
    public partial class UserView : Form, IUserView
    {
        private readonly UserPresenter _presenter;
        public UserView()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this);
        }

        public void ShowMessage(string message)
        {
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = _presenter.GetUserModel();
            MessageBox.Show(user.Name);
        }
    }
}
