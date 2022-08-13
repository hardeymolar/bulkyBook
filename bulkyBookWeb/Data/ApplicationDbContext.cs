using bulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace bulkyBookWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
    }
}
