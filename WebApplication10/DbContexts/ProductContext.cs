using Microsoft.EntityFrameworkCore;
using WebApplication10.Models;

namespace WebApplication10.DbContexts
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
