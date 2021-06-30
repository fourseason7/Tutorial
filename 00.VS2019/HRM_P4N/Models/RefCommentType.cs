using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefCommentType
    {
        public RefCommentType()
        {
            EmployeeComments = new HashSet<EmployeeComment>();
        }

        public int CommentTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<EmployeeComment> EmployeeComments { get; set; }
    }
}
