using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeePayrollHistory
    {
        public string CompanyLocation { get; set; }
        public string InvoiceNumber { get; set; }
        public string StaffingId { get; set; }
        public DateTime WeekendDate { get; set; }
        public string PayCode { get; set; }
        public decimal PayRate { get; set; }
        public string PaytypeId { get; set; }
        public decimal RegularHour { get; set; }
        public decimal OvertimeHour { get; set; }
        public decimal RegularAmount { get; set; }
        public decimal OvertimeAmount { get; set; }
        public decimal OtherAmount { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Modified { get; set; }
    }
}
