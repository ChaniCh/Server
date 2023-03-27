using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class RequestsRepository : IRequestsRepository
    {
        LibraryContext context;

        public RequestsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Requests obj)
        {
            context.Requests.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Requests.Find(id);
            if (c == null)
                return;
            context.Requests.Remove(c);
            context.SaveChanges();
        }

        public List<Requests> GetAll()
        {
            return context.Requests.ToList();
        }

        public Requests GetById(int id)
        {
            return context.Requests.Find(id);
        }

        public void Update(Requests obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }

        public void UpdateStatus(int requestId)
        {
            var request = context.Requests.Find(requestId);
            if (request != null)
            {
                request.Status = !request.Status;
                context.SaveChanges();
            }
        }
    }
}
