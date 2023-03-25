using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public UsersViewModel GetById(int id)
        {
            Users users = repository.GetById(id);
            return mapper.Map<UsersViewModel>(users);
        }

        public UsersViewModel GetByPassword(string email, string password)
        {
            UsersViewModel user = mapper.Map<UsersViewModel>(repository.GetByPassword(email, password));
            return user;
        }

        //public UsersViewModel GetByPassword(string name, string email, string password)
        //{
        //    UsersViewModel user = mapper.Map<UsersViewModel>(repository.GetByPassword(name, email, password));
        //    return user;
        //}

        public List<UsersViewModel> GetList()
        {
            List<UsersViewModel> usersViewModels = new List<UsersViewModel>();
            foreach(var user in repository.GetAll())
            {
                usersViewModels.Add(mapper.Map<UsersViewModel>(user));
            }
            return usersViewModels;
        }

        public int GetNumberOfUsers()
        {
            return repository.GetNumberOfUsers();
        }

        public async Task<bool> CheckEmailExistsAsync(string email)
        {
            return await repository.CheckEmailExistsAsync(email);
        }

        public async Task<List<UsersViewModel>> GetArtistAsync()
        {
            var artistJob = await repository.GetJobByNameAsync("Artist");
            if (artistJob == null)
            {
                return new List<UsersViewModel>();
            }
            var artistUsers = await repository.GetUsersByJobIdAsync(artistJob.Id);
            return mapper.Map<List<UsersViewModel>>(artistUsers);
        }
    }
}
