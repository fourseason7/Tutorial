using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefApprovalStatus
    {
        public RefApprovalStatus()
        {
            EmployeeComments = new HashSet<EmployeeComment>();
            EmployeeLeaves = new HashSet<EmployeeLeaf>();
        }

        public int StatusId { get; set; }
        public string Code { get; set; }
        public short SeqNo { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<EmployeeComment> EmployeeComments { get; set; }
        public virtual ICollection<EmployeeLeaf> EmployeeLeaves { get; set; }
    }
}
