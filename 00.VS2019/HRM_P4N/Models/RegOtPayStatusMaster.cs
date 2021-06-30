using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RegOtPayStatusMaster
    {
        public RegOtPayStatusMaster()
        {
            RegOtPayStatusDetails = new HashSet<RegOtPayStatusDetail>();
        }

        public int RegOtreportId { get; set; }
        public int GroupCompanyId { get; set; }
        public string PaySeqId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<RegOtPayStatusDetail> RegOtPayStatusDetails { get; set; }
    }
}
