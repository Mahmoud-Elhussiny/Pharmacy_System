using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Application.Contract;
using Pharmacy.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Persistence.Context
{
    public class DatabaseService : IdentityDbContext<ApplicationUser>, IDatabaseService
    {
        public DatabaseService()
        {

        }
        public DatabaseService(DbContextOptions<DatabaseService> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(e => e.isActive).HasDefaultValueSql("('true')");
            });
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("server =.;Database=PharmacySystem; Trusted_Connection=True;");

        //}



        public DbSet<Unit> units { get; set; }
        public DbSet<ApplicationUser> AppUser { get; set; }
        public DbSet<Representer> representers { get; set; }
        public DbSet<TheManufacturer> TheManufacturer { get; set; }
        public DbSet<DistributedCompany> distributedCompanies { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<ItemType> itemTypes { get; set; }
        public DbSet<ItemUnit> itemUnits { get; set; }
        public DbSet<SellingBill> sellingBills { get; set; }
        public DbSet<SellingBillDetails> sellingBillDetails { get; set; }
        public DbSet<PurchasingBill> purchasingBills { get; set; }
        public DbSet<PuchasingBillDetails> puchasingBillDetails { get; set; }
        public DbSet<ItemBarcode> itemBarcodes { get; set; }
        public DbSet<DataWarehouse> dataWarehouses { get; set; }



    }
}
