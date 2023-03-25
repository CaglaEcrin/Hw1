using Microsoft.EntityFrameworkCore;

namespace Hw1
{
    public class AuthorDataContext : DbContext
    {
        public DbSet<Author> Author { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-COM2R56\\SQLEXPRESS;Database = AuthorsDb; Trusted_Connection=True;");
        }

    }
}
