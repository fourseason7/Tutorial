using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeBank
    {
        public string EmployeeId { get; set; }
        public int EmployeeAccountId { get; set; }
        public int BankId { get; set; }
        public int BankTypeId { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string BankName { get; set; }
        public string BankType { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
