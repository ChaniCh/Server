using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.IServices
{
    public interface IUsersService
    {
        public void AddUser(UsersViewModel user);

        public void DeleteUser(int id);
       
        public UsersViewModel GetById(int id);

        public List<UsersViewModel> GetList();

        public UsersViewModel GetByPassword(string email, string password);

        public int GetNumberOfUsers();

        public Task<bool> CheckEmailExistsAsync(string email);

        public Task<List<UsersViewModel>> GetArtistAsync();

        //public UsersViewModel GetByPassword(string name, string email, string password);

    }
}
