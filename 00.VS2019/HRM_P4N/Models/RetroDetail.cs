using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RetroDetail
    {
        public int RetroDetailId { get; set; }
        public int RetroId { get; set; }
        public int CompanyId { get; set; }
        public string PaySeqId { get; set; }
        public decimal RetroAmount { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CompanyPaySeq CompanyPaySeq { get; set; }
        public virtual RetroHistory Retro { get; set; }
    }
}
