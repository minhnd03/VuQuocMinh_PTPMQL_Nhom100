using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Bảng Person trong CSDL
        public DbSet<Person> Persons { get; set; }
    }
}
