using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class StaffingDailyAttendanceLog
    {
        public DateTime LogDate { get; set; }
        public string ActionFlag { get; set; }
        public int CompanyId { get; set; }
        public string CompanyLocation { get; set; }
        public DateTime WorkDate { get; set; }
        public string StaffingId { get; set; }
        public int Count { get; set; }
        public DateTime PunchIn { get; set; }
        public DateTime? PunchOut { get; set; }
        public DateTime? RoundIn { get; set; }
        public DateTime? RoundOut { get; set; }
        public int? MealMin { get; set; }
        public string CreateLocation { get; set; }
        public DateTime StaffingModified { get; set; }
        public string Flag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
