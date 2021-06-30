using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Mbogroup
    {
        public Mbogroup()
        {
            SurveyReviewers = new HashSet<SurveyReviewer>();
        }

        public int MbogroupId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Year { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<SurveyReviewer> SurveyReviewers { get; set; }
    }
}
