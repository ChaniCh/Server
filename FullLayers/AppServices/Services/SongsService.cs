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
    public class SongsService : ISongsService
    {
        private ISongsRepository repository;
        private IMapper mapper;

        public SongsService(ISongsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddSong(SongsViewModel song)
        {
            repository.Create(mapper.Map<Songs>(song));
        }

        public void DeleteSong(int id)
        {
            repository.Delete(id);
        }

        public List<SongsViewModel> GetList()
        {
            List<SongsViewModel> songsViewModel = new List<SongsViewModel>();
            foreach(var song in repository.GetAll())
            {
                songsViewModel.Add(mapper.Map<SongsViewModel>(song));
            }
            return songsViewModel;
        }
    }
}
