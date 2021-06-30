using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class RefRelationshipType
    {
        public RefRelationshipType()
        {
            EmergencyContacts = new HashSet<EmergencyContact>();
            EmployeeRelationshipLists = new HashSet<EmployeeRelationshipList>();
        }

        public int RelationshipTypeId { get; set; }
        public string Code { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<EmployeeRelationshipList> EmployeeRelationshipLists { get; set; }
    }
}
