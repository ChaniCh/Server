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
    public class JobsService : IJobsService
    {
        IJobsRepository repository;
        IMapper mapper;

        public JobsService(IJobsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddJob(JobsViewModel job)
        {
            repository.Create(mapper.Map<Jobs>(job));
        }

        public void DeleteJob(int id)
        {
            repository.Delete(id);
        }

        public JobsViewModel GetById(int id)
        {
            Jobs jobs = repository.GetById(id);
            return mapper.Map<JobsViewModel>(jobs);
        }

        public List<JobsViewModel> GetList()
        {
            List<JobsViewModel> jobsViewModel = new List<JobsViewModel>();
            foreach (var job in repository.GetAll())
            {
                jobsViewModel.Add(mapper.Map<JobsViewModel>(job));
            }
            return jobsViewModel;
        }
    }
}
