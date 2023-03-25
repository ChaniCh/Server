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
    public class PostsService : IPostsService
    {
        IPostsRepository repository;
        IMapper mapper;

        public PostsService(IPostsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddPost(PostsViewModel post)
        {
            repository.Create(mapper.Map<Posts>(post));
        }

        public void DeletePost(int id)
        {
            repository.Delete(id);
        }

        public PostsViewModel GetById(int id)
        {
            Posts posts = repository.GetById(id);
            return mapper.Map<PostsViewModel>(posts);
        }

        public List<PostsViewModel> GetList()
        {
            List<PostsViewModel> postsViewModel = new List<PostsViewModel>();
            foreach (var post in GetList())
            {
                postsViewModel.Add(mapper.Map<PostsViewModel>(post));
            }
            return postsViewModel;
        }
    }
}
