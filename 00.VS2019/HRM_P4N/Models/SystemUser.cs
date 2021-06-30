using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class SystemUser
    {
        public SystemUser()
        {
            GroupUserLists = new HashSet<GroupUserList>();
            MultipleBranchsAuthListInsteadGroupIds = new HashSet<MultipleBranchsAuthListInsteadGroupId>();
            UserGroupCompanies = new HashSet<UserGroupCompany>();
            UserPasswords = new HashSet<UserPassword>();
        }

        public int SystemUserListId { get; set; }
        public string UserId { get; set; }
        public string EmployeeId { get; set; }
        public bool AllDepartmentAuth { get; set; }
        public bool Customer { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<GroupUserList> GroupUserLists { get; set; }
        public virtual ICollection<MultipleBranchsAuthListInsteadGroupId> MultipleBranchsAuthListInsteadGroupIds { get; set; }
        public virtual ICollection<UserGroupCompany> UserGroupCompanies { get; set; }
        public virtual ICollection<UserPassword> UserPasswords { get; set; }
    }
}
