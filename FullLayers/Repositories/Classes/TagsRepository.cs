using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Classes
{
    public class TagsRepository : ITagsRepository
    {
        LibraryContext context;

        public TagsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Tags obj)
        {
            context.Tags.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Tags.Find(id);
            if (c == null)
                return;
            context.Tags.Remove(c);
            context.SaveChanges();
        }

        public List<Tags> GetAll()
        {
            return context.Tags.ToList();
        }

        public Tags GetById(int id)
        {
            return context.Tags.Find(id);
        }

        public void Update(Tags obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }

        public async Task<bool> CheckTagExistsAsync(string tag)
        {
            return await context.Tags.AnyAsync(t => t.Name == tag);
        }
    }
}
