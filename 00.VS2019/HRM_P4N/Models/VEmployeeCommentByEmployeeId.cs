using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class VEmployeeCommentByEmployeeId
    {
        public string CommentType { get; set; }
        public DateTime RequestDate { get; set; }
        public string Remark { get; set; }
        public string EmployeeId { get; set; }
        public int CommentId { get; set; }
        public int StatusId { get; set; }
        public int CommentTypeId { get; set; }
    }
}
