using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class CommentsToSongRepository : ICommentsToSongRepository
    {
        LibraryContext context;

        public CommentsToSongRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(CommentsToSong obj)
        {
            context.CommentsToSong.Add(obj);
        }

        public void Delete(int id)
        {
            context.CommentsToSong.Remove(context.CommentsToSong.First(c => c.Id == id));
            context.SaveChanges();
        }

        public List<CommentsToSong> GetAll()
        {
            return context.CommentsToSong.ToList();
        }

        public CommentsToSong GetById(int id)
        {
            return context.CommentsToSong.First(c => c.Id == id);
        }

        public void Update(CommentsToSong obj)
        {
            context.CommentsToSong.Update(obj);
        }
    }
}
