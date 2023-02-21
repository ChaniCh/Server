using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class AlbumsRepository : IAlbumsRepository
    {
        LibraryContext context;

        public AlbumsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Albums obj)
        {
            context.Albums.Add(obj);
        }

        public void Delete(int id)
        {
            var c = context.Albums.Find(id);
            if (c == null)
                return;
            context.Albums.Remove(c);
            context.SaveChanges();
        }

        public List<Albums> GetAll()
        {
            return context.Albums.ToList();
        }

        public Albums GetById(int id)
        {
            return context.Albums.First(c => c.Id == id);
        }

        public void Update(Albums obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }

        public List<Songs> GetSongs(int albumId)
        {
            return context.Songs.Where(s => s.AlbumId == albumId).ToList();
        }

        public void SetStatus(int albumId, bool status)
        {
            Albums a = GetById(albumId);
            a.Status = status;
            context.SaveChanges();
        }
    }
}
