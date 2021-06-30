using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public string StaffingId { get; set; }
        public string AltEmpId { get; set; }
        public double PayRate { get; set; }
        public double RegHours { get; set; }
        public double RegWages { get; set; }
        public double OvtRate { get; set; }
        public double OvtHours { get; set; }
        public double OvtWages { get; set; }
        public double Gross { get; set; }
        public double Fee { get; set; }
        public double Total { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
