using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class PlaylistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? CountListening { get; set; }
        public string Image { get; set; }
        public bool? PublicOrPrivate { get; set; }
        public int? UserId { get; set; }
        public bool? Status { get; set; }

        public List<SongsToPlaylistViewModel> songsToPlaylist { get; set; }
    }
}
