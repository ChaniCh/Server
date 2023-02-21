using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class CommentsToSong
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual Songs Song { get; set; }
    }
}
