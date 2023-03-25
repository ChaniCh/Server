using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class SongsToPlaylistRepository : ISongsToPlaylistRepository
    {
        LibraryContext context;

        public SongsToPlaylistRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(SongsToPlaylist obj)
        {
            context.SongsToPlaylist.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.SongsToPlaylist.Find(id);
            if (c == null)
                return;
            context.SongsToPlaylist.Remove(c);
            context.SaveChanges();
        }

        public List<SongsToPlaylist> GetAll()
        {
            return context.SongsToPlaylist.ToList();
        }

        public SongsToPlaylist GetById(int id)
        {
            return context.SongsToPlaylist.Find(id);
        }

        public void Update(SongsToPlaylist obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }

        public List<Songs> GetPlaylistSongs(int playlistId)
        {
            var songs = context.SongsToPlaylist
                .Where(p => p.PlaylistId == playlistId)
                .Select(s => s.Song)
                .ToList();

            return songs;
        }

    }
}
