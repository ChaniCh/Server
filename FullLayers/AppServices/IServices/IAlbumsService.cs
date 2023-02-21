using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IAlbumsService
    {
        public void AddAlbum(AlbumsViewModel album);

        public void DeleteAlbum(int id);

        public List<AlbumsViewModel> GetList();

        public AlbumsViewModel GetById(int id);

        public List<SongsViewModel> GetSongs(int albumId);

        public void SetStatus(int albumId, bool status);
    }
}
