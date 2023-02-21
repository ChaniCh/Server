using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class TagForSongRepository : ITagForSongRepository
    {
        LibraryContext context;

        public TagForSongRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(TagForSong obj)
        {
            context.TagForSong.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.TagForSong.Find(id);
            if (c == null)
                return;
            context.TagForSong.Remove(c);
            context.SaveChanges();
        }

        public List<TagForSong> GetAll()
        {
            return context.TagForSong.ToList();
        }

        public TagForSong GetById(int id)
        {
            return context.TagForSong.Find(id);
        }

        public void Update(TagForSong obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
