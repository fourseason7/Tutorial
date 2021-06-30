using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class DailyAttendanceLog
    {
        public DateTime WorkDate { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? PunchIn { get; set; }
        public DateTime? PunchOut { get; set; }
        public DateTime? ConfirmIn { get; set; }
        public DateTime? ConfirmOut { get; set; }
        public int? MealMinLunch { get; set; }
        public int? MealMinDinner { get; set; }
        public int? WorkMin { get; set; }
        public int? ExceptionTypeId { get; set; }
        public int? WarningTypeId { get; set; }
        public bool? WarningYn { get; set; }
        public string CreateLocation { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string Comments { get; set; }
        public int? TerminalId { get; set; }
        public string Flag { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
