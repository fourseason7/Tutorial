using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefVisaStatus
    {
        public RefVisaStatus()
        {
            People = new HashSet<Person>();
        }

        public int VisaStatusTypeId { get; set; }
        public string Code { get; set; }
        public bool DefaultFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
