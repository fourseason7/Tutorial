using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VImage
    {
        public string EmployeeId { get; set; }
        public int ImageTypeId { get; set; }
        public string ImageText { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
