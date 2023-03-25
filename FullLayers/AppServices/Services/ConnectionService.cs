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
    public class ConnectionService : IConnectionService
    {
        IConnectionRepository repository;
        IUsersService service;
        IMapper mapper;

        public ConnectionService(IConnectionRepository repository, IMapper mapper, IUsersService service)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.service = service;
        }

        public void AddConnection(ConnectionViewModel connection)
        {
            repository.Create(mapper.Map<Connection>(connection));
        }

        public void DeleteConnection(int id)
        {
            repository.Delete(id);
        }

        public ConnectionViewModel GetById(int id)
        {
            Connection connection = repository.GetById(id);
            return mapper.Map<ConnectionViewModel>(connection);
        }

        public List<ConnectionViewModel> GetList()
        {
            List<ConnectionViewModel> connectionViewModel = new List<ConnectionViewModel>();
            foreach(var connection in GetList())
            {
                connectionViewModel.Add(mapper.Map<ConnectionViewModel>(connection));
            }
            return connectionViewModel;
        }

        public UsersViewModel Login(string email, string password)
        {
            int id = repository.GetUserId(email, password);
            repository.InsertUserId(id);
            return service.GetById(id);

        }


        //public UsersViewModel GetByPassword(string email, string password)
        //{
        //    UsersViewModel user = mapper.Map<UsersViewModel>(repository.GetByPassword(email, password));
        //    return user;
        //}
    }
}
