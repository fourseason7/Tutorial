﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class SurveyReviewer
    {
        public int MbogroupId { get; set; }
        public string EmployeeId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual Mbogroup Mbogroup { get; set; }
    }
}
