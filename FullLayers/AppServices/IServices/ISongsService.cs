using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ISongsService
    {
        public void AddSong(SongsViewModel song);

        public void DeleteSong(int id);

        public List<SongsViewModel> GetList();
    }
}
