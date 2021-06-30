using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class NgacAuthlog
    {
        public long IndexKey { get; set; }
        public long? UserIdindex { get; set; }
        public DateTime? TransactionTime { get; set; }
        public string UserId { get; set; }
        public int TerminalId { get; set; }
        public int? AuthType { get; set; }
        public int? AuthResult { get; set; }
        public int? FunctionKey { get; set; }
        public DateTime? ServerRecordTime { get; set; }
        public int? Reserved { get; set; }
        public int? LogType { get; set; }
        public int? TempValue { get; set; }
        public int? MinIndex { get; set; }
        public DateTime? TransDateTime { get; set; }
        public bool? DeleteFlag { get; set; }
        public string HostName { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
    }
}
