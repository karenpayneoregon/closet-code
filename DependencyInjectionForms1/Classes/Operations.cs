using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionForms1.Models;

namespace DependencyInjectionForms1.Classes
{
    public class Operations
    {
        public static List<UserModel> UserList()
         => new()
            {
                new UserModel() { Id = 1, Name = "Beth Massi" },
                new UserModel() { Id = 2, Name = "Kathleen Dollard" },
                new UserModel() {Id = 3, Name = "Tommy Williams"},
                new UserModel() {Id = 4, Name = "David Pine"},
                new UserModel() {Id = 5, Name = "Karen Payne"}
            };

           
    }
}
