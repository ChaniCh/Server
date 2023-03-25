using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IFollowListeningSongsService
    {
        public void AddFollowListeningSongs(FollowListeningSongsViewModel followListeningSong);

        public void DeleteFollowListeningSong(int id);

        public List<FollowListeningSongsViewModel> GetList();

        public FollowListeningSongsViewModel GetById(int id);

        public List<SongsViewModel> GetTopTenMostPlayedSongsLastWeek();
    }
}
