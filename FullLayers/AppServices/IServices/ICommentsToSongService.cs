using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ICommentsToSongService
    {
        public void AddCommentsToSong(CommentsToSongViewModel commentToSong);

        public void DeleteCommentsToSong(int id);

        public List<CommentsToSongViewModel> GetList();

        public CommentsToSongViewModel GetById(int id);
    }
}
