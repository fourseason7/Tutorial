using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class PersonInsuranceList
    {
        public int InsuranceListId { get; set; }
        public string PersonId { get; set; }
        public int InsurancePlanId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string GroupNumber { get; set; }
        public int NetworkTypeId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefInsurancePlan InsurancePlan { get; set; }
        public virtual RefNetworkType NetworkType { get; set; }
        public virtual Person Person { get; set; }
    }
}
