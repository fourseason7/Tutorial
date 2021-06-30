using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VCompanyPaySeq
    {
        public int CompanyId { get; set; }
        public string PaySeqId { get; set; }
        public bool PaidFlag { get; set; }
        public DateTime SeqStart { get; set; }
        public DateTime SeqEnd { get; set; }
        public DateTime? PayDate { get; set; }
        public string PayYear { get; set; }
    }
}
