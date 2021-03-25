using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC_DynamicMenu.Data
{
    [Table(name: "AspNetRoleMenuPermission")]
    public class RoleMenuPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("ApplicationRole")]
        public string RoleId { get; set; }

        [ForeignKey("NavigationMenu")]
        public Guid NavigationMenuId { get; set; }

        public NavigationMenu NavigationMenu { get; set; }
    }

    [Table(name: "AspNetNavigationMenu")]
    public class NavigationMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("ParentNavigationMenu")]
        public Guid? ParentMenuId { get; set; }

        public virtual NavigationMenu ParentNavigationMenu { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        [NotMapped]
        public bool Permitted { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RoleMenuPermission> RoleMenuPermission { get; set; }

        public DbSet<NavigationMenu> NavigationMenu { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
