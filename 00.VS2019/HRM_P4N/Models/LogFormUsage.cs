using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LogFormUsage
    {
        public DateTime FormOpenDate { get; set; }
        public int FormId { get; set; }
        public string InOutFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ApplicationForm Form { get; set; }
    }
}
