﻿using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface ISongsToPlaylistRepository : IRepository<SongsToPlaylist>
    {
        public List<Songs> GetPlaylistSongs(int playlistId);
    }
}
