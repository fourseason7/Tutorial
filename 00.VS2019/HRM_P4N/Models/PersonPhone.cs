using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PersonPhone
    {
        public string PersonId { get; set; }
        public int PhoneId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Person Person { get; set; }
        public virtual PhoneList Phone { get; set; }
    }
}
