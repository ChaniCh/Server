using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IPlaylistService
    {
        public void AddPlaylist(PlaylistViewModel playlist);

        public void DeletePlaylist(int id);

        public List<PlaylistViewModel> GetList();

        public PlaylistViewModel GetById(int id);

        public List<SongsViewModel> GetPlaylistSongs(int playlistId);

        //public List<SongsViewModel> GetPlaylistSongs(int playlistId);
    }
}
