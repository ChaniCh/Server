using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class FavoriteSongsRepository : IFavoriteSongsRepository
    {
        LibraryContext context;

        public FavoriteSongsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(FavoriteSongs obj)
        {
            obj.Date = DateTime.Now;
            context.FavoriteSongs.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.FavoriteSongs.Find(id);
            if (c == null)
                return;
            context.FavoriteSongs.Remove(c);
            context.SaveChanges();
        }

        public List<FavoriteSongs> GetAll()
        {
            return context.FavoriteSongs.ToList();
        }

        public FavoriteSongs GetById(int id)
        {
            return context.FavoriteSongs.Find(id);
        }

        public void Update(FavoriteSongs obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
