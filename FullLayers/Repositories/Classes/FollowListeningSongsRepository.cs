using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class FollowListeningSongsRepository : IFollowListeningSongsRepository
    {
        LibraryContext context;

        public FollowListeningSongsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(FollowListeningSongs obj)
        {
            context.FollowListeningSongs.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.FollowListeningSongs.Find(id);
            if (c == null)
                return;
            context.FollowListeningSongs.Remove(c);
            context.SaveChanges();
        }

        public List<FollowListeningSongs> GetAll()
        {
            return context.FollowListeningSongs.ToList();
        }

        public FollowListeningSongs GetById(int id)
        {
            return context.FollowListeningSongs.Find(id);
        }

        public void Update(FollowListeningSongs obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
