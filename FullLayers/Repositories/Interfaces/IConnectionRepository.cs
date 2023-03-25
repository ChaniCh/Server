using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IConnectionRepository : IRepository<Connection>
    {
        public int GetUserId(string email, string password);

        public void InsertUserId(int userId);

    }
}

