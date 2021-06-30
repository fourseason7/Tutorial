using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VPayApplyScheduleHourly
    {
        public string EmployeeId { get; set; }
        public string EffectivePaySeqId { get; set; }
        public string ExpiredPaySeqId { get; set; }
        public decimal PayRate { get; set; }
        public int PayTypeId { get; set; }
        public string Code { get; set; }
        public decimal OvertimeRatio { get; set; }
        public bool ActiveFlag { get; set; }
        public bool AppliedFlag { get; set; }
        public DateTime SeqStart { get; set; }
        public DateTime SeqEnd { get; set; }
        public DateTime Modified { get; set; }
        public int AdditionalPayType { get; set; }
        public decimal AdditionalPayAmount { get; set; }
        public decimal AdditionalPayRate { get; set; }
        public decimal? BillingPayRate { get; set; }
    }
}
