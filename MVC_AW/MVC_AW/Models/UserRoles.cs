using System;
using System.Collections.Generic;

namespace MVC_AW.Models
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            MenuSub = new HashSet<MenuSub>();
            UserLists = new HashSet<UserLists>();
        }

        public int Id { get; set; }
        public string Roles { get; set; }

        public virtual ICollection<MenuSub> MenuSub { get; set; }
        public virtual ICollection<UserLists> UserLists { get; set; }
    }
}
