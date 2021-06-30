using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class GroupCompanyLocation
    {
        public GroupCompanyLocation()
        {
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            EmployeeSchedules = new HashSet<EmployeeSchedule>();
            Employees = new HashSet<Employee>();
        }

        public int GrpCompLocId { get; set; }
        public int GroupCompanyId { get; set; }
        public int LocationId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual GroupCompany GroupCompany { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
