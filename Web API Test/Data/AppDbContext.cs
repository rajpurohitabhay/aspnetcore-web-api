using Microsoft.EntityFrameworkCore;
using Web_API_Test.Data.Models;

namespace Web_API_Test.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
