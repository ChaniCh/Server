using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Connection
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
