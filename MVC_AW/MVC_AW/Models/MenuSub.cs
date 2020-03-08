using System;
using System.Collections.Generic;

namespace MVC_AW.Models
{
    public partial class MenuSub
    {
        public int Id { get; set; }
        public string SubMenu { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int? MainMenuId { get; set; }
        public int? RoleId { get; set; }

        public virtual MenuMain MainMenu { get; set; }
        public virtual UserRoles Role { get; set; }
    }
}
