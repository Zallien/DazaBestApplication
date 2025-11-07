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
        private string DbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DazaBestApplication",
            "DazaBestApplication.db"
        );

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var directory = Path.GetDirectoryName(DbPath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().ToTable("Accounts");
            modelBuilder.Entity<Items>().ToTable("Items");
            modelBuilder.Entity<Products>().ToTable("Products");
            modelBuilder.Entity<IngredientsByProduct>().ToTable("IngredientsByProduct");
            modelBuilder.Entity<PurchaseitemDetails>().ToTable("PurchaseItemDetails");
            modelBuilder.Entity<PurchaseItemHeader>().ToTable("PurcahseItemHeader");
            modelBuilder.Entity<POSTransactionHeader>().ToTable("POSTransactionHeader");
            modelBuilder.Entity<POSTransactionDetails>().ToTable("POSTransactionDetails");
            modelBuilder.Entity<POSPaymentTransaction>().ToTable("POSPaymentTransaction");
            modelBuilder.Entity<POSTransactionHistory>().ToTable("POSTransactionHistory");
            modelBuilder.Entity<ItemAdjustmentHeader>().ToTable("ItemAdjustmentHeader");
            modelBuilder.Entity<ItemAdjustmentDetails>().ToTable("ItemAdjustmentDetails");
            modelBuilder.Entity<SecurityQuestions>().ToTable("SecurityQuestions");
            modelBuilder.Entity<BackupSettings>().ToTable("BackupSettings");
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<IngredientsByProduct> Ingredients { get; set; }
        public DbSet<PurchaseItemHeader> PurcahseItemHeader { get; set; }
        public DbSet<PurchaseitemDetails> PurchaseItemDetails { get; set; }
        public DbSet<POSTransactionHeader> TransactionHeader { get; set; }
        public DbSet<POSTransactionDetails> TransactionDetails { get; set; }
        public DbSet<POSPaymentTransaction> PaymentTransaction { get; set; }
        public DbSet<POSTransactionHistory> MyProperty { get; set; }
        public DbSet<ItemAdjustmentHeader> ItemAdjustmentHeader { get; set; }
        public DbSet<ItemAdjustmentDetails> ItemAdjustmentDetails { get; set; }
        public DbSet<SecurityQuestions> SecurityQuestions { get; set; }
        public DbSet<BackupSettings> BackupSettings { get; set; }

    }
}
