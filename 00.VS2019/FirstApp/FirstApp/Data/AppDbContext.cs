using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstApp.Models;

namespace FirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstApp.Models.Game> Game { get; set; }
        public DbSet<FirstApp.Models.Movie> Movie { get; set; }
    }
}
