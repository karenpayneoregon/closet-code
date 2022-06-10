using DependencyInjectionForms1.Interfaces;
using DependencyInjectionForms1.Models;

namespace DependencyInjectionForms1.Services
{
    public class UserService : IUserService
    {
        public UserModel GetUser(int Id)
        {
            return new UserModel() { Id = Id, Name = "Anakin Skywalker" };
        }
    }
}
