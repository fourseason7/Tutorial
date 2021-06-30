using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeScheduleFull
    {
        public string EmployeeId { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int CompanyId { get; set; }
        public bool AppliedFlag { get; set; }
        public bool ActiveFlag { get; set; }
        public int PositionId { get; set; }
        public int SectionId { get; set; }
        public int ShiftId { get; set; }
        public int GroupCompanyId { get; set; }
        public int LocationId { get; set; }
        public int DepartmentId { get; set; }
        public int GrpCompLocId { get; set; }
        public string Company { get; set; }
        public string GroupCompany { get; set; }
        public string Section { get; set; }
        public string Department { get; set; }
        public string Shift { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string ModifiedBy { get; set; }
    }
}
