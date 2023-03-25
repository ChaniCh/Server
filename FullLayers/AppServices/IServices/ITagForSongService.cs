using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.IServices
{
    public interface ITagForSongService
    {
        public void AddTagForSong(TagForSongViewModel tagForSong);

        public void DeleteTagForSong(int id);

        public List<TagForSongViewModel> GetList();

        public TagForSongViewModel GetById(int id);
    }
}
