using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Services
{
    public class UsersService : IUsersService
    {
        private IUsersRepository repository;
        private IMapper mapper;

        public UsersService(IUsersRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddUser(UsersViewModel user)
        {
            repository.Create(mapper.Map<Users>(user));
        }

        public void DeleteUser(int id)
        {
            repository.Delete(id);
        }

        public UsersViewModel GetByPassword(string name, string email, string password)
        {
            UsersViewModel user = mapper.Map<UsersViewModel>(repository.GetByPassword(name, email, password));
            return user;
        }

        public List<UsersViewModel> GetList()
        {
            List<UsersViewModel> usersViewModels = new List<UsersViewModel>();
            foreach(var user in repository.GetAll())
            {
                usersViewModels.Add(mapper.Map<UsersViewModel>(user));
            }
            return usersViewModels;
        }
    }
}
