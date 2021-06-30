using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class CompanyPaySeq
    {
        public CompanyPaySeq()
        {
            PayrollHistories = new HashSet<PayrollHistory>();
            RetroDetails = new HashSet<RetroDetail>();
        }

        public int CompanyId { get; set; }
        public string PaySeqId { get; set; }
        public bool PaidFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual PaySeq PaySeq { get; set; }
        public virtual ICollection<PayrollHistory> PayrollHistories { get; set; }
        public virtual ICollection<RetroDetail> RetroDetails { get; set; }
    }
}
