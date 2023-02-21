using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IUsersService
    {
        public void AddUser(UsersViewModel user);

        public void DeleteUser(int id);

        public List<UsersViewModel> GetList();

        public UsersViewModel GetByPassword(string name, string email, string password);
    }
}
