using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class MenuList
    {
        public MenuList()
        {
            MenuAuthLists = new HashSet<MenuAuthList>();
        }

        public int MenuId { get; set; }
        public string Code { get; set; }
        public int? SeqNo { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<MenuAuthList> MenuAuthLists { get; set; }
    }
}
