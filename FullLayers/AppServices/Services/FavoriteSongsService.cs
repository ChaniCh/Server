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
    public class FavoriteSongsService : IFavoriteSongsService
    {
        IFavoriteSongsRepository repository;
        IMapper mapper;

        public FavoriteSongsService(IFavoriteSongsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        } 

        public void AddFavoriteSong(FavoriteSongsViewModel favoriteSong)
        {
            favoriteSong.Date = DateTime.Now;
            repository.Create(mapper.Map<FavoriteSongs>(favoriteSong));
        }

        public void DeleteFavoriteSong(int id)
        {
            repository.Delete(id);
        }

        public FavoriteSongsViewModel GetById(int id)
        {
            FavoriteSongs favoriteSongs = repository.GetById(id);
            return mapper.Map<FavoriteSongsViewModel>(favoriteSongs);
        }

        public List<FavoriteSongsViewModel> GetList()
        {
            List<FavoriteSongsViewModel> favoriteSongsViewModels = new List<FavoriteSongsViewModel>();
            foreach(var favoriteSong in repository.GetAll())
            {
                favoriteSongsViewModels.Add(mapper.Map<FavoriteSongsViewModel>(favoriteSong));
            }
            return favoriteSongsViewModels;
        }
    }
}
