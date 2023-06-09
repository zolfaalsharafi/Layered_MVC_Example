using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Example.Models;

namespace MVC_Example.Data
{
    public class MVC_ExampleContext : DbContext
    {
        public MVC_ExampleContext (DbContextOptions<MVC_ExampleContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Example.Models.User> User { get; set; } = default!;

        public DbSet<MVC_Example.Models.Product> Product { get; set; } = default!;

        public DbSet<MVC_Example.Models.Category> Categories { get; set; } = default!;
    }
}
