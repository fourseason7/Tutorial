using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class TPersonPhone
    {
        public string EmployeeId { get; set; }
        public string PhoneNumber { get; set; }
        public int? PhoneTypeId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual TEmployee Employee { get; set; }
        public virtual TPhoneType PhoneType { get; set; }
    }
}
