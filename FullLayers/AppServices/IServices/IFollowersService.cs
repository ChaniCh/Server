using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface IFollowersService
    {
        public void AddFollower(FollowersViewModel follower);

        public void DeleteFollower(int id);

        public List<FollowersViewModel> GetList();

        public FollowersViewModel GetById(int id);
    }
}
