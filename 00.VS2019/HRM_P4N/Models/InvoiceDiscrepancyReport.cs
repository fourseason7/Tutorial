using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class InvoiceDiscrepancyReport
    {
        public DateTime SearchDate { get; set; }
        public int InvoiceId { get; set; }
        public string EmployeeId { get; set; }
        public string StaffingId { get; set; }
        public string AltEmpId { get; set; }
        public decimal CvepayRate { get; set; }
        public double? EffexPayRate { get; set; }
        public string PayrateDiff { get; set; }
        public double? CvetotalHr { get; set; }
        public double? EffexTotalHr { get; set; }
        public double? HrDiff { get; set; }
        public double? Cvegross { get; set; }
        public double? EffexGross { get; set; }
        public double? Cvefee { get; set; }
        public double? EffexFee { get; set; }
        public double? Cvetotal { get; set; }
        public string EffexTotal { get; set; }
        public DateTime? TotalDiff { get; set; }
        public string Reason { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
