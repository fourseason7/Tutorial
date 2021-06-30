using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LogDailyAttendance
    {
        public string WorkDate { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? PunchIn { get; set; }
        public DateTime? PunchOut { get; set; }
        public string ConfirmIn { get; set; }
        public string ConfirmOut { get; set; }
        public int? WorkMin { get; set; }
        public int? ExceptionTypeId { get; set; }
        public DateTime? PunchInChanged { get; set; }
        public DateTime? PunchOutChanged { get; set; }
        public string ConfirmInChanged { get; set; }
        public string ConfirmOutChanged { get; set; }
        public int? WorkMinChanged { get; set; }
        public int? ExceptionTypeIdchanged { get; set; }
        public string ChangeFlag { get; set; }
        public string Remark { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
