using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class PlaylistRepository : IPlaylistRepository
    {
        LibraryContext context;

        public PlaylistRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Playlist obj)
        {
            context.Playlist.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Playlist.Find(id);
            if (c == null)
                return;
            context.Playlist.Remove(c);
            context.SaveChanges();
        }

        public List<Playlist> GetAll()
        {
            return context.Playlist.ToList();
        }

        public Playlist GetById(int id)
        {
            return context.Playlist.Find(id);
        }

        public void Update(Playlist obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
