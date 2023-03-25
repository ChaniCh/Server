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
    public class UsersRepository : IUsersRepository
    {
        LibraryContext context;

        public UsersRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Users obj)
        {
            context.Users.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = context.Users.Find(id);
            if (c == null)
                return;
            context.Users.Remove(c);
            context.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return context.Users.ToList();
        }

        public Users GetById(int id)
        {
            return context.Users.Find(id);
        }

        public void Update(Users obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.Update(obj);
            context.SaveChanges();
        }

        public Users GetByPassword(string email, string password)
        {
            var user = context.Users.FirstOrDefault(e =>  e.Email == email && e.Password == password);
            return user != null ? user : null;
        }

        public int GetNumberOfUsers()
        {
            return context.Users.Count();
        }

        public async Task<bool> CheckEmailExistsAsync(string email)
        {
            return await context.Users.AnyAsync(e => e.Email == email);
        }

        public async Task<List<Users>> GetArtistAsync()
        {
            var artistJob = await context.Jobs.FirstOrDefaultAsync(j => j.Name == "Artist");
            if (artistJob == null)
            {
                return new List<Users>();
            }

            var artistUsers = await context.Users
                .Where(u => u.JobToUser.Any(ju => ju.JobId == artistJob.Id))
                .ToListAsync();

            return artistUsers;
        }

        public async Task<Jobs> GetJobByNameAsync(string name)
        {
            return await context.Jobs.FirstOrDefaultAsync(j => j.Name == name);
        }

        public async Task<List<Users>> GetUsersByJobIdAsync(int jobId)
        {
            return await context.Users
                .Where(u => u.JobToUser.Any(ju => ju.JobId == jobId))
                .ToListAsync();
        }

        //public Users GetByPassword(string name, string email, string password)
        //{
        //    var user = context.Users.FirstOrDefault(u => (u.Name == name ||
        //    u.Email == email) && u.Password == password);
        //    return user != null ? user : null;
        //}
    }
}
