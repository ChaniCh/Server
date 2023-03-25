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
    public class SongToSingerService : ISongToSingerService
    {
        private ISongToSingerRepository repository;
        private IMapper mapper;

        public SongToSingerService(ISongToSingerRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddSongToSinger(SongToSingerViewModel songToSinger)
        {
            repository.Create(mapper.Map<SongToSinger>(songToSinger));
        }

        public void DeleteSongToSinger(int id)
        {
            repository.Delete(id);
        }

        public SongToSingerViewModel GetById(int id)
        {
            SongToSinger songToSinger = repository.GetById(id);
            return mapper.Map<SongToSingerViewModel>(songToSinger);
        }

        public List<SongToSingerViewModel> GetList()
        {
            List<SongToSingerViewModel> songToSingerViewModel = new List<SongToSingerViewModel>();
            foreach (var songToSinger in repository.GetAll())
            {
                songToSingerViewModel.Add(mapper.Map<SongToSingerViewModel>(songToSinger));
            }
            return songToSingerViewModel;
        }
    }
}
