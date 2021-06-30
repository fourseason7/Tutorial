using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PayrollHistory
    {
        public string EmployeeId { get; set; }
        public string PaySeqId { get; set; }
        public int CompanyId { get; set; }
        public string PayweekId { get; set; }
        public decimal PayRate { get; set; }
        public int PaytypeId { get; set; }
        public decimal RegularHour { get; set; }
        public decimal OvertimeHour { get; set; }
        public decimal SickDayHour { get; set; }
        public decimal VacationHour { get; set; }
        public decimal HolidayHour { get; set; }
        public decimal NonPaidLeavesHour { get; set; }
        public decimal LeavesHour { get; set; }
        public decimal RetroHour { get; set; }
        public decimal RegularAmount { get; set; }
        public decimal OvertimeAmount { get; set; }
        public decimal LeavesAmount { get; set; }
        public decimal RetroAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CompanyPaySeq CompanyPaySeq { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual UnitPayseq Pay { get; set; }
        public virtual RefPayType Paytype { get; set; }
    }
}
