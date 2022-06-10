using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionForms1.Interfaces;
using DependencyInjectionForms1.Models;


namespace DependencyInjectionForms1.Presenters
{
    public class UserPresenter
    {
        private readonly IUserView _userView;
        private readonly IUserService userService;
        public UserPresenter(IUserView view)
        {
            _userView = view;
            userService = Program.GetService<IUserService>();
            Display();
        }

        public void Display()
        {
            _userView.ShowMessage("Hello User!");
        }

        public UserModel GetUserModel() => userService.GetUser(1); // calling method from ui
    }
}
