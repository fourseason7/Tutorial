//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicMenyBind.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuMain
    {
        public MenuMain()
        {
            this.MenuSubs = new HashSet<MenuSub>();
        }
    
        public int Id { get; set; }
        public string MainMenu { get; set; }
    
        public virtual ICollection<MenuSub> MenuSubs { get; set; }
    }
}
