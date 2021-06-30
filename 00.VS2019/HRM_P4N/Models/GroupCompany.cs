using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class GroupCompany
    {
        public GroupCompany()
        {
            BranchCompanies = new HashSet<BranchCompany>();
            Departments = new HashSet<Department>();
            GroupCompanyLocations = new HashSet<GroupCompanyLocation>();
            NotificationUserLists = new HashSet<NotificationUserList>();
            Positions = new HashSet<Position>();
            Shifts = new HashSet<Shift>();
            UserGroupCompanies = new HashSet<UserGroupCompany>();
        }

        public int GroupCompanyId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Company GroupCompanyNavigation { get; set; }
        public virtual ICollection<BranchCompany> BranchCompanies { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<GroupCompanyLocation> GroupCompanyLocations { get; set; }
        public virtual ICollection<NotificationUserList> NotificationUserLists { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
        public virtual ICollection<UserGroupCompany> UserGroupCompanies { get; set; }
    }
}
