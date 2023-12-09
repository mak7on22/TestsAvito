using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using test.Models.Categors;

namespace test.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Module> Modules { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
    }
}
