using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefLeavesOfAbsence
    {
        public RefLeavesOfAbsence()
        {
            EmployeeLeaves = new HashSet<EmployeeLeaf>();
            LeavesOfTheYears = new HashSet<LeavesOfTheYear>();
            LeavesPolicies = new HashSet<LeavesPolicy>();
        }

        public int LoatypeId { get; set; }
        public string Code { get; set; }
        public decimal? PaidHour { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string LoaTypeId1 { get; set; }

        public virtual ICollection<EmployeeLeaf> EmployeeLeaves { get; set; }
        public virtual ICollection<LeavesOfTheYear> LeavesOfTheYears { get; set; }
        public virtual ICollection<LeavesPolicy> LeavesPolicies { get; set; }
    }
}
