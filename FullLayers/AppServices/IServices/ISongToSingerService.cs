using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ISongToSingerService
    {
        public void AddSongToSinger(SongToSingerViewModel songToSinger);

        public void DeleteSongToSinger(int id);

        public List<SongToSingerViewModel> GetList();

        public SongToSingerViewModel GetById(int id);
    }
}
