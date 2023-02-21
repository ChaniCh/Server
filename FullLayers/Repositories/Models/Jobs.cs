using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            JobToUser = new HashSet<JobToUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<JobToUser> JobToUser { get; set; }
    }
}
