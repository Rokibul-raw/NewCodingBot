using Microsoft.EntityFrameworkCore;
using MyProjectAp.Models;

namespace MyProjectAp.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Catagory> catagories { get; set; }
    }
}
