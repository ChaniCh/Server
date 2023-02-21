using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class FollowListeningSongs
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SongId { get; set; }
        public DateTime Date { get; set; }

        public virtual Songs Song { get; set; }
        public virtual Users User { get; set; }
    }
}
