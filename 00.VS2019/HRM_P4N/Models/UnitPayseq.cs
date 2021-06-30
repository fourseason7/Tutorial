using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class UnitPayseq
    {
        public UnitPayseq()
        {
            PayrollHistories = new HashSet<PayrollHistory>();
        }

        public string PayweekId { get; set; }
        public string PaySeqId { get; set; }
        public DateTime WeekStart { get; set; }
        public DateTime WeekEnd { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PaySeq PaySeq { get; set; }
        public virtual ICollection<PayrollHistory> PayrollHistories { get; set; }
    }
}
