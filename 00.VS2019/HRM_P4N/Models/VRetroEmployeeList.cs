using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VRetroEmployeeList
    {
        public int RetroId { get; set; }
        public string EmployeeId { get; set; }
        public string ReqPaySeqId { get; set; }
        public int RetroDetailId { get; set; }
        public int CompanyId { get; set; }
        public string PaySeqId { get; set; }
        public int RetroTypeId { get; set; }
        public string Code { get; set; }
        public decimal? TotalHour { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RetroAmount { get; set; }
        public string Remark { get; set; }
        public bool PaidFlag { get; set; }
        public DateTime SeqStart { get; set; }
        public DateTime SeqEnd { get; set; }
    }
}
