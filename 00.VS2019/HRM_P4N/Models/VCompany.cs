using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VCompany
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyTypeId { get; set; }
        public string CompanyTypeCode { get; set; }
        public int PayPeriodTypeId { get; set; }
        public string CompanyPayTypeCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? TerminateDate { get; set; }
        public bool CompanyActiveFlag { get; set; }
        public bool CompanyTypeActiveFlag { get; set; }
        public bool PayPeriodActiveFlag { get; set; }
    }
}
