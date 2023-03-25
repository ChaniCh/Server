using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class Requests
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FileLocation { get; set; }
        public string Phone { get; set; }
        public bool? Status { get; set; }
        public DateTime Date { get; set; }
    }
}
