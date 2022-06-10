using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionForms1.Interfaces;
using DependencyInjectionForms1.Models;
using DependencyInjectionForms1.Services;
using DependencyInjectionForms1.Views;

namespace DependencyInjectionForms1.Presenters
{
    public class UserPresenter
    {
        private readonly IUserView _view;
        private readonly IUserService userService;
        public UserPresenter(IUserView view)
        {
            _view = view;
            userService = Program.GetService<IUserService>(); // request service object from ServiceProvider

            JustDoIt(); // quick sample for calling method from presenter
        }

        public void JustDoIt()
        {
            _view.JustDoIt("Hello User!");
        }

        public UserModel GetUserModel()
        {
            return userService.GetUser(1); // calling method from ui
        }
    }
}
