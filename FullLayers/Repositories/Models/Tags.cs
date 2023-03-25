using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Tags
    {
        public Tags()
        {
            TagForPost = new HashSet<TagForPost>();
            TagForSong = new HashSet<TagForSong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<TagForPost> TagForPost { get; set; }
        public virtual ICollection<TagForSong> TagForSong { get; set; }
    }
}
