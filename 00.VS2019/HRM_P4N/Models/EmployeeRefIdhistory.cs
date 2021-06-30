using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeeRefIdhistory
    {
        public string EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
        public int CompanyId { get; set; }
        public string RefEmployeeId { get; set; }
        public string IsStaffing { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
