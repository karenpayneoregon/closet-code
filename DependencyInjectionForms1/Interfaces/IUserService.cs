using DependencyInjectionForms1.Models;

namespace DependencyInjectionForms1.Interfaces
{
    public interface IUserService
    {
        UserModel GetUser(int Id);
    }
}
