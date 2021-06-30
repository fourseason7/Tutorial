using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeDemographic
    {
        public string PersonId { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Citizenship { get; set; }
        public string DriversLicense { get; set; }
        public string Ssn { get; set; }
        public int MaritalStatusTypeId { get; set; }
        public int GenderTypeId { get; set; }
        public int VisaStatusTypeId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryRegionCode { get; set; }
    }
}
