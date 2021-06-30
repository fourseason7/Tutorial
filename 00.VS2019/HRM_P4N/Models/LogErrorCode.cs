using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class LogErrorCode
    {
        public int ErroLogId { get; set; }
        public string WindowName { get; set; }
        public string MethodName { get; set; }
        public string ErrorMessage { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
    }
}
