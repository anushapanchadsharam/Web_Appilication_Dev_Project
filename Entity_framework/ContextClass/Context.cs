using Microsoft.EntityFrameworkCore;
using A_1_3690.Models;

namespace A_1_3690.ContextClass
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; 
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Cart> Order { get; set; }
        public DbSet<A_1_3690.Models.Category> Category { get; set; }



    }
}
