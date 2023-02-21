using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class CommentsToPost
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual Posts Post { get; set; }
    }
}
