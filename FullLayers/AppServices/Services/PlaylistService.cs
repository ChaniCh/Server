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
    public class PlaylistService : IPlaylistService
    {
        IPlaylistRepository repository;
        IMapper mapper;

        public PlaylistService(IPlaylistRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddPlaylist(PlaylistViewModel playlist)
        {
            repository.Create(mapper.Map<Playlist>(playlist));
        }

        public void DeletePlaylist(int id)
        {
            repository.Delete(id);
        }

        public PlaylistViewModel GetById(int id)
        {
            Playlist playlist = repository.GetById(id);
            return mapper.Map<PlaylistViewModel>(playlist);
        }

        public List<PlaylistViewModel> GetList()
        {
            List<PlaylistViewModel> playlistViewModel = new List<PlaylistViewModel>();
            foreach (var playlist in repository.GetAll())
            {
                playlistViewModel.Add(mapper.Map<PlaylistViewModel>(playlist));
            }
            return playlistViewModel;
        }

        public List<SongsViewModel> GetPlaylistSongs(int playlistId)
        {
            var songs = repository.GetPlaylistSongs(playlistId);
            var songsViewModel = mapper.Map<List<SongsViewModel>>(songs);

            return songsViewModel;
        }

        //public List<SongsViewModel> GetPlaylistSongs(int playlistId)
        //{
        //    List<SongsViewModel> songsViewModels = new List<SongsViewModel>();
        //    foreach(var songs in repository.GetPlaylistSongs(playlistId))
        //    {
        //        songsViewModels.Add(mapper.Map<SongsViewModel>(songs));
        //    }
        //    return songsViewModels;
        //}

        //public List<Songs> GetPlaylistSongs(int playlistId)
        //{
        //    var play
        //}

        //public List<Songs> GetPlaylistSongs(int playlistId)
        //{
        //    var playlist = repository.Get(p => p.Id == playlistId, includeProperties: "SongsToPlaylist.Song").FirstOrDefault();

        //    if (playlist == null)
        //    {
        //        return new List<Songs>();
        //    }

        //    return playlist.SongsToPlaylist
        //        .OrderBy(i => i.Id)
        //        .Select(s => s.Song)
        //        .ToList();
        //}

    }
}
