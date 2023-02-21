using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class SongsToPlaylist
    {
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int SongId { get; set; }

        public virtual Playlist Playlist { get; set; }
        public virtual Songs Song { get; set; }
    }
}
