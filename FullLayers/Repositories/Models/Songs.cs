using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Songs
    {
        public Songs()
        {
            CommentsToSong = new HashSet<CommentsToSong>();
            CopyrightReporting = new HashSet<CopyrightReporting>();
            FavoriteSongs = new HashSet<FavoriteSongs>();
            FollowListeningSongs = new HashSet<FollowListeningSongs>();
            SongToSinger = new HashSet<SongToSinger>();
            SongsToPlaylist = new HashSet<SongsToPlaylist>();
            TagForSong = new HashSet<TagForSong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PublicationDate { get; set; }
        public long? CountLike { get; set; }
        public long? CountListening { get; set; }
        public int? AlbumId { get; set; }
        public int? NumberInAlbum { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public string FileLocation { get; set; }

        public virtual Albums Album { get; set; }
        public virtual ICollection<CommentsToSong> CommentsToSong { get; set; }
        public virtual ICollection<CopyrightReporting> CopyrightReporting { get; set; }
        public virtual ICollection<FavoriteSongs> FavoriteSongs { get; set; }
        public virtual ICollection<FollowListeningSongs> FollowListeningSongs { get; set; }
        public virtual ICollection<SongToSinger> SongToSinger { get; set; }
        public virtual ICollection<SongsToPlaylist> SongsToPlaylist { get; set; }
        public virtual ICollection<TagForSong> TagForSong { get; set; }
    }
}
