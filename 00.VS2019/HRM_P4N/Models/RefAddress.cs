using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefAddress
    {
        public RefAddress()
        {
            AddresseLists = new HashSet<AddresseList>();
        }

        public int AddressTypeId { get; set; }
        public string Code { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<AddresseList> AddresseLists { get; set; }
    }
}
