using Microsoft.EntityFrameworkCore;
using A_1_3690.Models;

namespace A_1_3690.ContextClass
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Catagories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<A_1_3690.Models.Category> Category { get; set; }



    }
}
