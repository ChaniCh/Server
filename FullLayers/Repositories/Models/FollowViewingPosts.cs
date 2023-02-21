using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class FollowViewingPosts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime Date { get; set; }

        public virtual Posts Post { get; set; }
        public virtual Users User { get; set; }
    }
}
