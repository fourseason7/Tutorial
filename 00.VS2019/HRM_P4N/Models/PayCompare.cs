using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PayCompare
    {
        public string EmpId { get; set; }
        public string AltEmpId { get; set; }
        public decimal? PayRate { get; set; }
        public decimal? RegHours { get; set; }
        public decimal? RegWages { get; set; }
        public decimal? OvtRate { get; set; }
        public decimal? OvtHours { get; set; }
        public decimal? OvtWages { get; set; }
        public decimal? Gross { get; set; }
        public decimal? Fee { get; set; }
        public decimal? Total { get; set; }
    }
}
