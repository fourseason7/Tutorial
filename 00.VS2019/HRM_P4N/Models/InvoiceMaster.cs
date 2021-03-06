﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class InvoiceMaster
    {
        public int InvoiceId { get; set; }
        public string StaffingInvoiceId { get; set; }
        public int GroupCompanyId { get; set; }
        public int CompanyId { get; set; }
        public string PaySeqId { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual StaffingCompanyPayseq StaffingCompanyPayseq { get; set; }
    }
}
