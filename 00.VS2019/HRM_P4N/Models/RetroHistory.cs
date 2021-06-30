using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RetroHistory
    {
        public RetroHistory()
        {
            RetroDetails = new HashSet<RetroDetail>();
        }

        public int RetroId { get; set; }
        public string EmployeeId { get; set; }
        public string ReqPaySeqId { get; set; }
        public int RetroTypeId { get; set; }
        public decimal? TotalHour { get; set; }
        public decimal TotalAmount { get; set; }
        public string Remark { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual RetroType RetroType { get; set; }
        public virtual ICollection<RetroDetail> RetroDetails { get; set; }
    }
}
