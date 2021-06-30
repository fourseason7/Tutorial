using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Person
    {
        public Person()
        {
            EmergencyContacts = new HashSet<EmergencyContact>();
            EmployeeRelationshipLists = new HashSet<EmployeeRelationshipList>();
            Employees = new HashSet<Employee>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonEmails = new HashSet<PersonEmail>();
            PersonInsuranceLists = new HashSet<PersonInsuranceList>();
            PersonPhones = new HashSet<PersonPhone>();
            PersonPictures = new HashSet<PersonPicture>();
            StaffingUsers = new HashSet<StaffingUser>();
        }

        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MaritalStatusTypeId { get; set; }
        public string CountryRegionCode { get; set; }
        public int GenderTypeId { get; set; }
        public int VisaStatusTypeId { get; set; }
        public string DriversLicense { get; set; }
        public string Ssn { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string EmployeeId { get; set; }

        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
        public virtual RefGenderType GenderType { get; set; }
        public virtual MaritalStatusType MaritalStatusType { get; set; }
        public virtual RefVisaStatus VisaStatusType { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<EmployeeRelationshipList> EmployeeRelationshipLists { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        public virtual ICollection<PersonEmail> PersonEmails { get; set; }
        public virtual ICollection<PersonInsuranceList> PersonInsuranceLists { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
        public virtual ICollection<PersonPicture> PersonPictures { get; set; }
        public virtual ICollection<StaffingUser> StaffingUsers { get; set; }
    }
}
