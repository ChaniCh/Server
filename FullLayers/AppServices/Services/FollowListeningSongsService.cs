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
    public class FollowListeningSongsService : IFollowListeningSongsService
    {
        IFollowListeningSongsRepository repository;
        IMapper mapper;

        public FollowListeningSongsService(IFollowListeningSongsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        public void AddFollowListeningSongs(FollowListeningSongsViewModel followListeningSong)
        {
            followListeningSong.Date = DateTime.Now;
            repository.Create(mapper.Map<FollowListeningSongs>(followListeningSong));
        }

        public void DeleteFollowListeningSong(int id)
        {
            repository.Delete(id);
        }

        public FollowListeningSongsViewModel GetById(int id)
        {
            FollowListeningSongs followListeningSongs = repository.GetById(id);
            return mapper.Map<FollowListeningSongsViewModel>(followListeningSongs);
        }

        public List<FollowListeningSongsViewModel> GetList()
        {
            List<FollowListeningSongsViewModel> followListeningSongsViewModel = new List<FollowListeningSongsViewModel>();
            foreach (var followListeningSong in repository.GetAll())
            {
                followListeningSongsViewModel.Add(mapper.Map<FollowListeningSongsViewModel>(followListeningSong));
            }
            return followListeningSongsViewModel;
        }

        public List<SongsViewModel> GetTopTenMostPlayedSongsLastWeek()
        {
            var topTenSongs = repository.GetTopTenMostPlayedSongsLastWeek();
            var topTenSongsViewModel = mapper.Map<List<SongsViewModel>>(topTenSongs);

            return topTenSongsViewModel;
        }
    }
}

//public List<SongDTO> GetTopTenMostPlayedSongsLastWeek()
//{
//    var topTenSongs = _repository.GetTopTenMostPlayedSongsLastWeek();

//    var topTenSongsDTO = _mapper.Map<List<SongDTO>>(topTenSongs);

//    return topTenSongsDTO;
//}
