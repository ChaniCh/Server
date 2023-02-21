using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Albums
    {
        public Albums()
        {
            AlbumToSinger = new HashSet<AlbumToSinger>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<AlbumToSinger> AlbumToSinger { get; set; }
    }
}
