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
        public class SongsRepository : ISongsRepository
        {
            LibraryContext context;

            public SongsRepository(LibraryContext context)
            {
                this.context = context;
            }

            public void Create(Songs obj)
            {
                obj.Date = DateTime.Now;
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

            public string GetSongUrl(int songId)
            {
                var song = context.Songs.Find(songId);
                return song.FileLocation;
            }

        public async Task<List<Songs>> GetSongsByTagAsync(int tagId)
        {
            var songs = await context.Songs
                .Join(context.TagForSong,
                song => song.Id,
                tagForSong => tagForSong.SongId,
                (song, tagForSong) => new { Songs = song, TagForSong = tagForSong })
                .Join(context.Tags,
                tagForSong => tagForSong.TagForSong.TagId,
                tags => tags.Id,
                (tagForSong, tags) => new { Songs = tagForSong.Songs, Tags = tags })
                .Where(tagForSong => tagForSong.Tags.Id == tagId)
                .Select(tagForSong => tagForSong.Songs)
                .ToListAsync();

            return songs;
        }
    }
}

