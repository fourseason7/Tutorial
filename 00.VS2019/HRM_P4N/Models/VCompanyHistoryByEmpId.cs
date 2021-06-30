using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VCompanyHistoryByEmpId
    {
        public string EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public string Code { get; set; }
        public int? RetiredTypeId { get; set; }
        public bool ActiveFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
    }
}
