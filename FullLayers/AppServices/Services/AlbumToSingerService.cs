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
    public class AlbumToSingerService : IAlbumToSingerService
    {
        IAlbumToSingerRepository repository;
        IMapper mapper;

        public AlbumToSingerService(IAlbumToSingerRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddAlbumToSinger(AlbumToSingerViewModel album)
        {
            repository.Create(mapper.Map<AlbumToSinger>(album));
        }

        public void DeleteAlbumToSinger(int id)
        {
            repository.Delete(id);
        }

        public AlbumToSingerViewModel GetById(int id)
        {
            AlbumToSinger albumToSinger = repository.GetById(id);
            return mapper.Map<AlbumToSingerViewModel>(albumToSinger);
        }

        public List<AlbumToSingerViewModel> GetList()
        {
            List<AlbumToSingerViewModel> albumToSingerViewModels = new List<AlbumToSingerViewModel>();
            foreach(var albumToSinger in GetList())
            {
                albumToSingerViewModels.Add(mapper.Map<AlbumToSingerViewModel>(albumToSinger));
            }
            return albumToSingerViewModels;
        }
    }
}
