using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Playlist
    {
        public Playlist()
        {
            SongsToPlaylist = new HashSet<SongsToPlaylist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public long? CountListening { get; set; }
        public string Image { get; set; }
        public bool? PublicOrPrivate { get; set; }
        public int? UserId { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<SongsToPlaylist> SongsToPlaylist { get; set; }
    }
}
