using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeListforAme
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? RetireDate { get; set; }
    }
}
