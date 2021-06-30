using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VAttendanceByEmpId
    {
        public DateTime WorkDate { get; set; }
        public DateTime PunchIn { get; set; }
        public DateTime? PunchOut { get; set; }
        public DateTime? ConfirmIn { get; set; }
        public DateTime? ConfirmOut { get; set; }
        public int? MealMin { get; set; }
        public int? WorkMin { get; set; }
        public double TotalHour { get; set; }
        public string CreateLocation { get; set; }
        public string EmployeeId { get; set; }
        public int? ExceptionTypeId { get; set; }
    }
}
