using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefNetworkType
    {
        public RefNetworkType()
        {
            PersonInsuranceLists = new HashSet<PersonInsuranceList>();
        }

        public int NetworkTypeId { get; set; }
        public string Code { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<PersonInsuranceList> PersonInsuranceLists { get; set; }
    }
}
