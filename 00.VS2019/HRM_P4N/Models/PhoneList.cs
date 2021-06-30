using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PhoneList
    {
        public PhoneList()
        {
            PersonPhones = new HashSet<PersonPhone>();
        }

        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneTypeId { get; set; }
        public string ExtentionNumber { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string PersonId { get; set; }

        public virtual RefPhoneType PhoneType { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
