using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Survey
    {
        public Survey()
        {
            Questions = new HashSet<Question>();
        }

        public int SurveyId { get; set; }
        public int CompanyId { get; set; }
        public string Year { get; set; }
        public string Eva1 { get; set; }
        public string Eva2 { get; set; }
        public string Eva3 { get; set; }
        public string HostName { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
