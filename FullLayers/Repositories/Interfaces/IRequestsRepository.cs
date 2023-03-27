using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IRequestsRepository : IRepository<Requests>
    {
        public void UpdateStatus(int requestId);
    }
}
