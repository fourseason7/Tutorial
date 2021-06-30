using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeePicture
    {
        public string EmployeeId { get; set; }
        public int ImageId { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ImageList Image { get; set; }
    }
}
