using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class MinuteSeq
    {
        public string MinuteId { get; set; }
        public string Code { get; set; }
        public bool DefaultFlag { get; set; }
        public bool ConfirmFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
