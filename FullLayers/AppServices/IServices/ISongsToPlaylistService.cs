using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ISongsToPlaylistService
    {
        public void AddSongToPlaylist(SongsToPlaylistViewModel songToPlaylist);

        public void DeleteSongToPlaylist(int id);

        public List<SongsToPlaylistViewModel> GetList();

        public SongsToPlaylistViewModel GetById(int id);

        public List<SongsViewModel> GetPlaylistSongs(int playlistId);
    }
}
