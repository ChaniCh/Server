using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class AlbumToSinger
    {
        public int Id { get; set; }
        public int SingerId { get; set; }
        public int AlbumId { get; set; }

        public virtual Albums Album { get; set; }
        public virtual Users Singer { get; set; }
    }
}
