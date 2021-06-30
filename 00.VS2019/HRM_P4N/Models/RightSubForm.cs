using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RightSubForm
    {
        public string UserId { get; set; }
        public int SubFormId { get; set; }
        public bool RightFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual SubApplicationForm SubForm { get; set; }
    }
}
