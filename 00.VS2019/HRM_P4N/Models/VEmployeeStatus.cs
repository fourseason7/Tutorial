using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeStatus
    {
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public string TerminatedReason { get; set; }
        public int? LengthService { get; set; }
    }
}
