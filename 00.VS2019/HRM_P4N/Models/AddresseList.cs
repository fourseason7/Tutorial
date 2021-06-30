using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class AddresseList
    {
        public AddresseList()
        {
            LocationAddresses = new HashSet<LocationAddress>();
            PersonAddresses = new HashSet<PersonAddress>();
        }

        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceId { get; set; }
        public string CountryRegionCode { get; set; }
        public string PostalCode { get; set; }
        public int AddressTypeId { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string PersonId { get; set; }

        public virtual RefAddress AddressType { get; set; }
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
