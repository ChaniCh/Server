using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class JobToUserRepository : IJobToUserRepository
    {
        LibraryContext context;

        public JobToUserRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(JobToUser obj)
        {
            context.JobToUser.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.JobToUser.Find(id);
            if (c == null)
                return;
            context.JobToUser.Remove(c);
            context.SaveChanges();
        }

        public List<JobToUser> GetAll()
        {
            return context.JobToUser.ToList();
        }

        public JobToUser GetById(int id)
        {
            return context.JobToUser.Find(id);
        }

        public void Update(JobToUser obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
