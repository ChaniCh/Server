using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModels
{
    public class CopyrightReportingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int SongId { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
