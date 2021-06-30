using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Shift
    {
        public Shift()
        {
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            EmployeeSchedules = new HashSet<EmployeeSchedule>();
            Employees = new HashSet<Employee>();
        }

        public int ShiftId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int GroupCompanyId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string LunchStartTime { get; set; }
        public string LunchEndTime { get; set; }
        public int LunchMin { get; set; }
        public string DinnerStartTime { get; set; }
        public string DinnerEndTime { get; set; }
        public int DinnerMin { get; set; }
        public int RegularMin { get; set; }
        public bool OverNight { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string ShiftId1 { get; set; }

        public virtual GroupCompany GroupCompany { get; set; }
        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
