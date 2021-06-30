using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeInsuranceSummary
    {
        public string InsuranceType { get; set; }
        public string Detail { get; set; }
        public string EmployeeId { get; set; }
        public string PersonId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
