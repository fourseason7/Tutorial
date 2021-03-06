﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class MinWage
    {
        public int WageId { get; set; }
        public int GroupCompanyId { get; set; }
        public int PayTypeId { get; set; }
        public decimal Wage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
