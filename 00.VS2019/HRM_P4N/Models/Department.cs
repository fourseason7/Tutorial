using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Department
    {
        public Department()
        {
            DepartmentHistories = new HashSet<DepartmentHistory>();
            Sections = new HashSet<Section>();
        }

        public int DepartmentId { get; set; }
        public int GroupCompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int DepartmentTypeId { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string DepartmentId1 { get; set; }

        public virtual RefDepartmentType DepartmentType { get; set; }
        public virtual GroupCompany GroupCompany { get; set; }
        public virtual ICollection<DepartmentHistory> DepartmentHistories { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
