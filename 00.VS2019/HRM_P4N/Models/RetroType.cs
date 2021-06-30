using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RetroType
    {
        public RetroType()
        {
            RetroHistories = new HashSet<RetroHistory>();
        }

        public int RetroTypeId { get; set; }
        public string Code { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<RetroHistory> RetroHistories { get; set; }
    }
}
