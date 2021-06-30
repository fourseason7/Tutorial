using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class SubApplicationForm
    {
        public SubApplicationForm()
        {
            RightSubForms = new HashSet<RightSubForm>();
        }

        public int SubFormId { get; set; }
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

        public virtual ApplicationForm Form { get; set; }
        public virtual ICollection<RightSubForm> RightSubForms { get; set; }
    }
}
