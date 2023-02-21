using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class TagForSong
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int TagId { get; set; }

        public virtual Songs Song { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
