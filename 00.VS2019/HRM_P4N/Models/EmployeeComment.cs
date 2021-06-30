using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeeComment
    {
        public int CommentId { get; set; }
        public DateTime RequestDate { get; set; }
        public string EmployeeId { get; set; }
        public int StatusId { get; set; }
        public int CommentTypeId { get; set; }
        public string Remark { get; set; }
        public string RequestId { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefCommentType CommentType { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual RefApprovalStatus Status { get; set; }
    }
}
