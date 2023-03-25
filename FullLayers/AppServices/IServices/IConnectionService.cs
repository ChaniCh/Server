using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IConnectionService
    {
        public void AddConnection(ConnectionViewModel connection);

        public void DeleteConnection(int id);

        public List<ConnectionViewModel> GetList();

        public ConnectionViewModel GetById(int id);

        public UsersViewModel Login(string email, string password);
    }
}
