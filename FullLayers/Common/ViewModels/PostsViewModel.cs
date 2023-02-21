using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class PostsViewModel
    {
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

        public List<CommentsToPostViewModel> commentsToPost { get; set; }
        public List<FollowViewingPostsViewModel> followViewingPosts { get; set; }
        public List<TagForPostViewModel> tagForPost { get; set; }
    }
}
