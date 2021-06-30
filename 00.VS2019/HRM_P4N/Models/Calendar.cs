using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Calendar
    {
        public Calendar()
        {
            LeavesOfAbsences = new HashSet<LeavesOfAbsence>();
        }

        public DateTime WorkDate { get; set; }
        public byte CalendarDay { get; set; }
        public byte WorkDay { get; set; }
        public byte HolidayFlag { get; set; }
        public byte PayFlag { get; set; }
        public string PaySeqId { get; set; }
        public string Remark { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<LeavesOfAbsence> LeavesOfAbsences { get; set; }
    }
}
