using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeeSchedule
    {
        public string EmployeeId { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string ReferenceNo { get; set; }
        public int CompanyId { get; set; }
        public int GrpCompLocId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public int ShiftId { get; set; }
        public int? FormId { get; set; }
        public bool AppliedFlag { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual GroupCompanyLocation GrpCompLoc { get; set; }
        public virtual Section Section { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
