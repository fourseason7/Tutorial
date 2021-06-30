using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmailList
    {
        public EmailList()
        {
            PersonEmails = new HashSet<PersonEmail>();
        }

        public int EmailId { get; set; }
        public string Email { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<PersonEmail> PersonEmails { get; set; }
    }
}
