using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Microsoft.Extensions.Logging;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Services
{
    public class SongsToPlaylistService : ISongsToPlaylistService
    {
        ISongsToPlaylistRepository repository;
        IMapper mapper;
        ILogger<SongsToPlaylistService> logger;

        public SongsToPlaylistService(ISongsToPlaylistRepository repository, IMapper mapper,
            ILogger<SongsToPlaylistService> logger)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.logger = logger;
        }

        public void AddSongToPlaylist(SongsToPlaylistViewModel songToPlaylist)
        {
            repository.Create(mapper.Map<SongsToPlaylist>(songToPlaylist));
        }

        public void DeleteSongToPlaylist(int id)
        {
            repository.Delete(id);
        }

        public SongsToPlaylistViewModel GetById(int id)
        {
            SongsToPlaylist songsToPlaylist = repository.GetById(id);
            return mapper.Map<SongsToPlaylistViewModel>(songsToPlaylist);
        }

        public List<SongsToPlaylistViewModel> GetList()
        {
            List<SongsToPlaylistViewModel> songsToPlaylistViewModel = new List<SongsToPlaylistViewModel>();
            foreach (var songToPlaylist in GetList())
            {
                songsToPlaylistViewModel.Add(mapper.Map<SongsToPlaylistViewModel>(songToPlaylist));
            }
            return songsToPlaylistViewModel;
        }

        public List<SongsViewModel> GetPlaylistSongs(int playlistId)
        {
            //logger.LogInformation("Getting songs for playlist {playlistId}", playlistId);
            var songs = repository.GetPlaylistSongs(playlistId);
            var songsViewModel = mapper.Map<List<SongsViewModel>>(songs);

            //logger.LogInformation("Retrieved {count} songs for playlist {playlistId}", songsViewModel.Count, playlistId);

            return songsViewModel;
        }

    }
}
