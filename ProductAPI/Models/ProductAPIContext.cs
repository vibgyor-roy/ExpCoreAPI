using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models
{
    public class ProductAPIContext : DbContext
    {
        public ProductAPIContext(DbContextOptions<ProductAPIContext> options) : base(options) {}

        public DbSet<User> Users {get; set;}
    }
}