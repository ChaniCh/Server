using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Services
{
    public class CommentsToPostService : ICommentsToPostService
    {
        ICommentsToPostRepository repository;
        IMapper mapper;

        public CommentsToPostService(ICommentsToPostRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddCommentsToPost(CommentsToPostViewModel commentsToPost)
        {
            repository.Create(mapper.Map<CommentsToPost>(commentsToPost));
        }

        public void DeleteCommentsToPost(int id)
        {
            repository.Delete(id);
        }

        public CommentsToPostViewModel GetById(int id)
        {
            CommentsToPost commentsToPost = repository.GetById(id);
            return mapper.Map<CommentsToPostViewModel>(commentsToPost);
        }

        public List<CommentsToPostViewModel> GetList()
        {
            List<CommentsToPostViewModel> commentsToPostsViewModel = new List<CommentsToPostViewModel>();
            foreach(var commentToPost in GetList())
            {
                commentsToPostsViewModel.Add(mapper.Map<CommentsToPostViewModel>(commentToPost));
            }
            return commentsToPostsViewModel;
        }
    }
}
