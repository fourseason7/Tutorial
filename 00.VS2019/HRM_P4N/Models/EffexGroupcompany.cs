using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EffexGroupcompany
    {
        public int CompanyLocationId { get; set; }
        public int? CompanyLocationIdCve { get; set; }
        public string Code { get; set; }
        public bool ActiveFlag { get; set; }
        public bool InvoiceActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
