using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class AlbumToSingerRepository : IAlbumToSingerRepository
    {
        LibraryContext context;

        public AlbumToSingerRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(AlbumToSinger obj)
        {
            context.AlbumToSinger.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.AlbumToSinger.Remove(context.AlbumToSinger.First(c => c.Id == id));
            context.SaveChanges();
        }

        public List<AlbumToSinger> GetAll()
        {
            return context.AlbumToSinger.ToList();
        }

        public AlbumToSinger GetById(int id)
        {
            return context.AlbumToSinger.First(c => c.Id == id);
        }

        public void Update(AlbumToSinger obj)
        {
            context.AlbumToSinger.Update(obj);
        }
    }
}
