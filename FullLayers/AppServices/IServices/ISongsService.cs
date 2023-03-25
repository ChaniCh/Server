using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.IServices
{
    public interface ISongsService
    {
        public void AddSong(SongsViewModel song);

        public void DeleteSong(int id);

        public SongsViewModel GetById(int id);

        public List<SongsViewModel> GetList();

        public string GetSongUrl(int songId);

        public Task<List<SongsViewModel>> GetSongsByTagAsync(int tagId);
    }
}
