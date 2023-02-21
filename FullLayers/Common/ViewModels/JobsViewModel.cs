using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class JobsViewModel
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public List<JobToUserViewModel> jobToUser { get; set; }
    }
}
