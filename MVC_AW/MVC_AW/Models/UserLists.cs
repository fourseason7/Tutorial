using System;
using System.Collections.Generic;

namespace MVC_AW.Models
{
    public partial class UserLists
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public bool? IsActive { get; set; }
        public int? RoleId { get; set; }

        public virtual UserRoles Role { get; set; }
    }
}
