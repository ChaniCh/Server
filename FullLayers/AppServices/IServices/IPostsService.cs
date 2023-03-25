using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IPostsService
    {
        public void AddPost(PostsViewModel post);

        public void DeletePost(int id);

        public List<PostsViewModel> GetList();

        public PostsViewModel GetById(int id);
    }
}
