using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeDailyAttendance
    {
        public int CompanyId { get; set; }
        public int GroupCompanyId { get; set; }
        public int LocationId { get; set; }
        public int GrpCompLocId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public string EmployeeId { get; set; }
        public string StaffingId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public string GroupCompany { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string Position { get; set; }
        public string ShiftTime { get; set; }
        public decimal PayRate { get; set; }
        public decimal BillingPayRate { get; set; }
        public decimal? MarkupRate { get; set; }
        public string WorkDate { get; set; }
        public string DaysOfWeek { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? WorkMin { get; set; }
        public decimal? WorkHour { get; set; }
    }
}
