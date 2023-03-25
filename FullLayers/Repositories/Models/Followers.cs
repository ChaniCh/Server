using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Followers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SingerId { get; set; }
        public bool? Status { get; set; }

        public virtual Users Singer { get; set; }
        public virtual Users User { get; set; }
    }
}
