using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;

namespace SystemBackEnd
{
    public class BackEndDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DazaBestApplication.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().ToTable("Items");
            modelBuilder.Entity<Products>().ToTable("Products");
            modelBuilder.Entity<IngredientsByProduct>().ToTable("IngredientsByProduct");
            modelBuilder.Entity<PurchaseitemDetails>().ToTable("PurchaseItemDetails");
            modelBuilder.Entity<PurchaseItemHeader>().ToTable("PurcahseItemHeader");

        }

        public DbSet<Items> Items { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<IngredientsByProduct> Ingredients { get; set; }
        public DbSet<PurchaseItemHeader> PurcahseItemHeader { get; set; }
        public DbSet<PurchaseitemDetails> PurchaseItemDetails { get; set; }
    }
}
