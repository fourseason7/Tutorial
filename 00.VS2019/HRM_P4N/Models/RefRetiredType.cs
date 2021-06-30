using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefRetiredType
    {
        public RefRetiredType()
        {
            CompanyHistories = new HashSet<CompanyHistory>();
            Employees = new HashSet<Employee>();
        }

        public int RetiredTypeId { get; set; }
        public string Code { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
