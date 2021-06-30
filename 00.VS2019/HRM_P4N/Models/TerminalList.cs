using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class TerminalList
    {
        public int TerminalId { get; set; }
        public string TerminalName { get; set; }
        public string TerminalGroupName { get; set; }
        public DateTime? Created { get; set; }
        public string CreatredBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
