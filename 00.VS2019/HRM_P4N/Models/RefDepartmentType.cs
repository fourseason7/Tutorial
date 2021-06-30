using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefDepartmentType
    {
        public RefDepartmentType()
        {
            Departments = new HashSet<Department>();
        }

        public int DepartmentTypeId { get; set; }
        public string Code { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
