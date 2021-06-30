using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            AddresseLists = new HashSet<AddresseList>();
            People = new HashSet<Person>();
        }

        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public bool ActiveFlag { get; set; }
        public bool DefaultFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<AddresseList> AddresseLists { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
