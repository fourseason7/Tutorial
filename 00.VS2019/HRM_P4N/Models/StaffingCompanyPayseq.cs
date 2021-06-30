using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class StaffingCompanyPayseq
    {
        public StaffingCompanyPayseq()
        {
            InvoiceMasters = new HashSet<InvoiceMaster>();
        }

        public int CompanyId { get; set; }
        public string PaySeqId { get; set; }
        public int GroupCompanyId { get; set; }
        public bool PaidFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<InvoiceMaster> InvoiceMasters { get; set; }
    }
}
