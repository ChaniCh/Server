using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IFollowViewingPostsService
    {
        public void AddFollowViewingPosts(FollowViewingPostsViewModel followViewingPosts);

        public void DeleteFollowViewingPosts(int id);

        public List<FollowViewingPostsViewModel> GetList();

        public FollowViewingPostsViewModel GetById(int id);
    }
}
