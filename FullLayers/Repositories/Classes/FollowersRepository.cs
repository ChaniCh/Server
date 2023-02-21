using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class FollowersRepository : IFollowersRepository
    {
        LibraryContext context;

        public FollowersRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Followers obj)
        {
            context.Followers.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Followers.Find(id);
            context.Followers.Remove(c);
            context.SaveChanges();
        }

        public List<Followers> GetAll()
        {
            return context.Followers.ToList();
        }

        public Followers GetById(int id)
        {
            return context.Followers.Find(id);
        }

        public void Update(Followers obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
