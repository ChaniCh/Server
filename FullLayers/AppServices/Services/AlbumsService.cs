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
    public class AlbumsService : IAlbumsService
    {
        private IAlbumsRepository repository;
        private IMapper mapper;

        public AlbumsService(IAlbumsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddAlbum(AlbumsViewModel album)
        {
            repository.Create(mapper.Map<Albums>(album));
        }

        public void DeleteAlbum(int id)
        {
            repository.Delete(id);
        }

        public AlbumsViewModel GetById(int id)
        {
            Albums albums = repository.GetById(id);
            return mapper.Map<AlbumsViewModel>(albums);
        }

        public List<AlbumsViewModel> GetList()
        {
            List<AlbumsViewModel> albumsViewModels = new List<AlbumsViewModel>();
            foreach(var album in repository.GetAll())
            {
                albumsViewModels.Add(mapper.Map<AlbumsViewModel>(album));
            }
            return albumsViewModels;
        }

        public List<SongsViewModel> GetSongs(int albumId)
        {
            List<SongsViewModel> songsViewModels = new List<SongsViewModel>();
            foreach(var song in repository.GetSongs(albumId))
            {
                songsViewModels.Add(mapper.Map<SongsViewModel>(song));
            }
            return songsViewModels;
        }

        public void SetStatus(int albumId, bool status)
        {
            repository.SetStatus(albumId, status);
        }
    }
}
