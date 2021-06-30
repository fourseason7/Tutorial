using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PaySeq
    {
        public PaySeq()
        {
            CompanyPaySeqs = new HashSet<CompanyPaySeq>();
            PayApplySchedules = new HashSet<PayApplySchedule>();
            UnitPayseqs = new HashSet<UnitPayseq>();
        }

        public string PaySeqId { get; set; }
        public DateTime SeqStart { get; set; }
        public DateTime SeqEnd { get; set; }
        public int? PayPeriodTypeId { get; set; }
        public string DateAdded { get; set; }
        public DateTime? PayDate { get; set; }
        public string PayYear { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefPayPeriodType PayPeriodType { get; set; }
        public virtual ICollection<CompanyPaySeq> CompanyPaySeqs { get; set; }
        public virtual ICollection<PayApplySchedule> PayApplySchedules { get; set; }
        public virtual ICollection<UnitPayseq> UnitPayseqs { get; set; }
    }
}
