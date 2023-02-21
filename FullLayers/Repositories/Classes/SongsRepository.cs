using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class SongsRepository : ISongsRepository
    {
        LibraryContext context;

        public SongsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Songs obj)
        {
            context.Songs.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Songs.Find(id);
            if (c == null)
                return;
            context.Songs.Remove(c);
            context.SaveChanges();
        }

        public List<Songs> GetAll()
        {
            return context.Songs.ToList();
        }

        public Songs GetById(int id)
        {
            return context.Songs.Find(id);
        }

        public void Update(Songs obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
