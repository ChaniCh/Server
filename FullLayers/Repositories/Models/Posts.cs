using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Posts
    {
        public Posts()
        {
            CommentsToPost = new HashSet<CommentsToPost>();
            FollowViewingPosts = new HashSet<FollowViewingPosts>();
            TagForPost = new HashSet<TagForPost>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public string Credit { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public long? CountLike { get; set; }
        public long? CountListening { get; set; }
        public DateTime? LastViewingDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<CommentsToPost> CommentsToPost { get; set; }
        public virtual ICollection<FollowViewingPosts> FollowViewingPosts { get; set; }
        public virtual ICollection<TagForPost> TagForPost { get; set; }
    }
}
