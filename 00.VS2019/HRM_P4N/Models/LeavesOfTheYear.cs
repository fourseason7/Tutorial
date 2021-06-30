using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LeavesOfTheYear
    {
        public string EmployeeId { get; set; }
        public string Year { get; set; }
        public int LoatypeId { get; set; }
        public short AllowedHour { get; set; }
        public short RollOverHour { get; set; }
        public short TotalHour { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefLeavesOfAbsence Loatype { get; set; }
    }
}
