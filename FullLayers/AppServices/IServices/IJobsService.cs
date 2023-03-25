using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IJobsService
    {
        public void AddJob(JobsViewModel job);

        public void DeleteJob(int id);

        public List<JobsViewModel> GetList();

        public JobsViewModel GetById(int id);
    }
}
