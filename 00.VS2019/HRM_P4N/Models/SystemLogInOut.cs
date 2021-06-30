using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class SystemLogInOut
    {
        public string SystemUserId { get; set; }
        public string LogInOut { get; set; }
        public string VersionMajor { get; set; }
        public string VersionMinor { get; set; }
        public string VersionBuild { get; set; }
        public string VersionRevision { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
