using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class BuildVersion
    {
        public int VersionMajor { get; set; }
        public int VersionMinor { get; set; }
        public int VersionBuild { get; set; }
        public int VersionRevision { get; set; }
        public string HostName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedId { get; set; }
    }
}
