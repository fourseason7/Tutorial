using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LeavesPolicy
    {
        public short ServiceYear { get; set; }
        public int LoatypeId { get; set; }
        public int PayTypeId { get; set; }
        public int AllowedDays { get; set; }
        public int? MaximumDays { get; set; }
        public string Remark { get; set; }
        public bool ActiveFlag { get; set; }
        public int Version { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefLeavesOfAbsence Loatype { get; set; }
        public virtual RefPayType PayType { get; set; }
    }
}
