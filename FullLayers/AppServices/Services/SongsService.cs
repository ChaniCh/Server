using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            song.Date = DateTime.Now;
            repository.Create(mapper.Map<Songs>(song));
        }

        public void DeleteSong(int id)
        {
            repository.Delete(id);
        }

        public SongsViewModel GetById(int id)
        {
            Songs songs = repository.GetById(id);
            return mapper.Map<SongsViewModel>(songs);
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

        public string GetSongUrl(int songId)
        {
            var url = repository.GetSongUrl(songId);
            return url;
        }

        public async Task<List<SongsViewModel>> GetSongsByTagAsync(int tagId)
        {
            var songs = await repository.GetSongsByTagAsync(tagId);
            var songsViewModel = mapper.Map<List<SongsViewModel>>(songs);
            return songsViewModel;
        }
    }
}
