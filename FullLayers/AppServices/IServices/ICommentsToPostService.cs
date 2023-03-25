using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ICommentsToPostService
    {
        public void AddCommentsToPost(CommentsToPostViewModel commentsToPost);

        public void DeleteCommentsToPost(int id);

        public List<CommentsToPostViewModel> GetList();

        public CommentsToPostViewModel GetById(int id);
    }
}
