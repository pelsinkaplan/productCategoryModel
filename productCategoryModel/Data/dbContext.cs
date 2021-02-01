using Microsoft.EntityFrameworkCore;
using productCategoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productCategoryModel.Data
{
    class dbContext : DbContext
    {
        public dbContext()
        {

        }
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithOne(y => y.Category)
                .HasForeignKey(z => z.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB; " +
                    "Database=ProductCategoryDatabase;Integrated Security = yes");
            }
        }

    }
}
