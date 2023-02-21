using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Models
{
    public partial class FollowSelectionSinger
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SingerId { get; set; }
        public DateTime Date { get; set; }

        public virtual Users User { get; set; }
    }
}
