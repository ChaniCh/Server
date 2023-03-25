using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class FollowViewingPostsRepository : IFollowViewingPostsRepository
    {
        LibraryContext context;

        public FollowViewingPostsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(FollowViewingPosts obj)
        {
            context.FollowViewingPosts.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.FollowViewingPosts.Find(id);
            if (c == null)
                return;
            context.FollowViewingPosts.Remove(c);
            context.SaveChanges();
        }

        public List<FollowViewingPosts> GetAll()
        {
            return context.FollowViewingPosts.ToList();
        }

        public FollowViewingPosts GetById(int id)
        {
            return context.FollowViewingPosts.Find(id);
        }

        public void Update(FollowViewingPosts obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}


