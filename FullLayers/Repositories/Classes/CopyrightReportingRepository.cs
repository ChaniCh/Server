using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class CopyrightReportingRepository : ICopyrightReportingRepository
    {
        LibraryContext context;
        public CopyrightReportingRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(CopyrightReporting obj)
        {
            context.CopyrightReporting.Add(obj);
        }

        public void Delete(int id)
        {
            var c = context.CopyrightReporting.Find(id);
            if (c == null)
                return;
            context.Remove(c);
            context.SaveChanges();
        }

        public List<CopyrightReporting> GetAll()
        {
            return context.CopyrightReporting.ToList();
        }

        public CopyrightReporting GetById(int id)
        {
            return context.CopyrightReporting.Find(id);
        }

        public void Update(CopyrightReporting obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
