﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class MboemployeeHistory
    {
        public string EmployeeId { get; set; }
        public string Year { get; set; }
        public bool? CompleteFlag1 { get; set; }
        public string Manager1 { get; set; }
        public bool? CompleteFlag2 { get; set; }
        public string Manager2 { get; set; }
        public bool? CompleteFlag3 { get; set; }
        public string Manager3 { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}