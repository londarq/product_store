using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.ApplicationContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Product>()
                .Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Inventory)
                .WithOne(i => i.Product)
                .HasForeignKey<ProductInventory>(p => p.ProductId);


            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<ProductCategory>()
                .Property(c => c.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProductInventory>()
                .HasKey(i => i.Id);
            modelBuilder.Entity<ProductInventory>()
                .Property(i => i.Id).ValueGeneratedOnAdd();
        }
    }
}
