using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Position
    {
        public Position()
        {
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            Employees = new HashSet<Employee>();
        }

        public int PositionId { get; set; }
        public int GroupCompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string PositionId1 { get; set; }

        public virtual GroupCompany GroupCompany { get; set; }
        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
