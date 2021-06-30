using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeDetail
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Citizenship { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string DriversLicense { get; set; }
        public string Ssn { get; set; }
        public string Nationality { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public string TerminatedReason { get; set; }
        public string Status { get; set; }
        public int? LengthService { get; set; }
        public decimal PayRate { get; set; }
        public string PayType { get; set; }
    }
}
