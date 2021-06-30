using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VSection
    {
        public int SectionId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool ActiveFlag { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string SectionId1 { get; set; }
    }
}
