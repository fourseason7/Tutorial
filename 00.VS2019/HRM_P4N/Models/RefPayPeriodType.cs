using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefPayPeriodType
    {
        public RefPayPeriodType()
        {
            Companies = new HashSet<Company>();
            PaySeqs = new HashSet<PaySeq>();
        }

        public int PayPeriodTypeId { get; set; }
        public string Code { get; set; }
        public bool? ActiveFlag { get; set; }
        public decimal? WorkHourReg { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<PaySeq> PaySeqs { get; set; }
    }
}
