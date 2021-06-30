using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RegOtPayStatusDetail
    {
        public int RegOtreportId { get; set; }
        public int CompanyId { get; set; }
        public int SectionId { get; set; }
        public int NumEe { get; set; }
        public double RegHr { get; set; }
        public double Othr { get; set; }
        public double OtHrRatio { get; set; }
        public double TotalHr { get; set; }
        public double RegAmt { get; set; }
        public double Otamt { get; set; }
        public double OtpaidRatio { get; set; }
        public double Gross { get; set; }
        public double StaffingFee { get; set; }
        public double TotalPaid { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RegOtPayStatusMaster RegOtreport { get; set; }
    }
}
