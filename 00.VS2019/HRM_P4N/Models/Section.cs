using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Section
    {
        public Section()
        {
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            EmployeeSchedules = new HashSet<EmployeeSchedule>();
            Employees = new HashSet<Employee>();
        }

        public int SectionId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string SectionId1 { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
