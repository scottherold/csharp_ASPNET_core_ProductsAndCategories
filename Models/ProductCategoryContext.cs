using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Models
{
    public class ProductCategoryContext : DbContext
    {
        // connector to the DB
        public ProductCategoryContext(DbContextOptions<ProductCategoryContext> options) : base(options) { }
        
        // DB query-set for products
        public DbSet<Product> Products { get; set; }

        // DB query-set for categories
        public DbSet<Category> Categories { get; set; }

        // DB query-set for associations
        public DbSet<Association> Associations { get; set; }
    }
}