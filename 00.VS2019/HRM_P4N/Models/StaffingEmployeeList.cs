using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class StaffingEmployeeList
    {
        public int CompanyId { get; set; }
        public string StaffingId { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsRehired { get; set; }
        public DateTime? TermDate { get; set; }
        public string CompanyLocation { get; set; }
        public int? SectionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public decimal PayRate { get; set; }
        public string PayTypeName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneCell { get; set; }
        public string Email { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string EmergencyPhone { get; set; }
        public DateTime StaffingModified { get; set; }
        public string Flag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
