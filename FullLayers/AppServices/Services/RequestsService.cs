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
    public class RequestsService : IRequestsService
    {
        private IRequestsRepository repository;
        private IMapper mapper;

        public RequestsService(IRequestsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddRequest(RequestsViewModel request)
        {
            repository.Create(mapper.Map<Requests>(request));
        }

        public void DeleteRequest(int id)
        {
            repository.Delete(id);
        }

        public RequestsViewModel GetById(int id)
        {
            Requests requests = repository.GetById(id);
            return mapper.Map<RequestsViewModel>(requests);
        }

        public List<RequestsViewModel> GetList()
        {
            List<RequestsViewModel> requestsViewModel = new List<RequestsViewModel>();
            foreach (var request in repository.GetAll())
            {
                requestsViewModel.Add(mapper.Map<RequestsViewModel>(request));
            }
            return requestsViewModel;
        }

        public void UpdateStatus(int requestId)
        {
            repository.UpdateStatus(requestId);
        }
    }
}
