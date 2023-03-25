using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class AlbumsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool Status { get; set; }

        public List<AlbumToSingerViewModel> albumToSinger { get; set; }
    }
}
