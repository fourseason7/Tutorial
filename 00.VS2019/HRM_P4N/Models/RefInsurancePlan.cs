using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefInsurancePlan
    {
        public RefInsurancePlan()
        {
            PersonInsuranceLists = new HashSet<PersonInsuranceList>();
        }

        public int InsurancePlanId { get; set; }
        public string Code { get; set; }
        public int InsuranceTypeId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefInsuranceCompany InsuranceCompany { get; set; }
        public virtual RefInsuranceType InsuranceType { get; set; }
        public virtual ICollection<PersonInsuranceList> PersonInsuranceLists { get; set; }
    }
}
