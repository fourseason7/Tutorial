using System;
using System.Collections.Generic;

namespace MVC_AW.Models
{
    public partial class MenuMain
    {
        public MenuMain()
        {
            MenuSub = new HashSet<MenuSub>();
        }

        public int Id { get; set; }
        public string MainMenu { get; set; }

        public virtual ICollection<MenuSub> MenuSub { get; set; }
    }
}
