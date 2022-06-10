using System.Linq;
using DependencyInjectionForms1.Classes;
using DependencyInjectionForms1.Interfaces;
using DependencyInjectionForms1.Models;

namespace DependencyInjectionForms1.Services
{
    public class UserService : IUserService
    {
        public UserModel GetUser(int Id) => 
            Operations.UserList().FirstOrDefault(person => person.Id == Id);
    }
}
