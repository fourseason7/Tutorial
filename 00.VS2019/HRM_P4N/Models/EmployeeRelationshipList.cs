using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class EmployeeRelationshipList
    {
        public string EmployeeId { get; set; }
        public string PersonId { get; set; }
        public int RelationshipTypeId { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Person Person { get; set; }
        public virtual RefRelationshipType RelationshipType { get; set; }
    }
}
