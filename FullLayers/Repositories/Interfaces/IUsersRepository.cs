using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IUsersRepository : IRepository<Users>
    {
        public Users GetByPassword(string name, string email, string password);
    }
}
