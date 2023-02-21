using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class TagForPost
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }

        public virtual Posts Post { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
