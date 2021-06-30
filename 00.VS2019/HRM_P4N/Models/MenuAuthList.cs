using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class MenuAuthList
    {
        public MenuAuthList()
        {
            GroupAuthLists = new HashSet<GroupAuthList>();
        }

        public int MenuAuthId { get; set; }
        public int MenuId { get; set; }
        public int AuthTypeId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefAuthType AuthType { get; set; }
        public virtual MenuList Menu { get; set; }
        public virtual ICollection<GroupAuthList> GroupAuthLists { get; set; }
    }
}
