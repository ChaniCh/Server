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
    public class FollowersService : IFollowersService
    {
        IFollowersRepository repository;
        IMapper mapper;

        public FollowersService(IFollowersRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddFollower(FollowersViewModel follower)
        {
            repository.Create(mapper.Map<Followers>(follower));
        }

        public void DeleteFollower(int id)
        {
            repository.Delete(id);
        }

        public FollowersViewModel GetById(int id)
        {
            Followers followers = repository.GetById(id);
            return mapper.Map<FollowersViewModel>(followers);
        }

        public List<FollowersViewModel> GetList()
        {
            List<FollowersViewModel> followersViewModels = new List<FollowersViewModel>();
            foreach (var follower in repository.GetAll())
            {
                followersViewModels.Add(mapper.Map<FollowersViewModel>(follower));
            }
            return followersViewModels;
        }
    }
}
