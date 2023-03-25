using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IAlbumToSingerService
    {
        public void AddAlbumToSinger(AlbumToSingerViewModel album);

        public void DeleteAlbumToSinger(int id);

        public List<AlbumToSingerViewModel> GetList();

        public AlbumToSingerViewModel GetById(int id);
    }
}
