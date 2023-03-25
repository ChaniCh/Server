using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class SongToSinger
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int SingerId { get; set; }

        public virtual Users Singer { get; set; }
        public virtual Songs Song { get; set; }
    }
}
