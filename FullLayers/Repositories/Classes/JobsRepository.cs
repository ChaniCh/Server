using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class JobsRepository : IJobsRepository
    {
        LibraryContext context;

        public JobsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Jobs obj)
        {
            context.Jobs.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Jobs.Find(id);
            if (c == null)
                return;
            context.Jobs.Remove(c);
            context.SaveChanges();
        }

        public List<Jobs> GetAll()
        {
            return context.Jobs.ToList();
        }

        public Jobs GetById(int id)
        {
            return context.Jobs.Find(id);
        }

        public void Update(Jobs obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
