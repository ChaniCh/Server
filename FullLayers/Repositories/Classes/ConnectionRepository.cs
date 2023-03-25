using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Classes
{
    public class ConnectionRepository : IConnectionRepository
    {
        LibraryContext context;

        public ConnectionRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Connection obj)
        {
            context.Connection.Add(obj);
        }

        public void Delete(int id)
        {
            context.Connection.Remove(context.Connection.First(c => c.Id == id));
            context.SaveChanges();
        }

        public List<Connection> GetAll()
        {
            return context.Connection.ToList();
        }

        public Connection GetById(int id)
        {
            return context.Connection.First(c => c.Id == id);
        }

        public void Update(Connection obj)
        {
            context.Connection.Update(obj);
        }

        public int GetUserId(string email, string password)
        {
            int userId = 0;
            var user = context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                userId = user.Id;
            }
            return userId;
        }
        
        public void InsertUserId(int userId)
        {
            var id = new Connection { UserId = userId, Date = DateTime.Now };
            context.Connection.Add(id);
            context.SaveChanges();
        }
    }
}
