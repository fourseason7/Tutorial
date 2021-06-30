using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VLocation
    {
        public int LocationId { get; set; }
        public int? AddressId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool LocationActiveFlag { get; set; }
        public bool? LocationAddressActiveFlag { get; set; }
    }
}
