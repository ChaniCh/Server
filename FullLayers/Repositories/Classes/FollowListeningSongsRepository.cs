using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class FollowListeningSongsRepository : IFollowListeningSongsRepository
    {
        LibraryContext context;

        public FollowListeningSongsRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(FollowListeningSongs obj)
        {
            obj.Date = DateTime.Now;
            context.FollowListeningSongs.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.FollowListeningSongs.Find(id);
            if (c == null)
                return;
            context.FollowListeningSongs.Remove(c);
            context.SaveChanges();
        }

        public List<FollowListeningSongs> GetAll()
        {
            return context.FollowListeningSongs.ToList();
        }

        public FollowListeningSongs GetById(int id)
        {
            return context.FollowListeningSongs.Find(id);
        }

        public void Update(FollowListeningSongs obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }

        public List<Songs> GetTopTenMostPlayedSongsLastWeek()
        {
            var oneWeekAgo = DateTime.Now.AddDays(-7);

            var topTenSongs = context.FollowListeningSongs
                .Where(f => f.Date >= oneWeekAgo)
                .GroupBy(f => f.Song)
                .OrderByDescending(g => g.Count())
                .Take(10)
                .Select(g => g.Key)
                .ToList();

            return topTenSongs;
        }
    }
}

//public List<Song> GetTopTenMostPlayedSongsLastWeek()
//{
//    // Calculate the date one week ago
//    var oneWeekAgo = DateTime.Now.AddDays(-7);

//    // Query the follow_listening_songs table to get the top ten most played songs in the last week
//    var topTenSongs = _context.FollowListeningSongs
//        .Where(f => f.DateListened >= oneWeekAgo) // Filter by date listened in the last week
//        .GroupBy(f => f.Song) // Group by song
//        .OrderByDescending(g => g.Count()) // Order by count of listens
//        .Take(10) // Take the top ten songs
//        .Select(g => g.Key) // Select the song from each group
//        .Include(s => s.Artist) // Include the artist for each song
//        .ToList(); // Execute the query and return the results

//    return topTenSongs;
//}
