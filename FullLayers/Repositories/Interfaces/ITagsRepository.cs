using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ITagsRepository : IRepository<Tags>
    {
        public Task<bool> CheckTagExistsAsync(string tag);
    }
}
