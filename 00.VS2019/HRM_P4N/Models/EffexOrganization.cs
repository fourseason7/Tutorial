using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EffexOrganization
    {
        public string OrganizationId { get; set; }
        public int CompanyLocation { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public int? SectionId { get; set; }
        public string DepartmentCve { get; set; }
        public string SectionCve { get; set; }
        public int? SectionIdCve { get; set; }
        public bool ActiveFlag { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
