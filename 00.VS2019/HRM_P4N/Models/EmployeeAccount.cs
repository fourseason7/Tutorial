using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeeAccount
    {
        public int EmployeeAccountId { get; set; }
        public string EmployeeId { get; set; }
        public int BankId { get; set; }
        public int BankTypeId { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefBank Bank { get; set; }
        public virtual RefBankType BankType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
