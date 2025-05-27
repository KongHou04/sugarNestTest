using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure
{
    public class MyShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MyShopDbContext(DbContextOptions<MyShopDbContext> options) : base(options) { }
    }
}
