using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LeavesOfAbsence
    {
        public int Loaid { get; set; }
        public int LeavesId { get; set; }
        public string Year { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal Loahour { get; set; }
        public string Remark { get; set; }
        public bool ActiveFlag { get; set; }
        public bool PaidFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual EmployeeLeaf Leaves { get; set; }
        public virtual Calendar WorkDateNavigation { get; set; }
    }
}
