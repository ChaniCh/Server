using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class PostsRepository : IPostsRepository
    {
        LibraryContext context;

        public PostsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Posts obj)
        {
            context.Posts.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Posts.Find(id);
            if (c == null)
                return;
            context.Posts.Remove(c);
            context.SaveChanges();
        }

        public List<Posts> GetAll()
        {
            return context.Posts.ToList();
        }

        public Posts GetById(int id)
        {
            return context.Posts.Find(id);
        }

        public void Update(Posts obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
