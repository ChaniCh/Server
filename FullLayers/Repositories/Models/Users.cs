using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Users
    {
        public Users()
        {
            AlbumToSinger = new HashSet<AlbumToSinger>();
            Connection = new HashSet<Connection>();
            FavoriteSongs = new HashSet<FavoriteSongs>();
            FollowListeningSongs = new HashSet<FollowListeningSongs>();
            FollowSelectionSingerSinger = new HashSet<FollowSelectionSinger>();
            FollowSelectionSingerUser = new HashSet<FollowSelectionSinger>();
            FollowViewingPosts = new HashSet<FollowViewingPosts>();
            FollowersSinger = new HashSet<Followers>();
            FollowersUser = new HashSet<Followers>();
            JobToUser = new HashSet<JobToUser>();
            SongToSinger = new HashSet<SongToSinger>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<AlbumToSinger> AlbumToSinger { get; set; }
        public virtual ICollection<Connection> Connection { get; set; }
        public virtual ICollection<FavoriteSongs> FavoriteSongs { get; set; }
        public virtual ICollection<FollowListeningSongs> FollowListeningSongs { get; set; }
        public virtual ICollection<FollowSelectionSinger> FollowSelectionSingerSinger { get; set; }
        public virtual ICollection<FollowSelectionSinger> FollowSelectionSingerUser { get; set; }
        public virtual ICollection<FollowViewingPosts> FollowViewingPosts { get; set; }
        public virtual ICollection<Followers> FollowersSinger { get; set; }
        public virtual ICollection<Followers> FollowersUser { get; set; }
        public virtual ICollection<JobToUser> JobToUser { get; set; }
        public virtual ICollection<SongToSinger> SongToSinger { get; set; }
    }
}
