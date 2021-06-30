using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VDailyStatusLogFull
    {
        public DateTime WorkDate { get; set; }
        public string EmployeeId { get; set; }
        public decimal PayRate { get; set; }
        public int PayTypeId { get; set; }
        public int CompanyId { get; set; }
        public int GrpCompLocId { get; set; }
        public int LocationId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public int ShiftId { get; set; }
        public int MealMin { get; set; }
        public int WorkMin { get; set; }
        public int LeavesMin { get; set; }
        public string Department { get; set; }
        public string Shift { get; set; }
        public string Section { get; set; }
        public int DepartmentId { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string GroupCompany { get; set; }
        public string Location { get; set; }
        public int GroupCompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
