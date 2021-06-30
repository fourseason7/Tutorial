using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class NotificationUserList
    {
        public int GroupCompanyId { get; set; }
        public string EmployeeId { get; set; }
        public int NotificationId { get; set; }
        public bool ActiveFalg { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual GroupCompany GroupCompany { get; set; }
        public virtual NotificationList Notification { get; set; }
    }
}
