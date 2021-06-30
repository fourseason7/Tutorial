using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LeavesOfTheYearAdded
    {
        public string EmployeeId { get; set; }
        public DateTime AllowedDate { get; set; }
        public int LoatypeId { get; set; }
        public short AllowedHour { get; set; }
        public string Remark { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
