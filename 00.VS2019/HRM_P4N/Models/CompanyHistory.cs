using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class CompanyHistory
    {
        public string EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public int? RetiredTypeId { get; set; }
        public string Remark { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual RefRetiredType RetiredType { get; set; }
    }
}
