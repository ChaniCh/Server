using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IJobToUserService
    {
        public void AddJobToUser(JobToUserViewModel jobToUser);

        public void DeleteJobToUser(int id);

        public List<JobToUserViewModel> GetList();

        public JobToUserViewModel GetById(int id);
    }
}
