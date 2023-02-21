using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Users GetByPassword(string name, string email, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.Name == name && 
            (u.Email == email || u.Password == password));
            return user != null ? user : null;
        }
    }
}
