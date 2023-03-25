using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class CopyrightReporting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int SongId { get; set; }
        public string Message { get; set; }
        public int? Status { get; set; }

        public virtual Songs Song { get; set; }
    }
}
