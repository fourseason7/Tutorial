using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Employee
    {
        public Employee()
        {
            CompanyHistories = new HashSet<CompanyHistory>();
            DailyAttendances = new HashSet<DailyAttendance>();
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            DepartmentHistories = new HashSet<DepartmentHistory>();
            EmergencyContacts = new HashSet<EmergencyContact>();
            EmployeeAccounts = new HashSet<EmployeeAccount>();
            EmployeeComments = new HashSet<EmployeeComment>();
            EmployeeDocuments = new HashSet<EmployeeDocument>();
            EmployeeLeafApprovals = new HashSet<EmployeeLeaf>();
            EmployeeLeafEmployees = new HashSet<EmployeeLeaf>();
            EmployeePictures = new HashSet<EmployeePicture>();
            EmployeeRefIdhistories = new HashSet<EmployeeRefIdhistory>();
            EmployeeRelationshipLists = new HashSet<EmployeeRelationshipList>();
            EmployeeSchedules = new HashSet<EmployeeSchedule>();
            EmployeeStaffingIds = new HashSet<EmployeeStaffingId>();
            NotificationUserLists = new HashSet<NotificationUserList>();
            PayApplySchedules = new HashSet<PayApplySchedule>();
            PayrollHistories = new HashSet<PayrollHistory>();
            RetroHistories = new HashSet<RetroHistory>();
        }

        public string EmployeeId { get; set; }
        public string PersonId { get; set; }
        public int CompanyId { get; set; }
        public int GrpCompLocId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public int ShiftId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public int? RetiredTypeId { get; set; }
        public decimal PayRate { get; set; }
        public int PayTypeId { get; set; }
        public int AdditionalPayType { get; set; }
        public decimal AdditionalPayAmount { get; set; }
        public decimal AdditionalPayRate { get; set; }
        public decimal BillingPayRate { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual GroupCompanyLocation GrpCompLoc { get; set; }
        public virtual RefPayType PayType { get; set; }
        public virtual Person Person { get; set; }
        public virtual Position Position { get; set; }
        public virtual RefRetiredType RetiredType { get; set; }
        public virtual Section Section { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Mboemployee Mboemployee { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<DailyAttendance> DailyAttendances { get; set; }
        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<DepartmentHistory> DepartmentHistories { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<EmployeeAccount> EmployeeAccounts { get; set; }
        public virtual ICollection<EmployeeComment> EmployeeComments { get; set; }
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
        public virtual ICollection<EmployeeLeaf> EmployeeLeafApprovals { get; set; }
        public virtual ICollection<EmployeeLeaf> EmployeeLeafEmployees { get; set; }
        public virtual ICollection<EmployeePicture> EmployeePictures { get; set; }
        public virtual ICollection<EmployeeRefIdhistory> EmployeeRefIdhistories { get; set; }
        public virtual ICollection<EmployeeRelationshipList> EmployeeRelationshipLists { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual ICollection<EmployeeStaffingId> EmployeeStaffingIds { get; set; }
        public virtual ICollection<NotificationUserList> NotificationUserLists { get; set; }
        public virtual ICollection<PayApplySchedule> PayApplySchedules { get; set; }
        public virtual ICollection<PayrollHistory> PayrollHistories { get; set; }
        public virtual ICollection<RetroHistory> RetroHistories { get; set; }
    }
}
