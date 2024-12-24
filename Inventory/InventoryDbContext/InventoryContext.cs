using Inventory.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace Inventory.InventoryDbContext

{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.ConfigureWarnings(warnings =>
        //        warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StockAdjustment> StockAdjustment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Role Primary Key


            //Tables and Primary Keys

            modelBuilder.Entity<Product>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Category>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Supplier>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<StockAdjustment>()
                .HasKey(b => b.Id);




            //Tables and initial seeding data

            modelBuilder.Entity <Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Pipe 110",
                    SupplierId = 1,
                    CategoryId = 1,
                    Price = 12,
                    Quantity = 100, 
                    InStock = true, 
                    Blocked = false   
                });


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Pipes & Fittings",
                    Description = "UPVC"

                });

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    Id = 1,
                    Name = "ERA",
                    Address = "Shanghai"
                });



            // Configure User-Role Relationship
            modelBuilder.Entity<Product>()
                .HasOne(u => u.Supplier) // A Product has one Supplier
                .WithMany(r => r.Products) // A Supplier can have many Product
                .HasForeignKey(u => u.SupplierId);

            modelBuilder.Entity<Product>()
                .HasOne(u => u.Category) // A Product has one Category
                .WithMany(r => r.Products) // A Category can have many Products
                .HasForeignKey(u => u.CategoryId);

            modelBuilder.Entity<StockAdjustment>()
                .HasOne(u => u.Product)
                .WithMany(r => r.StockAdjustments)
                .HasForeignKey(u => u.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

        
    

