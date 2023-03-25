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

        public List<Songs> GetPlaylistSongs(int playlistId)
        {
            var songs = context.SongsToPlaylist
                .Where(s => s.PlaylistId == playlistId)
                .Select(s => s.Song)
                .ToList();
            return songs;
        }

        //public List<Songs> GetPlaylistSongs(int playlistId)
        //{
        //    var playlist = context.Playlist
        //        .Include(p => p.SongsToPlaylist)
        //        .ThenInclude(s => s.Song)
        //        .FirstOrDefault(p => p.Id == playlistId);

        //    if(playlist == null)
        //    {
        //        return new List<Songs>();
        //    }

        //    return playlist.SongsToPlaylist
        //        .OrderBy(i => i.Id)
        //        .Select(s => s.Song)
        //        .ToList();      
        //}

        //public List<Songs> GetSongsForPlaylist(int playlistId)
        //{
        //    using (var context = new YourDbContext())
        //    {
        //        var playlist = context.Playlists
        //            .Include(p => p.SongsToPlaylists)
        //            .ThenInclude(sp => sp.Song)
        //            .FirstOrDefault(p => p.Id == playlistId);

        //        if (playlist == null)
        //        {
        //            return new List<Songs>();
        //        }

        //        return playlist.SongsToPlaylists
        //            .OrderBy(sp => sp.Id)
        //            .Select(sp => sp.Song)
        //            .ToList();
        //    }
        //}


        //public List<SongsToPlaylist> GetPlaylistSongs(int playlistId)
        //{
        //    return context.SongsToPlaylist.Where(p => p.PlaylistId == playlistId).ToList();
        //}
    }
}
