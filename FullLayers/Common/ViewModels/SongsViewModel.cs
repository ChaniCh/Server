using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class SongsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PublicationDate { get; set; }
        public long? CountLike { get; set; }
        public long? CountListening { get; set; }
        public int? AlbumId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        //public DateTime LastListeningDate { get; set; }
        public bool Status { get; set; }

        public List<CommentsToSongViewModel> commentsToSong { get; set; }
        public List<CopyrightReportingViewModel> copyrightReporting { get; set; }
        public List<FavoriteSongsViewModel> favoriteSongs { get; set; }
        public List<FollowListeningSongsViewModel> followListeningSongs { get; set; }
        public List<SongsToPlaylistViewModel> songsToPlaylist { get; set; }
        public List<TagForSongViewModel> tagForSong { get; set; }
    }
}
