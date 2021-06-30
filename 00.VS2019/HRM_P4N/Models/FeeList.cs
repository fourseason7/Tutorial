using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class FeeList
    {
        public int CompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public bool? MarkupType { get; set; }
        public decimal MarkupFee { get; set; }
        public decimal MarkUpFeeOt { get; set; }
        public decimal MarkUpFeeAmt { get; set; }
        public decimal MarkUpFeeOtamt { get; set; }
        public DateTime? EndDate { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
