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
    public class FollowViewingPostsService : IFollowViewingPostsService
    {
        IFollowViewingPostsRepository repository;
        IMapper mapper;

        public FollowViewingPostsService(IFollowViewingPostsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddFollowViewingPosts(FollowViewingPostsViewModel followViewingPosts)
        {
            repository.Create(mapper.Map<FollowViewingPosts>(followViewingPosts));
        }

        public void DeleteFollowViewingPosts(int id)
        {
            repository.Delete(id);
        }

        public FollowViewingPostsViewModel GetById(int id)
        {
            FollowViewingPosts followViewingPosts = repository.GetById(id);
            return mapper.Map<FollowViewingPostsViewModel>(followViewingPosts);
        }

        public List<FollowViewingPostsViewModel> GetList()
        {
            List<FollowViewingPostsViewModel> followViewingPostsViewModels = new List<FollowViewingPostsViewModel>();
            foreach(var followViewingPost in GetList())
            {
                followViewingPostsViewModels.Add(mapper.Map<FollowViewingPostsViewModel>(followViewingPost));
            }
            return followViewingPostsViewModels;
        }
    }
}
