using AspnetNote.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetNote.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=localhost;Initial Catalog=NorthWind;Persist Security Info=True;User ID=sa;Password=***********
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;User Id=sa;Password = kkh19797;");
        }

    }
}
