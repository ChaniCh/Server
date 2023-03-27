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
    public class JobToUserService : IJobToUserService
    {
        IJobToUserRepository repository;
        IMapper mapper;

        public JobToUserService(IJobToUserRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddJobToUser(JobToUserViewModel jobToUser)
        {
            repository.Create(mapper.Map<JobToUser>(jobToUser));
        }

        public void DeleteJobToUser(int id)
        {
            repository.Delete(id);
        }

        public JobToUserViewModel GetById(int id)
        {
            JobToUser jobToUser = repository.GetById(id);
            return mapper.Map<JobToUserViewModel>(jobToUser);
        }

        public List<JobToUserViewModel> GetList()
        {
            List<JobToUserViewModel> jobToUserViewModel = new List<JobToUserViewModel>();
            foreach (var jobToUser in repository.GetAll())
            {
                jobToUserViewModel.Add(mapper.Map<JobToUserViewModel>(jobToUser));
            }
            return jobToUserViewModel;
        }
    }
}
