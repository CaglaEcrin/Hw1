using Microsoft.EntityFrameworkCore;

namespace Hw1
{
    public class BookDataContext : DbContext
    {
        public DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-COM2R56\\SQLEXPRESS;Database = BooksDb; Trusted_Connection=True;");
        }
    }
}
