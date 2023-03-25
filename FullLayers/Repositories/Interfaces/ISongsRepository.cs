using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ISongsRepository : IRepository<Songs>
    {
        public string GetSongUrl(int songId);

        public Task<List<Songs>> GetSongsByTagAsync(int tagId);
    }
}
