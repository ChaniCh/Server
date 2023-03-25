using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IAlbumsRepository : IRepository<Albums>
    {
        public List<Songs> GetSongs(int albumId);

        public void SetStatus(int albumId, bool status);

        public List<Albums> GetAlbumsBySingerId(int singerId);
    }
}
