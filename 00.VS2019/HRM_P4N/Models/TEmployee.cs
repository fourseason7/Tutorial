using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class TEmployee
    {
        public TEmployee()
        {
            TPersonPhones = new HashSet<TPersonPhone>();
        }

        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MaritalStatusTypeId { get; set; }
        public int GenderTypeId { get; set; }
        public string Ssn { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual MartitalStatusType MaritalStatusType { get; set; }
        public virtual ICollection<TPersonPhone> TPersonPhones { get; set; }
    }
}
