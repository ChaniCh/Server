using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IFavoriteSongsService
    {
        public void AddFavoriteSong(FavoriteSongsViewModel favoriteSong);

        public void DeleteFavoriteSong(int id);

        public List<FavoriteSongsViewModel> GetList();

        public FavoriteSongsViewModel GetById(int id);
    }
}
