using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Location
    {
        public Location()
        {
            GroupCompanyLocations = new HashSet<GroupCompanyLocation>();
            LocationAddresses = new HashSet<LocationAddress>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<GroupCompanyLocation> GroupCompanyLocations { get; set; }
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
    }
}
