using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class ApplicationForm
    {
        public ApplicationForm()
        {
            LogFormUsages = new HashSet<LogFormUsage>();
            RightForms = new HashSet<RightForm>();
            SubApplicationForms = new HashSet<SubApplicationForm>();
        }

        public int FormId { get; set; }
        public string FormName { get; set; }
        public string CaptionName { get; set; }
        public string ControlName { get; set; }
        public bool? ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<LogFormUsage> LogFormUsages { get; set; }
        public virtual ICollection<RightForm> RightForms { get; set; }
        public virtual ICollection<SubApplicationForm> SubApplicationForms { get; set; }
    }
}
