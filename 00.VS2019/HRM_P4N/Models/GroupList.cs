using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class GroupList
    {
        public GroupList()
        {
            GroupAuthLists = new HashSet<GroupAuthList>();
            GroupUserLists = new HashSet<GroupUserList>();
        }

        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<GroupAuthList> GroupAuthLists { get; set; }
        public virtual ICollection<GroupUserList> GroupUserLists { get; set; }
    }
}
