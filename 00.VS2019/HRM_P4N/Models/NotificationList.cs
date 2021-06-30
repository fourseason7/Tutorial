using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class NotificationList
    {
        public NotificationList()
        {
            NotificationUserLists = new HashSet<NotificationUserList>();
        }

        public int NotificationId { get; set; }
        public string NotificationName { get; set; }
        public string Description { get; set; }
        public bool ActiveFalg { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<NotificationUserList> NotificationUserLists { get; set; }
    }
}
