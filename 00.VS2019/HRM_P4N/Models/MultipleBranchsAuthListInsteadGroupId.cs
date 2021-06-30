using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class MultipleBranchsAuthListInsteadGroupId
    {
        public int SystemUserListId { get; set; }
        public int GroupCompanyId { get; set; }
        public int MenuAuthId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual SystemUser SystemUserList { get; set; }
    }
}
