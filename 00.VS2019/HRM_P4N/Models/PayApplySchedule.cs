using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PayApplySchedule
    {
        public string EmployeeId { get; set; }
        public string EffectivePaySeqId { get; set; }
        public string ExpiredPaySeqId { get; set; }
        public decimal PayRate { get; set; }
        public int AdditionalPayType { get; set; }
        public decimal AdditionalPayAmount { get; set; }
        public decimal AdditionalPayRate { get; set; }
        public decimal BillingPayRate { get; set; }
        public int PayTypeId { get; set; }
        public string RequestEmployeeId { get; set; }
        public bool ActiveFlag { get; set; }
        public bool AppliedFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PaySeq EffectivePaySeq { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual RefPayType PayType { get; set; }
    }
}
