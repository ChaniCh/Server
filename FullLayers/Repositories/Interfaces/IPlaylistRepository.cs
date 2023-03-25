using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IPlaylistRepository : IRepository<Playlist>
    {
        public List<Songs> GetPlaylistSongs(int playlistId);

        //public List<Songs> GetPlaylistSongs(int playlistId);

        //public List<SongsToPlaylist> GetPlaylistSongs(int playlistId);
    }
}
