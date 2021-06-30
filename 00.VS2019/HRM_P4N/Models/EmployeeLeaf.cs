using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeeLeaf
    {
        public EmployeeLeaf()
        {
            LeavesOfAbsences = new HashSet<LeavesOfAbsence>();
        }

        public int LeavesId { get; set; }
        public string EmployeeId { get; set; }
        public int LoatypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remark { get; set; }
        public string ApprovalId { get; set; }
        public bool ActiveFlag { get; set; }
        public bool EditFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Approval { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual RefLeavesOfAbsence Loatype { get; set; }
        public virtual RefApprovalStatus Status { get; set; }
        public virtual ICollection<LeavesOfAbsence> LeavesOfAbsences { get; set; }
    }
}
