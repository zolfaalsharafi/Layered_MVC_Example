using Microsoft.EntityFrameworkCore;
using MVC_Example.DataAccessLayer.Models;

namespace MVC_Example.DataAccessLayer.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;

        public DbSet<Product> Product { get; set; } = default!;

        public DbSet<Category> Categories { get; set; } = default!;

        public DbSet<Country> Countries { get; set; } = default!;
    }
}
