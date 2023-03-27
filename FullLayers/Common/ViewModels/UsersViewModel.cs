using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Newsletter { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public List<AlbumToSingerViewModel> albumToSinger { get; set; }
        public List<ConnectionViewModel> connection { get; set; }
        public List<FavoriteSongsViewModel> favoriteSongs { get; set; }
        public List<FollowListeningSongsViewModel> followListeningSongs { get; set; }
        public List<FollowViewingPostsViewModel> followViewingPosts { get; set; }
        public List<FollowersViewModel> followersSinger { get; set; }
        public List<FollowersViewModel> followersUser { get; set; }
        public List<JobToUserViewModel> jobToUser { get; set; }
    }
}
