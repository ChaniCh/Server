using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class TagsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public List<TagForPostViewModel> tagForPost { get; set; }
        public List<TagForSongViewModel> tagForSong { get; set; }
    }
}
