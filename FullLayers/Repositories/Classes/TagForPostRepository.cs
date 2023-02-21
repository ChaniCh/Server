using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class TagForPostRepository : ITagForPostRepository
    {
        LibraryContext context;

        public TagForPostRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(TagForPost obj)
        {
            context.TagForPost.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.TagForPost.Find(id);
            if (c == null)
                return;
            context.TagForPost.Remove(c);
            context.SaveChanges();
        }

        public List<TagForPost> GetAll()
        {
            return context.TagForPost.ToList();
        }

        public TagForPost GetById(int id)
        {
            return context.TagForPost.Find(id);
        }

        public void Update(TagForPost obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
