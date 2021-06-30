using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeFull
    {
        public string EmployeeId { get; set; }
        public string PersonId { get; set; }
        public int CompanyId { get; set; }
        public int GroupCompanyId { get; set; }
        public int LocationId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public int ShiftId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public int? RetiredTypeId { get; set; }
        public decimal PayRate { get; set; }
        public int PayTypeId { get; set; }
        public bool GrpLocActiveFlag { get; set; }
        public bool DeptSectActiveFalg { get; set; }
        public int AdditionalPayType { get; set; }
        public decimal AdditionalPayAmount { get; set; }
        public decimal AdditionalPayRate { get; set; }
        public decimal? BillingPayRate { get; set; }
    }
}
