using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class FollowListeningSongsViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SongId { get; set; }
        public DateTime Date { get; set; }
    }
}
