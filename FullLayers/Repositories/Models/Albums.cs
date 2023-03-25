using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Albums
    {
        public Albums()
        {
            AlbumToSinger = new HashSet<AlbumToSinger>();
            Songs = new HashSet<Songs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PublicationDate { get; set; }
        public bool? Status { get; set; }
        public string Image { get; set; }

        public virtual ICollection<AlbumToSinger> AlbumToSinger { get; set; }
        public virtual ICollection<Songs> Songs { get; set; }
    }
}
