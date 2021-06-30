using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class DailyStatusLog
    {
        public DateTime WorkDate { get; set; }
        public string EmployeeId { get; set; }
        public decimal PayRate { get; set; }
        public decimal BillingPayRate { get; set; }
        public int PayTypeId { get; set; }
        public int CompanyId { get; set; }
        public int GrpCompLocId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public int ShiftId { get; set; }
        public int MealMin { get; set; }
        public int WorkMin { get; set; }
        public int LeavesMin { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual GroupCompanyLocation GrpCompLoc { get; set; }
        public virtual RefPayType PayType { get; set; }
        public virtual Position Position { get; set; }
        public virtual Section Section { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
