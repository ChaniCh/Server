using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class SongToSingerRepository : ISongToSingerRepository
    {
        LibraryContext context;

        public SongToSingerRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(SongToSinger obj)
        {
            try
            {
                context.SongToSinger.Add(obj);
                context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }


    public void Delete(int id)
        {
            var songToSinger = context.SongToSinger.Find(id);
            if (songToSinger == null)
                return;
            context.SongToSinger.Remove(songToSinger);
            context.SaveChanges();
        }

        public List<SongToSinger> GetAll()
        {
            return context.SongToSinger.ToList();
        }

        public SongToSinger GetById(int id)
        {
            return context.SongToSinger.Find(id);
        }

        public void Update(SongToSinger obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }
    }
}
