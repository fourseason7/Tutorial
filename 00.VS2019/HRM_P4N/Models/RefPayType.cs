using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefPayType
    {
        public RefPayType()
        {
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            Employees = new HashSet<Employee>();
            LeavesPolicies = new HashSet<LeavesPolicy>();
            PayApplySchedules = new HashSet<PayApplySchedule>();
            PayrollHistories = new HashSet<PayrollHistory>();
        }

        public int PayTypeId { get; set; }
        public string Code { get; set; }
        public decimal OvertimeRatio { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<LeavesPolicy> LeavesPolicies { get; set; }
        public virtual ICollection<PayApplySchedule> PayApplySchedules { get; set; }
        public virtual ICollection<PayrollHistory> PayrollHistories { get; set; }
    }
}
