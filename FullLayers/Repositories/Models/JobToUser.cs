using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class JobToUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }

        public virtual Jobs Job { get; set; }
        public virtual Users User { get; set; }
    }
}
