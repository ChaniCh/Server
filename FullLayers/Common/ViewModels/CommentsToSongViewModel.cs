using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class CommentsToSongViewModel
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
